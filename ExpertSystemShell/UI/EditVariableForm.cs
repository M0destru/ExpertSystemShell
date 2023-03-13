using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public enum EditVariableMode
    {
        Add,
        Change,
    }

    public partial class EditVariableForm : Form
    {
        private readonly KnowledgeBase knowledgeBase;
        private readonly EditVariableMode mode;
        private readonly int selectedVarId;
        private Variable newVariable;
        private bool defaultQuestionText;

        public EditVariableForm(KnowledgeBase knowledgeBase, EditVariableMode mode,
            int selectedVarId)
        {
            InitializeComponent();
            this.knowledgeBase = knowledgeBase;
            this.mode = mode;
            this.selectedVarId = selectedVarId;
            newVariable = new Variable();
            InitializeEditVariableForm();
        }

        private string GetUniqueVariableName()
        {
            string varName = string.Empty;
            int num = knowledgeBase.Variables.Count + 1;
            do
            {
                varName = "Variable" + num++;
            } while (knowledgeBase.Variables.Exists(v => v.Name == varName));
            return varName;
        }

        private void InitializeEditVariableForm()
        {
            btnEditDomain.Enabled = false;
            // инициализация comboBox с доменами
            cbDomain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDomain.DataSource = knowledgeBase.Domains;

            if (mode == EditVariableMode.Add)
            {
                Text = "Создание переменной";
                defaultQuestionText = true;
                tbVariableName.Text = GetUniqueVariableName();
                cbDomain.SelectedIndex = -1;
                rbRequestedVariable.Checked = true;
            }
            else if (mode == EditVariableMode.Change)
            {
                newVariable = new Variable(
                    knowledgeBase.Variables[selectedVarId].Name,
                    knowledgeBase.Variables[selectedVarId].Type,
                    knowledgeBase.Variables[selectedVarId].Domain,
                    knowledgeBase.Variables[selectedVarId].Question);
                Text = "Редактирование переменной";
                defaultQuestionText = false;
                tbVariableName.Text = knowledgeBase.Variables[selectedVarId].Name;
                cbDomain.SelectedItem = knowledgeBase.Variables[selectedVarId].Domain;
                if (knowledgeBase.Variables[selectedVarId].Type == EVariableType.Requested)
                {
                    rbRequestedVariable.Checked = true;
                }
                else if (knowledgeBase.Variables[selectedVarId].Type == EVariableType.Inferable)
                {
                    rbInferableVariable.Checked = true;
                }
                else
                {
                    rbRequestedInferred.Checked = true;
                }

            }
        }

        private void btnEditDomain_Click(object sender, EventArgs e)
        {
            EditDomainForm editDomainForm = new EditDomainForm(knowledgeBase,
                EditDomainMode.Change, cbDomain.SelectedIndex);
            DialogResult dlgResult = editDomainForm.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                // обновить содержимое comboBox с доменами
                cbDomain.DataSource = null;
                cbDomain.DataSource = knowledgeBase.Domains;
            }
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            EditDomainForm addDomainForm = new EditDomainForm(knowledgeBase,
                EditDomainMode.Add, knowledgeBase.Domains.Count - 1);
            addDomainForm.ShowDialog();
            cbDomain.SelectedIndex = cbDomain.Items.Count - 1;
            newVariable.Domain = (Domain)cbDomain.SelectedItem; // почему-то изменение индекса не вызывает событие :(
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            EditVariableResult result;
            if (mode == EditVariableMode.Add)
            {
                result = knowledgeBase.AddVariable(newVariable, selectedVarId);
            }
            else
            {
                result = knowledgeBase.ChangeVariable(
                    knowledgeBase.Variables[selectedVarId],
                    newVariable);
            }

            if (result == EditVariableResult.Success)
            {
                DialogResult = DialogResult.OK;
            }

            else if (result == EditVariableResult.EmptyName)
            {
                MessageBox.Show("Имя переменной не может быть пустой строкой", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditVariableResult.AlreadyExistsName)
            {
                MessageBox.Show("Переменная с таким именем уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditVariableResult.EmptyDomain)
            {
                MessageBox.Show("Необходимо выбрать домен значений для переменной", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditVariableResult.EmptyQuestion)
            {
                MessageBox.Show("Текст вопроса не может быть пустой строкой", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditVariableResult.VariableUsed)
            {
                List<Rule> rules = knowledgeBase.GetRulesWithVariable(knowledgeBase.Variables[selectedVarId]);
                string rulesNames = string.Join(", ", rules.Select(r => r.Name));
                MessageBox.Show("Изменение переменной невозможно, так как она уже используется в правилах:\n" + rulesNames, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbVariableName_TextChanged(object sender, EventArgs e)
        {
            newVariable.Name = tbVariableName.Text;
            if (defaultQuestionText)
            {
                tbQuestionText.Text = tbVariableName.TextLength > 0 ?
                    tbVariableName.Text + "?" : "";
            }
        }

        private void cbDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDomain.SelectedIndex == -1)
            {
                btnEditDomain.Enabled = false;
            }
            else
            {
                btnEditDomain.Enabled = true;
            }
            newVariable.Domain = (Domain)cbDomain.SelectedItem;
        }

        private void rbRequestedVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRequestedVariable.Checked)
            {
                newVariable.Type = EVariableType.Requested;
                tbQuestionText.Enabled = true;
                if (mode == EditVariableMode.Change)
                {
                    tbQuestionText.Text = knowledgeBase.Variables[selectedVarId].Question;
                }
                else
                {
                    tbQuestionText.Text = tbVariableName.Text != "" ? tbVariableName.Text + "?" : "";
                }
            }
        }

        private void rbRequestedInferred_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRequestedInferred.Checked)
            {
                newVariable.Type = EVariableType.InferredRequested;
                tbQuestionText.Enabled = true;
                if (mode == EditVariableMode.Change)
                {
                    tbQuestionText.Text = knowledgeBase.Variables[selectedVarId].Question;
                }
                else
                {
                    tbQuestionText.Text = tbVariableName.Text != "" ? tbVariableName.Text + "?" : "";
                }
            }
        }

        private void rbInferableVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInferableVariable.Checked)
            {
                newVariable.Type = EVariableType.Inferable;
                tbQuestionText.Enabled = false;
                tbQuestionText.Clear();
            }
        }

        private void tbQuestionText_TextChanged(object sender, EventArgs e)
        {
            newVariable.Question = tbQuestionText.Text;
            if (defaultQuestionText && tbQuestionText.TextLength > 0 &&
                tbQuestionText.Text.Substring(0, tbQuestionText.TextLength - 1) != tbVariableName.Text)
            {
                defaultQuestionText = false;
            }
        }
    }
}
