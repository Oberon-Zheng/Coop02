namespace 四则运算_生成
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cBoxAllowNeg = new System.Windows.Forms.CheckBox();
            this.cBoxAllowFrac = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lBoxQuizDisp = new System.Windows.Forms.ListBox();
            this.stpMaxPrecision = new System.Windows.Forms.NumericUpDown();
            this.grpQuizType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxOptr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCQuizNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQMul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpQAdd)).BeginInit();
            this.grpQuizOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpMaxPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxQTypeAdd
            // 
            this.cBoxQTypeAdd.AutoSize = true;
            this.cBoxQTypeAdd.Location = new System.Drawing.Point(5, 19);
            this.cBoxQTypeAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxQTypeAdd.Name = "cBoxQTypeAdd";
            this.cBoxQTypeAdd.Size = new System.Drawing.Size(48, 16);
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
            this.grpQuizType.Location = new System.Drawing.Point(9, 10);
            this.grpQuizType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuizType.Name = "grpQuizType";
            this.grpQuizType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuizType.Size = new System.Drawing.Size(160, 229);
            this.grpQuizType.TabIndex = 4;
            this.grpQuizType.TabStop = false;
            this.grpQuizType.Text = "题目类型";
            // 
            // cBoxCQuizAllowBrack
            // 
            this.cBoxCQuizAllowBrack.AutoSize = true;
            this.cBoxCQuizAllowBrack.Location = new System.Drawing.Point(62, 206);
            this.cBoxCQuizAllowBrack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxCQuizAllowBrack.Name = "cBoxCQuizAllowBrack";
            this.cBoxCQuizAllowBrack.Size = new System.Drawing.Size(72, 16);
            this.cBoxCQuizAllowBrack.TabIndex = 26;
            this.cBoxCQuizAllowBrack.Text = "允许括号";
            this.cBoxCQuizAllowBrack.UseVisualStyleBackColor = true;
            // 
            // labPromptAllowType
            // 
            this.labPromptAllowType.AutoSize = true;
            this.labPromptAllowType.Location = new System.Drawing.Point(30, 166);
            this.labPromptAllowType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPromptAllowType.Name = "labPromptAllowType";
            this.labPromptAllowType.Size = new System.Drawing.Size(29, 12);
            this.labPromptAllowType.TabIndex = 25;
            this.labPromptAllowType.Text = "允许";
            // 
            // cBoxCQuizDiv
            // 
            this.cBoxCQuizDiv.AutoSize = true;
            this.cBoxCQuizDiv.Location = new System.Drawing.Point(111, 186);
            this.cBoxCQuizDiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxCQuizDiv.Name = "cBoxCQuizDiv";
            this.cBoxCQuizDiv.Size = new System.Drawing.Size(48, 16);
            this.cBoxCQuizDiv.TabIndex = 24;
            this.cBoxCQuizDiv.Text = "除法";
            this.cBoxCQuizDiv.UseVisualStyleBackColor = true;
            // 
            // cBoxCQuizMul
            // 
            this.cBoxCQuizMul.AutoSize = true;
            this.cBoxCQuizMul.Location = new System.Drawing.Point(62, 186);
            this.cBoxCQuizMul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxCQuizMul.Name = "cBoxCQuizMul";
            this.cBoxCQuizMul.Size = new System.Drawing.Size(48, 16);
            this.cBoxCQuizMul.TabIndex = 22;
            this.cBoxCQuizMul.Text = "乘法";
            this.cBoxCQuizMul.UseVisualStyleBackColor = true;
            // 
            // cBoxCQuizAdd
            // 
            this.cBoxCQuizAdd.AutoSize = true;
            this.cBoxCQuizAdd.Location = new System.Drawing.Point(62, 166);
            this.cBoxCQuizAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxCQuizAdd.Name = "cBoxCQuizAdd";
            this.cBoxCQuizAdd.Size = new System.Drawing.Size(48, 16);
            this.cBoxCQuizAdd.TabIndex = 18;
            this.cBoxCQuizAdd.Text = "加法";
            this.cBoxCQuizAdd.UseVisualStyleBackColor = true;
            // 
            // cBoxCQuizSub
            // 
            this.cBoxCQuizSub.AutoSize = true;
            this.cBoxCQuizSub.Location = new System.Drawing.Point(111, 166);
            this.cBoxCQuizSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxCQuizSub.Name = "cBoxCQuizSub";
            this.cBoxCQuizSub.Size = new System.Drawing.Size(48, 16);
            this.cBoxCQuizSub.TabIndex = 19;
            this.cBoxCQuizSub.Text = "减法";
            this.cBoxCQuizSub.UseVisualStyleBackColor = true;
            // 
            // labPromptCQuizNum
            // 
            this.labPromptCQuizNum.AutoSize = true;
            this.labPromptCQuizNum.Location = new System.Drawing.Point(4, 118);
            this.labPromptCQuizNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPromptCQuizNum.Name = "labPromptCQuizNum";
            this.labPromptCQuizNum.Size = new System.Drawing.Size(53, 12);
            this.labPromptCQuizNum.TabIndex = 23;
            this.labPromptCQuizNum.Text = "题目数量";
            // 
            // stpMaxOptr
            // 
            this.stpMaxOptr.Location = new System.Drawing.Point(73, 140);
            this.stpMaxOptr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpMaxOptr.Size = new System.Drawing.Size(72, 21);
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
            this.stpCQuizNum.Location = new System.Drawing.Point(73, 117);
            this.stpCQuizNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpCQuizNum.Size = new System.Drawing.Size(72, 21);
            this.stpCQuizNum.TabIndex = 21;
            this.stpCQuizNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labPromptMaxOptr
            // 
            this.labPromptMaxOptr.AutoSize = true;
            this.labPromptMaxOptr.Location = new System.Drawing.Point(4, 142);
            this.labPromptMaxOptr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPromptMaxOptr.Name = "labPromptMaxOptr";
            this.labPromptMaxOptr.Size = new System.Drawing.Size(65, 12);
            this.labPromptMaxOptr.TabIndex = 17;
            this.labPromptMaxOptr.Text = "最大运算数";
            // 
            // cBoxAllowCplx
            // 
            this.cBoxAllowCplx.AutoSize = true;
            this.cBoxAllowCplx.Location = new System.Drawing.Point(4, 99);
            this.cBoxAllowCplx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxAllowCplx.Name = "cBoxAllowCplx";
            this.cBoxAllowCplx.Size = new System.Drawing.Size(72, 16);
            this.cBoxAllowCplx.TabIndex = 16;
            this.cBoxAllowCplx.Text = "复合运算";
            this.cBoxAllowCplx.UseVisualStyleBackColor = true;
            // 
            // stpQDiv
            // 
            this.stpQDiv.Location = new System.Drawing.Point(55, 74);
            this.stpQDiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpQDiv.Size = new System.Drawing.Size(90, 21);
            this.stpQDiv.TabIndex = 10;
            this.stpQDiv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stpQMul
            // 
            this.stpQMul.Location = new System.Drawing.Point(55, 54);
            this.stpQMul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpQMul.Size = new System.Drawing.Size(90, 21);
            this.stpQMul.TabIndex = 9;
            this.stpQMul.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stpQSub
            // 
            this.stpQSub.Location = new System.Drawing.Point(55, 34);
            this.stpQSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpQSub.Size = new System.Drawing.Size(90, 21);
            this.stpQSub.TabIndex = 8;
            this.stpQSub.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stpQSub.ValueChanged += new System.EventHandler(this.stpQAddSub_ValueChanged);
            // 
            // stpQAdd
            // 
            this.stpQAdd.Location = new System.Drawing.Point(55, 14);
            this.stpQAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stpQAdd.Size = new System.Drawing.Size(90, 21);
            this.stpQAdd.TabIndex = 7;
            this.stpQAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cBoxQTypeDiv
            // 
            this.cBoxQTypeDiv.AutoSize = true;
            this.cBoxQTypeDiv.Location = new System.Drawing.Point(4, 79);
            this.cBoxQTypeDiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxQTypeDiv.Name = "cBoxQTypeDiv";
            this.cBoxQTypeDiv.Size = new System.Drawing.Size(48, 16);
            this.cBoxQTypeDiv.TabIndex = 6;
            this.cBoxQTypeDiv.Text = "除法";
            this.cBoxQTypeDiv.UseVisualStyleBackColor = true;
            this.cBoxQTypeDiv.CheckedChanged += new System.EventHandler(this.cBoxQTypeDiv_CheckedChanged);
            // 
            // cBoxQTypeMul
            // 
            this.cBoxQTypeMul.AutoSize = true;
            this.cBoxQTypeMul.Location = new System.Drawing.Point(4, 59);
            this.cBoxQTypeMul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxQTypeMul.Name = "cBoxQTypeMul";
            this.cBoxQTypeMul.Size = new System.Drawing.Size(48, 16);
            this.cBoxQTypeMul.TabIndex = 5;
            this.cBoxQTypeMul.Text = "乘法";
            this.cBoxQTypeMul.UseVisualStyleBackColor = true;
            this.cBoxQTypeMul.CheckedChanged += new System.EventHandler(this.cBoxQTypeMul_CheckedChanged);
            // 
            // cBoxQTypeSub
            // 
            this.cBoxQTypeSub.AutoSize = true;
            this.cBoxQTypeSub.Location = new System.Drawing.Point(5, 39);
            this.cBoxQTypeSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxQTypeSub.Name = "cBoxQTypeSub";
            this.cBoxQTypeSub.Size = new System.Drawing.Size(48, 16);
            this.cBoxQTypeSub.TabIndex = 4;
            this.cBoxQTypeSub.Text = "减法";
            this.cBoxQTypeSub.UseVisualStyleBackColor = true;
            this.cBoxQTypeSub.CheckedChanged += new System.EventHandler(this.cBoxQTypeSub_CheckedChanged);
            // 
            // grpQuizOption
            // 
            this.grpQuizOption.Controls.Add(this.stpMaxPrecision);
            this.grpQuizOption.Controls.Add(this.label1);
            this.grpQuizOption.Controls.Add(this.textBox1);
            this.grpQuizOption.Controls.Add(this.cBoxAllowNeg);
            this.grpQuizOption.Controls.Add(this.cBoxAllowFrac);
            this.grpQuizOption.Location = new System.Drawing.Point(9, 243);
            this.grpQuizOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuizOption.Name = "grpQuizOption";
            this.grpQuizOption.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuizOption.Size = new System.Drawing.Size(160, 90);
            this.grpQuizOption.TabIndex = 5;
            this.grpQuizOption.TabStop = false;
            this.grpQuizOption.Text = "题目约束";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "上限运算值";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 21);
            this.textBox1.TabIndex = 2;
            // 
            // cBoxAllowNeg
            // 
            this.cBoxAllowNeg.AutoSize = true;
            this.cBoxAllowNeg.Location = new System.Drawing.Point(4, 40);
            this.cBoxAllowNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxAllowNeg.Name = "cBoxAllowNeg";
            this.cBoxAllowNeg.Size = new System.Drawing.Size(72, 16);
            this.cBoxAllowNeg.TabIndex = 1;
            this.cBoxAllowNeg.Text = "允许负数";
            this.cBoxAllowNeg.UseVisualStyleBackColor = true;
            // 
            // cBoxAllowFrac
            // 
            this.cBoxAllowFrac.AutoSize = true;
            this.cBoxAllowFrac.Location = new System.Drawing.Point(4, 20);
            this.cBoxAllowFrac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxAllowFrac.Name = "cBoxAllowFrac";
            this.cBoxAllowFrac.Size = new System.Drawing.Size(72, 16);
            this.cBoxAllowFrac.TabIndex = 0;
            this.cBoxAllowFrac.Text = "允许小数";
            this.cBoxAllowFrac.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(535, 256);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 290);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "继续生成";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 256);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "保存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lBoxQuizDisp
            // 
            this.lBoxQuizDisp.FormattingEnabled = true;
            this.lBoxQuizDisp.ItemHeight = 12;
            this.lBoxQuizDisp.Location = new System.Drawing.Point(189, 24);
            this.lBoxQuizDisp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxQuizDisp.Name = "lBoxQuizDisp";
            this.lBoxQuizDisp.Size = new System.Drawing.Size(403, 220);
            this.lBoxQuizDisp.TabIndex = 17;
            // 
            // stpMaxPrecision
            // 
            this.stpMaxPrecision.Location = new System.Drawing.Point(73, 19);
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
            this.stpMaxPrecision.Size = new System.Drawing.Size(72, 21);
            this.stpMaxPrecision.TabIndex = 4;
            this.stpMaxPrecision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmQuizGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.lBoxQuizDisp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpQuizOption);
            this.Controls.Add(this.grpQuizType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lBoxQuizDisp;
        private System.Windows.Forms.NumericUpDown stpMaxPrecision;
    }
}

