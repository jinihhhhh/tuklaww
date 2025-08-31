namespace Program1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolTip toolTip1;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxMenuSelection = new System.Windows.Forms.GroupBox();
            this.pnlMangoFloat = new System.Windows.Forms.Panel();
            this.cbMangoFloat = new System.Windows.Forms.CheckBox();
            this.nudMangoFloatQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMangoSizes = new System.Windows.Forms.GroupBox();
            this.rbMangoSmall = new System.Windows.Forms.RadioButton();
            this.rbMangoMedium = new System.Windows.Forms.RadioButton();
            this.rbMangoLarge = new System.Windows.Forms.RadioButton();
            this.btnAddMango = new System.Windows.Forms.Button();
            this.lblMangoFloatPrice = new System.Windows.Forms.Label();
            this.pnlKamoteFloat = new System.Windows.Forms.Panel();
            this.cbKamoteFloat = new System.Windows.Forms.CheckBox();
            this.nudKamoteFloatQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBoxKamoteSizes = new System.Windows.Forms.GroupBox();
            this.rbKamoteSmall = new System.Windows.Forms.RadioButton();
            this.rbKamoteMedium = new System.Windows.Forms.RadioButton();
            this.rbKamoteLarge = new System.Windows.Forms.RadioButton();
            this.btnAddKamote = new System.Windows.Forms.Button();
            this.lblKamoteFloatPrice = new System.Windows.Forms.Label();
            this.pnlKangkongFloat = new System.Windows.Forms.Panel();
            this.cbKangkongFloat = new System.Windows.Forms.CheckBox();
            this.nudKangkongFloatQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBoxKangkongSizes = new System.Windows.Forms.GroupBox();
            this.rbKangkongSmall = new System.Windows.Forms.RadioButton();
            this.rbKangkongMedium = new System.Windows.Forms.RadioButton();
            this.rbKangkongLarge = new System.Windows.Forms.RadioButton();
            this.btnAddKangkong = new System.Windows.Forms.Button();
            this.lblKangkongFloatPrice = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.receiptTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMenuSelection.SuspendLayout();
            this.pnlMangoFloat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMangoFloatQuantity)).BeginInit();
            this.groupBoxMangoSizes.SuspendLayout();
            this.pnlKamoteFloat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamoteFloatQuantity)).BeginInit();
            this.groupBoxKamoteSizes.SuspendLayout();
            this.pnlKangkongFloat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKangkongFloatQuantity)).BeginInit();
            this.groupBoxKangkongSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenuSelection
            // 
            this.groupBoxMenuSelection.BackColor = System.Drawing.Color.White;
            this.groupBoxMenuSelection.Controls.Add(this.pnlMangoFloat);
            this.groupBoxMenuSelection.Controls.Add(this.pnlKamoteFloat);
            this.groupBoxMenuSelection.Controls.Add(this.pnlKangkongFloat);
            this.groupBoxMenuSelection.Controls.Add(this.btnGenerateReceipt);
            this.groupBoxMenuSelection.Controls.Add(this.totalAmountTextBox);
            this.groupBoxMenuSelection.Controls.Add(this.changeTextBox);
            this.groupBoxMenuSelection.Controls.Add(this.cashTextBox);
            this.groupBoxMenuSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMenuSelection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenuSelection.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxMenuSelection.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMenuSelection.Name = "groupBoxMenuSelection";
            this.groupBoxMenuSelection.Size = new System.Drawing.Size(680, 560);
            this.groupBoxMenuSelection.TabIndex = 0;
            this.groupBoxMenuSelection.TabStop = false;
            this.groupBoxMenuSelection.Text = "Select Items";
            // 
            // pnlMangoFloat
            // 
            this.pnlMangoFloat.BackColor = System.Drawing.Color.White;
            this.pnlMangoFloat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMangoFloat.Controls.Add(this.cbMangoFloat);
            this.pnlMangoFloat.Controls.Add(this.nudMangoFloatQuantity);
            this.pnlMangoFloat.Controls.Add(this.groupBoxMangoSizes);
            this.pnlMangoFloat.Controls.Add(this.btnAddMango);
            this.pnlMangoFloat.Controls.Add(this.lblMangoFloatPrice);
            this.pnlMangoFloat.Location = new System.Drawing.Point(10, 30);
            this.pnlMangoFloat.Name = "pnlMangoFloat";
            this.pnlMangoFloat.Size = new System.Drawing.Size(660, 100);
            this.pnlMangoFloat.TabIndex = 0;
            // 
            // cbMangoFloat
            // 
            this.cbMangoFloat.AutoSize = true;
            this.cbMangoFloat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMangoFloat.Location = new System.Drawing.Point(7, 17);
            this.cbMangoFloat.Name = "cbMangoFloat";
            this.cbMangoFloat.Size = new System.Drawing.Size(133, 27);
            this.cbMangoFloat.TabIndex = 0;
            this.cbMangoFloat.Text = "Mango Float";
            this.cbMangoFloat.UseVisualStyleBackColor = true;
            this.cbMangoFloat.CheckedChanged += new System.EventHandler(this.cbMangoFloat_CheckedChanged);
            // 
            // nudMangoFloatQuantity
            // 
            this.nudMangoFloatQuantity.Location = new System.Drawing.Point(125, 17);
            this.nudMangoFloatQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMangoFloatQuantity.Name = "nudMangoFloatQuantity";
            this.nudMangoFloatQuantity.Size = new System.Drawing.Size(55, 30);
            this.nudMangoFloatQuantity.TabIndex = 1;
            this.nudMangoFloatQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxMangoSizes
            // 
            this.groupBoxMangoSizes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxMangoSizes.Controls.Add(this.rbMangoSmall);
            this.groupBoxMangoSizes.Controls.Add(this.rbMangoMedium);
            this.groupBoxMangoSizes.Controls.Add(this.rbMangoLarge);
            this.groupBoxMangoSizes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMangoSizes.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxMangoSizes.Location = new System.Drawing.Point(195, 5);
            this.groupBoxMangoSizes.Name = "groupBoxMangoSizes";
            this.groupBoxMangoSizes.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxMangoSizes.Size = new System.Drawing.Size(385, 45);
            this.groupBoxMangoSizes.TabIndex = 2;
            this.groupBoxMangoSizes.TabStop = false;
            this.groupBoxMangoSizes.Text = "Sizes";
            // 
            // rbMangoSmall
            // 
            this.rbMangoSmall.AutoSize = true;
            this.rbMangoSmall.Checked = true;
            this.rbMangoSmall.Location = new System.Drawing.Point(5, 19);
            this.rbMangoSmall.Name = "rbMangoSmall";
            this.rbMangoSmall.Size = new System.Drawing.Size(67, 24);
            this.rbMangoSmall.TabIndex = 0;
            this.rbMangoSmall.TabStop = true;
            this.rbMangoSmall.Text = "Small";
            this.rbMangoSmall.UseVisualStyleBackColor = true;
            this.rbMangoSmall.CheckedChanged += new System.EventHandler(this.MangoSizeRadioButtons_CheckedChanged);
            // 
            // rbMangoMedium
            // 
            this.rbMangoMedium.AutoSize = true;
            this.rbMangoMedium.Location = new System.Drawing.Point(108, 15);
            this.rbMangoMedium.Name = "rbMangoMedium";
            this.rbMangoMedium.Size = new System.Drawing.Size(85, 24);
            this.rbMangoMedium.TabIndex = 1;
            this.rbMangoMedium.Text = "Medium";
            this.rbMangoMedium.UseVisualStyleBackColor = true;
            this.rbMangoMedium.CheckedChanged += new System.EventHandler(this.MangoSizeRadioButtons_CheckedChanged);
            // 
            // rbMangoLarge
            // 
            this.rbMangoLarge.AutoSize = true;
            this.rbMangoLarge.Location = new System.Drawing.Point(239, 15);
            this.rbMangoLarge.Name = "rbMangoLarge";
            this.rbMangoLarge.Size = new System.Drawing.Size(67, 24);
            this.rbMangoLarge.TabIndex = 2;
            this.rbMangoLarge.Text = "Large";
            this.rbMangoLarge.UseVisualStyleBackColor = true;
            this.rbMangoLarge.CheckedChanged += new System.EventHandler(this.MangoSizeRadioButtons_CheckedChanged);
            // 
            // btnAddMango
            // 
            this.btnAddMango.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddMango.FlatAppearance.BorderSize = 0;
            this.btnAddMango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMango.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMango.ForeColor = System.Drawing.Color.White;
            this.btnAddMango.Location = new System.Drawing.Point(395, 60);
            this.btnAddMango.Name = "btnAddMango";
            this.btnAddMango.Size = new System.Drawing.Size(90, 28);
            this.btnAddMango.TabIndex = 3;
            this.btnAddMango.Text = "Add to Order";
            this.btnAddMango.UseVisualStyleBackColor = false;
            this.btnAddMango.Click += new System.EventHandler(this.btnAddMango_Click);
            // 
            // lblMangoFloatPrice
            // 
            this.lblMangoFloatPrice.AutoSize = true;
            this.lblMangoFloatPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangoFloatPrice.Location = new System.Drawing.Point(271, 67);
            this.lblMangoFloatPrice.Name = "lblMangoFloatPrice";
            this.lblMangoFloatPrice.Size = new System.Drawing.Size(92, 20);
            this.lblMangoFloatPrice.TabIndex = 4;
            this.lblMangoFloatPrice.Text = "Price: ₱0.00";
            // 
            // pnlKamoteFloat
            // 
            this.pnlKamoteFloat.BackColor = System.Drawing.Color.White;
            this.pnlKamoteFloat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKamoteFloat.Controls.Add(this.cbKamoteFloat);
            this.pnlKamoteFloat.Controls.Add(this.nudKamoteFloatQuantity);
            this.pnlKamoteFloat.Controls.Add(this.groupBoxKamoteSizes);
            this.pnlKamoteFloat.Controls.Add(this.btnAddKamote);
            this.pnlKamoteFloat.Controls.Add(this.lblKamoteFloatPrice);
            this.pnlKamoteFloat.Location = new System.Drawing.Point(10, 140);
            this.pnlKamoteFloat.Name = "pnlKamoteFloat";
            this.pnlKamoteFloat.Size = new System.Drawing.Size(660, 100);
            this.pnlKamoteFloat.TabIndex = 1;
            // 
            // cbKamoteFloat
            // 
            this.cbKamoteFloat.AutoSize = true;
            this.cbKamoteFloat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKamoteFloat.Location = new System.Drawing.Point(3, 22);
            this.cbKamoteFloat.Name = "cbKamoteFloat";
            this.cbKamoteFloat.Size = new System.Drawing.Size(139, 27);
            this.cbKamoteFloat.TabIndex = 0;
            this.cbKamoteFloat.Text = "Kamote Float";
            this.cbKamoteFloat.UseVisualStyleBackColor = true;
            this.cbKamoteFloat.CheckedChanged += new System.EventHandler(this.cbKamoteFloat_CheckedChanged);
            // 
            // nudKamoteFloatQuantity
            // 
            this.nudKamoteFloatQuantity.Location = new System.Drawing.Point(125, 20);
            this.nudKamoteFloatQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKamoteFloatQuantity.Name = "nudKamoteFloatQuantity";
            this.nudKamoteFloatQuantity.Size = new System.Drawing.Size(55, 30);
            this.nudKamoteFloatQuantity.TabIndex = 1;
            this.nudKamoteFloatQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxKamoteSizes
            // 
            this.groupBoxKamoteSizes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxKamoteSizes.Controls.Add(this.rbKamoteSmall);
            this.groupBoxKamoteSizes.Controls.Add(this.rbKamoteMedium);
            this.groupBoxKamoteSizes.Controls.Add(this.rbKamoteLarge);
            this.groupBoxKamoteSizes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKamoteSizes.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxKamoteSizes.Location = new System.Drawing.Point(195, 5);
            this.groupBoxKamoteSizes.Name = "groupBoxKamoteSizes";
            this.groupBoxKamoteSizes.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxKamoteSizes.Size = new System.Drawing.Size(385, 45);
            this.groupBoxKamoteSizes.TabIndex = 2;
            this.groupBoxKamoteSizes.TabStop = false;
            this.groupBoxKamoteSizes.Text = "Sizes";
            // 
            // rbKamoteSmall
            // 
            this.rbKamoteSmall.AutoSize = true;
            this.rbKamoteSmall.Checked = true;
            this.rbKamoteSmall.Location = new System.Drawing.Point(5, 19);
            this.rbKamoteSmall.Name = "rbKamoteSmall";
            this.rbKamoteSmall.Size = new System.Drawing.Size(67, 24);
            this.rbKamoteSmall.TabIndex = 0;
            this.rbKamoteSmall.TabStop = true;
            this.rbKamoteSmall.Text = "Small";
            this.rbKamoteSmall.UseVisualStyleBackColor = true;
            this.rbKamoteSmall.CheckedChanged += new System.EventHandler(this.KamoteSizeRadioButtons_CheckedChanged);
            // 
            // rbKamoteMedium
            // 
            this.rbKamoteMedium.AutoSize = true;
            this.rbKamoteMedium.Location = new System.Drawing.Point(108, 17);
            this.rbKamoteMedium.Name = "rbKamoteMedium";
            this.rbKamoteMedium.Size = new System.Drawing.Size(85, 24);
            this.rbKamoteMedium.TabIndex = 1;
            this.rbKamoteMedium.Text = "Medium";
            this.rbKamoteMedium.UseVisualStyleBackColor = true;
            this.rbKamoteMedium.CheckedChanged += new System.EventHandler(this.KamoteSizeRadioButtons_CheckedChanged);
            // 
            // rbKamoteLarge
            // 
            this.rbKamoteLarge.AutoSize = true;
            this.rbKamoteLarge.Location = new System.Drawing.Point(239, 15);
            this.rbKamoteLarge.Name = "rbKamoteLarge";
            this.rbKamoteLarge.Size = new System.Drawing.Size(67, 24);
            this.rbKamoteLarge.TabIndex = 2;
            this.rbKamoteLarge.Text = "Large";
            this.rbKamoteLarge.UseVisualStyleBackColor = true;
            this.rbKamoteLarge.CheckedChanged += new System.EventHandler(this.KamoteSizeRadioButtons_CheckedChanged);
            // 
            // btnAddKamote
            // 
            this.btnAddKamote.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddKamote.FlatAppearance.BorderSize = 0;
            this.btnAddKamote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKamote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKamote.ForeColor = System.Drawing.Color.White;
            this.btnAddKamote.Location = new System.Drawing.Point(395, 62);
            this.btnAddKamote.Name = "btnAddKamote";
            this.btnAddKamote.Size = new System.Drawing.Size(90, 28);
            this.btnAddKamote.TabIndex = 3;
            this.btnAddKamote.Text = "Add to Order";
            this.btnAddKamote.UseVisualStyleBackColor = false;
            this.btnAddKamote.Click += new System.EventHandler(this.btnAddKamote_Click);
            // 
            // lblKamoteFloatPrice
            // 
            this.lblKamoteFloatPrice.AutoSize = true;
            this.lblKamoteFloatPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKamoteFloatPrice.Location = new System.Drawing.Point(271, 69);
            this.lblKamoteFloatPrice.Name = "lblKamoteFloatPrice";
            this.lblKamoteFloatPrice.Size = new System.Drawing.Size(92, 20);
            this.lblKamoteFloatPrice.TabIndex = 4;
            this.lblKamoteFloatPrice.Text = "Price: ₱0.00";
            // 
            // pnlKangkongFloat
            // 
            this.pnlKangkongFloat.BackColor = System.Drawing.Color.White;
            this.pnlKangkongFloat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKangkongFloat.Controls.Add(this.cbKangkongFloat);
            this.pnlKangkongFloat.Controls.Add(this.nudKangkongFloatQuantity);
            this.pnlKangkongFloat.Controls.Add(this.groupBoxKangkongSizes);
            this.pnlKangkongFloat.Controls.Add(this.btnAddKangkong);
            this.pnlKangkongFloat.Controls.Add(this.lblKangkongFloatPrice);
            this.pnlKangkongFloat.Location = new System.Drawing.Point(10, 250);
            this.pnlKangkongFloat.Name = "pnlKangkongFloat";
            this.pnlKangkongFloat.Size = new System.Drawing.Size(660, 100);
            this.pnlKangkongFloat.TabIndex = 2;
            // 
            // cbKangkongFloat
            // 
            this.cbKangkongFloat.AutoSize = true;
            this.cbKangkongFloat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKangkongFloat.Location = new System.Drawing.Point(-1, 20);
            this.cbKangkongFloat.Name = "cbKangkongFloat";
            this.cbKangkongFloat.Size = new System.Drawing.Size(159, 27);
            this.cbKangkongFloat.TabIndex = 0;
            this.cbKangkongFloat.Text = "Kangkong Float";
            this.cbKangkongFloat.UseVisualStyleBackColor = true;
            this.cbKangkongFloat.CheckedChanged += new System.EventHandler(this.cbKangkongFloat_CheckedChanged);
            // 
            // nudKangkongFloatQuantity
            // 
            this.nudKangkongFloatQuantity.Location = new System.Drawing.Point(134, 20);
            this.nudKangkongFloatQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKangkongFloatQuantity.Name = "nudKangkongFloatQuantity";
            this.nudKangkongFloatQuantity.Size = new System.Drawing.Size(55, 30);
            this.nudKangkongFloatQuantity.TabIndex = 1;
            this.nudKangkongFloatQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKangkongFloatQuantity.ValueChanged += new System.EventHandler(this.nudKangkongFloatQuantity_ValueChanged);
            // 
            // groupBoxKangkongSizes
            // 
            this.groupBoxKangkongSizes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxKangkongSizes.Controls.Add(this.rbKangkongSmall);
            this.groupBoxKangkongSizes.Controls.Add(this.rbKangkongMedium);
            this.groupBoxKangkongSizes.Controls.Add(this.rbKangkongLarge);
            this.groupBoxKangkongSizes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKangkongSizes.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxKangkongSizes.Location = new System.Drawing.Point(195, 5);
            this.groupBoxKangkongSizes.Name = "groupBoxKangkongSizes";
            this.groupBoxKangkongSizes.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxKangkongSizes.Size = new System.Drawing.Size(385, 45);
            this.groupBoxKangkongSizes.TabIndex = 2;
            this.groupBoxKangkongSizes.TabStop = false;
            this.groupBoxKangkongSizes.Text = "Sizes";
            // 
            // rbKangkongSmall
            // 
            this.rbKangkongSmall.AutoSize = true;
            this.rbKangkongSmall.Checked = true;
            this.rbKangkongSmall.Location = new System.Drawing.Point(5, 19);
            this.rbKangkongSmall.Name = "rbKangkongSmall";
            this.rbKangkongSmall.Size = new System.Drawing.Size(67, 24);
            this.rbKangkongSmall.TabIndex = 0;
            this.rbKangkongSmall.TabStop = true;
            this.rbKangkongSmall.Text = "Small";
            this.rbKangkongSmall.UseVisualStyleBackColor = true;
            this.rbKangkongSmall.CheckedChanged += new System.EventHandler(this.KangkongSizeRadioButtons_CheckedChanged);
            // 
            // rbKangkongMedium
            // 
            this.rbKangkongMedium.AutoSize = true;
            this.rbKangkongMedium.Location = new System.Drawing.Point(108, 16);
            this.rbKangkongMedium.Name = "rbKangkongMedium";
            this.rbKangkongMedium.Size = new System.Drawing.Size(85, 24);
            this.rbKangkongMedium.TabIndex = 1;
            this.rbKangkongMedium.Text = "Medium";
            this.rbKangkongMedium.UseVisualStyleBackColor = true;
            this.rbKangkongMedium.CheckedChanged += new System.EventHandler(this.KangkongSizeRadioButtons_CheckedChanged);
            // 
            // rbKangkongLarge
            // 
            this.rbKangkongLarge.AutoSize = true;
            this.rbKangkongLarge.Location = new System.Drawing.Point(239, 17);
            this.rbKangkongLarge.Name = "rbKangkongLarge";
            this.rbKangkongLarge.Size = new System.Drawing.Size(67, 24);
            this.rbKangkongLarge.TabIndex = 2;
            this.rbKangkongLarge.Text = "Large";
            this.rbKangkongLarge.UseVisualStyleBackColor = true;
            this.rbKangkongLarge.CheckedChanged += new System.EventHandler(this.KangkongSizeRadioButtons_CheckedChanged);
            // 
            // btnAddKangkong
            // 
            this.btnAddKangkong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddKangkong.FlatAppearance.BorderSize = 0;
            this.btnAddKangkong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKangkong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKangkong.ForeColor = System.Drawing.Color.White;
            this.btnAddKangkong.Location = new System.Drawing.Point(395, 56);
            this.btnAddKangkong.Name = "btnAddKangkong";
            this.btnAddKangkong.Size = new System.Drawing.Size(90, 28);
            this.btnAddKangkong.TabIndex = 3;
            this.btnAddKangkong.Text = "Add to Order";
            this.btnAddKangkong.UseVisualStyleBackColor = false;
            this.btnAddKangkong.Click += new System.EventHandler(this.btnAddKangkong_Click);
            // 
            // lblKangkongFloatPrice
            // 
            this.lblKangkongFloatPrice.AutoSize = true;
            this.lblKangkongFloatPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKangkongFloatPrice.Location = new System.Drawing.Point(271, 63);
            this.lblKangkongFloatPrice.Name = "lblKangkongFloatPrice";
            this.lblKangkongFloatPrice.Size = new System.Drawing.Size(92, 20);
            this.lblKangkongFloatPrice.TabIndex = 4;
            this.lblKangkongFloatPrice.Text = "Price: ₱0.00";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(80, 371);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(120, 32);
            this.totalAmountTextBox.TabIndex = 3;
            // 
            // changeTextBox
            // 
            this.changeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextBox.Location = new System.Drawing.Point(91, 447);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(120, 32);
            this.changeTextBox.TabIndex = 7;
            // 
            // cashTextBox
            // 
            this.cashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashTextBox.Location = new System.Drawing.Point(80, 411);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(120, 30);
            this.cashTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cashTextBox, "Enter cash amount up to ₱10,000");
            this.cashTextBox.TextChanged += new System.EventHandler(this.cashTextBox_TextChanged);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.EnableHeadersVisualStyles = false;
            this.dgvOrderItems.GridColor = System.Drawing.Color.LightGray;
            this.dgvOrderItems.Location = new System.Drawing.Point(720, 20);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(350, 300);
            this.dgvOrderItems.TabIndex = 1;
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveSelectedItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(720, 325);
            this.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem";
            this.btnRemoveSelectedItem.Size = new System.Drawing.Size(160, 30);
            this.btnRemoveSelectedItem.TabIndex = 10;
            this.btnRemoveSelectedItem.Text = "Remove Selected Item";
            this.btnRemoveSelectedItem.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedItem.Click += new System.EventHandler(this.btnRemoveSelectedItem_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Location = new System.Drawing.Point(890, 325);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(80, 30);
            this.btnClearOrder.TabIndex = 11;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(30, 400);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 23);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total:";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.Location = new System.Drawing.Point(30, 435);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(52, 23);
            this.labelCash.TabIndex = 4;
            this.labelCash.Text = "Cash:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(30, 470);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(75, 23);
            this.labelChange.TabIndex = 6;
            this.labelChange.Text = "Change:";
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateReceipt.FlatAppearance.BorderSize = 0;
            this.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReceipt.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReceipt.Location = new System.Drawing.Point(11, 485);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(180, 40);
            this.btnGenerateReceipt.TabIndex = 8;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = false;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // receiptTextBox
            // 
            this.receiptTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.receiptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTextBox.Location = new System.Drawing.Point(720, 360);
            this.receiptTextBox.Multiline = true;
            this.receiptTextBox.Name = "receiptTextBox";
            this.receiptTextBox.ReadOnly = true;
            this.receiptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiptTextBox.Size = new System.Drawing.Size(350, 200);
            this.receiptTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnRemoveSelectedItem);
            this.Controls.Add(this.receiptTextBox);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.groupBoxMenuSelection);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMenuSelection.ResumeLayout(false);
            this.groupBoxMenuSelection.PerformLayout();
            this.pnlMangoFloat.ResumeLayout(false);
            this.pnlMangoFloat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMangoFloatQuantity)).EndInit();
            this.groupBoxMangoSizes.ResumeLayout(false);
            this.groupBoxMangoSizes.PerformLayout();
            this.pnlKamoteFloat.ResumeLayout(false);
            this.pnlKamoteFloat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamoteFloatQuantity)).EndInit();
            this.groupBoxKamoteSizes.ResumeLayout(false);
            this.groupBoxKamoteSizes.PerformLayout();
            this.pnlKangkongFloat.ResumeLayout(false);
            this.pnlKangkongFloat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKangkongFloatQuantity)).EndInit();
            this.groupBoxKangkongSizes.ResumeLayout(false);
            this.groupBoxKangkongSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declare all the new controls here
        private System.Windows.Forms.GroupBox groupBoxMenuSelection;

        // Mango Float controls
        private System.Windows.Forms.Panel pnlMangoFloat;
        private System.Windows.Forms.CheckBox cbMangoFloat;
        private System.Windows.Forms.NumericUpDown nudMangoFloatQuantity;
        private System.Windows.Forms.GroupBox groupBoxMangoSizes;
        private System.Windows.Forms.RadioButton rbMangoSmall;
        private System.Windows.Forms.RadioButton rbMangoMedium;
        private System.Windows.Forms.RadioButton rbMangoLarge;
        private System.Windows.Forms.Button btnAddMango;
        private System.Windows.Forms.Label lblMangoFloatPrice;

        // Kamote Float controls
        private System.Windows.Forms.Panel pnlKamoteFloat;
        private System.Windows.Forms.CheckBox cbKamoteFloat;
        private System.Windows.Forms.NumericUpDown nudKamoteFloatQuantity;
        private System.Windows.Forms.GroupBox groupBoxKamoteSizes;
        private System.Windows.Forms.RadioButton rbKamoteSmall;
        private System.Windows.Forms.RadioButton rbKamoteMedium;
        private System.Windows.Forms.RadioButton rbKamoteLarge;
        private System.Windows.Forms.Button btnAddKamote;
        private System.Windows.Forms.Label lblKamoteFloatPrice;

        // Kangkong Float controls
        private System.Windows.Forms.Panel pnlKangkongFloat;
        private System.Windows.Forms.CheckBox cbKangkongFloat;
        private System.Windows.Forms.NumericUpDown nudKangkongFloatQuantity;
        private System.Windows.Forms.GroupBox groupBoxKangkongSizes;
        private System.Windows.Forms.RadioButton rbKangkongSmall;
        private System.Windows.Forms.RadioButton rbKangkongMedium;
        private System.Windows.Forms.RadioButton rbKangkongLarge;
        private System.Windows.Forms.Button btnAddKangkong;
        private System.Windows.Forms.Label lblKangkongFloatPrice;

        // Common controls
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnRemoveSelectedItem;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.TextBox receiptTextBox;
    }
}