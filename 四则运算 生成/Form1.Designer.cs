﻿namespace 四则运算_生成
{
    partial class FrmQuizGen
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxQTypeAdd = new System.Windows.Forms.CheckBox();
            this.grpQuizType = new System.Windows.Forms.GroupBox();
            this.cBoxCQuizAllowBrack = new System.Windows.Forms.CheckBox();
            this.labPromptAllowType = new System.Windows.Forms.Label();
            this.cBoxCQuizDiv = new System.Windows.Forms.CheckBox();
            this.cBoxCQuizMul = new System.Windows.Forms.CheckBox();
            this.cBoxCQuizAdd = new System.Windows.Forms.CheckBox();
            this.cBoxCQuizSub = new System.Windows.Forms.CheckBox();
            this.labPromptCQuizNum = new System.Windows.Forms.Label();
            this.stpMaxOptr = new System.Windows.Forms.NumericUpDown();
            this.stpCQuizNum = new System.Windows.Forms.NumericUpDown();
            this.labPromptMaxOptr = new System.Windows.Forms.Label();
            this.cBoxAllowCplx = new System.Windows.Forms.CheckBox();
            this.stpQDiv = new System.Windows.Forms.NumericUpDown();
            this.stpQMul = new System.Windows.Forms.NumericUpDown();
            this.stpQSub = new System.Windows.Forms.NumericUpDown();
            this.stpQAdd = new System.Windows.Forms.NumericUpDown();
            this.cBoxQTypeDiv = new System.Windows.Forms.CheckBox();
            this.cBoxQTypeMul = new System.Windows.Forms.CheckBox();
            this.cBoxQTypeSub = new System.Windows.Forms.CheckBox();
            this.grpQuizOption = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.stpMaxPrecision = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxAllowNeg = new System.Windows.Forms.CheckBox();
            this.cBoxAllowFrac = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lBoxQuizDisp = new System.Windows.Forms.ListBox();
            this.sfdQuestionstxt = new System.Windows.Forms.SaveFileDialog();
            this.grpQuizType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxOptr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCQuizNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQMul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQAdd)).BeginInit();
            this.grpQuizOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxQTypeAdd
            // 
            this.cBoxQTypeAdd.AutoSize = true;
            this.cBoxQTypeAdd.Location = new System.Drawing.Point(7, 24);
            this.cBoxQTypeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxQTypeAdd.Name = "cBoxQTypeAdd";
            this.cBoxQTypeAdd.Size = new System.Drawing.Size(59, 19);
            this.cBoxQTypeAdd.TabIndex = 3;
            this.cBoxQTypeAdd.Text = "加法";
            this.cBoxQTypeAdd.UseVisualStyleBackColor = true;
            this.cBoxQTypeAdd.CheckedChanged += new System.EventHandler(this.cBoxQTypeAdd_CheckedChanged);
            // 
            // grpQuizType
            // 
            this.grpQuizType.Controls.Add(this.cBoxCQuizAllowBrack);
            this.grpQuizType.Controls.Add(this.labPromptAllowType);
            this.grpQuizType.Controls.Add(this.cBoxCQuizDiv);
            this.grpQuizType.Controls.Add(this.cBoxCQuizMul);
            this.grpQuizType.Controls.Add(this.cBoxCQuizAdd);
            this.grpQuizType.Controls.Add(this.cBoxCQuizSub);
            this.grpQuizType.Controls.Add(this.labPromptCQuizNum);
            this.grpQuizType.Controls.Add(this.stpMaxOptr);
            this.grpQuizType.Controls.Add(this.stpCQuizNum);
            this.grpQuizType.Controls.Add(this.labPromptMaxOptr);
            this.grpQuizType.Controls.Add(this.cBoxAllowCplx);
            this.grpQuizType.Controls.Add(this.stpQDiv);
            this.grpQuizType.Controls.Add(this.stpQMul);
            this.grpQuizType.Controls.Add(this.stpQSub);
            this.grpQuizType.Controls.Add(this.stpQAdd);
            this.grpQuizType.Controls.Add(this.cBoxQTypeDiv);
            this.grpQuizType.Controls.Add(this.cBoxQTypeMul);
            this.grpQuizType.Controls.Add(this.cBoxQTypeSub);
            this.grpQuizType.Controls.Add(this.cBoxQTypeAdd);
            this.grpQuizType.Location = new System.Drawing.Point(12, 12);
            this.grpQuizType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuizType.Name = "grpQuizType";
            this.grpQuizType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuizType.Size = new System.Drawing.Size(213, 286);
            this.grpQuizType.TabIndex = 4;
            this.grpQuizType.TabStop = false;
            this.grpQuizType.Text = "题目类型";
            // 
            // cBoxCQuizAllowBrack
            // 
            this.cBoxCQuizAllowBrack.AutoSize = true;
            this.cBoxCQuizAllowBrack.Location = new System.Drawing.Point(83, 258);
            this.cBoxCQuizAllowBrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCQuizAllowBrack.Name = "cBoxCQuizAllowBrack";
            this.cBoxCQuizAllowBrack.Size = new System.Drawing.Size(89, 19);
            this.cBoxCQuizAllowBrack.TabIndex = 26;
            this.cBoxCQuizAllowBrack.Text = "允许括号";
            this.cBoxCQuizAllowBrack.UseVisualStyleBackColor = true;
            this.cBoxCQuizAllowBrack.CheckedChanged += new System.EventHandler(this.cBoxCQuizAllowBrack_CheckedChanged);
            // 
            // labPromptAllowType
            // 
            this.labPromptAllowType.AutoSize = true;
            this.labPromptAllowType.Location = new System.Drawing.Point(40, 208);
            this.labPromptAllowType.Name = "labPromptAllowType";
            this.labPromptAllowType.Size = new System.Drawing.Size(37, 15);
            this.labPromptAllowType.TabIndex = 25;
            this.labPromptAllowType.Text = "允许";
            // 
            // cBoxCQuizDiv
            // 
            this.cBoxCQuizDiv.AutoSize = true;
            this.cBoxCQuizDiv.Location = new System.Drawing.Point(148, 232);
            this.cBoxCQuizDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCQuizDiv.Name = "cBoxCQuizDiv";
            this.cBoxCQuizDiv.Size = new System.Drawing.Size(59, 19);
            this.cBoxCQuizDiv.TabIndex = 24;
            this.cBoxCQuizDiv.Text = "除法";
            this.cBoxCQuizDiv.UseVisualStyleBackColor = true;
            this.cBoxCQuizDiv.CheckedChanged += new System.EventHandler(this.cBoxCQuizDiv_CheckedChanged);
            // 
            // cBoxCQuizMul
            // 
            this.cBoxCQuizMul.AutoSize = true;
            this.cBoxCQuizMul.Location = new System.Drawing.Point(83, 232);
            this.cBoxCQuizMul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCQuizMul.Name = "cBoxCQuizMul";
            this.cBoxCQuizMul.Size = new System.Drawing.Size(59, 19);
            this.cBoxCQuizMul.TabIndex = 22;
            this.cBoxCQuizMul.Text = "乘法";
            this.cBoxCQuizMul.UseVisualStyleBackColor = true;
            this.cBoxCQuizMul.CheckedChanged += new System.EventHandler(this.cBoxCQuizMul_CheckedChanged);
            // 
            // cBoxCQuizAdd
            // 
            this.cBoxCQuizAdd.AutoSize = true;
            this.cBoxCQuizAdd.Location = new System.Drawing.Point(83, 208);
            this.cBoxCQuizAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCQuizAdd.Name = "cBoxCQuizAdd";
            this.cBoxCQuizAdd.Size = new System.Drawing.Size(59, 19);
            this.cBoxCQuizAdd.TabIndex = 18;
            this.cBoxCQuizAdd.Text = "加法";
            this.cBoxCQuizAdd.UseVisualStyleBackColor = true;
            this.cBoxCQuizAdd.CheckedChanged += new System.EventHandler(this.cBoxCQuizAdd_CheckedChanged);
            // 
            // cBoxCQuizSub
            // 
            this.cBoxCQuizSub.AutoSize = true;
            this.cBoxCQuizSub.Location = new System.Drawing.Point(148, 208);
            this.cBoxCQuizSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCQuizSub.Name = "cBoxCQuizSub";
            this.cBoxCQuizSub.Size = new System.Drawing.Size(59, 19);
            this.cBoxCQuizSub.TabIndex = 19;
            this.cBoxCQuizSub.Text = "减法";
            this.cBoxCQuizSub.UseVisualStyleBackColor = true;
            this.cBoxCQuizSub.CheckedChanged += new System.EventHandler(this.cBoxCQuizSub_CheckedChanged);
            // 
            // labPromptCQuizNum
            // 
            this.labPromptCQuizNum.AutoSize = true;
            this.labPromptCQuizNum.Location = new System.Drawing.Point(5, 148);
            this.labPromptCQuizNum.Name = "labPromptCQuizNum";
            this.labPromptCQuizNum.Size = new System.Drawing.Size(67, 15);
            this.labPromptCQuizNum.TabIndex = 23;
            this.labPromptCQuizNum.Text = "题目数量";
            // 
            // stpMaxOptr
            // 
            this.stpMaxOptr.Location = new System.Drawing.Point(97, 175);
            this.stpMaxOptr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpMaxOptr.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.stpMaxOptr.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.stpMaxOptr.Name = "stpMaxOptr";
            this.stpMaxOptr.Size = new System.Drawing.Size(96, 25);
            this.stpMaxOptr.TabIndex = 20;
            this.stpMaxOptr.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.stpMaxOptr.ValueChanged += new System.EventHandler(this.stpMaxOptr_ValueChanged);
            // 
            // stpCQuizNum
            // 
            this.stpCQuizNum.Location = new System.Drawing.Point(97, 146);
            this.stpCQuizNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpCQuizNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stpCQuizNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpCQuizNum.Name = "stpCQuizNum";
            this.stpCQuizNum.Size = new System.Drawing.Size(96, 25);
            this.stpCQuizNum.TabIndex = 21;
            this.stpCQuizNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpCQuizNum.ValueChanged += new System.EventHandler(this.stpCQuizNum_ValueChanged);
            // 
            // labPromptMaxOptr
            // 
            this.labPromptMaxOptr.AutoSize = true;
            this.labPromptMaxOptr.Location = new System.Drawing.Point(5, 178);
            this.labPromptMaxOptr.Name = "labPromptMaxOptr";
            this.labPromptMaxOptr.Size = new System.Drawing.Size(82, 15);
            this.labPromptMaxOptr.TabIndex = 17;
            this.labPromptMaxOptr.Text = "最大运算数";
            // 
            // cBoxAllowCplx
            // 
            this.cBoxAllowCplx.AutoSize = true;
            this.cBoxAllowCplx.Location = new System.Drawing.Point(5, 124);
            this.cBoxAllowCplx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAllowCplx.Name = "cBoxAllowCplx";
            this.cBoxAllowCplx.Size = new System.Drawing.Size(89, 19);
            this.cBoxAllowCplx.TabIndex = 16;
            this.cBoxAllowCplx.Text = "复合运算";
            this.cBoxAllowCplx.UseVisualStyleBackColor = true;
            this.cBoxAllowCplx.CheckedChanged += new System.EventHandler(this.cBoxAllowCplx_CheckedChanged);
            // 
            // stpQDiv
            // 
            this.stpQDiv.Location = new System.Drawing.Point(73, 92);
            this.stpQDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpQDiv.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stpQDiv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQDiv.Name = "stpQDiv";
            this.stpQDiv.Size = new System.Drawing.Size(120, 25);
            this.stpQDiv.TabIndex = 10;
            this.stpQDiv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQDiv.ValueChanged += new System.EventHandler(this.stpQDiv_ValueChanged);
            // 
            // stpQMul
            // 
            this.stpQMul.Location = new System.Drawing.Point(73, 68);
            this.stpQMul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpQMul.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stpQMul.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQMul.Name = "stpQMul";
            this.stpQMul.Size = new System.Drawing.Size(120, 25);
            this.stpQMul.TabIndex = 9;
            this.stpQMul.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQMul.ValueChanged += new System.EventHandler(this.stpQMul_ValueChanged);
            // 
            // stpQSub
            // 
            this.stpQSub.Location = new System.Drawing.Point(73, 42);
            this.stpQSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpQSub.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stpQSub.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQSub.Name = "stpQSub";
            this.stpQSub.Size = new System.Drawing.Size(120, 25);
            this.stpQSub.TabIndex = 8;
            this.stpQSub.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQSub.ValueChanged += new System.EventHandler(this.stpQSub_ValueChanged);
            // 
            // stpQAdd
            // 
            this.stpQAdd.Location = new System.Drawing.Point(73, 18);
            this.stpQAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stpQAdd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stpQAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQAdd.Name = "stpQAdd";
            this.stpQAdd.Size = new System.Drawing.Size(120, 25);
            this.stpQAdd.TabIndex = 7;
            this.stpQAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQAdd.ValueChanged += new System.EventHandler(this.stpQAdd_ValueChanged);
            // 
            // cBoxQTypeDiv
            // 
            this.cBoxQTypeDiv.AutoSize = true;
            this.cBoxQTypeDiv.Location = new System.Drawing.Point(5, 99);
            this.cBoxQTypeDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxQTypeDiv.Name = "cBoxQTypeDiv";
            this.cBoxQTypeDiv.Size = new System.Drawing.Size(59, 19);
            this.cBoxQTypeDiv.TabIndex = 6;
            this.cBoxQTypeDiv.Text = "除法";
            this.cBoxQTypeDiv.UseVisualStyleBackColor = true;
            this.cBoxQTypeDiv.CheckedChanged += new System.EventHandler(this.cBoxQTypeDiv_CheckedChanged);
            // 
            // cBoxQTypeMul
            // 
            this.cBoxQTypeMul.AutoSize = true;
            this.cBoxQTypeMul.Location = new System.Drawing.Point(5, 74);
            this.cBoxQTypeMul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxQTypeMul.Name = "cBoxQTypeMul";
            this.cBoxQTypeMul.Size = new System.Drawing.Size(59, 19);
            this.cBoxQTypeMul.TabIndex = 5;
            this.cBoxQTypeMul.Text = "乘法";
            this.cBoxQTypeMul.UseVisualStyleBackColor = true;
            this.cBoxQTypeMul.CheckedChanged += new System.EventHandler(this.cBoxQTypeMul_CheckedChanged);
            // 
            // cBoxQTypeSub
            // 
            this.cBoxQTypeSub.AutoSize = true;
            this.cBoxQTypeSub.Location = new System.Drawing.Point(7, 49);
            this.cBoxQTypeSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxQTypeSub.Name = "cBoxQTypeSub";
            this.cBoxQTypeSub.Size = new System.Drawing.Size(59, 19);
            this.cBoxQTypeSub.TabIndex = 4;
            this.cBoxQTypeSub.Text = "减法";
            this.cBoxQTypeSub.UseVisualStyleBackColor = true;
            this.cBoxQTypeSub.CheckedChanged += new System.EventHandler(this.cBoxQTypeSub_CheckedChanged);
            // 
            // grpQuizOption
            // 
            this.grpQuizOption.Controls.Add(this.numericUpDown1);
            this.grpQuizOption.Controls.Add(this.stpMaxPrecision);
            this.grpQuizOption.Controls.Add(this.label1);
            this.grpQuizOption.Controls.Add(this.cBoxAllowNeg);
            this.grpQuizOption.Controls.Add(this.cBoxAllowFrac);
            this.grpQuizOption.Location = new System.Drawing.Point(12, 304);
            this.grpQuizOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuizOption.Name = "grpQuizOption";
            this.grpQuizOption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuizOption.Size = new System.Drawing.Size(213, 112);
            this.grpQuizOption.TabIndex = 5;
            this.grpQuizOption.TabStop = false;
            this.grpQuizOption.Text = "题目约束";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 75);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 25);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // stpMaxPrecision
            // 
            this.stpMaxPrecision.Location = new System.Drawing.Point(99, 24);
            this.stpMaxPrecision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stpMaxPrecision.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.stpMaxPrecision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpMaxPrecision.Name = "stpMaxPrecision";
            this.stpMaxPrecision.Size = new System.Drawing.Size(108, 25);
            this.stpMaxPrecision.TabIndex = 4;
            this.stpMaxPrecision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpMaxPrecision.ValueChanged += new System.EventHandler(this.stpMaxPrecision_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "上限运算值";
            // 
            // cBoxAllowNeg
            // 
            this.cBoxAllowNeg.AutoSize = true;
            this.cBoxAllowNeg.Location = new System.Drawing.Point(5, 50);
            this.cBoxAllowNeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAllowNeg.Name = "cBoxAllowNeg";
            this.cBoxAllowNeg.Size = new System.Drawing.Size(89, 19);
            this.cBoxAllowNeg.TabIndex = 1;
            this.cBoxAllowNeg.Text = "允许负数";
            this.cBoxAllowNeg.UseVisualStyleBackColor = true;
            // 
            // cBoxAllowFrac
            // 
            this.cBoxAllowFrac.AutoSize = true;
            this.cBoxAllowFrac.Location = new System.Drawing.Point(5, 25);
            this.cBoxAllowFrac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAllowFrac.Name = "cBoxAllowFrac";
            this.cBoxAllowFrac.Size = new System.Drawing.Size(89, 19);
            this.cBoxAllowFrac.TabIndex = 0;
            this.cBoxAllowFrac.Text = "允许小数";
            this.cBoxAllowFrac.UseVisualStyleBackColor = true;
            this.cBoxAllowFrac.CheckedChanged += new System.EventHandler(this.cBoxAllowFrac_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(252, 320);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 38);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(713, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 320);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lBoxQuizDisp
            // 
            this.lBoxQuizDisp.FormattingEnabled = true;
            this.lBoxQuizDisp.ItemHeight = 15;
            this.lBoxQuizDisp.Location = new System.Drawing.Point(252, 30);
            this.lBoxQuizDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBoxQuizDisp.Name = "lBoxQuizDisp";
            this.lBoxQuizDisp.Size = new System.Drawing.Size(536, 274);
            this.lBoxQuizDisp.TabIndex = 17;
            this.lBoxQuizDisp.SelectedIndexChanged += new System.EventHandler(this.lBoxQuizDisp_SelectedIndexChanged);
            // 
            // sfdQuestionstxt
            // 
            this.sfdQuestionstxt.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdQuestionstxt_FileOk);
            // 
            // FrmQuizGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBoxQuizDisp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpQuizOption);
            this.Controls.Add(this.grpQuizType);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuizGen";
            this.Text = "四则运算生成器";
            this.Activated += new System.EventHandler(this.FrmQuizGen_Activated);
            this.grpQuizType.ResumeLayout(false);
            this.grpQuizType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxOptr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCQuizNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQMul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQAdd)).EndInit();
            this.grpQuizOption.ResumeLayout(false);
            this.grpQuizOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxPrecision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cBoxQTypeAdd;
        private System.Windows.Forms.GroupBox grpQuizType;
        private System.Windows.Forms.NumericUpDown stpQAdd;
        private System.Windows.Forms.CheckBox cBoxQTypeDiv;
        private System.Windows.Forms.CheckBox cBoxQTypeMul;
        private System.Windows.Forms.CheckBox cBoxQTypeSub;
        private System.Windows.Forms.NumericUpDown stpQDiv;
        private System.Windows.Forms.NumericUpDown stpQMul;
        private System.Windows.Forms.NumericUpDown stpQSub;
        private System.Windows.Forms.GroupBox grpQuizOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxAllowNeg;
        private System.Windows.Forms.CheckBox cBoxAllowFrac;
        private System.Windows.Forms.CheckBox cBoxCQuizAllowBrack;
        private System.Windows.Forms.Label labPromptAllowType;
        private System.Windows.Forms.CheckBox cBoxCQuizDiv;
        private System.Windows.Forms.CheckBox cBoxCQuizMul;
        private System.Windows.Forms.CheckBox cBoxCQuizAdd;
        private System.Windows.Forms.CheckBox cBoxCQuizSub;
        private System.Windows.Forms.Label labPromptCQuizNum;
        private System.Windows.Forms.NumericUpDown stpMaxOptr;
        private System.Windows.Forms.NumericUpDown stpCQuizNum;
        private System.Windows.Forms.Label labPromptMaxOptr;
        private System.Windows.Forms.CheckBox cBoxAllowCplx;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lBoxQuizDisp;
        private System.Windows.Forms.NumericUpDown stpMaxPrecision;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog sfdQuestionstxt;
    }
}

