using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public enum EditFactMode
    {
        AddPremiseFact,
        ChangePremiseFact,
        AddInferenceFact,
        ChangeInferenceFact,
    }

    public partial class EditFactForm : Form
    {
        private KnowledgeBase _knowledgeBase;
        private readonly EditFactMode _mode;
        public Fact SelectedFact { get; set; }


        public EditFactForm(KnowledgeBase knowledgeBase, EditFactMode mode, Fact selectedFact = null)
        {
            InitializeComponent();
            _knowledgeBase = knowledgeBase;
            _mode = mode;
            SelectedFact = selectedFact;
            InitializeEditFactForm();
        }

        private void InitializeEditFactForm()
        {
            btnOk.Enabled = false;
            btnEditVariable.Enabled = false;
            /* Отключает возможность редактирования переменной через форму изменения фактов. 
             Необходима доработка. При использовании могут возникать ошибочные ситуации! */
            btnEditVariable.Visible = false;

            // инициализация comboBox с правилами и значениями
            cbVariable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVariable.Items.Clear();
            cbValue.Items.Clear();

            if (_mode == EditFactMode.AddPremiseFact)
            {
                Text = "Добавление факта посылки";
                cbVariable.Items.AddRange(_knowledgeBase.Variables.ToArray());
            }
            else if (_mode == EditFactMode.ChangePremiseFact)
            {
                Text = "Редактирование факта посылки";
                cbVariable.Items.AddRange(_knowledgeBase.Variables.ToArray());
                cbVariable.SelectedItem = SelectedFact.Variable;
                cbValue.SelectedItem = SelectedFact.Value.Value;
            }
            else if (_mode == EditFactMode.AddInferenceFact)
            {
                Text = "Добавление факта заключения";
                cbVariable.Items.AddRange(
                    _knowledgeBase.Variables.Where(v => v.Type != EVariableType.Requested).ToArray());
            }
            else if (_mode == EditFactMode.ChangeInferenceFact)
            {
                Text = "Редактирование факта заключения";
                cbVariable.Items.AddRange(
                    _knowledgeBase.Variables.Where(v => v.Type != EVariableType.Requested).ToArray());
                cbVariable.SelectedItem = SelectedFact.Variable;
                cbValue.SelectedItem = SelectedFact.Value.Value;
            }
        }

        private void RefreshDomainValues()
        {
            string selectedDomainValue = (string)cbValue.SelectedItem;
            cbValue.Items.Clear();
            if (cbVariable.SelectedItem != null)
            {
                cbValue.Items.AddRange(((Variable)cbVariable.SelectedItem).Domain.Values.Select(v => $"{v}").ToArray());
                cbValue.SelectedItem = selectedDomainValue;
            }
        }

        private void cbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVariable.SelectedIndex == -1)
            {
                btnEditVariable.Enabled = false;
            }
            else
            {
                btnEditVariable.Enabled = true;
            }
            RefreshDomainValues();
            btnOk.Enabled = cbValue.SelectedIndex >= 0 && cbValue.SelectedIndex >= 0;
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = cbValue.SelectedIndex >= 0 && cbValue.SelectedIndex >= 0;
        }

        private void btnEditVariable_Click(object sender, EventArgs e)
        {
            EditVariableForm editVariableForm = new EditVariableForm(_knowledgeBase,
                EditVariableMode.Change, cbVariable.SelectedIndex);
            DialogResult dlgResult = editVariableForm.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                cbVariable.Items[cbVariable.SelectedIndex] = _knowledgeBase.Variables[cbVariable.SelectedIndex];
            }
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            EditVariableForm addVariableForm = new EditVariableForm(_knowledgeBase, 
                EditVariableMode.Add, _knowledgeBase.Variables.Count - 1);
            DialogResult dlgResult = addVariableForm.ShowDialog();
            RefreshDomainValues();
            // была добавлена новая переменная
            if (dlgResult == DialogResult.OK) 
            {
                if (_knowledgeBase.Variables.Last().Type == EVariableType.Requested && 
                    (_mode == EditFactMode.AddInferenceFact || 
                    _mode == EditFactMode.ChangeInferenceFact))
                {
                    return;
                }
                cbVariable.Items.Add(_knowledgeBase.Variables.Last());
                cbVariable.SelectedItem = cbVariable.Items[cbVariable.Items.Count - 1];
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedFact = new Fact((Variable) cbVariable.SelectedItem, new DomainValue((string) cbValue.SelectedItem));
            DialogResult = DialogResult.OK;
        }

    }
}
