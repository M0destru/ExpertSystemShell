using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public partial class ExpertSystemForm : Form
    {
        private KnowledgeBase knowledgeBase;
        private InferenceEngine inferenceEngine;
        private string pathToFile;

        public ExpertSystemForm()
        {
            InitializeComponent();
            knowledgeBase = null;
            inferenceEngine = null;
            pathToFile = "";
            InitializeExpertSystemForm();
        }

        private void SetInterfaceActive(bool value)
        {
            tabControl.Visible = value;
            tsCbConsultation.Visible = value;
            tsMenuExplanation.Enabled = false;
            tsMenuSave.Enabled = pathToFile != "";
            tsMenuSaveAs.Enabled = value;
        }

        private void InitializeExpertSystemForm()
        {
            if (knowledgeBase == null)
            {
                SetInterfaceActive(false);
            }
            else
            {
                SetInterfaceActive(true);
                InitializeRuleTab();
                InitializeVarTab();
                InitializeDomainTab();
            }
        }

        // Меню
        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            if (knowledgeBase != null)
            {
                DialogResult dlgRes = MessageBox.Show(
                    "Вы уверены, что хотите выйти? " +
                    "Все несохраненные данные будут потеряны.",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (dlgRes != DialogResult.Yes) return;
            }
            Close();
        }

        private void tsMenuNewFile_Click(object sender, EventArgs e)
        {
            if (knowledgeBase != null)
            {
                DialogResult dlgRes = MessageBox.Show(
                    "Вы уверены, что хотите создать новую базу знаний? " +
                    "Все несохраненные данные будут потеряны.",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (dlgRes != DialogResult.Yes) return;
            }
            knowledgeBase = new KnowledgeBase();
            Text = "Новая экспертная система";
            InitializeExpertSystemForm();
        }

        private void tsMenuOpenFile_Click(object sender, EventArgs e)
        {
            if (knowledgeBase != null)
            {
                DialogResult dlgRes = MessageBox.Show(
                    "Вы уверены, что хотите открыть новый файл? " +
                    "Все несохраненные данные будут потеряны.",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (dlgRes != DialogResult.Yes) return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BIN Files (*.bin)|*.bin";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                knowledgeBase = new KnowledgeBase().LoadKnowledgeBase(dlg.FileName);
                pathToFile = dlg.FileName;
                Text = $"{pathToFile.Split('\\').Last()}";
                InitializeExpertSystemForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось загрузить базу знаний из файла\n\nОшибка: " + ex.Message,
                    "Ошибка при загрузки данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                knowledgeBase.SaveKnowledgeBase(pathToFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось сохранить изменения\n\nОшибка:" + ex.Message,
                    "Ошибка при сохранении данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsMenuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "BIN Files (*.bin)|*.bin";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                knowledgeBase.SaveKnowledgeBase(dlg.FileName);
                pathToFile = dlg.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось сохранить изменения\n" + ex.Message,
                    "Ошибка при сохранении данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsMenuStartConsultation_Click(object sender, EventArgs e)
        {
            inferenceEngine = new InferenceEngine(knowledgeBase);
            ConsultationForm consForm = new ConsultationForm(knowledgeBase);
            DialogResult dlgRes = consForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                bool result = inferenceEngine.Run(ConsultationForm.StartGoalVariable);
                tsMenuExplanation.Enabled = result;
                consForm = new ConsultationForm(inferenceEngine.WorkingMemory);
                consForm.ShowDialog();
            }
        }

        private void tsMenuExplanation_Click(object sender, EventArgs e)
        {
            ExplanationForm explanationForm = new ExplanationForm(inferenceEngine.WorkingMemory);
            explanationForm.ShowDialog();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // сохранить выделение выбранного элемента при смене вкладки
            int indexOfSelectedElem = -1;

            if (tabControl.SelectedIndex == 0) // вкладка "Правила"
            {
                if (lstViewRules.SelectedIndices.Count > 0)
                {
                    indexOfSelectedElem = lstViewRules.SelectedIndices[0];
                }
                InitializeRuleTab();
                if (indexOfSelectedElem > -1)
                {
                    lstViewRules.Items[indexOfSelectedElem].Selected = true;
                }
            }

            else if (tabControl.SelectedIndex == 1) // вкладка "Переменные"
            {
                if (lstViewVariables.SelectedIndices.Count > 0)
                {
                    indexOfSelectedElem = lstViewVariables.SelectedIndices[0];
                }
                InitializeVarTab();
                if (indexOfSelectedElem > -1)
                {
                    lstViewVariables.Items[indexOfSelectedElem].Selected = true;
                }
            }

            else if (tabControl.SelectedIndex == 2) // вкладка "Домены"
            {
                if (lstViewDomains.SelectedIndices.Count > 0)
                {
                    indexOfSelectedElem = lstViewDomains.SelectedIndices[0];
                }
                InitializeDomainTab();
                if (indexOfSelectedElem > -1)
                {
                    lstViewDomains.Items[indexOfSelectedElem].Selected = true;
                }
            }
        }


        // Вкладка "Правила"

        // инициализация вкладки "Правила"
        private void InitializeRuleTab()
        {
            btnChangeRule.Enabled = btnDelRule.Enabled = false;
            lstViewRules.AllowDrop = true;
            lstViewRules.Items.Clear();
            foreach (var rule in knowledgeBase.Rules)
            {
                lstViewRules.Items.Add(new ListViewItem(new string[]
                {
                    rule.Name,
                    rule.ToString()
                })
                {
                    Tag = rule
                });
            }
            ChangeLstViewRulesSize();

            lstBoxPremiseFacts.Items.Clear();
            lstBoxInferenceFacts.Items.Clear();
        }

        private void lstViewRules_SizeChanged(object sender, EventArgs e)
        {
            ChangeLstViewRulesSize();
        }

        private void ChangeLstViewRulesSize()
        {
            if (lstViewRules.Columns.Count != 2)
            {
                return;
            }
            lstViewRules.Columns[0].Width = (int)(lstViewRules.Width * 0.15);
            lstViewRules.Columns[1].Width = (int)(lstViewRules.Width * 0.85);
        }

        private void ChangeLstViewVariablesSize()
        {
            if (lstViewVariables.Columns.Count != 3) 
            {
                return;
            }
            lstViewVariables.Columns[0].Width = (int)(lstViewVariables.Width * 0.40);
            lstViewVariables.Columns[1].Width = (int)(lstViewVariables.Width * 0.20);
            lstViewVariables.Columns[2].Width = (int)(lstViewVariables.Width * 0.40);
        }

        private void ChangeLstViewDomainsSize()
        {
            if (lstViewDomains.Columns.Count != 1)
            {
                return;
            }
            lstViewDomains.Columns[0].Width = (int)(lstViewDomains.Width * 1);
        }

        private void lstViewRules_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstViewRules.DoDragDrop(lstViewRules.SelectedItems[0], DragDropEffects.Move);
        }

        private void lstViewRules_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstViewRules_DragDrop(object sender, DragEventArgs e)
        {
            if (lstViewRules.SelectedItems.Count == 0)
            {
                return;
            }

            Point p = lstViewRules.PointToClient(new Point(e.X, e.Y));
            ListViewItem lvItemDrag = lstViewRules.GetItemAt(p.X, p.Y);

            if (lvItemDrag == null)
            {
                return;
            }

            int itemDragInd = lvItemDrag.Index;

            ListViewItem[] selected = new ListViewItem[lstViewRules.SelectedItems.Count];
            for (int i = 0; i < lstViewRules.SelectedItems.Count; i++)
            {
                selected[i] = lstViewRules.SelectedItems[i];
            }

            for (int i = 0; i < selected.GetLength(0); i++)
            {
                ListViewItem selectedItem = selected[i];
                int insertItemPos, removeItemPos;

                if (itemDragInd == selectedItem.Index)
                {
                    return;
                }

                if (selectedItem.Index < itemDragInd)
                {
                    insertItemPos = itemDragInd + 1;
                    removeItemPos = selectedItem.Index;
                }
                else
                {
                    insertItemPos = itemDragInd;
                    removeItemPos = selectedItem.Index + 1;
                }

                ListViewItem insertItem = (ListViewItem)selectedItem.Clone();
                knowledgeBase.Rules.Insert(insertItemPos, (Rule)insertItem.Tag);
                knowledgeBase.Rules.RemoveAt(removeItemPos);

                lstViewRules.Items.Insert(insertItemPos, insertItem);
                lstViewRules.Items.Remove(selectedItem);

            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            int index = lstViewRules.SelectedIndices.Count == 0 ?
                lstViewRules.Items.Count - 1 : lstViewRules.SelectedIndices[0];
            EditRuleForm addRuleForm = new EditRuleForm(knowledgeBase, EditRuleMode.Add, index);
            DialogResult dlgRes = addRuleForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                int addedRuleInd = index + 1;
                ListViewItem lvItem = new ListViewItem(new string[]
                {
                    knowledgeBase.Rules[addedRuleInd].Name,
                    knowledgeBase.Rules[addedRuleInd].ToString()
                })
                {
                    Tag = knowledgeBase.Rules[addedRuleInd]
                };

                lstViewRules.Items.Insert(addedRuleInd, lvItem);
                lstViewRules.Items[addedRuleInd].Selected = true;
            }
        }

        private void btnChangeRule_Click(object sender, EventArgs e)
        {
            int index = lstViewRules.SelectedIndices[0];
            EditRuleForm changeRuleForm = new EditRuleForm(knowledgeBase, EditRuleMode.Change, index);
            DialogResult dlgRes = changeRuleForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                lstViewRules.Items[index] = new ListViewItem(new string[]
                {
                    knowledgeBase.Rules[index].Name,
                    knowledgeBase.Rules[index].ToString()
                })
                {
                    Tag = knowledgeBase.Rules[index]
                };

                lstViewRules.Items[index].Selected = true;
            }
        }

        private void btnDelRule_Click(object sender, EventArgs e)
        {
            Rule ruleToDel = (Rule)lstViewRules.SelectedItems[0].Tag;
            EditRuleResult result = knowledgeBase.DeleteRule(ruleToDel);
            lstViewRules.Items.Remove(lstViewRules.SelectedItems[0]);
        }

        private void UpdateSelectedRuleInfo()
        {
            lstBoxPremiseFacts.Items.Clear();
            lstBoxInferenceFacts.Items.Clear();

            if (lstViewRules.SelectedItems.Count > 0)
            {
                btnChangeRule.Enabled = btnDelRule.Enabled = true;
                lstBoxPremiseFacts.Items.AddRange(knowledgeBase.Rules[lstViewRules.SelectedIndices[0]].Premises.ToArray());
                lstBoxInferenceFacts.Items.AddRange(knowledgeBase.Rules[lstViewRules.SelectedIndices[0]].Inferences.ToArray());
            }
            else
            {
                btnChangeRule.Enabled = btnDelRule.Enabled = false;
            }
        }

        private void lstViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedRuleInfo();
        }

        // Вкладка "Переменные"

        // инициализация вкладки "Переменные"
        private void InitializeVarTab()
        {
            tbQuestionText.ReadOnly = true;
            btnChangeVariable.Enabled = btnDelVariable.Enabled = false;
            lstViewVariables.Items.Clear();
            lstBoxDomainValues.Items.Clear();
            lstBoxUsedInRules.Items.Clear();
            tbQuestionText.Clear();
            foreach (var variable in knowledgeBase.Variables)
            {
                ListViewItem lvItem = new ListViewItem(new string[]
                {
                    variable.Name,
                    variable.Type == EVariableType.Requested? 
                        "Запрашиваемая" : variable.Type == EVariableType.Inferable? 
                            "Выводимая" : "Выводимо-запрашиваемая",
                    variable.Domain.Name

                })
                {
                    Tag = variable
                };
                lstViewVariables.Items.Add(lvItem);
            }
            ChangeLstViewVariablesSize();
        }

        private void lstViewVariables_SizeChanged(object sender, EventArgs e)
        {
            ChangeLstViewVariablesSize();
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            int index = lstViewVariables.SelectedIndices.Count == 0 ?
                lstViewVariables.Items.Count - 1 : lstViewVariables.SelectedIndices[0];
            EditVariableForm addVariableForm = new EditVariableForm(knowledgeBase, EditVariableMode.Add, index);
            DialogResult dlgRes = addVariableForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                int addedVariableInd = index + 1;
                ListViewItem lvItem = new ListViewItem(new string[]
                {
                    knowledgeBase.Variables[addedVariableInd].Name,
                    knowledgeBase.Variables[addedVariableInd].Type == EVariableType.Requested?
                        "Запрашиваемая" : 
                            knowledgeBase.Variables[addedVariableInd].Type == EVariableType.Inferable?
                                "Выводимая" : "Выводимо-запрашиваемая",
                    knowledgeBase.Variables[addedVariableInd].Domain.Name

                })
                {
                    Tag = knowledgeBase.Variables[addedVariableInd]
                };

                lstViewVariables.Items.Insert(addedVariableInd, lvItem);
                lstViewVariables.Items[addedVariableInd].Selected = true;
                tbQuestionText.Text = knowledgeBase.Variables[addedVariableInd].Question;
            }

        }

        private void btnChangeVariable_Click(object sender, EventArgs e)
        {
            int index = lstViewVariables.SelectedIndices[0];
            EditVariableForm changeVariableForm = new EditVariableForm(knowledgeBase, EditVariableMode.Change, index);
            DialogResult dlgRes = changeVariableForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                lstViewVariables.Items[index] = new ListViewItem(new string[]
                {
                    knowledgeBase.Variables[index].Name,
                    knowledgeBase.Variables[index].Type == EVariableType.Requested?
                        "Запрашиваемая" : 
                            knowledgeBase.Variables[index].Type == EVariableType.Inferable?
                                "Выводимая" : "Выводимо-запрашиваемая",
                    knowledgeBase.Variables[index].Domain.Name

                })
                {
                    Tag = knowledgeBase.Variables[index]
                };

                lstViewVariables.Items[index].Selected = true;
                UpdateSelectedVariableInfo();
            }
        }

        private void btnDelVariable_Click(object sender, EventArgs e)
        {
            Variable varToDel = (Variable)lstViewVariables.SelectedItems[0].Tag;
            EditVariableResult result = knowledgeBase.DeleteVariable(varToDel);
            if (result == EditVariableResult.VariableUsed)
            {
                List<Rule> rules = knowledgeBase.GetRulesWithVariable(varToDel);
                string rulesNames = string.Join(", ", rules.Select(r => r.Name));
                MessageBox.Show("Удаление переменной невозможно, так как она уже используется в правилах: \n\n" + rulesNames, 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstViewVariables.Items.Remove(lstViewVariables.SelectedItems[0]);
        }

        private void UpdateSelectedVariableInfo()
        {
            lstBoxDomainValues.Items.Clear();
            lstBoxUsedInRules.Items.Clear();
            tbQuestionText.Clear();

            if (lstViewVariables.SelectedItems.Count > 0)
            {
                btnChangeVariable.Enabled = btnDelVariable.Enabled = true;
                Variable selectedVar = knowledgeBase.Variables[lstViewVariables.SelectedIndices[0]];
                lstBoxDomainValues.Items.AddRange(selectedVar.Domain.Values.ToArray());
                lstBoxUsedInRules.Items.AddRange(
                    knowledgeBase.GetRulesWithVariable(selectedVar).Select(v => v.Name).ToArray());
                tbQuestionText.Enabled = selectedVar.Type != EVariableType.Inferable;
                tbQuestionText.Text = selectedVar.Question;
            }
            else
            {
                btnChangeVariable.Enabled = btnDelVariable.Enabled = false;
            }
        }

        private void lstViewVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedVariableInfo();
        }

        // Вкладка "Домены"

        // инициализация вкладки "Домены"
        private void InitializeDomainTab()
        {
            btnChangeDomain.Enabled = btnDelDomain.Enabled = false;
            lstViewDomains.Items.Clear();
            foreach (var d in knowledgeBase.Domains)
            {
                lstViewDomains.Items.Add(new ListViewItem
                {
                    Text = d.Name,
                    Tag = d,
                });
            }
            lstBoxValuesOfDomain.Items.Clear();
            ChangeLstViewDomainsSize();
        }

        private void lstViewDomains_SizeChanged(object sender, EventArgs e)
        {
            ChangeLstViewDomainsSize();
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            int index = lstViewDomains.SelectedIndices.Count == 0 ?
                lstViewDomains.Items.Count - 1 : lstViewDomains.SelectedIndices[0];
            EditDomainForm addDomainForm = new EditDomainForm(knowledgeBase,
                EditDomainMode.Add, index);
            DialogResult dlgRes = addDomainForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                int addedDomainInd = index + 1;
                lstViewDomains.Items.Insert(addedDomainInd, new ListViewItem
                {
                    Text = knowledgeBase.Domains[addedDomainInd].Name,
                    Tag = knowledgeBase.Domains[addedDomainInd]
                });
                lstViewDomains.Items[addedDomainInd].Selected = true;
            }
        }

        private void btnChangeDomain_Click(object sender, EventArgs e)
        {
            int index = lstViewDomains.SelectedIndices[0];
            EditDomainForm changeDomainForm = new EditDomainForm(knowledgeBase,
                EditDomainMode.Change, index);
            DialogResult dlgRes = changeDomainForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                lstViewDomains.Items[index].Text = knowledgeBase.Domains[index].Name;
                lstViewDomains.Items[index].Tag = knowledgeBase.Domains[index];
                UpdateSelectedDomainInfo();
            }
        }

        private void btnDelDomain_Click(object sender, EventArgs e)
        {
            Domain domainToDel = (Domain)lstViewDomains.SelectedItems[0].Tag;
            EditDomainResult result = knowledgeBase.DeleteDomain(domainToDel);
            if (result == EditDomainResult.DomainUsed)
            {
                List<Variable> variables = knowledgeBase.GetVariablesWithDomain(domainToDel);
                if (variables.Count > 0)
                {
                    string varsNames = string.Join(", ", variables);
                    MessageBox.Show("Удаление невозможно, так как домен уже используется в переменных: \n" + varsNames, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            lstViewDomains.Items.Remove(lstViewDomains.SelectedItems[0]);
        }

        private void UpdateSelectedDomainInfo()
        {
            lstBoxValuesOfDomain.Items.Clear();
            if (lstViewDomains.SelectedItems.Count > 0)
            {
                btnChangeDomain.Enabled = btnDelDomain.Enabled = true;
                lstBoxValuesOfDomain.Items.AddRange(
                    knowledgeBase.Domains[lstViewDomains.SelectedIndices[0]].Values.ToArray());
            }
            else
            {
                btnChangeDomain.Enabled = btnDelDomain.Enabled = false;
            }
        }

        private void lstViewDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedDomainInfo();
        }
    }
}
