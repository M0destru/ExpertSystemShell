namespace ExpertSystemShell.UI
{
    partial class ExpertSystemForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsCbFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCbConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuStartConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExplanation = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.panelRules = new System.Windows.Forms.Panel();
            this.lstViewRules = new System.Windows.Forms.ListView();
            this.columnRuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuleDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelRuleOperations = new System.Windows.Forms.Panel();
            this.gbRuleInference = new System.Windows.Forms.GroupBox();
            this.lstBoxInferenceFacts = new System.Windows.Forms.ListBox();
            this.gbRulePremise = new System.Windows.Forms.GroupBox();
            this.lstBoxPremiseFacts = new System.Windows.Forms.ListBox();
            this.gbEditRule = new System.Windows.Forms.GroupBox();
            this.btnDelRule = new System.Windows.Forms.Button();
            this.btnChangeRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tabPageVariables = new System.Windows.Forms.TabPage();
            this.panelVariables = new System.Windows.Forms.Panel();
            this.lstViewVariables = new System.Windows.Forms.ListView();
            this.columnVariableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVariableType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVariableDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelVariableOperations = new System.Windows.Forms.Panel();
            this.gbQuestionText = new System.Windows.Forms.GroupBox();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.gbAvailableDomainValues = new System.Windows.Forms.GroupBox();
            this.lstBoxDomainValues = new System.Windows.Forms.ListBox();
            this.gbEditVariable = new System.Windows.Forms.GroupBox();
            this.btnDelVariable = new System.Windows.Forms.Button();
            this.btnChangeVariable = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.tabPageDomains = new System.Windows.Forms.TabPage();
            this.panelDomains = new System.Windows.Forms.Panel();
            this.lstViewDomains = new System.Windows.Forms.ListView();
            this.columnDomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDomainOperations = new System.Windows.Forms.Panel();
            this.gbDomainValues = new System.Windows.Forms.GroupBox();
            this.lstBoxValuesOfDomain = new System.Windows.Forms.ListBox();
            this.gbEditDomain = new System.Windows.Forms.GroupBox();
            this.btnDelDomain = new System.Windows.Forms.Button();
            this.btnChangeDomain = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.gbUsedInRules = new System.Windows.Forms.GroupBox();
            this.lstBoxUsedInRules = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.panelRules.SuspendLayout();
            this.panelRuleOperations.SuspendLayout();
            this.gbRuleInference.SuspendLayout();
            this.gbRulePremise.SuspendLayout();
            this.gbEditRule.SuspendLayout();
            this.tabPageVariables.SuspendLayout();
            this.panelVariables.SuspendLayout();
            this.panelVariableOperations.SuspendLayout();
            this.gbQuestionText.SuspendLayout();
            this.gbAvailableDomainValues.SuspendLayout();
            this.gbEditVariable.SuspendLayout();
            this.tabPageDomains.SuspendLayout();
            this.panelDomains.SuspendLayout();
            this.panelDomainOperations.SuspendLayout();
            this.gbDomainValues.SuspendLayout();
            this.gbEditDomain.SuspendLayout();
            this.gbUsedInRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCbFile,
            this.tsCbConsultation});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip.TabIndex = 0;
            // 
            // tsCbFile
            // 
            this.tsCbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNewFile,
            this.tsMenuOpenFile,
            this.tsMenuSave,
            this.tsMenuSaveAs,
            this.toolStripSeparator1,
            this.tsMenuExit});
            this.tsCbFile.Name = "tsCbFile";
            this.tsCbFile.Size = new System.Drawing.Size(59, 26);
            this.tsCbFile.Text = "Файл";
            // 
            // tsMenuNewFile
            // 
            this.tsMenuNewFile.Name = "tsMenuNewFile";
            this.tsMenuNewFile.Size = new System.Drawing.Size(192, 26);
            this.tsMenuNewFile.Text = "Новый";
            this.tsMenuNewFile.Click += new System.EventHandler(this.tsMenuNewFile_Click);
            // 
            // tsMenuOpenFile
            // 
            this.tsMenuOpenFile.Name = "tsMenuOpenFile";
            this.tsMenuOpenFile.Size = new System.Drawing.Size(192, 26);
            this.tsMenuOpenFile.Text = "Открыть";
            this.tsMenuOpenFile.Click += new System.EventHandler(this.tsMenuOpenFile_Click);
            // 
            // tsMenuSave
            // 
            this.tsMenuSave.Name = "tsMenuSave";
            this.tsMenuSave.Size = new System.Drawing.Size(192, 26);
            this.tsMenuSave.Text = "Сохранить";
            this.tsMenuSave.Click += new System.EventHandler(this.tsMenuSave_Click);
            // 
            // tsMenuSaveAs
            // 
            this.tsMenuSaveAs.Name = "tsMenuSaveAs";
            this.tsMenuSaveAs.Size = new System.Drawing.Size(192, 26);
            this.tsMenuSaveAs.Text = "Сохранить как";
            this.tsMenuSaveAs.Click += new System.EventHandler(this.tsMenuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.Name = "tsMenuExit";
            this.tsMenuExit.ShortcutKeyDisplayString = "";
            this.tsMenuExit.Size = new System.Drawing.Size(192, 26);
            this.tsMenuExit.Text = "Выход";
            this.tsMenuExit.Click += new System.EventHandler(this.tsMenuExit_Click);
            // 
            // tsCbConsultation
            // 
            this.tsCbConsultation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuStartConsultation,
            this.tsMenuExplanation});
            this.tsCbConsultation.Name = "tsCbConsultation";
            this.tsCbConsultation.Size = new System.Drawing.Size(120, 26);
            this.tsCbConsultation.Text = "Консультация";
            // 
            // tsMenuStartConsultation
            // 
            this.tsMenuStartConsultation.Name = "tsMenuStartConsultation";
            this.tsMenuStartConsultation.Size = new System.Drawing.Size(245, 26);
            this.tsMenuStartConsultation.Text = "Начать";
            this.tsMenuStartConsultation.Click += new System.EventHandler(this.tsMenuStartConsultation_Click);
            // 
            // tsMenuExplanation
            // 
            this.tsMenuExplanation.Name = "tsMenuExplanation";
            this.tsMenuExplanation.Size = new System.Drawing.Size(245, 26);
            this.tsMenuExplanation.Text = "Показать объяснение";
            this.tsMenuExplanation.Click += new System.EventHandler(this.tsMenuExplanation_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRules);
            this.tabControl.Controls.Add(this.tabPageVariables);
            this.tabControl.Controls.Add(this.tabPageDomains);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 30);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 524);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.panelRules);
            this.tabPageRules.Controls.Add(this.panelRuleOperations);
            this.tabPageRules.Location = new System.Drawing.Point(4, 25);
            this.tabPageRules.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRules.Size = new System.Drawing.Size(1059, 495);
            this.tabPageRules.TabIndex = 0;
            this.tabPageRules.Text = "Правила";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // panelRules
            // 
            this.panelRules.Controls.Add(this.lstViewRules);
            this.panelRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRules.Location = new System.Drawing.Point(4, 4);
            this.panelRules.Margin = new System.Windows.Forms.Padding(4);
            this.panelRules.Name = "panelRules";
            this.panelRules.Size = new System.Drawing.Size(651, 487);
            this.panelRules.TabIndex = 0;
            // 
            // lstViewRules
            // 
            this.lstViewRules.AllowDrop = true;
            this.lstViewRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRuleName,
            this.columnRuleDescription});
            this.lstViewRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewRules.FullRowSelect = true;
            this.lstViewRules.GridLines = true;
            this.lstViewRules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewRules.HideSelection = false;
            this.lstViewRules.Location = new System.Drawing.Point(0, 0);
            this.lstViewRules.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewRules.MultiSelect = false;
            this.lstViewRules.Name = "lstViewRules";
            this.lstViewRules.ShowItemToolTips = true;
            this.lstViewRules.Size = new System.Drawing.Size(651, 487);
            this.lstViewRules.TabIndex = 0;
            this.lstViewRules.UseCompatibleStateImageBehavior = false;
            this.lstViewRules.View = System.Windows.Forms.View.Details;
            this.lstViewRules.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstViewRules_ItemDrag);
            this.lstViewRules.SelectedIndexChanged += new System.EventHandler(this.lstViewRules_SelectedIndexChanged);
            this.lstViewRules.SizeChanged += new System.EventHandler(this.lstViewRules_SizeChanged);
            this.lstViewRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstViewRules_DragDrop);
            this.lstViewRules.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstViewRules_DragEnter);
            // 
            // columnRuleName
            // 
            this.columnRuleName.Text = "Имя";
            // 
            // columnRuleDescription
            // 
            this.columnRuleDescription.Text = "Описание";
            this.columnRuleDescription.Width = 350;
            // 
            // panelRuleOperations
            // 
            this.panelRuleOperations.Controls.Add(this.gbRulePremise);
            this.panelRuleOperations.Controls.Add(this.gbEditRule);
            this.panelRuleOperations.Controls.Add(this.gbRuleInference);
            this.panelRuleOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRuleOperations.Location = new System.Drawing.Point(655, 4);
            this.panelRuleOperations.Margin = new System.Windows.Forms.Padding(4);
            this.panelRuleOperations.Name = "panelRuleOperations";
            this.panelRuleOperations.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelRuleOperations.Size = new System.Drawing.Size(400, 487);
            this.panelRuleOperations.TabIndex = 5;
            // 
            // gbRuleInference
            // 
            this.gbRuleInference.Controls.Add(this.lstBoxInferenceFacts);
            this.gbRuleInference.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbRuleInference.Location = new System.Drawing.Point(4, 363);
            this.gbRuleInference.Margin = new System.Windows.Forms.Padding(4);
            this.gbRuleInference.Name = "gbRuleInference";
            this.gbRuleInference.Padding = new System.Windows.Forms.Padding(4);
            this.gbRuleInference.Size = new System.Drawing.Size(396, 124);
            this.gbRuleInference.TabIndex = 7;
            this.gbRuleInference.TabStop = false;
            this.gbRuleInference.Text = "Заключение";
            // 
            // lstBoxInferenceFacts
            // 
            this.lstBoxInferenceFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxInferenceFacts.FormattingEnabled = true;
            this.lstBoxInferenceFacts.HorizontalScrollbar = true;
            this.lstBoxInferenceFacts.ItemHeight = 16;
            this.lstBoxInferenceFacts.Location = new System.Drawing.Point(4, 19);
            this.lstBoxInferenceFacts.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxInferenceFacts.Name = "lstBoxInferenceFacts";
            this.lstBoxInferenceFacts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxInferenceFacts.Size = new System.Drawing.Size(388, 101);
            this.lstBoxInferenceFacts.TabIndex = 0;
            // 
            // gbRulePremise
            // 
            this.gbRulePremise.Controls.Add(this.lstBoxPremiseFacts);
            this.gbRulePremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRulePremise.Location = new System.Drawing.Point(4, 108);
            this.gbRulePremise.Margin = new System.Windows.Forms.Padding(4);
            this.gbRulePremise.Name = "gbRulePremise";
            this.gbRulePremise.Padding = new System.Windows.Forms.Padding(4);
            this.gbRulePremise.Size = new System.Drawing.Size(396, 255);
            this.gbRulePremise.TabIndex = 6;
            this.gbRulePremise.TabStop = false;
            this.gbRulePremise.Text = "Посылка";
            // 
            // lstBoxPremiseFacts
            // 
            this.lstBoxPremiseFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxPremiseFacts.FormattingEnabled = true;
            this.lstBoxPremiseFacts.HorizontalScrollbar = true;
            this.lstBoxPremiseFacts.ItemHeight = 16;
            this.lstBoxPremiseFacts.Location = new System.Drawing.Point(4, 19);
            this.lstBoxPremiseFacts.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxPremiseFacts.Name = "lstBoxPremiseFacts";
            this.lstBoxPremiseFacts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxPremiseFacts.Size = new System.Drawing.Size(388, 232);
            this.lstBoxPremiseFacts.TabIndex = 0;
            // 
            // gbEditRule
            // 
            this.gbEditRule.Controls.Add(this.btnDelRule);
            this.gbEditRule.Controls.Add(this.btnChangeRule);
            this.gbEditRule.Controls.Add(this.btnAddRule);
            this.gbEditRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditRule.Location = new System.Drawing.Point(4, 0);
            this.gbEditRule.Margin = new System.Windows.Forms.Padding(4);
            this.gbEditRule.Name = "gbEditRule";
            this.gbEditRule.Padding = new System.Windows.Forms.Padding(4);
            this.gbEditRule.Size = new System.Drawing.Size(396, 108);
            this.gbEditRule.TabIndex = 1;
            this.gbEditRule.TabStop = false;
            this.gbEditRule.Text = "Редактирование";
            // 
            // btnDelRule
            // 
            this.btnDelRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelRule.Location = new System.Drawing.Point(4, 75);
            this.btnDelRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelRule.Name = "btnDelRule";
            this.btnDelRule.Size = new System.Drawing.Size(388, 28);
            this.btnDelRule.TabIndex = 2;
            this.btnDelRule.Text = "Удалить";
            this.btnDelRule.UseVisualStyleBackColor = true;
            this.btnDelRule.Click += new System.EventHandler(this.btnDelRule_Click);
            // 
            // btnChangeRule
            // 
            this.btnChangeRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeRule.Location = new System.Drawing.Point(4, 47);
            this.btnChangeRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeRule.Name = "btnChangeRule";
            this.btnChangeRule.Size = new System.Drawing.Size(388, 28);
            this.btnChangeRule.TabIndex = 1;
            this.btnChangeRule.Text = "Изменить";
            this.btnChangeRule.UseVisualStyleBackColor = true;
            this.btnChangeRule.Click += new System.EventHandler(this.btnChangeRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRule.Location = new System.Drawing.Point(4, 19);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(388, 28);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "Добавить";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // tabPageVariables
            // 
            this.tabPageVariables.Controls.Add(this.panelVariables);
            this.tabPageVariables.Controls.Add(this.panelVariableOperations);
            this.tabPageVariables.Location = new System.Drawing.Point(4, 25);
            this.tabPageVariables.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageVariables.Name = "tabPageVariables";
            this.tabPageVariables.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageVariables.Size = new System.Drawing.Size(1059, 495);
            this.tabPageVariables.TabIndex = 1;
            this.tabPageVariables.Text = "Переменные";
            this.tabPageVariables.UseVisualStyleBackColor = true;
            // 
            // panelVariables
            // 
            this.panelVariables.Controls.Add(this.lstViewVariables);
            this.panelVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVariables.Location = new System.Drawing.Point(4, 4);
            this.panelVariables.Margin = new System.Windows.Forms.Padding(4);
            this.panelVariables.Name = "panelVariables";
            this.panelVariables.Size = new System.Drawing.Size(651, 487);
            this.panelVariables.TabIndex = 10;
            // 
            // lstViewVariables
            // 
            this.lstViewVariables.AllowDrop = true;
            this.lstViewVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVariableName,
            this.columnVariableType,
            this.columnVariableDomain});
            this.lstViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewVariables.FullRowSelect = true;
            this.lstViewVariables.GridLines = true;
            this.lstViewVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewVariables.HideSelection = false;
            this.lstViewVariables.Location = new System.Drawing.Point(0, 0);
            this.lstViewVariables.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewVariables.MultiSelect = false;
            this.lstViewVariables.Name = "lstViewVariables";
            this.lstViewVariables.Size = new System.Drawing.Size(651, 487);
            this.lstViewVariables.TabIndex = 0;
            this.lstViewVariables.UseCompatibleStateImageBehavior = false;
            this.lstViewVariables.View = System.Windows.Forms.View.Details;
            this.lstViewVariables.SelectedIndexChanged += new System.EventHandler(this.lstViewVariables_SelectedIndexChanged);
            this.lstViewVariables.SizeChanged += new System.EventHandler(this.lstViewVariables_SizeChanged);
            // 
            // columnVariableName
            // 
            this.columnVariableName.Text = "Имя";
            this.columnVariableName.Width = 136;
            // 
            // columnVariableType
            // 
            this.columnVariableType.Text = "Тип";
            this.columnVariableType.Width = 136;
            // 
            // columnVariableDomain
            // 
            this.columnVariableDomain.Text = "Домен";
            this.columnVariableDomain.Width = 136;
            // 
            // panelVariableOperations
            // 
            this.panelVariableOperations.Controls.Add(this.gbAvailableDomainValues);
            this.panelVariableOperations.Controls.Add(this.gbUsedInRules);
            this.panelVariableOperations.Controls.Add(this.gbEditVariable);
            this.panelVariableOperations.Controls.Add(this.gbQuestionText);
            this.panelVariableOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVariableOperations.Location = new System.Drawing.Point(655, 4);
            this.panelVariableOperations.Margin = new System.Windows.Forms.Padding(4);
            this.panelVariableOperations.Name = "panelVariableOperations";
            this.panelVariableOperations.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelVariableOperations.Size = new System.Drawing.Size(400, 487);
            this.panelVariableOperations.TabIndex = 9;
            // 
            // gbQuestionText
            // 
            this.gbQuestionText.Controls.Add(this.tbQuestionText);
            this.gbQuestionText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbQuestionText.Location = new System.Drawing.Point(4, 392);
            this.gbQuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.gbQuestionText.Name = "gbQuestionText";
            this.gbQuestionText.Padding = new System.Windows.Forms.Padding(4);
            this.gbQuestionText.Size = new System.Drawing.Size(396, 95);
            this.gbQuestionText.TabIndex = 6;
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
            this.tbQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbQuestionText.Size = new System.Drawing.Size(388, 72);
            this.tbQuestionText.TabIndex = 0;
            // 
            // gbAvailableDomainValues
            // 
            this.gbAvailableDomainValues.Controls.Add(this.lstBoxDomainValues);
            this.gbAvailableDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAvailableDomainValues.Location = new System.Drawing.Point(4, 108);
            this.gbAvailableDomainValues.Margin = new System.Windows.Forms.Padding(4);
            this.gbAvailableDomainValues.Name = "gbAvailableDomainValues";
            this.gbAvailableDomainValues.Padding = new System.Windows.Forms.Padding(4);
            this.gbAvailableDomainValues.Size = new System.Drawing.Size(396, 147);
            this.gbAvailableDomainValues.TabIndex = 7;
            this.gbAvailableDomainValues.TabStop = false;
            this.gbAvailableDomainValues.Text = "Допустимые значения домена";
            // 
            // lstBoxDomainValues
            // 
            this.lstBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxDomainValues.FormattingEnabled = true;
            this.lstBoxDomainValues.HorizontalScrollbar = true;
            this.lstBoxDomainValues.ItemHeight = 16;
            this.lstBoxDomainValues.Location = new System.Drawing.Point(4, 19);
            this.lstBoxDomainValues.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxDomainValues.Name = "lstBoxDomainValues";
            this.lstBoxDomainValues.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxDomainValues.Size = new System.Drawing.Size(388, 124);
            this.lstBoxDomainValues.TabIndex = 0;
            // 
            // gbEditVariable
            // 
            this.gbEditVariable.Controls.Add(this.btnDelVariable);
            this.gbEditVariable.Controls.Add(this.btnChangeVariable);
            this.gbEditVariable.Controls.Add(this.btnAddVariable);
            this.gbEditVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditVariable.Location = new System.Drawing.Point(4, 0);
            this.gbEditVariable.Margin = new System.Windows.Forms.Padding(4);
            this.gbEditVariable.Name = "gbEditVariable";
            this.gbEditVariable.Padding = new System.Windows.Forms.Padding(4);
            this.gbEditVariable.Size = new System.Drawing.Size(396, 108);
            this.gbEditVariable.TabIndex = 1;
            this.gbEditVariable.TabStop = false;
            this.gbEditVariable.Text = "Редактирование";
            // 
            // btnDelVariable
            // 
            this.btnDelVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelVariable.Location = new System.Drawing.Point(4, 75);
            this.btnDelVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelVariable.Name = "btnDelVariable";
            this.btnDelVariable.Size = new System.Drawing.Size(388, 28);
            this.btnDelVariable.TabIndex = 2;
            this.btnDelVariable.Text = "Удалить";
            this.btnDelVariable.UseVisualStyleBackColor = true;
            this.btnDelVariable.Click += new System.EventHandler(this.btnDelVariable_Click);
            // 
            // btnChangeVariable
            // 
            this.btnChangeVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeVariable.Location = new System.Drawing.Point(4, 47);
            this.btnChangeVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeVariable.Name = "btnChangeVariable";
            this.btnChangeVariable.Size = new System.Drawing.Size(388, 28);
            this.btnChangeVariable.TabIndex = 1;
            this.btnChangeVariable.Text = "Изменить";
            this.btnChangeVariable.UseVisualStyleBackColor = true;
            this.btnChangeVariable.Click += new System.EventHandler(this.btnChangeVariable_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVariable.Location = new System.Drawing.Point(4, 19);
            this.btnAddVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(388, 28);
            this.btnAddVariable.TabIndex = 0;
            this.btnAddVariable.Text = "Добавить";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // tabPageDomains
            // 
            this.tabPageDomains.Controls.Add(this.panelDomains);
            this.tabPageDomains.Controls.Add(this.panelDomainOperations);
            this.tabPageDomains.Location = new System.Drawing.Point(4, 25);
            this.tabPageDomains.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDomains.Name = "tabPageDomains";
            this.tabPageDomains.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDomains.Size = new System.Drawing.Size(1059, 497);
            this.tabPageDomains.TabIndex = 2;
            this.tabPageDomains.Text = "Домены";
            this.tabPageDomains.UseVisualStyleBackColor = true;
            // 
            // panelDomains
            // 
            this.panelDomains.Controls.Add(this.lstViewDomains);
            this.panelDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDomains.Location = new System.Drawing.Point(4, 4);
            this.panelDomains.Margin = new System.Windows.Forms.Padding(4);
            this.panelDomains.Name = "panelDomains";
            this.panelDomains.Size = new System.Drawing.Size(651, 489);
            this.panelDomains.TabIndex = 9;
            // 
            // lstViewDomains
            // 
            this.lstViewDomains.AllowDrop = true;
            this.lstViewDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDomainName});
            this.lstViewDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewDomains.FullRowSelect = true;
            this.lstViewDomains.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewDomains.HideSelection = false;
            this.lstViewDomains.Location = new System.Drawing.Point(0, 0);
            this.lstViewDomains.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewDomains.MultiSelect = false;
            this.lstViewDomains.Name = "lstViewDomains";
            this.lstViewDomains.Size = new System.Drawing.Size(651, 489);
            this.lstViewDomains.TabIndex = 0;
            this.lstViewDomains.UseCompatibleStateImageBehavior = false;
            this.lstViewDomains.View = System.Windows.Forms.View.Details;
            this.lstViewDomains.SelectedIndexChanged += new System.EventHandler(this.lstViewDomains_SelectedIndexChanged);
            this.lstViewDomains.SizeChanged += new System.EventHandler(this.lstViewDomains_SizeChanged);
            // 
            // columnDomainName
            // 
            this.columnDomainName.Text = "Имя";
            this.columnDomainName.Width = 430;
            // 
            // panelDomainOperations
            // 
            this.panelDomainOperations.Controls.Add(this.gbDomainValues);
            this.panelDomainOperations.Controls.Add(this.gbEditDomain);
            this.panelDomainOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDomainOperations.Location = new System.Drawing.Point(655, 4);
            this.panelDomainOperations.Margin = new System.Windows.Forms.Padding(4);
            this.panelDomainOperations.Name = "panelDomainOperations";
            this.panelDomainOperations.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelDomainOperations.Size = new System.Drawing.Size(400, 489);
            this.panelDomainOperations.TabIndex = 8;
            // 
            // gbDomainValues
            // 
            this.gbDomainValues.Controls.Add(this.lstBoxValuesOfDomain);
            this.gbDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDomainValues.Location = new System.Drawing.Point(4, 108);
            this.gbDomainValues.Margin = new System.Windows.Forms.Padding(4);
            this.gbDomainValues.Name = "gbDomainValues";
            this.gbDomainValues.Padding = new System.Windows.Forms.Padding(4);
            this.gbDomainValues.Size = new System.Drawing.Size(396, 381);
            this.gbDomainValues.TabIndex = 6;
            this.gbDomainValues.TabStop = false;
            this.gbDomainValues.Text = "Значение домена";
            // 
            // lstBoxValuesOfDomain
            // 
            this.lstBoxValuesOfDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxValuesOfDomain.FormattingEnabled = true;
            this.lstBoxValuesOfDomain.ItemHeight = 16;
            this.lstBoxValuesOfDomain.Location = new System.Drawing.Point(4, 19);
            this.lstBoxValuesOfDomain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxValuesOfDomain.Name = "lstBoxValuesOfDomain";
            this.lstBoxValuesOfDomain.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxValuesOfDomain.Size = new System.Drawing.Size(388, 358);
            this.lstBoxValuesOfDomain.TabIndex = 0;
            // 
            // gbEditDomain
            // 
            this.gbEditDomain.Controls.Add(this.btnDelDomain);
            this.gbEditDomain.Controls.Add(this.btnChangeDomain);
            this.gbEditDomain.Controls.Add(this.btnAddDomain);
            this.gbEditDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditDomain.Location = new System.Drawing.Point(4, 0);
            this.gbEditDomain.Margin = new System.Windows.Forms.Padding(4);
            this.gbEditDomain.Name = "gbEditDomain";
            this.gbEditDomain.Padding = new System.Windows.Forms.Padding(4);
            this.gbEditDomain.Size = new System.Drawing.Size(396, 108);
            this.gbEditDomain.TabIndex = 1;
            this.gbEditDomain.TabStop = false;
            this.gbEditDomain.Text = "Редактирование";
            // 
            // btnDelDomain
            // 
            this.btnDelDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelDomain.Location = new System.Drawing.Point(4, 75);
            this.btnDelDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDomain.Name = "btnDelDomain";
            this.btnDelDomain.Size = new System.Drawing.Size(388, 28);
            this.btnDelDomain.TabIndex = 2;
            this.btnDelDomain.Text = "Удалить";
            this.btnDelDomain.UseVisualStyleBackColor = true;
            this.btnDelDomain.Click += new System.EventHandler(this.btnDelDomain_Click);
            // 
            // btnChangeDomain
            // 
            this.btnChangeDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeDomain.Location = new System.Drawing.Point(4, 47);
            this.btnChangeDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeDomain.Name = "btnChangeDomain";
            this.btnChangeDomain.Size = new System.Drawing.Size(388, 28);
            this.btnChangeDomain.TabIndex = 1;
            this.btnChangeDomain.Text = "Изменить";
            this.btnChangeDomain.UseVisualStyleBackColor = true;
            this.btnChangeDomain.Click += new System.EventHandler(this.btnChangeDomain_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDomain.Location = new System.Drawing.Point(4, 19);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(388, 28);
            this.btnAddDomain.TabIndex = 0;
            this.btnAddDomain.Text = "Добавить";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // gbUsedInRules
            // 
            this.gbUsedInRules.Controls.Add(this.lstBoxUsedInRules);
            this.gbUsedInRules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUsedInRules.Location = new System.Drawing.Point(4, 255);
            this.gbUsedInRules.Name = "gbUsedInRules";
            this.gbUsedInRules.Padding = new System.Windows.Forms.Padding(4);
            this.gbUsedInRules.Size = new System.Drawing.Size(396, 137);
            this.gbUsedInRules.TabIndex = 1;
            this.gbUsedInRules.TabStop = false;
            this.gbUsedInRules.Text = "Используется в правилах";
            // 
            // lstBoxUsedInRules
            // 
            this.lstBoxUsedInRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxUsedInRules.FormattingEnabled = true;
            this.lstBoxUsedInRules.ItemHeight = 16;
            this.lstBoxUsedInRules.Location = new System.Drawing.Point(4, 19);
            this.lstBoxUsedInRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lstBoxUsedInRules.Name = "lstBoxUsedInRules";
            this.lstBoxUsedInRules.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBoxUsedInRules.Size = new System.Drawing.Size(388, 114);
            this.lstBoxUsedInRules.TabIndex = 0;
            // 
            // ExpertSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpertSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оболочка ЭС";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.panelRules.ResumeLayout(false);
            this.panelRuleOperations.ResumeLayout(false);
            this.gbRuleInference.ResumeLayout(false);
            this.gbRulePremise.ResumeLayout(false);
            this.gbEditRule.ResumeLayout(false);
            this.tabPageVariables.ResumeLayout(false);
            this.panelVariables.ResumeLayout(false);
            this.panelVariableOperations.ResumeLayout(false);
            this.gbQuestionText.ResumeLayout(false);
            this.gbQuestionText.PerformLayout();
            this.gbAvailableDomainValues.ResumeLayout(false);
            this.gbEditVariable.ResumeLayout(false);
            this.tabPageDomains.ResumeLayout(false);
            this.panelDomains.ResumeLayout(false);
            this.panelDomainOperations.ResumeLayout(false);
            this.gbDomainValues.ResumeLayout(false);
            this.gbEditDomain.ResumeLayout(false);
            this.gbUsedInRules.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsCbFile;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsCbConsultation;
        private System.Windows.Forms.ToolStripMenuItem tsMenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSave;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.ToolStripMenuItem tsMenuStartConsultation;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExplanation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.TabPage tabPageVariables;
        private System.Windows.Forms.TabPage tabPageDomains;
        private System.Windows.Forms.ListView lstViewRules;
        private System.Windows.Forms.ColumnHeader columnRuleName;
        private System.Windows.Forms.ColumnHeader columnRuleDescription;
        private System.Windows.Forms.GroupBox gbEditRule;
        private System.Windows.Forms.Button btnDelRule;
        private System.Windows.Forms.Button btnChangeRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Panel panelRuleOperations;
        private System.Windows.Forms.GroupBox gbRuleInference;
        private System.Windows.Forms.GroupBox gbRulePremise;
        private System.Windows.Forms.Panel panelRules;
        private System.Windows.Forms.Panel panelDomainOperations;
        private System.Windows.Forms.GroupBox gbDomainValues;
        private System.Windows.Forms.GroupBox gbEditDomain;
        private System.Windows.Forms.Button btnDelDomain;
        private System.Windows.Forms.Button btnChangeDomain;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Panel panelDomains;
        private System.Windows.Forms.ListView lstViewDomains;
        private System.Windows.Forms.ColumnHeader columnDomainName;
        private System.Windows.Forms.Panel panelVariables;
        private System.Windows.Forms.ListView lstViewVariables;
        private System.Windows.Forms.ColumnHeader columnVariableName;
        private System.Windows.Forms.ColumnHeader columnVariableType;
        private System.Windows.Forms.ColumnHeader columnVariableDomain;
        private System.Windows.Forms.Panel panelVariableOperations;
        private System.Windows.Forms.GroupBox gbQuestionText;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.GroupBox gbEditVariable;
        private System.Windows.Forms.Button btnDelVariable;
        private System.Windows.Forms.Button btnChangeVariable;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.GroupBox gbAvailableDomainValues;
        private System.Windows.Forms.ListBox lstBoxDomainValues;
        private System.Windows.Forms.ListBox lstBoxValuesOfDomain;
        private System.Windows.Forms.ListBox lstBoxInferenceFacts;
        private System.Windows.Forms.ListBox lstBoxPremiseFacts;
        private System.Windows.Forms.GroupBox gbUsedInRules;
        private System.Windows.Forms.ListBox lstBoxUsedInRules;
    }
}

