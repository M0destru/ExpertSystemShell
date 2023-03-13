using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public enum EditDomainMode
    {
        Add,
        Change,
    }

    public partial class EditDomainForm : Form
    {
        private readonly KnowledgeBase knowledgeBase;
        private readonly EditDomainMode mode;
        private readonly int selectedDomainId;
        private Domain newDomain;

        public EditDomainForm(KnowledgeBase knowledgeBase, EditDomainMode mode, 
            int selectedDomainId)
        {
            InitializeComponent();
            this.knowledgeBase = knowledgeBase;
            this.mode = mode;
            this.selectedDomainId = selectedDomainId;
            InitializeEditDomainForm();
        }

        private string GetUniqueDomainName()
        {
            string domainName = string.Empty;
            int num = knowledgeBase.Domains.Count + 1;
            do
            {
                domainName = "Domain" + num++;
            } while (knowledgeBase.Domains.FirstOrDefault(d => d.Name == domainName) != null);
            return domainName;
        }

        private void InitializeEditDomainForm()
        {
            if (mode == EditDomainMode.Add)
            {
                newDomain = new Domain();
                Text = "Создание домена";
                tbDomainName.Text = GetUniqueDomainName();
            }
            else if (mode == EditDomainMode.Change)
            {
                newDomain = new Domain(
                    knowledgeBase.Domains[selectedDomainId].Name,
                    new List<DomainValue>(knowledgeBase.Domains[selectedDomainId].Values));
                Text = "Редактирование домена";
                tbDomainName.Text = newDomain.Name;
            }
            newDomain.Values.ForEach(dv => lstBoxDomainValues.Items.Add(dv.Value));
            btnEditDomainValue.Text = "Добавить";
            btnDelDomainValue.Enabled = false;
        }

        private void btnEditDomainValue_Click(object sender, EventArgs e)
        {
            if (tbDomainValue.Text == "")
            {
                MessageBox.Show("Значение домена не может быть пустой строкой", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lstBoxDomainValues.Items.Contains(tbDomainValue.Text))
            {
                MessageBox.Show("Значения домена должны быть уникальными", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstBoxDomainValues.SelectedItems.Count == 0) // добавление нового значения
            {
                lstBoxDomainValues.Items.Add(tbDomainValue.Text);
                tbDomainValue.Clear();
            }
            else // редактирование значения
            {
                lstBoxDomainValues.Items[lstBoxDomainValues.SelectedIndex] = tbDomainValue.Text;
            }
        }

        private void btnDelDomainValue_Click(object sender, EventArgs e)
        {
            lstBoxDomainValues.Items.Remove(lstBoxDomainValues.SelectedItem);
            tbDomainValue.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            newDomain.Values.Clear();
            foreach (string strVal in lstBoxDomainValues.Items)
            {
                newDomain.Values.Add(new DomainValue(strVal));
            }
            EditDomainResult result;
            if (mode == EditDomainMode.Add)
            {
                result = knowledgeBase.AddDomain(newDomain, selectedDomainId);
            }
            else
            {
                result = knowledgeBase.ChangeDomain(
                    knowledgeBase.Domains[selectedDomainId],
                    newDomain);
            }

            if (result == EditDomainResult.Success)
            {
                DialogResult = DialogResult.OK;
            }

            else if (result == EditDomainResult.EmptyName)
            {
                MessageBox.Show("Название домена не может быть пустой строкой", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditDomainResult.AlreadyExistsName)
            {
                MessageBox.Show("Домен с таким названием уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditDomainResult.EmptyDomainValues)
            {
                MessageBox.Show("Домен должен содержать хотя бы одно значение", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == EditDomainResult.DomainUsed)
            {
                /*List<Rule> rules = knowledgeBase.GetRulesWithDomain(knowledgeBase.Domains[selectedDomainId]);
                string rulesNames = string.Join(", ", rules.Select(r => r.Name));
                MessageBox.Show("Домен уже используется в правилах \n" + rulesNames + "\n\n" +
                    "Исходные значения домена должны присутствовать в обновленном домене", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                List<Variable> variables = knowledgeBase.GetVariablesWithDomain(
                    knowledgeBase.Domains[selectedDomainId]);
                if (variables.Count > 0)
                {
                    string varsNames = string.Join(", ", variables);
                    MessageBox.Show("Домен уже используется в переменных: \n" + varsNames + "\n\n" +
                        "Исходные значения домена должны присутствовать в обновленном домене", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbDomainName_TextChanged(object sender, EventArgs e)
        {
            newDomain.Name = tbDomainName.Text;
        }

        private void lstBoxDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxDomainValues.SelectedIndex == -1)
            {
                btnEditDomainValue.Text = "Добавить";
                btnDelDomainValue.Enabled = false;
                tbDomainValue.Clear();
            }
            else
            {
                btnEditDomainValue.Text = "Изменить";
                btnDelDomainValue.Enabled = true;
                tbDomainValue.Text = lstBoxDomainValues.SelectedItem.ToString();
            }
        }
    }
}
