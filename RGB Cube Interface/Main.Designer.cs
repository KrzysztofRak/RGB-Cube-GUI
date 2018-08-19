namespace RGB_Cube_Interface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.comboSerialPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupSetColor = new System.Windows.Forms.GroupBox();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.btnRandColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioUpdateDiode = new System.Windows.Forms.RadioButton();
            this.radioUpdateCube = new System.Windows.Forms.RadioButton();
            this.picSelectedColor = new System.Windows.Forms.PictureBox();
            this.pictureColorPicker = new System.Windows.Forms.PictureBox();
            this.groupText = new System.Windows.Forms.GroupBox();
            this.labelTextDelay = new System.Windows.Forms.Label();
            this.sliderTextDelay = new System.Windows.Forms.TrackBar();
            this.picSelectedColor2 = new System.Windows.Forms.PictureBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.groupAnimations = new System.Windows.Forms.GroupBox();
            this.labelAnimationDelay = new System.Windows.Forms.Label();
            this.sliderAnimationDelay = new System.Windows.Forms.TrackBar();
            this.btnSendAnimation = new System.Windows.Forms.Button();
            this.picSelectedColor3 = new System.Windows.Forms.PictureBox();
            this.checkBoxRandomColors = new System.Windows.Forms.CheckBox();
            this.comboAnimation = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioColors = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.radioAnimation = new System.Windows.Forms.RadioButton();
            this.numericLayer = new System.Windows.Forms.NumericUpDown();
            this.radioUpdateLayer = new System.Windows.Forms.RadioButton();
            this.comboAxis = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupSetColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorPicker)).BeginInit();
            this.groupText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTextDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor2)).BeginInit();
            this.groupAnimations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAnimationDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSerialPort
            // 
            this.comboSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSerialPort.FormattingEnabled = true;
            this.comboSerialPort.Location = new System.Drawing.Point(12, 24);
            this.comboSerialPort.Name = "comboSerialPort";
            this.comboSerialPort.Size = new System.Drawing.Size(119, 21);
            this.comboSerialPort.TabIndex = 1;
            this.comboSerialPort.DropDown += new System.EventHandler(this.comboSerialPort_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConnection);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.comboSerialPort);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz port";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.ForeColor = System.Drawing.Color.Gold;
            this.labelConnection.Location = new System.Drawing.Point(4, 54);
            this.labelConnection.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(200, 13);
            this.labelConnection.TabIndex = 11;
            this.labelConnection.Text = "Nie połączono";
            this.labelConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(137, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(60, 21);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupSetColor
            // 
            this.groupSetColor.Controls.Add(this.comboAxis);
            this.groupSetColor.Controls.Add(this.numericLayer);
            this.groupSetColor.Controls.Add(this.radioUpdateLayer);
            this.groupSetColor.Controls.Add(this.numericZ);
            this.groupSetColor.Controls.Add(this.label3);
            this.groupSetColor.Controls.Add(this.numericY);
            this.groupSetColor.Controls.Add(this.label2);
            this.groupSetColor.Controls.Add(this.numericX);
            this.groupSetColor.Controls.Add(this.btnRandColor);
            this.groupSetColor.Controls.Add(this.label1);
            this.groupSetColor.Controls.Add(this.radioUpdateDiode);
            this.groupSetColor.Controls.Add(this.radioUpdateCube);
            this.groupSetColor.Controls.Add(this.picSelectedColor);
            this.groupSetColor.Controls.Add(this.pictureColorPicker);
            this.groupSetColor.ForeColor = System.Drawing.Color.White;
            this.groupSetColor.Location = new System.Drawing.Point(238, 12);
            this.groupSetColor.Name = "groupSetColor";
            this.groupSetColor.Size = new System.Drawing.Size(281, 483);
            this.groupSetColor.TabIndex = 10;
            this.groupSetColor.TabStop = false;
            this.groupSetColor.Text = "Wybierz kolor";
            // 
            // numericZ
            // 
            this.numericZ.Location = new System.Drawing.Point(152, 444);
            this.numericZ.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(28, 20);
            this.numericZ.TabIndex = 22;
            this.numericZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(134, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Z:";
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(100, 444);
            this.numericY.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(28, 20);
            this.numericY.TabIndex = 20;
            this.numericY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(82, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Y:";
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(48, 444);
            this.numericX.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(28, 20);
            this.numericX.TabIndex = 18;
            this.numericX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRandColor
            // 
            this.btnRandColor.ForeColor = System.Drawing.Color.Black;
            this.btnRandColor.Location = new System.Drawing.Point(208, 269);
            this.btnRandColor.Name = "btnRandColor";
            this.btnRandColor.Size = new System.Drawing.Size(60, 25);
            this.btnRandColor.TabIndex = 16;
            this.btnRandColor.Text = "Losuj";
            this.btnRandColor.UseVisualStyleBackColor = true;
            this.btnRandColor.Click += new System.EventHandler(this.btnRandColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "X:";
            // 
            // radioUpdateDiode
            // 
            this.radioUpdateDiode.AutoSize = true;
            this.radioUpdateDiode.Location = new System.Drawing.Point(12, 418);
            this.radioUpdateDiode.Name = "radioUpdateDiode";
            this.radioUpdateDiode.Size = new System.Drawing.Size(124, 17);
            this.radioUpdateDiode.TabIndex = 12;
            this.radioUpdateDiode.Text = "Aktualizuj kolor diody";
            this.radioUpdateDiode.UseVisualStyleBackColor = true;
            // 
            // radioUpdateCube
            // 
            this.radioUpdateCube.AutoSize = true;
            this.radioUpdateCube.Checked = true;
            this.radioUpdateCube.Location = new System.Drawing.Point(12, 313);
            this.radioUpdateCube.Name = "radioUpdateCube";
            this.radioUpdateCube.Size = new System.Drawing.Size(168, 17);
            this.radioUpdateCube.TabIndex = 11;
            this.radioUpdateCube.TabStop = true;
            this.radioUpdateCube.Text = "Aktualizuj kolor całego cube\'a";
            this.radioUpdateCube.UseVisualStyleBackColor = true;
            // 
            // picSelectedColor
            // 
            this.picSelectedColor.BackColor = System.Drawing.Color.Gold;
            this.picSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectedColor.Location = new System.Drawing.Point(12, 269);
            this.picSelectedColor.Name = "picSelectedColor";
            this.picSelectedColor.Size = new System.Drawing.Size(190, 25);
            this.picSelectedColor.TabIndex = 9;
            this.picSelectedColor.TabStop = false;
            // 
            // pictureColorPicker
            // 
            this.pictureColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureColorPicker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureColorPicker.Image = global::RGB_Cube_Interface.Properties.Resources.color_picker1;
            this.pictureColorPicker.Location = new System.Drawing.Point(12, 24);
            this.pictureColorPicker.Name = "pictureColorPicker";
            this.pictureColorPicker.Size = new System.Drawing.Size(256, 239);
            this.pictureColorPicker.TabIndex = 8;
            this.pictureColorPicker.TabStop = false;
            this.pictureColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureRgbPicker_MouseClick);
            // 
            // groupText
            // 
            this.groupText.Controls.Add(this.labelTextDelay);
            this.groupText.Controls.Add(this.sliderTextDelay);
            this.groupText.Controls.Add(this.picSelectedColor2);
            this.groupText.Controls.Add(this.btnSendText);
            this.groupText.Controls.Add(this.textBoxText);
            this.groupText.ForeColor = System.Drawing.Color.White;
            this.groupText.Location = new System.Drawing.Point(12, 381);
            this.groupText.Name = "groupText";
            this.groupText.Size = new System.Drawing.Size(208, 114);
            this.groupText.TabIndex = 12;
            this.groupText.TabStop = false;
            this.groupText.Text = "Wyślij tekst (maks. 128 znaków)";
            // 
            // labelTextDelay
            // 
            this.labelTextDelay.AutoSize = true;
            this.labelTextDelay.Location = new System.Drawing.Point(135, 82);
            this.labelTextDelay.Name = "labelTextDelay";
            this.labelTextDelay.Size = new System.Drawing.Size(41, 13);
            this.labelTextDelay.TabIndex = 16;
            this.labelTextDelay.Text = "100 ms";
            // 
            // sliderTextDelay
            // 
            this.sliderTextDelay.LargeChange = 2;
            this.sliderTextDelay.Location = new System.Drawing.Point(12, 50);
            this.sliderTextDelay.Maximum = 20;
            this.sliderTextDelay.MaximumSize = new System.Drawing.Size(100, 22);
            this.sliderTextDelay.MinimumSize = new System.Drawing.Size(185, 22);
            this.sliderTextDelay.Name = "sliderTextDelay";
            this.sliderTextDelay.Size = new System.Drawing.Size(185, 22);
            this.sliderTextDelay.TabIndex = 15;
            this.sliderTextDelay.Value = 5;
            this.sliderTextDelay.ValueChanged += new System.EventHandler(this.sliderTextDelay_ValueChanged);
            // 
            // picSelectedColor2
            // 
            this.picSelectedColor2.BackColor = System.Drawing.Color.Gold;
            this.picSelectedColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectedColor2.Location = new System.Drawing.Point(176, 78);
            this.picSelectedColor2.Name = "picSelectedColor2";
            this.picSelectedColor2.Size = new System.Drawing.Size(21, 21);
            this.picSelectedColor2.TabIndex = 14;
            this.picSelectedColor2.TabStop = false;
            // 
            // btnSendText
            // 
            this.btnSendText.ForeColor = System.Drawing.Color.Black;
            this.btnSendText.Location = new System.Drawing.Point(12, 78);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(119, 21);
            this.btnSendText.TabIndex = 13;
            this.btnSendText.Text = "Wyślij";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxText.Location = new System.Drawing.Point(12, 24);
            this.textBoxText.MaxLength = 128;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(185, 20);
            this.textBoxText.TabIndex = 12;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // groupAnimations
            // 
            this.groupAnimations.Controls.Add(this.labelAnimationDelay);
            this.groupAnimations.Controls.Add(this.sliderAnimationDelay);
            this.groupAnimations.Controls.Add(this.btnSendAnimation);
            this.groupAnimations.Controls.Add(this.picSelectedColor3);
            this.groupAnimations.Controls.Add(this.checkBoxRandomColors);
            this.groupAnimations.Controls.Add(this.comboAnimation);
            this.groupAnimations.ForeColor = System.Drawing.Color.White;
            this.groupAnimations.Location = new System.Drawing.Point(12, 224);
            this.groupAnimations.Name = "groupAnimations";
            this.groupAnimations.Size = new System.Drawing.Size(208, 142);
            this.groupAnimations.TabIndex = 14;
            this.groupAnimations.TabStop = false;
            this.groupAnimations.Text = "Wybierz animacje";
            // 
            // labelAnimationDelay
            // 
            this.labelAnimationDelay.AutoSize = true;
            this.labelAnimationDelay.Location = new System.Drawing.Point(135, 89);
            this.labelAnimationDelay.Name = "labelAnimationDelay";
            this.labelAnimationDelay.Size = new System.Drawing.Size(41, 13);
            this.labelAnimationDelay.TabIndex = 18;
            this.labelAnimationDelay.Text = "100 ms";
            // 
            // sliderAnimationDelay
            // 
            this.sliderAnimationDelay.LargeChange = 2;
            this.sliderAnimationDelay.Location = new System.Drawing.Point(12, 57);
            this.sliderAnimationDelay.Maximum = 20;
            this.sliderAnimationDelay.MaximumSize = new System.Drawing.Size(100, 22);
            this.sliderAnimationDelay.MinimumSize = new System.Drawing.Size(185, 22);
            this.sliderAnimationDelay.Name = "sliderAnimationDelay";
            this.sliderAnimationDelay.Size = new System.Drawing.Size(185, 22);
            this.sliderAnimationDelay.TabIndex = 17;
            this.sliderAnimationDelay.Value = 5;
            this.sliderAnimationDelay.ValueChanged += new System.EventHandler(this.sliderAnimationDelay_ValueChanged);
            // 
            // btnSendAnimation
            // 
            this.btnSendAnimation.ForeColor = System.Drawing.Color.Black;
            this.btnSendAnimation.Location = new System.Drawing.Point(12, 85);
            this.btnSendAnimation.Name = "btnSendAnimation";
            this.btnSendAnimation.Size = new System.Drawing.Size(119, 21);
            this.btnSendAnimation.TabIndex = 16;
            this.btnSendAnimation.Text = "Wyślij";
            this.btnSendAnimation.UseVisualStyleBackColor = true;
            this.btnSendAnimation.Click += new System.EventHandler(this.btnSendAnimation_Click);
            // 
            // picSelectedColor3
            // 
            this.picSelectedColor3.BackColor = System.Drawing.Color.Gold;
            this.picSelectedColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectedColor3.Location = new System.Drawing.Point(176, 85);
            this.picSelectedColor3.Name = "picSelectedColor3";
            this.picSelectedColor3.Size = new System.Drawing.Size(21, 21);
            this.picSelectedColor3.TabIndex = 15;
            this.picSelectedColor3.TabStop = false;
            // 
            // checkBoxRandomColors
            // 
            this.checkBoxRandomColors.AutoSize = true;
            this.checkBoxRandomColors.Location = new System.Drawing.Point(12, 112);
            this.checkBoxRandomColors.Name = "checkBoxRandomColors";
            this.checkBoxRandomColors.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRandomColors.TabIndex = 3;
            this.checkBoxRandomColors.Text = "Losowe kolory";
            this.checkBoxRandomColors.UseVisualStyleBackColor = true;
            // 
            // comboAnimation
            // 
            this.comboAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnimation.FormattingEnabled = true;
            this.comboAnimation.Location = new System.Drawing.Point(12, 30);
            this.comboAnimation.Name = "comboAnimation";
            this.comboAnimation.Size = new System.Drawing.Size(185, 21);
            this.comboAnimation.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioColors);
            this.groupBox5.Controls.Add(this.radioText);
            this.groupBox5.Controls.Add(this.radioAnimation);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 119);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menu";
            // 
            // radioColors
            // 
            this.radioColors.AutoSize = true;
            this.radioColors.Checked = true;
            this.radioColors.Location = new System.Drawing.Point(12, 89);
            this.radioColors.Name = "radioColors";
            this.radioColors.Size = new System.Drawing.Size(81, 17);
            this.radioColors.TabIndex = 2;
            this.radioColors.TabStop = true;
            this.radioColors.Text = "Ustaw kolor";
            this.radioColors.UseVisualStyleBackColor = true;
            this.radioColors.CheckedChanged += new System.EventHandler(this.radioColors_CheckedChanged);
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Location = new System.Drawing.Point(12, 56);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(78, 17);
            this.radioText.TabIndex = 1;
            this.radioText.TabStop = true;
            this.radioText.Text = "Wyślij tekst";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.CheckedChanged += new System.EventHandler(this.radioText_CheckedChanged);
            // 
            // radioAnimation
            // 
            this.radioAnimation.AutoSize = true;
            this.radioAnimation.Location = new System.Drawing.Point(12, 24);
            this.radioAnimation.Name = "radioAnimation";
            this.radioAnimation.Size = new System.Drawing.Size(108, 17);
            this.radioAnimation.TabIndex = 0;
            this.radioAnimation.TabStop = true;
            this.radioAnimation.Text = "Wybierz animacje";
            this.radioAnimation.UseVisualStyleBackColor = true;
            this.radioAnimation.CheckedChanged += new System.EventHandler(this.radioAnimation_CheckedChanged);
            // 
            // numericLayer
            // 
            this.numericLayer.Location = new System.Drawing.Point(100, 383);
            this.numericLayer.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericLayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLayer.Name = "numericLayer";
            this.numericLayer.Size = new System.Drawing.Size(28, 20);
            this.numericLayer.TabIndex = 25;
            this.numericLayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericLayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioUpdateLayer
            // 
            this.radioUpdateLayer.AutoSize = true;
            this.radioUpdateLayer.Location = new System.Drawing.Point(12, 359);
            this.radioUpdateLayer.Name = "radioUpdateLayer";
            this.radioUpdateLayer.Size = new System.Drawing.Size(137, 17);
            this.radioUpdateLayer.TabIndex = 23;
            this.radioUpdateLayer.Text = "Aktualizuj kolor warstwy";
            this.radioUpdateLayer.UseVisualStyleBackColor = true;
            // 
            // comboAxis
            // 
            this.comboAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAxis.FormattingEnabled = true;
            this.comboAxis.Items.AddRange(new object[] {
            "Oś X",
            "Oś Y",
            "Oś Z"});
            this.comboAxis.Location = new System.Drawing.Point(33, 382);
            this.comboAxis.Name = "comboAxis";
            this.comboAxis.Size = new System.Drawing.Size(61, 21);
            this.comboAxis.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(531, 510);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupAnimations);
            this.Controls.Add(this.groupText);
            this.Controls.Add(this.groupSetColor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "RGB Cube GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSetColor.ResumeLayout(false);
            this.groupSetColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorPicker)).EndInit();
            this.groupText.ResumeLayout(false);
            this.groupText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTextDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor2)).EndInit();
            this.groupAnimations.ResumeLayout(false);
            this.groupAnimations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAnimationDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboSerialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupSetColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioUpdateDiode;
        private System.Windows.Forms.RadioButton radioUpdateCube;
        private System.Windows.Forms.PictureBox picSelectedColor;
        private System.Windows.Forms.PictureBox pictureColorPicker;
        private System.Windows.Forms.Button btnRandColor;
        private System.Windows.Forms.GroupBox groupText;
        private System.Windows.Forms.PictureBox picSelectedColor2;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.GroupBox groupAnimations;
        private System.Windows.Forms.ComboBox comboAnimation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioColors;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.RadioButton radioAnimation;
        private System.Windows.Forms.TrackBar sliderTextDelay;
        private System.Windows.Forms.Label labelTextDelay;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRandomColors;
        private System.Windows.Forms.PictureBox picSelectedColor3;
        private System.Windows.Forms.Button btnSendAnimation;
        private System.Windows.Forms.TrackBar sliderAnimationDelay;
        private System.Windows.Forms.Label labelAnimationDelay;
        private System.Windows.Forms.NumericUpDown numericLayer;
        private System.Windows.Forms.RadioButton radioUpdateLayer;
        private System.Windows.Forms.ComboBox comboAxis;
    }
}

