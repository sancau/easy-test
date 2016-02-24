namespace EasyTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonImportFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.checkCh1 = new System.Windows.Forms.CheckBox();
            this.checkCh2 = new System.Windows.Forms.CheckBox();
            this.checkCh3 = new System.Windows.Forms.CheckBox();
            this.checkCh4 = new System.Windows.Forms.CheckBox();
            this.checkCh5 = new System.Windows.Forms.CheckBox();
            this.checkCh6 = new System.Windows.Forms.CheckBox();
            this.checkCh7 = new System.Windows.Forms.CheckBox();
            this.checkCh8 = new System.Windows.Forms.CheckBox();
            this.numericChecksCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTargetValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxChamber = new System.Windows.Forms.ListBox();
            this.listBoxGOST = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericKT = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericIU = new System.Windows.Forms.NumericUpDown();
            this.listBoxSpecialist = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxHeadName = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonCreateDoc = new System.Windows.Forms.Button();
            this.textBoxReportPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBrowseDir = new System.Windows.Forms.Button();
            this.numericStartRow = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonManualAuto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonClearGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericChecksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIU)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartRow)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(116, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(458, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonImportFile
            // 
            this.buttonImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportFile.Location = new System.Drawing.Point(721, 10);
            this.buttonImportFile.Name = "buttonImportFile";
            this.buttonImportFile.Size = new System.Drawing.Size(135, 23);
            this.buttonImportFile.TabIndex = 1;
            this.buttonImportFile.Text = "Импортировать";
            this.buttonImportFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Источник данных:";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 50);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(466, 20);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Параметры и ход обработки (автоматический режим)";
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseFile.Location = new System.Drawing.Point(580, 10);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(135, 23);
            this.buttonBrowseFile.TabIndex = 4;
            this.buttonBrowseFile.Text = "Выбор файла";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreview.Location = new System.Drawing.Point(16, 82);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ReadOnly = true;
            this.textBoxPreview.Size = new System.Drawing.Size(840, 78);
            this.textBoxPreview.TabIndex = 5;
            this.textBoxPreview.Text = "Импортируйте файл для начала обработки или воспользуйтесь ручным вводом...";
            // 
            // checkCh1
            // 
            this.checkCh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh1.AutoSize = true;
            this.checkCh1.Location = new System.Drawing.Point(120, 418);
            this.checkCh1.Name = "checkCh1";
            this.checkCh1.Size = new System.Drawing.Size(66, 17);
            this.checkCh1.TabIndex = 6;
            this.checkCh1.Text = "Канал 1";
            this.checkCh1.UseVisualStyleBackColor = true;
            // 
            // checkCh2
            // 
            this.checkCh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh2.AutoSize = true;
            this.checkCh2.Location = new System.Drawing.Point(192, 417);
            this.checkCh2.Name = "checkCh2";
            this.checkCh2.Size = new System.Drawing.Size(66, 17);
            this.checkCh2.TabIndex = 7;
            this.checkCh2.Text = "Канал 2";
            this.checkCh2.UseVisualStyleBackColor = true;
            // 
            // checkCh3
            // 
            this.checkCh3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh3.AutoSize = true;
            this.checkCh3.Location = new System.Drawing.Point(264, 417);
            this.checkCh3.Name = "checkCh3";
            this.checkCh3.Size = new System.Drawing.Size(66, 17);
            this.checkCh3.TabIndex = 8;
            this.checkCh3.Text = "Канал 3";
            this.checkCh3.UseVisualStyleBackColor = true;
            // 
            // checkCh4
            // 
            this.checkCh4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh4.AutoSize = true;
            this.checkCh4.Location = new System.Drawing.Point(336, 417);
            this.checkCh4.Name = "checkCh4";
            this.checkCh4.Size = new System.Drawing.Size(66, 17);
            this.checkCh4.TabIndex = 9;
            this.checkCh4.Text = "Канал 4";
            this.checkCh4.UseVisualStyleBackColor = true;
            // 
            // checkCh5
            // 
            this.checkCh5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh5.AutoSize = true;
            this.checkCh5.Location = new System.Drawing.Point(408, 417);
            this.checkCh5.Name = "checkCh5";
            this.checkCh5.Size = new System.Drawing.Size(66, 17);
            this.checkCh5.TabIndex = 10;
            this.checkCh5.Text = "Канал 5";
            this.checkCh5.UseVisualStyleBackColor = true;
            // 
            // checkCh6
            // 
            this.checkCh6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh6.AutoSize = true;
            this.checkCh6.Location = new System.Drawing.Point(480, 417);
            this.checkCh6.Name = "checkCh6";
            this.checkCh6.Size = new System.Drawing.Size(66, 17);
            this.checkCh6.TabIndex = 11;
            this.checkCh6.Text = "Канал 6";
            this.checkCh6.UseVisualStyleBackColor = true;
            // 
            // checkCh7
            // 
            this.checkCh7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh7.AutoSize = true;
            this.checkCh7.Location = new System.Drawing.Point(552, 417);
            this.checkCh7.Name = "checkCh7";
            this.checkCh7.Size = new System.Drawing.Size(66, 17);
            this.checkCh7.TabIndex = 12;
            this.checkCh7.Text = "Канал 7";
            this.checkCh7.UseVisualStyleBackColor = true;
            // 
            // checkCh8
            // 
            this.checkCh8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCh8.AutoSize = true;
            this.checkCh8.Location = new System.Drawing.Point(624, 417);
            this.checkCh8.Name = "checkCh8";
            this.checkCh8.Size = new System.Drawing.Size(66, 17);
            this.checkCh8.TabIndex = 13;
            this.checkCh8.Text = "Канал 8";
            this.checkCh8.UseVisualStyleBackColor = true;
            // 
            // numericChecksCount
            // 
            this.numericChecksCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericChecksCount.Location = new System.Drawing.Point(696, 527);
            this.numericChecksCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericChecksCount.Name = "numericChecksCount";
            this.numericChecksCount.Size = new System.Drawing.Size(160, 20);
            this.numericChecksCount.TabIndex = 15;
            this.numericChecksCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество измерений:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Режим (градусов C):";
            // 
            // numericTargetValue
            // 
            this.numericTargetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericTargetValue.DecimalPlaces = 1;
            this.numericTargetValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericTargetValue.Location = new System.Drawing.Point(173, 567);
            this.numericTargetValue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericTargetValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericTargetValue.Name = "numericTargetValue";
            this.numericTargetValue.Size = new System.Drawing.Size(147, 20);
            this.numericTargetValue.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Камера:";
            // 
            // listBoxChamber
            // 
            this.listBoxChamber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxChamber.FormattingEnabled = true;
            this.listBoxChamber.Items.AddRange(new object[] {
            "Votsch 7250",
            "Votsch 7010-1",
            "Votsch 7010-2",
            "Votsch 7018 (new)",
            "Votsch 7018 (old)",
            "Votsch 7060",
            "Atlas",
            "КТК",
            "ТБВ",
            "TVAC-1400",
            "NZ-250"});
            this.listBoxChamber.Location = new System.Drawing.Point(16, 467);
            this.listBoxChamber.Name = "listBoxChamber";
            this.listBoxChamber.Size = new System.Drawing.Size(140, 121);
            this.listBoxChamber.TabIndex = 20;
            // 
            // listBoxGOST
            // 
            this.listBoxGOST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxGOST.FormattingEnabled = true;
            this.listBoxGOST.Items.AddRange(new object[] {
            "ГОСТ 25051.2-82"});
            this.listBoxGOST.Location = new System.Drawing.Point(173, 467);
            this.listBoxGOST.Name = "listBoxGOST";
            this.listBoxGOST.Size = new System.Drawing.Size(147, 69);
            this.listBoxGOST.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Стандарт:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Средняя темп. КТ (градусов C):";
            // 
            // numericKT
            // 
            this.numericKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericKT.DecimalPlaces = 1;
            this.numericKT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericKT.Location = new System.Drawing.Point(336, 567);
            this.numericKT.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericKT.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericKT.Name = "numericKT";
            this.numericKT.Size = new System.Drawing.Size(163, 20);
            this.numericKT.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Средняя темп. ИУ (градусов C):";
            // 
            // numericIU
            // 
            this.numericIU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericIU.DecimalPlaces = 1;
            this.numericIU.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericIU.Location = new System.Drawing.Point(517, 567);
            this.numericIU.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericIU.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericIU.Name = "numericIU";
            this.numericIU.Size = new System.Drawing.Size(165, 20);
            this.numericIU.TabIndex = 25;
            // 
            // listBoxSpecialist
            // 
            this.listBoxSpecialist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSpecialist.FormattingEnabled = true;
            this.listBoxSpecialist.Items.AddRange(new object[] {
            "Беляев Н.Н.",
            "Кандлин Л.А.",
            "Комаров С.В.",
            "Пашков Е.В.",
            "Татчин А.В."});
            this.listBoxSpecialist.Location = new System.Drawing.Point(336, 467);
            this.listBoxSpecialist.Name = "listBoxSpecialist";
            this.listBoxSpecialist.Size = new System.Drawing.Size(163, 69);
            this.listBoxSpecialist.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Специалист:";
            // 
            // listBoxHeadName
            // 
            this.listBoxHeadName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxHeadName.FormattingEnabled = true;
            this.listBoxHeadName.Items.AddRange(new object[] {
            "Ксенофонтов Б.А."});
            this.listBoxHeadName.Location = new System.Drawing.Point(518, 467);
            this.listBoxHeadName.Name = "listBoxHeadName";
            this.listBoxHeadName.Size = new System.Drawing.Size(164, 69);
            this.listBoxHeadName.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Руководитель:";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateReport.Location = new System.Drawing.Point(580, 615);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(135, 23);
            this.buttonCreateReport.TabIndex = 31;
            this.buttonCreateReport.Text = "Обработать данные";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDoc
            // 
            this.buttonCreateDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateDoc.Location = new System.Drawing.Point(721, 615);
            this.buttonCreateDoc.Name = "buttonCreateDoc";
            this.buttonCreateDoc.Size = new System.Drawing.Size(135, 23);
            this.buttonCreateDoc.TabIndex = 32;
            this.buttonCreateDoc.Text = "Создать протокол";
            this.buttonCreateDoc.UseVisualStyleBackColor = true;
            // 
            // textBoxReportPath
            // 
            this.textBoxReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportPath.Location = new System.Drawing.Point(103, 617);
            this.textBoxReportPath.Name = "textBoxReportPath";
            this.textBoxReportPath.ReadOnly = true;
            this.textBoxReportPath.Size = new System.Drawing.Size(327, 20);
            this.textBoxReportPath.TabIndex = 33;
            this.textBoxReportPath.Text = "D:\\Reports\\";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Папка отчетов:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Статус:";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(164, 17);
            this.toolStripStatus.Text = "Ожидание входных данных...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.timestamp,
            this.channel1,
            this.channel2,
            this.channel3,
            this.channel4,
            this.channel5,
            this.channel6,
            this.channel7,
            this.channel8,
            this.KT,
            this.IU});
            this.dataGridView1.Location = new System.Drawing.Point(16, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 240);
            this.dataGridView1.TabIndex = 36;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 35;
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "Время";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timestamp.Width = 65;
            // 
            // channel1
            // 
            this.channel1.HeaderText = "Канал 1";
            this.channel1.Name = "channel1";
            this.channel1.ReadOnly = true;
            this.channel1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel1.Width = 72;
            // 
            // channel2
            // 
            this.channel2.HeaderText = "Канал 2";
            this.channel2.Name = "channel2";
            this.channel2.ReadOnly = true;
            this.channel2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel2.Width = 72;
            // 
            // channel3
            // 
            this.channel3.HeaderText = "Канал 3";
            this.channel3.Name = "channel3";
            this.channel3.ReadOnly = true;
            this.channel3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel3.Width = 72;
            // 
            // channel4
            // 
            this.channel4.HeaderText = "Канал 4";
            this.channel4.Name = "channel4";
            this.channel4.ReadOnly = true;
            this.channel4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel4.Width = 72;
            // 
            // channel5
            // 
            this.channel5.HeaderText = "Канал 5";
            this.channel5.Name = "channel5";
            this.channel5.ReadOnly = true;
            this.channel5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel5.Width = 72;
            // 
            // channel6
            // 
            this.channel6.HeaderText = "Канал 6";
            this.channel6.Name = "channel6";
            this.channel6.ReadOnly = true;
            this.channel6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel6.Width = 72;
            // 
            // channel7
            // 
            this.channel7.HeaderText = "Канал 7";
            this.channel7.Name = "channel7";
            this.channel7.ReadOnly = true;
            this.channel7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel7.Width = 72;
            // 
            // channel8
            // 
            this.channel8.HeaderText = "Канал 8";
            this.channel8.Name = "channel8";
            this.channel8.ReadOnly = true;
            this.channel8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.channel8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel8.Width = 72;
            // 
            // KT
            // 
            this.KT.HeaderText = "К.Т.";
            this.KT.Name = "KT";
            this.KT.ReadOnly = true;
            this.KT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KT.Width = 72;
            // 
            // IU
            // 
            this.IU.HeaderText = "И.У.";
            this.IU.Name = "IU";
            this.IU.ReadOnly = true;
            this.IU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IU.Width = 72;
            // 
            // buttonBrowseDir
            // 
            this.buttonBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDir.Location = new System.Drawing.Point(439, 615);
            this.buttonBrowseDir.Name = "buttonBrowseDir";
            this.buttonBrowseDir.Size = new System.Drawing.Size(135, 23);
            this.buttonBrowseDir.TabIndex = 37;
            this.buttonBrowseDir.Text = "Выбор папки отчетов";
            this.buttonBrowseDir.UseVisualStyleBackColor = true;
            // 
            // numericStartRow
            // 
            this.numericStartRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericStartRow.Location = new System.Drawing.Point(696, 567);
            this.numericStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStartRow.Name = "numericStartRow";
            this.numericStartRow.Size = new System.Drawing.Size(160, 20);
            this.numericStartRow.TabIndex = 38;
            this.numericStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(693, 550);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Начать обработку с:";
            // 
            // buttonManualAuto
            // 
            this.buttonManualAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonManualAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManualAuto.Location = new System.Drawing.Point(696, 417);
            this.buttonManualAuto.Name = "buttonManualAuto";
            this.buttonManualAuto.Size = new System.Drawing.Size(160, 91);
            this.buttonManualAuto.TabIndex = 40;
            this.buttonManualAuto.Text = "ПЕРЕЙТИ В РУЧНОЙ РЕЖИМ";
            this.buttonManualAuto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Задействовать:";
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.Enabled = false;
            this.buttonAddRow.Location = new System.Drawing.Point(580, 50);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(276, 23);
            this.buttonAddRow.TabIndex = 43;
            this.buttonAddRow.Text = "Добавить строку измерений (недоступно в АВТО)";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            // 
            // buttonClearGrid
            // 
            this.buttonClearGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGrid.Location = new System.Drawing.Point(485, 50);
            this.buttonClearGrid.Name = "buttonClearGrid";
            this.buttonClearGrid.Size = new System.Drawing.Size(89, 23);
            this.buttonClearGrid.TabIndex = 44;
            this.buttonClearGrid.Text = "Сброс данных";
            this.buttonClearGrid.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 680);
            this.Controls.Add(this.buttonClearGrid);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonManualAuto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericStartRow);
            this.Controls.Add(this.buttonBrowseDir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxReportPath);
            this.Controls.Add(this.buttonCreateDoc);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.listBoxHeadName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBoxSpecialist);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericIU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericKT);
            this.Controls.Add(this.listBoxGOST);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxChamber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericTargetValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericChecksCount);
            this.Controls.Add(this.checkCh8);
            this.Controls.Add(this.checkCh7);
            this.Controls.Add(this.checkCh6);
            this.Controls.Add(this.checkCh5);
            this.Controls.Add(this.checkCh4);
            this.Controls.Add(this.checkCh3);
            this.Controls.Add(this.checkCh2);
            this.Controls.Add(this.checkCh1);
            this.Controls.Add(this.textBoxPreview);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(884, 718);
            this.MinimumSize = new System.Drawing.Size(884, 718);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTest (73DB application)";
            ((System.ComponentModel.ISupportInitialize)(this.numericChecksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIU)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonImportFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.CheckBox checkCh1;
        private System.Windows.Forms.CheckBox checkCh2;
        private System.Windows.Forms.CheckBox checkCh3;
        private System.Windows.Forms.CheckBox checkCh4;
        private System.Windows.Forms.CheckBox checkCh5;
        private System.Windows.Forms.CheckBox checkCh6;
        private System.Windows.Forms.CheckBox checkCh7;
        private System.Windows.Forms.CheckBox checkCh8;
        private System.Windows.Forms.NumericUpDown numericChecksCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericTargetValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxChamber;
        private System.Windows.Forms.ListBox listBoxGOST;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericKT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericIU;
        private System.Windows.Forms.ListBox listBoxSpecialist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxHeadName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonCreateDoc;
        private System.Windows.Forms.TextBox textBoxReportPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBrowseDir;
        private System.Windows.Forms.NumericUpDown numericStartRow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonManualAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn KT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IU;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonClearGrid;
    }
}

