using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public enum ConsultationPhase
    {
        GoalDefinition,
        AskQuestions,
        ShowResult
    }

    public partial class ConsultationForm : Form
    {
        private readonly KnowledgeBase _knowledgeBase;
        private readonly WorkingMemory _workingMemory;
        private readonly Variable _requestedVar;
        private readonly ConsultationPhase _consPhase;

        public Fact RequestedFact { get; set; }
        public static Variable StartGoalVariable { get; set; }

        public ConsultationForm()
        {
            InitializeComponent();
        }

        public ConsultationForm(KnowledgeBase knowledgeBase) : this()
        {
            _consPhase = ConsultationPhase.GoalDefinition;
            _knowledgeBase = knowledgeBase;
            InitConsultationForm();
        }

        public ConsultationForm(WorkingMemory workingMemory, Variable requestedVar = null) : this()
        {
            _workingMemory = workingMemory;
            _requestedVar = requestedVar;
            _consPhase = requestedVar != null ? ConsultationPhase.AskQuestions : ConsultationPhase.ShowResult;
            InitConsultationForm();
        }

        private void ConsultationForm_Shown(object sender, EventArgs e)
        {
            tbConsultation.Focus();
            tbConsultation.ScrollToCaret();
            tbConsultation.SelectionStart = tbConsultation.SelectionLength;
        }

        private void PrintAnswer(int num, string question, string answer)
        {
            tbConsultation.AppendText($"Вопрос {num}: {question}");
            tbConsultation.AppendText(Environment.NewLine);
            tbConsultation.AppendText($"Ответ: {answer}" + Environment.NewLine + Environment.NewLine);
        }

        private void FillConsultationLog()
        {
            List<Fact> requestedFacts = _workingMemory.ProvenFacts
                .Where(f => f.Variable.Type == EVariableType.Requested).ToList();
            for (int i = requestedFacts.Count - 1; i >= 0; i--)
            {
                PrintAnswer(requestedFacts.Count - i,
                    requestedFacts[i].Variable.Question, requestedFacts[i].Value.Value);
            }
        }

        private void InitConsultationForm()
        {
            cbAnswers.DropDownStyle = ComboBoxStyle.DropDownList;
            tbConsultation.Clear();
            btnAnswer.Enabled = true;
            btnShowExplanation.Visible = false;

            if (_consPhase == ConsultationPhase.GoalDefinition)
            {
                tbCurQuestion.Text = "Цель консультации";
                cbAnswers.Items.AddRange(_knowledgeBase.Variables
                     .Where(v => v.Type != EVariableType.Requested)
                     .ToArray());
                if (cbAnswers.Items.Count > 0)
                {
                    cbAnswers.SelectedIndex = 0;
                }
                else
                {
                    btnAnswer.Enabled = false;
                }
            }
            else
            {
                PrintAnswer(0, "Цель консультации", StartGoalVariable.Name);
                FillConsultationLog();
                if (_consPhase == ConsultationPhase.AskQuestions)
                {
                    tbCurQuestion.Text = _requestedVar.Question;
                    cbAnswers.Items.AddRange(_requestedVar.Domain.Values.ToArray());
                    cbAnswers.SelectedIndex = 0;
                }
                else
                {
                    gbCurQuestion.Visible = false;
                    cbAnswers.Visible = false;
                    btnAnswer.Text = "Завершить";

                    tbConsultation.AppendText("Консультация завершена." + Environment.NewLine);
                    var lastProvedFact = _workingMemory.ProvenFacts.Count > 0 ?
                        _workingMemory.ProvenFacts.Peek() : null;
                    if (lastProvedFact?.Variable == StartGoalVariable)
                    {
                        tbConsultation.AppendText(lastProvedFact.ToString());
                        btnShowExplanation.Visible = true;
                    }
                    else
                    {
                        tbConsultation.AppendText("Не удалось определить значение целевой переменной!");
                    }
                }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (_consPhase == ConsultationPhase.GoalDefinition)
            {
                StartGoalVariable = (Variable)cbAnswers.SelectedItem;
            }
            else if (_consPhase == ConsultationPhase.AskQuestions)
            {
                RequestedFact = new Fact(_requestedVar, (DomainValue)cbAnswers.SelectedItem);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnShowExplanation_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show(
                "Перейти к объяснению результатов?",
                "Компонента объяснения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (dlgResult == DialogResult.Yes)
            {
                new ExplanationForm(_workingMemory).ShowDialog();
            }
        }
    }
}
