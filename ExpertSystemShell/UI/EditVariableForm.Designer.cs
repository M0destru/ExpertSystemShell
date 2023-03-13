namespace ExpertSystemShell.UI
{
    partial class EditVariableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVariableForm));
            this.gbVariableName = new System.Windows.Forms.GroupBox();
            this.tbVariableName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.btnEditDomain = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.gbVariableType = new System.Windows.Forms.GroupBox();
            this.rbRequestedInferred = new System.Windows.Forms.RadioButton();
            this.rbInferableVariable = new System.Windows.Forms.RadioButton();
            this.rbRequestedVariable = new System.Windows.Forms.RadioButton();
            this.gbQuestionText = new System.Windows.Forms.GroupBox();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.gbVariableName.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.gbVariableType.SuspendLayout();
            this.gbQuestionText.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVariableName
            // 
            this.gbVariableName.Controls.Add(this.tbVariableName);
            this.gbVariableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVariableName.Location = new System.Drawing.Point(0, 0);
            this.gbVariableName.Margin = new System.Windows.Forms.Padding(4);
            this.gbVariableName.Name = "gbVariableName";
            this.gbVariableName.Padding = new System.Windows.Forms.Padding(4);
            this.gbVariableName.Size = new System.Drawing.Size(419, 50);
            this.gbVariableName.TabIndex = 0;
            this.gbVariableName.TabStop = false;
            this.gbVariableName.Text = "Имя переменной";
            // 
            // tbVariableName
            // 
            this.tbVariableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVariableName.Location = new System.Drawing.Point(4, 19);
            this.tbVariableName.Margin = new System.Windows.Forms.Padding(4);
            this.tbVariableName.Name = "tbVariableName";
            this.tbVariableName.Size = new System.Drawing.Size(411, 22);
            this.tbVariableName.TabIndex = 0;
            this.tbVariableName.TextChanged += new System.EventHandler(this.tbVariableName_TextChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.btnOk);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 300);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(419, 36);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(315, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.btnEditDomain);
            this.gbDomain.Controls.Add(this.btnAddDomain);
            this.gbDomain.Controls.Add(this.cbDomain);
            this.gbDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDomain.Location = new System.Drawing.Point(0, 50);
            this.gbDomain.Margin = new System.Windows.Forms.Padding(4);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Padding = new System.Windows.Forms.Padding(4);
            this.gbDomain.Size = new System.Drawing.Size(419, 55);
            this.gbDomain.TabIndex = 2;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Домен";
            // 
            // btnEditDomain
            // 
            this.btnEditDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditDomain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDomain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditDomain.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDomain.Image")));
            this.btnEditDomain.Location = new System.Drawing.Point(349, 18);
            this.btnEditDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDomain.Name = "btnEditDomain";
            this.btnEditDomain.Size = new System.Drawing.Size(31, 26);
            this.btnEditDomain.TabIndex = 5;
            this.btnEditDomain.UseVisualStyleBackColor = false;
            this.btnEditDomain.Click += new System.EventHandler(this.btnEditDomain_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddDomain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDomain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDomain.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDomain.Image")));
            this.btnAddDomain.Location = new System.Drawing.Point(384, 18);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(31, 26);
            this.btnAddDomain.TabIndex = 4;
            this.btnAddDomain.UseVisualStyleBackColor = false;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // cbDomain
            // 
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(4, 20);
            this.cbDomain.Margin = new System.Windows.Forms.Padding(4);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(337, 24);
            this.cbDomain.TabIndex = 0;
            this.cbDomain.SelectedIndexChanged += new System.EventHandler(this.cbDomain_SelectedIndexChanged);
            // 
            // gbVariableType
            // 
            this.gbVariableType.Controls.Add(this.rbRequestedInferred);
            this.gbVariableType.Controls.Add(this.rbInferableVariable);
            this.gbVariableType.Controls.Add(this.rbRequestedVariable);
            this.gbVariableType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVariableType.Location = new System.Drawing.Point(0, 105);
            this.gbVariableType.Margin = new System.Windows.Forms.Padding(4);
            this.gbVariableType.Name = "gbVariableType";
            this.gbVariableType.Padding = new System.Windows.Forms.Padding(4);
            this.gbVariableType.Size = new System.Drawing.Size(419, 66);
            this.gbVariableType.TabIndex = 3;
            this.gbVariableType.TabStop = false;
            this.gbVariableType.Text = "Тип переменной";
            // 
            // rbRequestedInferred
            // 
            this.rbRequestedInferred.AutoSize = true;
            this.rbRequestedInferred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRequestedInferred.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRequestedInferred.Location = new System.Drawing.Point(147, 19);
            this.rbRequestedInferred.Margin = new System.Windows.Forms.Padding(4);
            this.rbRequestedInferred.Name = "rbRequestedInferred";
            this.rbRequestedInferred.Size = new System.Drawing.Size(160, 43);
            this.rbRequestedInferred.TabIndex = 2;
            this.rbRequestedInferred.TabStop = true;
            this.rbRequestedInferred.Text = "Выводимо-\r\nзапрашиваемая";
            this.rbRequestedInferred.UseVisualStyleBackColor = true;
            this.rbRequestedInferred.CheckedChanged += new System.EventHandler(this.rbRequestedInferred_CheckedChanged);
            // 
            // rbInferableVariable
            // 
            this.rbInferableVariable.AutoSize = true;
            this.rbInferableVariable.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbInferableVariable.Location = new System.Drawing.Point(307, 19);
            this.rbInferableVariable.Margin = new System.Windows.Forms.Padding(4);
            this.rbInferableVariable.Name = "rbInferableVariable";
            this.rbInferableVariable.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.rbInferableVariable.Size = new System.Drawing.Size(108, 43);
            this.rbInferableVariable.TabIndex = 1;
            this.rbInferableVariable.TabStop = true;
            this.rbInferableVariable.Text = "Выводимая";
            this.rbInferableVariable.UseVisualStyleBackColor = true;
            this.rbInferableVariable.CheckedChanged += new System.EventHandler(this.rbInferableVariable_CheckedChanged);
            // 
            // rbRequestedVariable
            // 
            this.rbRequestedVariable.AutoSize = true;
            this.rbRequestedVariable.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbRequestedVariable.Location = new System.Drawing.Point(4, 19);
            this.rbRequestedVariable.Margin = new System.Windows.Forms.Padding(4);
            this.rbRequestedVariable.Name = "rbRequestedVariable";
            this.rbRequestedVariable.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.rbRequestedVariable.Size = new System.Drawing.Size(143, 43);
            this.rbRequestedVariable.TabIndex = 0;
            this.rbRequestedVariable.TabStop = true;
            this.rbRequestedVariable.Text = "Запрашиваемая";
            this.rbRequestedVariable.UseVisualStyleBackColor = true;
            this.rbRequestedVariable.CheckedChanged += new System.EventHandler(this.rbRequestedVariable_CheckedChanged);
            // 
            // gbQuestionText
            // 
            this.gbQuestionText.Controls.Add(this.tbQuestionText);
            this.gbQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuestionText.Location = new System.Drawing.Point(0, 171);
            this.gbQuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.gbQuestionText.Name = "gbQuestionText";
            this.gbQuestionText.Padding = new System.Windows.Forms.Padding(4);
            this.gbQuestionText.Size = new System.Drawing.Size(419, 129);
            this.gbQuestionText.TabIndex = 4;
            this.gbQuestionText.TabStop = false;
            this.gbQuestionText.Text = "Текст вопроса";
            // 
            // tbQuestionText
            // 
            this.tbQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestionText.Location = new System.Drawing.Point(4, 19);
            this.tbQuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuestionText.Multiline = true;
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.Size = new System.Drawing.Size(411, 106);
            this.tbQuestionText.TabIndex = 0;
            this.tbQuestionText.TextChanged += new System.EventHandler(this.tbQuestionText_TextChanged);
            // 
            // EditVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 336);
            this.Controls.Add(this.gbQuestionText);
            this.Controls.Add(this.gbVariableType);
            this.Controls.Add(this.gbDomain);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.gbVariableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditVariableForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание переменной";
            this.gbVariableName.ResumeLayout(false);
            this.gbVariableName.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.gbDomain.ResumeLayout(false);
            this.gbVariableType.ResumeLayout(false);
            this.gbVariableType.PerformLayout();
            this.gbQuestionText.ResumeLayout(false);
            this.gbQuestionText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVariableName;
        private System.Windows.Forms.TextBox tbVariableName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox gbDomain;
        private System.Windows.Forms.ComboBox cbDomain;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbVariableType;
        private System.Windows.Forms.RadioButton rbInferableVariable;
        private System.Windows.Forms.RadioButton rbRequestedVariable;
        private System.Windows.Forms.GroupBox gbQuestionText;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.Button btnEditDomain;
        private System.Windows.Forms.RadioButton rbRequestedInferred;
    }
}