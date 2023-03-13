using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public enum EditRuleMode
    {
        Add,
        Change,
    }

    public partial class EditRuleForm : Form
    {
        private readonly KnowledgeBase _knowledgeBase;
        private readonly EditRuleMode _mode;
        private readonly int _selectedRuleId;
        private Rule newRule;

        public EditRuleForm(KnowledgeBase knowledgeBase, EditRuleMode mode, int selectedRuleId)
        {
            InitializeComponent();
            _knowledgeBase = knowledgeBase;
            _selectedRuleId = selectedRuleId;
            _mode = mode;
            InitializeEditRuleForm();
        }

        private string GetUniqueRuleName()
        {
            string ruleName = string.Empty;
            int num = _knowledgeBase.Rules.Count + 1;
            do
            {
                ruleName = "Rule" + num++;
            } while (_knowledgeBase.Rules.Exists(r => r.Name == ruleName));
            return ruleName;
        }

        private void InitializeEditRuleForm()
        {
            btnChangePremiseFact.Enabled = false;
            btnDelPremiseFact.Enabled = false;
            btnChangeInferenceFact.Enabled = false;
            btnDelInferenceFact.Enabled = false;
            tbExplanation.ReadOnly = false;
            lstBoxPremise.Items.Clear();
            lstBoxInference.Items.Clear();

            if (_mode == EditRuleMode.Add)
            {
                newRule = new Rule();
                Text = "Добавление правила";
                tbRuleName.Text = GetUniqueRuleName();
                tbExplanation.Clear();

            }
            else if (_mode == EditRuleMode.Change)
            {
                newRule = new Rule(
                    _knowledgeBase.Rules[_selectedRuleId].Name,
                    new List<Fact>(_knowledgeBase.Rules[_selectedRuleId].Premises),
                    new List<Fact>(_knowledgeBase.Rules[_selectedRuleId].Inferences),
                    _knowledgeBase.Rules[_selectedRuleId].Reason);
                Text = "Редактирование правила";
                tbRuleName.Text = _knowledgeBase.Rules[_selectedRuleId].Name;
                _knowledgeBase.Rules[_selectedRuleId].Premises.ForEach(f => lstBoxPremise.Items.Add(f));
                _knowledgeBase.Rules[_selectedRuleId].Inferences.ForEach(f => lstBoxInference.Items.Add(f));
                tbExplanation.Text = _knowledgeBase.Rules[_selectedRuleId].Reason;
            }
        }

        private void btnAddPremiseFact_Click(object sender, System.EventArgs e)
        {
            EditFactForm addPremiseFactForm = new EditFactForm(_knowledgeBase, EditFactMode.AddPremiseFact);
            DialogResult dlgRes = addPremiseFactForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                if (newRule.ContainsFact(addPremiseFactForm.SelectedFact))
                {
                    MessageBox.Show("Факт уже добавлен в посылку или заключение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newRule.Premises.Add(addPremiseFactForm.SelectedFact);
                lstBoxPremise.Items.Add(addPremiseFactForm.SelectedFact);  
            }
        }

        private void btnChangePremiseFact_Click(object sender, System.EventArgs e)
        {
            EditFactForm changePremiseFactForm = new EditFactForm(_knowledgeBase, 
                EditFactMode.ChangePremiseFact, (Fact) lstBoxPremise.SelectedItem);
            DialogResult dlgRes = changePremiseFactForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                if (newRule.ContainsFact(changePremiseFactForm.SelectedFact))
                {
                    MessageBox.Show("Факт уже добавлен в посылку или заключение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newRule.Premises[lstBoxPremise.SelectedIndex] = changePremiseFactForm.SelectedFact;
                lstBoxPremise.Items[lstBoxPremise.SelectedIndex] = changePremiseFactForm.SelectedFact;
            }
        }

        private void btnAddInferenceFact_Click(object sender, System.EventArgs e)
        {
            EditFactForm addInferenceFactForm = new EditFactForm(_knowledgeBase, 
                EditFactMode.AddInferenceFact);
            DialogResult dlgRes = addInferenceFactForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                if (newRule.ContainsFact(addInferenceFactForm.SelectedFact))
                {
                    MessageBox.Show("Факт уже добавлен в посылку или заключение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newRule.Inferences.Add(addInferenceFactForm.SelectedFact);
                lstBoxInference.Items.Add(addInferenceFactForm.SelectedFact);
            }
        }

        private void btnChangeInferenceFact_Click(object sender, System.EventArgs e)
        {
            EditFactForm changeInferenceFactForm = new EditFactForm(_knowledgeBase, 
                EditFactMode.ChangeInferenceFact, (Fact) lstBoxInference.SelectedItem);
            DialogResult dlgRes = changeInferenceFactForm.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                if (newRule.ContainsFact(changeInferenceFactForm.SelectedFact))
                {
                    MessageBox.Show("Факт уже добавлен в посылку или заключение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newRule.Inferences[lstBoxInference.SelectedIndex] = changeInferenceFactForm.SelectedFact;
                lstBoxInference.Items[lstBoxInference.SelectedIndex] = changeInferenceFactForm.SelectedFact;
            }
        }

        private void btnDelPremiseFact_Click(object sender, System.EventArgs e)
        {
            newRule.Premises.Remove((Fact)lstBoxPremise.SelectedItem);
            lstBoxPremise.Items.RemoveAt(lstBoxPremise.SelectedIndex);
        }

        private void btnDelInferenceFact_Click(object sender, System.EventArgs e)
        {
            newRule.Inferences.Remove((Fact)lstBoxInference.SelectedItem);
            lstBoxInference.Items.RemoveAt(lstBoxInference.SelectedIndex);
        }

        private void btnOKRule_Click(object sender, System.EventArgs e)
        {
            // обновить порядок элементов в посылке и заключение
            newRule.Premises = lstBoxPremise.Items.Cast<Fact>().ToList();
            newRule.Inferences = lstBoxInference.Items.Cast<Fact>().ToList();

            EditRuleResult result;
            if (_mode == EditRuleMode.Add)
            {
                result = _knowledgeBase.AddRule(newRule, _selectedRuleId);
            }
            else
            {
                result = _knowledgeBase.ChangeRule(
                    _knowledgeBase.Rules[_selectedRuleId],
                    newRule);
            }

            if (result == EditRuleResult.Success)
            {
                DialogResult = DialogResult.OK;
            }

            else if (result == EditRuleResult.EmptyName)
            {
                MessageBox.Show("Имя правила не может быть пустой строкой", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditRuleResult.AlreadyExistsName)
            {
                MessageBox.Show("Правило с таким именем уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditRuleResult.EmptyPremiseList)
            {
                MessageBox.Show("Посылка правила должна содержать хотя бы 1 факт", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditRuleResult.EmptyInferenceList)
            {
                MessageBox.Show("Заключение правила должно содержать хотя бы 1 факт", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbRuleName_TextChanged(object sender, System.EventArgs e)
        {
            newRule.Name = tbRuleName.Text;
        }

        private void tbExplanation_TextChanged(object sender, System.EventArgs e)
        {
            newRule.Reason = tbExplanation.Text;
        }

        private void lstBoxPremise_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstBoxPremise.SelectedIndex > -1)
            {
                btnChangePremiseFact.Enabled = true;
                btnDelPremiseFact.Enabled = true;
            }
            else
            {
                btnChangePremiseFact.Enabled = false;
                btnDelPremiseFact.Enabled = false;
            }
        }

        private void lstBoxInference_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstBoxInference.SelectedIndex > -1)
            {
                btnChangeInferenceFact.Enabled = true;
                btnDelInferenceFact.Enabled = true;
            }
            else
            {
                btnChangeInferenceFact.Enabled = false;
                btnDelInferenceFact.Enabled = false;
            }
        }
    }
}
