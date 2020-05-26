﻿namespace AutoResxTranslator
{
	partial class frmMain
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Language1");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Language2");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabResx = new System.Windows.Forms.TabPage();
			this.btnStartResxTranslate = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabXml = new System.Windows.Forms.TabPage();
			this.lstResxLanguages = new System.Windows.Forms.ListView();
			this.lblResxTranslateStatus = new System.Windows.Forms.Label();
			this.btnStartXmlTranlate = new System.Windows.Forms.Button();
			this.barResxProgress = new System.Windows.Forms.ProgressBar();
			this.label15 = new System.Windows.Forms.Label();
			this.btnSelectOutputDir = new System.Windows.Forms.Button();
			this.txtOutputDir = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnSelectXmlSource = new System.Windows.Forms.Button();
			this.cmbSourceResxLng = new System.Windows.Forms.ComboBox();
			this.txtSourceResx = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtSrc = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.cmbDesc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSrc = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkExcelCreateAbsent = new System.Windows.Forms.CheckBox();
			this.btnSelectExcel = new System.Windows.Forms.Button();
			this.btnOpenExcel = new System.Windows.Forms.Button();
			this.txtExcelFile = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnImportExcel = new System.Windows.Forms.Button();
			this.cmbExcelTranslation = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbExcelSheets = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbExcelKey = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnExcelResx = new System.Windows.Forms.Button();
			this.txtExcelResx = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabBrowser = new System.Windows.Forms.TabPage();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.googleApiKey = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtMsTranslationRegion = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMsTranslationKey = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.rbtnGoogleTranslateService = new System.Windows.Forms.RadioButton();
			this.rbtnMsTranslateService = new System.Windows.Forms.RadioButton();
			this.btnSelectResxSource = new System.Windows.Forms.Button();
			this.lnkAbout = new System.Windows.Forms.LinkLabel();
			this.lstXmlLanguages = new System.Windows.Forms.ListView();
			this.barXmlProgress = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.cmbSourceXmlLng = new System.Windows.Forms.ComboBox();
			this.txtSourceXml = new System.Windows.Forms.TextBox();
			this.tabMain.SuspendLayout();
			this.tabResx.SuspendLayout();
			this.tabXml.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabBrowser.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tabResx);
			this.tabMain.Controls.Add(this.tabXml);
			this.tabMain.Controls.Add(this.tabPage2);
			this.tabMain.Controls.Add(this.tabPage1);
			this.tabMain.Controls.Add(this.tabBrowser);
			this.tabMain.Controls.Add(this.tabPage3);
			this.tabMain.Location = new System.Drawing.Point(12, 12);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(650, 372);
			this.tabMain.TabIndex = 0;
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
			// 
			// tabResx
			// 
			this.tabResx.Controls.Add(this.btnStartResxTranslate);
			this.tabResx.Controls.Add(this.label6);
			this.tabResx.Controls.Add(this.label5);
			this.tabResx.Controls.Add(this.label4);
			this.tabResx.Location = new System.Drawing.Point(4, 22);
			this.tabResx.Name = "tabResx";
			this.tabResx.Padding = new System.Windows.Forms.Padding(3);
			this.tabResx.Size = new System.Drawing.Size(642, 346);
			this.tabResx.TabIndex = 2;
			this.tabResx.Text = "ResX Translator";
			this.tabResx.UseVisualStyleBackColor = true;
			// 
			// btnStartResxTranslate
			// 
			this.btnStartResxTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartResxTranslate.Location = new System.Drawing.Point(544, 259);
			this.btnStartResxTranslate.Name = "btnStartResxTranslate";
			this.btnStartResxTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnStartResxTranslate.TabIndex = 10;
			this.btnStartResxTranslate.Text = "Translate";
			this.btnStartResxTranslate.UseVisualStyleBackColor = true;
			this.btnStartResxTranslate.Click += new System.EventHandler(this.btnStartResxTranslate_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Output Languages:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Output Directory:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Source Resx File:";
			// 
			// tabXml
			// 
			this.tabXml.Controls.Add(this.lstResxLanguages);
			this.tabXml.Controls.Add(this.lblResxTranslateStatus);
			this.tabXml.Controls.Add(this.btnStartXmlTranlate);
			this.tabXml.Controls.Add(this.barResxProgress);
			this.tabXml.Controls.Add(this.label15);
			this.tabXml.Controls.Add(this.btnSelectOutputDir);
			this.tabXml.Controls.Add(this.txtOutputDir);
			this.tabXml.Controls.Add(this.label16);
			this.tabXml.Controls.Add(this.btnSelectXmlSource);
			this.tabXml.Controls.Add(this.cmbSourceResxLng);
			this.tabXml.Controls.Add(this.txtSourceResx);
			this.tabXml.Controls.Add(this.label17);
			this.tabXml.Location = new System.Drawing.Point(4, 22);
			this.tabXml.Name = "tabXml";
			this.tabXml.Padding = new System.Windows.Forms.Padding(3);
			this.tabXml.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabXml.Size = new System.Drawing.Size(642, 346);
			this.tabXml.TabIndex = 6;
			this.tabXml.Text = "xml Translator";
			this.tabXml.UseVisualStyleBackColor = true;
			// 
			// lstResxLanguages
			// 
			this.lstResxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstResxLanguages.CheckBoxes = true;
			this.lstResxLanguages.HideSelection = false;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			this.lstResxLanguages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lstResxLanguages.Location = new System.Drawing.Point(113, 71);
			this.lstResxLanguages.Name = "lstResxLanguages";
			this.lstResxLanguages.Size = new System.Drawing.Size(424, 182);
			this.lstResxLanguages.TabIndex = 12;
			this.lstResxLanguages.UseCompatibleStateImageBehavior = false;
			this.lstResxLanguages.View = System.Windows.Forms.View.List;
			// 
			// lblResxTranslateStatus
			// 
			this.lblResxTranslateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResxTranslateStatus.AutoEllipsis = true;
			this.lblResxTranslateStatus.ForeColor = System.Drawing.Color.Black;
			this.lblResxTranslateStatus.Location = new System.Drawing.Point(113, 289);
			this.lblResxTranslateStatus.Name = "lblResxTranslateStatus";
			this.lblResxTranslateStatus.Size = new System.Drawing.Size(505, 54);
			this.lblResxTranslateStatus.TabIndex = 11;
			// 
			// btnStartXmlTranlate
			// 
			this.btnStartXmlTranlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartXmlTranlate.Location = new System.Drawing.Point(552, 253);
			this.btnStartXmlTranlate.Name = "btnStartXmlTranlate";
			this.btnStartXmlTranlate.Size = new System.Drawing.Size(75, 23);
			this.btnStartXmlTranlate.TabIndex = 22;
			this.btnStartXmlTranlate.Text = "Translate";
			this.btnStartXmlTranlate.UseVisualStyleBackColor = true;
			this.btnStartXmlTranlate.Click += new System.EventHandler(this.btnStartXmlTranlate_Click);
			// 
			// barResxProgress
			// 
			this.barResxProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.barResxProgress.Location = new System.Drawing.Point(113, 259);
			this.barResxProgress.Name = "barResxProgress";
			this.barResxProgress.Size = new System.Drawing.Size(424, 23);
			this.barResxProgress.TabIndex = 9;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(15, 67);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 13);
			this.label15.TabIndex = 20;
			this.label15.Text = "Output Languages:";
			// 
			// btnSelectOutputDir
			// 
			this.btnSelectOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectOutputDir.Location = new System.Drawing.Point(543, 42);
			this.btnSelectOutputDir.Name = "btnSelectOutputDir";
			this.btnSelectOutputDir.Size = new System.Drawing.Size(75, 23);
			this.btnSelectOutputDir.TabIndex = 6;
			this.btnSelectOutputDir.Text = "Select";
			this.btnSelectOutputDir.UseVisualStyleBackColor = true;
			this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
			// 
			// txtOutputDir
			// 
			this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputDir.Location = new System.Drawing.Point(113, 44);
			this.txtOutputDir.Name = "txtOutputDir";
			this.txtOutputDir.Size = new System.Drawing.Size(424, 21);
			this.txtOutputDir.TabIndex = 5;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(23, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(92, 13);
			this.label16.TabIndex = 17;
			this.label16.Text = "Output Directory:";
			// 
			// btnSelectXmlSource
			// 
			this.btnSelectXmlSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectXmlSource.Location = new System.Drawing.Point(543, 15);
			this.btnSelectXmlSource.Name = "btnSelectXmlSource";
			this.btnSelectXmlSource.Size = new System.Drawing.Size(75, 23);
			this.btnSelectXmlSource.TabIndex = 3;
			this.btnSelectXmlSource.Text = "Select";
			this.btnSelectXmlSource.UseVisualStyleBackColor = true;
			this.btnSelectXmlSource.Click += new System.EventHandler(this.btnSelectXmlSource_Click);
			// 
			// cmbSourceResxLng
			// 
			this.cmbSourceResxLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbSourceResxLng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbSourceResxLng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSourceResxLng.FormattingEnabled = true;
			this.cmbSourceResxLng.Location = new System.Drawing.Point(416, 17);
			this.cmbSourceResxLng.Name = "cmbSourceResxLng";
			this.cmbSourceResxLng.Size = new System.Drawing.Size(121, 21);
			this.cmbSourceResxLng.TabIndex = 2;
			// 
			// txtSourceResx
			// 
			this.txtSourceResx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSourceResx.Location = new System.Drawing.Point(113, 17);
			this.txtSourceResx.Name = "txtSourceResx";
			this.txtSourceResx.ReadOnly = true;
			this.txtSourceResx.Size = new System.Drawing.Size(297, 21);
			this.txtSourceResx.TabIndex = 1;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(25, 14);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(82, 13);
			this.label17.TabIndex = 13;
			this.label17.Text = "Source xml File:";
			this.label17.Click += new System.EventHandler(this.label17_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(642, 346);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Text Translator";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtSrc);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtDesc);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(636, 340);
			this.splitContainer1.SplitterDistance = 156;
			this.splitContainer1.TabIndex = 0;
			// 
			// txtSrc
			// 
			this.txtSrc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSrc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtSrc.Location = new System.Drawing.Point(0, 31);
			this.txtSrc.Multiline = true;
			this.txtSrc.Name = "txtSrc";
			this.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSrc.Size = new System.Drawing.Size(636, 125);
			this.txtSrc.TabIndex = 1;
			this.txtSrc.Text = "Bienvenue.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnTranslate);
			this.panel1.Controls.Add(this.cmbDesc);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmbSrc);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(636, 31);
			this.panel1.TabIndex = 0;
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(444, 5);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnTranslate.TabIndex = 4;
			this.btnTranslate.Text = "Translate";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_ClickAsync);
			// 
			// cmbDesc
			// 
			this.cmbDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDesc.FormattingEnabled = true;
			this.cmbDesc.Location = new System.Drawing.Point(317, 5);
			this.cmbDesc.Name = "cmbDesc";
			this.cmbDesc.Size = new System.Drawing.Size(121, 21);
			this.cmbDesc.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(246, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Translate to:";
			// 
			// cmbSrc
			// 
			this.cmbSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSrc.FormattingEnabled = true;
			this.cmbSrc.Location = new System.Drawing.Point(103, 5);
			this.cmbSrc.Name = "cmbSrc";
			this.cmbSrc.Size = new System.Drawing.Size(121, 21);
			this.cmbSrc.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source Language:";
			// 
			// txtDesc
			// 
			this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDesc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtDesc.Location = new System.Drawing.Point(0, 21);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDesc.Size = new System.Drawing.Size(636, 159);
			this.txtDesc.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(636, 21);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Translation result:";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.btnExcelResx);
			this.tabPage1.Controls.Add(this.txtExcelResx);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(642, 346);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Excel Import";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkExcelCreateAbsent);
			this.groupBox1.Controls.Add(this.btnSelectExcel);
			this.groupBox1.Controls.Add(this.btnOpenExcel);
			this.groupBox1.Controls.Add(this.txtExcelFile);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnImportExcel);
			this.groupBox1.Controls.Add(this.cmbExcelTranslation);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cmbExcelSheets);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbExcelKey);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Location = new System.Drawing.Point(6, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(630, 153);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Import";
			// 
			// chkExcelCreateAbsent
			// 
			this.chkExcelCreateAbsent.AutoSize = true;
			this.chkExcelCreateAbsent.Checked = true;
			this.chkExcelCreateAbsent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkExcelCreateAbsent.Location = new System.Drawing.Point(107, 128);
			this.chkExcelCreateAbsent.Name = "chkExcelCreateAbsent";
			this.chkExcelCreateAbsent.Size = new System.Drawing.Size(167, 17);
			this.chkExcelCreateAbsent.TabIndex = 9;
			this.chkExcelCreateAbsent.Text = "Create absent language keys";
			this.chkExcelCreateAbsent.UseVisualStyleBackColor = true;
			// 
			// btnSelectExcel
			// 
			this.btnSelectExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectExcel.Location = new System.Drawing.Point(537, 18);
			this.btnSelectExcel.Name = "btnSelectExcel";
			this.btnSelectExcel.Size = new System.Drawing.Size(75, 23);
			this.btnSelectExcel.TabIndex = 3;
			this.btnSelectExcel.Text = "Select";
			this.btnSelectExcel.UseVisualStyleBackColor = true;
			this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
			// 
			// btnOpenExcel
			// 
			this.btnOpenExcel.Location = new System.Drawing.Point(263, 46);
			this.btnOpenExcel.Name = "btnOpenExcel";
			this.btnOpenExcel.Size = new System.Drawing.Size(75, 23);
			this.btnOpenExcel.TabIndex = 1;
			this.btnOpenExcel.Text = "Open Excel";
			this.btnOpenExcel.UseVisualStyleBackColor = true;
			this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
			// 
			// txtExcelFile
			// 
			this.txtExcelFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExcelFile.Location = new System.Drawing.Point(107, 20);
			this.txtExcelFile.Name = "txtExcelFile";
			this.txtExcelFile.Size = new System.Drawing.Size(424, 21);
			this.txtExcelFile.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(46, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Excel File:";
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Enabled = false;
			this.btnImportExcel.Location = new System.Drawing.Point(263, 100);
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.Size = new System.Drawing.Size(75, 23);
			this.btnImportExcel.TabIndex = 4;
			this.btnImportExcel.Text = "Import";
			this.btnImportExcel.UseVisualStyleBackColor = true;
			this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
			// 
			// cmbExcelTranslation
			// 
			this.cmbExcelTranslation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExcelTranslation.FormattingEnabled = true;
			this.cmbExcelTranslation.Location = new System.Drawing.Point(107, 101);
			this.cmbExcelTranslation.Name = "cmbExcelTranslation";
			this.cmbExcelTranslation.Size = new System.Drawing.Size(150, 21);
			this.cmbExcelTranslation.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(-1, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Translation Column:";
			// 
			// cmbExcelSheets
			// 
			this.cmbExcelSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExcelSheets.FormattingEnabled = true;
			this.cmbExcelSheets.Location = new System.Drawing.Point(107, 47);
			this.cmbExcelSheets.Name = "cmbExcelSheets";
			this.cmbExcelSheets.Size = new System.Drawing.Size(150, 21);
			this.cmbExcelSheets.TabIndex = 0;
			this.cmbExcelSheets.SelectedIndexChanged += new System.EventHandler(this.cmbExcelSheets_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(34, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 13);
			this.label11.TabIndex = 8;
			this.label11.Text = "Sheet Name:";
			// 
			// cmbExcelKey
			// 
			this.cmbExcelKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExcelKey.FormattingEnabled = true;
			this.cmbExcelKey.Location = new System.Drawing.Point(107, 74);
			this.cmbExcelKey.Name = "cmbExcelKey";
			this.cmbExcelKey.Size = new System.Drawing.Size(150, 21);
			this.cmbExcelKey.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(34, 77);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Key Column:";
			// 
			// btnExcelResx
			// 
			this.btnExcelResx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcelResx.Location = new System.Drawing.Point(543, 15);
			this.btnExcelResx.Name = "btnExcelResx";
			this.btnExcelResx.Size = new System.Drawing.Size(75, 23);
			this.btnExcelResx.TabIndex = 1;
			this.btnExcelResx.Text = "Select";
			this.btnExcelResx.UseVisualStyleBackColor = true;
			this.btnExcelResx.Click += new System.EventHandler(this.btnExcelResx_Click);
			// 
			// txtExcelResx
			// 
			this.txtExcelResx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExcelResx.Location = new System.Drawing.Point(113, 17);
			this.txtExcelResx.Name = "txtExcelResx";
			this.txtExcelResx.ReadOnly = true;
			this.txtExcelResx.Size = new System.Drawing.Size(424, 21);
			this.txtExcelResx.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(53, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Resx File:";
			// 
			// tabBrowser
			// 
			this.tabBrowser.Controls.Add(this.webBrowser);
			this.tabBrowser.Location = new System.Drawing.Point(4, 22);
			this.tabBrowser.Name = "tabBrowser";
			this.tabBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tabBrowser.Size = new System.Drawing.Size(642, 346);
			this.tabBrowser.TabIndex = 4;
			this.tabBrowser.Text = "Google Translator";
			this.tabBrowser.UseVisualStyleBackColor = true;
			// 
			// webBrowser
			// 
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.Size = new System.Drawing.Size(636, 340);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Url = new System.Uri("https://translate.google.com/", System.UriKind.Absolute);
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(642, 346);
			this.tabPage3.TabIndex = 5;
			this.tabPage3.Text = "Translate Service";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.googleApiKey);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.txtMsTranslationRegion);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtMsTranslationKey);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.rbtnGoogleTranslateService);
			this.groupBox2.Controls.Add(this.rbtnMsTranslateService);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(630, 112);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Translate Service Selection";
			// 
			// googleApiKey
			// 
			this.googleApiKey.Location = new System.Drawing.Point(274, 16);
			this.googleApiKey.Name = "googleApiKey";
			this.googleApiKey.Size = new System.Drawing.Size(200, 21);
			this.googleApiKey.TabIndex = 7;
			this.googleApiKey.TextChanged += new System.EventHandler(this.googleApiKey_TextChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(190, 22);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(78, 13);
			this.label20.TabIndex = 6;
			this.label20.Text = "Google apikey:";
			// 
			// txtMsTranslationRegion
			// 
			this.txtMsTranslationRegion.Enabled = false;
			this.txtMsTranslationRegion.Location = new System.Drawing.Point(369, 71);
			this.txtMsTranslationRegion.Name = "txtMsTranslationRegion";
			this.txtMsTranslationRegion.Size = new System.Drawing.Size(100, 21);
			this.txtMsTranslationRegion.TabIndex = 5;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(319, 74);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(44, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Region:";
			// 
			// txtMsTranslationKey
			// 
			this.txtMsTranslationKey.Enabled = false;
			this.txtMsTranslationKey.Location = new System.Drawing.Point(103, 71);
			this.txtMsTranslationKey.Name = "txtMsTranslationKey";
			this.txtMsTranslationKey.Size = new System.Drawing.Size(200, 21);
			this.txtMsTranslationKey.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 74);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 13);
			this.label12.TabIndex = 2;
			this.label12.Text = "Subscription Key:";
			// 
			// rbtnGoogleTranslateService
			// 
			this.rbtnGoogleTranslateService.AutoSize = true;
			this.rbtnGoogleTranslateService.Checked = true;
			this.rbtnGoogleTranslateService.Location = new System.Drawing.Point(6, 20);
			this.rbtnGoogleTranslateService.Name = "rbtnGoogleTranslateService";
			this.rbtnGoogleTranslateService.Size = new System.Drawing.Size(152, 17);
			this.rbtnGoogleTranslateService.TabIndex = 1;
			this.rbtnGoogleTranslateService.TabStop = true;
			this.rbtnGoogleTranslateService.Text = "Google Translation Service";
			this.rbtnGoogleTranslateService.UseVisualStyleBackColor = true;
			// 
			// rbtnMsTranslateService
			// 
			this.rbtnMsTranslateService.AutoSize = true;
			this.rbtnMsTranslateService.Location = new System.Drawing.Point(6, 43);
			this.rbtnMsTranslateService.Name = "rbtnMsTranslateService";
			this.rbtnMsTranslateService.Size = new System.Drawing.Size(216, 17);
			this.rbtnMsTranslateService.TabIndex = 0;
			this.rbtnMsTranslateService.Text = "Microsoft Cognitive Translations Service";
			this.rbtnMsTranslateService.UseVisualStyleBackColor = true;
			this.rbtnMsTranslateService.CheckedChanged += new System.EventHandler(this.RbtnMsTranslateService_CheckedChanged);
			// 
			// btnSelectResxSource
			// 
			this.btnSelectResxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectResxSource.Location = new System.Drawing.Point(543, 15);
			this.btnSelectResxSource.Name = "btnSelectResxSource";
			this.btnSelectResxSource.Size = new System.Drawing.Size(75, 23);
			this.btnSelectResxSource.TabIndex = 3;
			this.btnSelectResxSource.Text = "Select";
			this.btnSelectResxSource.UseVisualStyleBackColor = true;
			this.btnSelectResxSource.Click += new System.EventHandler(this.btnSelectResxSource_Click);
			// 
			// lnkAbout
			// 
			this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkAbout.AutoSize = true;
			this.lnkAbout.Location = new System.Drawing.Point(621, 13);
			this.lnkAbout.Name = "lnkAbout";
			this.lnkAbout.Size = new System.Drawing.Size(36, 13);
			this.lnkAbout.TabIndex = 3;
			this.lnkAbout.TabStop = true;
			this.lnkAbout.Text = "About";
			this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
			// 
			// lstXmlLanguages
			// 
			this.lstXmlLanguages.HideSelection = false;
			this.lstXmlLanguages.Location = new System.Drawing.Point(0, 0);
			this.lstXmlLanguages.Name = "lstXmlLanguages";
			this.lstXmlLanguages.Size = new System.Drawing.Size(121, 97);
			this.lstXmlLanguages.TabIndex = 0;
			this.lstXmlLanguages.UseCompatibleStateImageBehavior = false;
			// 
			// barXmlProgress
			// 
			this.barXmlProgress.Location = new System.Drawing.Point(0, 0);
			this.barXmlProgress.Name = "barXmlProgress";
			this.barXmlProgress.Size = new System.Drawing.Size(100, 23);
			this.barXmlProgress.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(121, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(424, 20);
			this.textBox1.TabIndex = 18;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(0, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			// 
			// cmbSourceXmlLng
			// 
			this.cmbSourceXmlLng.Location = new System.Drawing.Point(0, 0);
			this.cmbSourceXmlLng.Name = "cmbSourceXmlLng";
			this.cmbSourceXmlLng.Size = new System.Drawing.Size(121, 21);
			this.cmbSourceXmlLng.TabIndex = 0;
			// 
			// txtSourceXml
			// 
			this.txtSourceXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSourceXml.Location = new System.Drawing.Point(121, 11);
			this.txtSourceXml.Name = "txtSourceXml";
			this.txtSourceXml.ReadOnly = true;
			this.txtSourceXml.Size = new System.Drawing.Size(297, 20);
			this.txtSourceXml.TabIndex = 14;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 396);
			this.Controls.Add(this.lnkAbout);
			this.Controls.Add(this.tabMain);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auto Resource Translator";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabMain.ResumeLayout(false);
			this.tabResx.ResumeLayout(false);
			this.tabResx.PerformLayout();
			this.tabXml.ResumeLayout(false);
			this.tabXml.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabBrowser.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtSrc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.ComboBox cmbDesc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSrc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabResx;
		private System.Windows.Forms.Button btnSelectResxSource;
		private System.Windows.Forms.Button btnSelectXmlSource;
		private System.Windows.Forms.ComboBox cmbSourceResxLng;
		private System.Windows.Forms.TextBox txtSourceResx;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSelectOutputDir;
		private System.Windows.Forms.TextBox txtOutputDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblResxTranslateStatus;
		private System.Windows.Forms.Button btnStartResxTranslate;
		private System.Windows.Forms.ProgressBar barResxProgress;
		private System.Windows.Forms.ListView lstResxLanguages;
		private System.Windows.Forms.LinkLabel lnkAbout;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnExcelResx;
		private System.Windows.Forms.TextBox txtExcelResx;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSelectExcel;
		private System.Windows.Forms.TextBox txtExcelFile;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnImportExcel;
		private System.Windows.Forms.ComboBox cmbExcelTranslation;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbExcelKey;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnOpenExcel;
		private System.Windows.Forms.ComboBox cmbExcelSheets;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox chkExcelCreateAbsent;
		private System.Windows.Forms.TabPage tabBrowser;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbtnGoogleTranslateService;
		private System.Windows.Forms.RadioButton rbtnMsTranslateService;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtMsTranslationRegion;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMsTranslationKey;
		private System.Windows.Forms.CheckBox subDirectoriesIncluded;
		private System.Windows.Forms.TextBox googleApiKey;
		private System.Windows.Forms.TabPage tabXml;
		private System.Windows.Forms.ListView lstXmlLanguages;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button btnStartXmlTranlate;
		private System.Windows.Forms.ProgressBar barXmlProgress;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cmbSourceXmlLng;
		private System.Windows.Forms.TextBox txtSourceXml;
		private System.Windows.Forms.Label label17;
	}
}

