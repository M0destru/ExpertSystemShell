namespace ExpertSystemShell.UI
{
    partial class ConsultationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAnswers = new System.Windows.Forms.ComboBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnShowExplanation = new System.Windows.Forms.Button();
            this.panelConsultation = new System.Windows.Forms.Panel();
            this.tbConsultation = new System.Windows.Forms.TextBox();
            this.tbCurQuestion = new System.Windows.Forms.TextBox();
            this.gbCurQuestion = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel.SuspendLayout();
            this.panelConsultation.SuspendLayout();
            this.gbCurQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.cbAnswers);
            this.flowLayoutPanel.Controls.Add(this.btnAnswer);
            this.flowLayoutPanel.Controls.Add(this.btnShowExplanation);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 455);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.flowLayoutPanel.Size = new System.Drawing.Size(644, 62);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // cbAnswers
            // 
            this.cbAnswers.FormattingEnabled = true;
            this.cbAnswers.Location = new System.Drawing.Point(8, 11);
            this.cbAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.cbAnswers.Name = "cbAnswers";
            this.cbAnswers.Size = new System.Drawing.Size(492, 24);
            this.cbAnswers.TabIndex = 0;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(508, 11);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(123, 27);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnShowExplanation
            // 
            this.btnShowExplanation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowExplanation.Location = new System.Drawing.Point(8, 46);
            this.btnShowExplanation.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowExplanation.Name = "btnShowExplanation";
            this.btnShowExplanation.Size = new System.Drawing.Size(123, 0);
            this.btnShowExplanation.TabIndex = 2;
            this.btnShowExplanation.Text = "Объяснение";
            this.btnShowExplanation.UseVisualStyleBackColor = true;
            this.btnShowExplanation.Visible = false;
            this.btnShowExplanation.Click += new System.EventHandler(this.btnShowExplanation_Click);
            // 
            // panelConsultation
            // 
            this.panelConsultation.AutoScroll = true;
            this.panelConsultation.Controls.Add(this.tbConsultation);
            this.panelConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultation.Location = new System.Drawing.Point(0, 0);
            this.panelConsultation.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsultation.Name = "panelConsultation";
            this.panelConsultation.Padding = new System.Windows.Forms.Padding(4, 7, 4, 10);
            this.panelConsultation.Size = new System.Drawing.Size(644, 397);
            this.panelConsultation.TabIndex = 1;
            // 
            // tbConsultation
            // 
            this.tbConsultation.BackColor = System.Drawing.Color.Lavender;
            this.tbConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsultation.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConsultation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbConsultation.Location = new System.Drawing.Point(4, 7);
            this.tbConsultation.Margin = new System.Windows.Forms.Padding(4);
            this.tbConsultation.Multiline = true;
            this.tbConsultation.Name = "tbConsultation";
            this.tbConsultation.ReadOnly = true;
            this.tbConsultation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsultation.Size = new System.Drawing.Size(636, 380);
            this.tbConsultation.TabIndex = 0;
            this.tbConsultation.Text = "\r\n";
            // 
            // tbCurQuestion
            // 
            this.tbCurQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurQuestion.Location = new System.Drawing.Point(4, 19);
            this.tbCurQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurQuestion.Name = "tbCurQuestion";
            this.tbCurQuestion.ReadOnly = true;
            this.tbCurQuestion.Size = new System.Drawing.Size(636, 22);
            this.tbCurQuestion.TabIndex = 1;
            // 
            // gbCurQuestion
            // 
            this.gbCurQuestion.Controls.Add(this.tbCurQuestion);
            this.gbCurQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCurQuestion.Location = new System.Drawing.Point(0, 397);
            this.gbCurQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.gbCurQuestion.Name = "gbCurQuestion";
            this.gbCurQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.gbCurQuestion.Size = new System.Drawing.Size(644, 58);
            this.gbCurQuestion.TabIndex = 2;
            this.gbCurQuestion.TabStop = false;
            this.gbCurQuestion.Text = "Текущий вопрос";
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 517);
            this.Controls.Add(this.panelConsultation);
            this.Controls.Add(this.gbCurQuestion);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Консультация";
            this.Shown += new System.EventHandler(this.ConsultationForm_Shown);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelConsultation.ResumeLayout(false);
            this.panelConsultation.PerformLayout();
            this.gbCurQuestion.ResumeLayout(false);
            this.gbCurQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox cbAnswers;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Panel panelConsultation;
        private System.Windows.Forms.TextBox tbConsultation;
        private System.Windows.Forms.GroupBox gbCurQuestion;
        private System.Windows.Forms.TextBox tbCurQuestion;
        private System.Windows.Forms.Button btnShowExplanation;
    }
}