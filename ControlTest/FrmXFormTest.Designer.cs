﻿namespace ControlTest
{
    partial class FrmXFormTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXFormTest));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCommonButton = new PowerControl.XButton();
            this.ripplePictureBox1 = new PowerControl.RipplePictureBox();
            this.btnDropdownButton = new PowerControl.XButton();
            this.ddbi1 = new PowerControl.DropDownButtonItem();
            this.ddbi2 = new PowerControl.DropDownButtonItem();
            this.xTreeView1 = new PowerControl.XTreeView();
            this.loadingCircle1 = new PowerControl.LoadingCircle();
            this.btnLoadingLayer = new PowerControl.XButton();
            this.ipTextBox1 = new PowerControl.IPTextBox();
            this.chk1 = new PowerControl.XCheckBox();
            this.xComboBox1 = new PowerControl.XComboBox();
            this.xDataGridView1 = new PowerControl.XDataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp1 = new PowerControl.XGroupBox();
            this.xProgressBar1 = new PowerControl.XProgressBar();
            this.rdo1 = new PowerControl.XRadioButton();
            this.xTabControl1 = new PowerControl.XTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt1 = new PowerControl.XTextBox();
            this.xShadowPanel1 = new PowerControl.XShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ripplePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).BeginInit();
            this.grp1.SuspendLayout();
            this.xTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommonButton
            // 
            this.btnCommonButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCommonButton.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnCommonButton.CheckedForeColor = System.Drawing.Color.White;
            this.btnCommonButton.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnCommonButton.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCommonButton.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnCommonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCommonButton.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnCommonButton.HoldingForeColor = System.Drawing.Color.White;
            this.btnCommonButton.HoldingImage = null;
            this.btnCommonButton.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnCommonButton.Image = null;
            this.btnCommonButton.Location = new System.Drawing.Point(44, 37);
            this.btnCommonButton.Name = "btnCommonButton";
            this.btnCommonButton.Size = new System.Drawing.Size(91, 65);
            this.btnCommonButton.StartColor = System.Drawing.Color.White;
            this.btnCommonButton.TabIndex = 0;
            this.btnCommonButton.Text = "常规按钮";
            this.btnCommonButton.Click += new System.EventHandler(this.btnCommonButton_Click);
            // 
            // ripplePictureBox1
            // 
            this.ripplePictureBox1.DragSplashRadius = 10;
            this.ripplePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ripplePictureBox1.Image")));
            this.ripplePictureBox1.Location = new System.Drawing.Point(17, 434);
            this.ripplePictureBox1.MinimumSize = new System.Drawing.Size(256, 256);
            this.ripplePictureBox1.Name = "ripplePictureBox1";
            this.ripplePictureBox1.Size = new System.Drawing.Size(256, 256);
            this.ripplePictureBox1.TabIndex = 1;
            this.ripplePictureBox1.TabStop = false;
            // 
            // btnDropdownButton
            // 
            this.btnDropdownButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnDropdownButton.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnDropdownButton.CheckedForeColor = System.Drawing.Color.White;
            this.btnDropdownButton.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDropdownButton.DropDownItems.Add(this.ddbi1);
            this.btnDropdownButton.DropDownItems.Add(this.ddbi2);
            this.btnDropdownButton.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnDropdownButton.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnDropdownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDropdownButton.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnDropdownButton.HoldingForeColor = System.Drawing.Color.White;
            this.btnDropdownButton.HoldingImage = null;
            this.btnDropdownButton.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDropdownButton.Image = null;
            this.btnDropdownButton.Location = new System.Drawing.Point(182, 37);
            this.btnDropdownButton.Name = "btnDropdownButton";
            this.btnDropdownButton.Size = new System.Drawing.Size(91, 65);
            this.btnDropdownButton.StartColor = System.Drawing.Color.White;
            this.btnDropdownButton.TabIndex = 1;
            this.btnDropdownButton.Text = "下拉按钮";
            // 
            // ddbi1
            // 
            this.ddbi1.Caption = "下拉项1";
            this.ddbi1.Location = new System.Drawing.Point(0, 0);
            this.ddbi1.Name = "ddbi1";
            this.ddbi1.ParentBtn = this.btnDropdownButton;
            this.ddbi1.Size = new System.Drawing.Size(91, 65);
            this.ddbi1.TabIndex = 0;
            this.ddbi1.Click += new System.EventHandler(this.ddbi1_Click);
            // 
            // ddbi2
            // 
            this.ddbi2.Caption = "下拉项2";
            this.ddbi2.Location = new System.Drawing.Point(0, 65);
            this.ddbi2.Name = "ddbi2";
            this.ddbi2.ParentBtn = this.btnDropdownButton;
            this.ddbi2.Size = new System.Drawing.Size(91, 65);
            this.ddbi2.TabIndex = 0;
            this.ddbi2.Click += new System.EventHandler(this.ddbi2_Click);
            // 
            // xTreeView1
            // 
            this.xTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.xTreeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xTreeView1.Location = new System.Drawing.Point(40, 186);
            this.xTreeView1.Name = "xTreeView1";
            treeNode9.Name = "节点6";
            treeNode9.Text = "节点6";
            treeNode10.Name = "节点0";
            treeNode10.Text = "节点0";
            treeNode11.Name = "节点5";
            treeNode11.Text = "节点5";
            treeNode12.Name = "节点4";
            treeNode12.Text = "节点4";
            treeNode13.Name = "节点3";
            treeNode13.Text = "节点3";
            treeNode14.Name = "节点1";
            treeNode14.Text = "节点1";
            treeNode15.Name = "节点7";
            treeNode15.Text = "节点7";
            treeNode16.Name = "节点2";
            treeNode16.Text = "节点2";
            this.xTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode16});
            this.xTreeView1.SelectedBackColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.xTreeView1.SelectedBackColorUnFocused = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.xTreeView1.SelectedForeColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xTreeView1.SelectedForeColorUnFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xTreeView1.Size = new System.Drawing.Size(233, 188);
            this.xTreeView1.TabIndex = 2;
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.BackColor = System.Drawing.Color.Black;
            this.loadingCircle1.Color = System.Drawing.Color.White;
            this.loadingCircle1.Location = new System.Drawing.Point(335, 447);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.Size = new System.Drawing.Size(231, 231);
            this.loadingCircle1.TabIndex = 4;
            this.loadingCircle1.Text = "loadingCircle1";
            // 
            // btnLoadingLayer
            // 
            this.btnLoadingLayer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnLoadingLayer.CheckedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnLoadingLayer.CheckedForeColor = System.Drawing.Color.White;
            this.btnLoadingLayer.CheckedStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnLoadingLayer.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLoadingLayer.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnLoadingLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoadingLayer.HoldingEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.btnLoadingLayer.HoldingForeColor = System.Drawing.Color.White;
            this.btnLoadingLayer.HoldingImage = null;
            this.btnLoadingLayer.HoldingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnLoadingLayer.Image = null;
            this.btnLoadingLayer.Location = new System.Drawing.Point(335, 37);
            this.btnLoadingLayer.Name = "btnLoadingLayer";
            this.btnLoadingLayer.Size = new System.Drawing.Size(91, 65);
            this.btnLoadingLayer.StartColor = System.Drawing.Color.White;
            this.btnLoadingLayer.TabIndex = 9;
            this.btnLoadingLayer.Text = "遮罩层";
            this.btnLoadingLayer.Click += new System.EventHandler(this.btnLoadingLayer_Click);
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.BackColor = System.Drawing.Color.White;
            this.ipTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipTextBox1.Location = new System.Drawing.Point(323, 186);
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.ipTextBox1.Size = new System.Drawing.Size(127, 18);
            this.ipTextBox1.TabIndex = 11;
            this.ipTextBox1.Value = ((System.Net.IPAddress)(resources.GetObject("ipTextBox1.Value")));
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.BackColor = System.Drawing.Color.White;
            this.chk1.BoxBorderColor = System.Drawing.SystemColors.ControlText;
            this.chk1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.chk1.Location = new System.Drawing.Point(323, 235);
            this.chk1.MouseHoveringForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(66, 16);
            this.chk1.TabIndex = 13;
            this.chk1.Text = "复选框1";
            this.chk1.UseVisualStyleBackColor = false;
            // 
            // xComboBox1
            // 
            this.xComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xComboBox1.FormattingEnabled = true;
            this.xComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.xComboBox1.Location = new System.Drawing.Point(323, 272);
            this.xComboBox1.Name = "xComboBox1";
            this.xComboBox1.Size = new System.Drawing.Size(121, 24);
            this.xComboBox1.TabIndex = 15;
            // 
            // xDataGridView1
            // 
            this.xDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.xDataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.xDataGridView1.ColumnHeadersHeight = 21;
            this.xDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xDataGridView1.ColumnHeadersVisible = true;
            this.xDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Age});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xDataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.xDataGridView1.EnableHeadersVisualStyles = false;
            this.xDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.xDataGridView1.Location = new System.Drawing.Point(29, 49);
            this.xDataGridView1.Name = "xDataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.xDataGridView1.RowHeadersVisible = false;
            this.xDataGridView1.RowHeadersWidth = 41;
            this.xDataGridView1.RowTemplate.Height = 23;
            this.xDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xDataGridView1.Size = new System.Drawing.Size(385, 164);
            this.xDataGridView1.TabIndex = 17;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "姓名";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Age
            // 
            this.Column_Age.HeaderText = "年龄";
            this.Column_Age.Name = "Column_Age";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.xDataGridView1);
            this.grp1.Location = new System.Drawing.Point(691, 398);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(446, 230);
            this.grp1.TabIndex = 18;
            this.grp1.TabStop = false;
            this.grp1.Text = "分组框1";
            this.grp1.TitleFont = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Bold);
            this.grp1.TitleMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            // 
            // xProgressBar1
            // 
            this.xProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.xProgressBar1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.xProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.xProgressBar1.Location = new System.Drawing.Point(323, 341);
            this.xProgressBar1.Max = 100;
            this.xProgressBar1.Min = 0;
            this.xProgressBar1.Name = "xProgressBar1";
            this.xProgressBar1.Size = new System.Drawing.Size(260, 33);
            this.xProgressBar1.TabIndex = 20;
            this.xProgressBar1.Text = "75%";
            this.xProgressBar1.Value = 75;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.rdo1.Location = new System.Drawing.Point(411, 234);
            this.rdo1.MouseHoveringForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.rdo1.Name = "rdo1";
            this.rdo1.OuterCircleColor = System.Drawing.SystemColors.ControlText;
            this.rdo1.Size = new System.Drawing.Size(65, 16);
            this.rdo1.TabIndex = 21;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "单选框1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // xTabControl1
            // 
            this.xTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.xTabControl1.Controls.Add(this.tabPage1);
            this.xTabControl1.Controls.Add(this.tabPage2);
            this.xTabControl1.HeaderBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.xTabControl1.HeaderBackColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xTabControl1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.xTabControl1.HeaderSelectedBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(252)))));
            this.xTabControl1.HeaderSelectedBackColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.xTabControl1.HeaderSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xTabControl1.Location = new System.Drawing.Point(678, 213);
            this.xTabControl1.Name = "xTabControl1";
            this.xTabControl1.SelectedIndex = 0;
            this.xTabControl1.Size = new System.Drawing.Size(217, 142);
            this.xTabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(209, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(209, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.White;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt1.Location = new System.Drawing.Point(483, 183);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "文本框1";
            // 
            // xShadowPanel1
            // 
            this.xShadowPanel1.Location = new System.Drawing.Point(918, 37);
            this.xShadowPanel1.Name = "xShadowPanel1";
            this.xShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.xShadowPanel1.ShadowHeightRatio = 1F;
            this.xShadowPanel1.Size = new System.Drawing.Size(235, 314);
            this.xShadowPanel1.TabIndex = 24;
            this.xShadowPanel1.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // FrmXFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 732);
            this.Controls.Add(this.xShadowPanel1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.xTabControl1);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.xProgressBar1);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.xComboBox1);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.ipTextBox1);
            this.Controls.Add(this.btnLoadingLayer);
            this.Controls.Add(this.loadingCircle1);
            this.Controls.Add(this.xTreeView1);
            this.Controls.Add(this.ripplePictureBox1);
            this.Controls.Add(this.btnDropdownButton);
            this.Controls.Add(this.btnCommonButton);
            this.KeyPreview = true;
            this.Name = "FrmXFormTest";
            this.Text = "FrmXFormTest";
            this.TitleBarEndColor = System.Drawing.Color.Pink;
            this.TitleBarStartColor = System.Drawing.Color.HotPink;
            this.Load += new System.EventHandler(this.FrmXFormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ripplePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).EndInit();
            this.grp1.ResumeLayout(false);
            this.xTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowerControl.XButton btnCommonButton;
        private PowerControl.RipplePictureBox ripplePictureBox1;
        private PowerControl.XButton btnDropdownButton;
        private PowerControl.XTreeView xTreeView1;
        private PowerControl.DropDownButtonItem ddbi1;
        private PowerControl.DropDownButtonItem ddbi2;
        private PowerControl.LoadingCircle loadingCircle1;
        private PowerControl.XButton btnLoadingLayer;
        private PowerControl.IPTextBox ipTextBox1;
        private PowerControl.XCheckBox chk1;
        private PowerControl.XComboBox xComboBox1;
        private PowerControl.XDataGridView xDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Age;
        private PowerControl.XGroupBox grp1;
        private PowerControl.XProgressBar xProgressBar1;
        private PowerControl.XRadioButton rdo1;
        private PowerControl.XTabControl xTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private PowerControl.XTextBox txt1;
        private PowerControl.XShadowPanel xShadowPanel1;
    }
}