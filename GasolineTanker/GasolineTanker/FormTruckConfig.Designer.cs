namespace GasolineTanker
{
    partial class FormTruckConfig
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
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelSimpleObject = new System.Windows.Forms.Label();
            this.labelModifiedObject = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.checkBoxFlasher = new System.Windows.Forms.CheckBox();
            this.checkBoxCistern = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.panelObject = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.panelObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelSimpleObject);
            this.groupBoxConfig.Controls.Add(this.labelModifiedObject);
            this.groupBoxConfig.Controls.Add(this.groupBoxColors);
            this.groupBoxConfig.Controls.Add(this.checkBoxFlasher);
            this.groupBoxConfig.Controls.Add(this.checkBoxCistern);
            this.groupBoxConfig.Controls.Add(this.numericUpDownWeight);
            this.groupBoxConfig.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxConfig.Controls.Add(this.labelSpeed);
            this.groupBoxConfig.Controls.Add(this.labelWeight);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(568, 268);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Параметры";
            // 
            // labelSimpleObject
            // 
            this.labelSimpleObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimpleObject.Location = new System.Drawing.Point(293, 206);
            this.labelSimpleObject.Name = "labelSimpleObject";
            this.labelSimpleObject.Size = new System.Drawing.Size(110, 50);
            this.labelSimpleObject.TabIndex = 0;
            this.labelSimpleObject.Text = "Простой";
            this.labelSimpleObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSimpleObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // labelModifiedObject
            // 
            this.labelModifiedObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModifiedObject.Location = new System.Drawing.Point(423, 206);
            this.labelModifiedObject.Name = "labelModifiedObject";
            this.labelModifiedObject.Size = new System.Drawing.Size(110, 50);
            this.labelModifiedObject.TabIndex = 1;
            this.labelModifiedObject.Text = "Продвинутый";
            this.labelModifiedObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelModifiedObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(278, 26);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(271, 164);
            this.groupBoxColors.TabIndex = 6;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(210, 97);
            this.panelPurple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(45, 55);
            this.panelPurple.TabIndex = 0;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(80, 97);
            this.panelGray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(45, 55);
            this.panelGray.TabIndex = 0;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(145, 97);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(45, 55);
            this.panelBlack.TabIndex = 0;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(15, 97);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(45, 55);
            this.panelWhite.TabIndex = 0;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(145, 27);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(45, 55);
            this.panelBlue.TabIndex = 0;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(80, 27);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(45, 55);
            this.panelGreen.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(210, 27);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(45, 55);
            this.panelYellow.TabIndex = 0;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(15, 27);
            this.panelRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(45, 55);
            this.panelRed.TabIndex = 1;
            // 
            // checkBoxFlasher
            // 
            this.checkBoxFlasher.AutoSize = true;
            this.checkBoxFlasher.Location = new System.Drawing.Point(22, 166);
            this.checkBoxFlasher.Name = "checkBoxFlasher";
            this.checkBoxFlasher.Size = new System.Drawing.Size(230, 24);
            this.checkBoxFlasher.TabIndex = 5;
            this.checkBoxFlasher.Text = "Наличие сигнального маяка";
            this.checkBoxFlasher.UseVisualStyleBackColor = true;
            // 
            // checkBoxCistern
            // 
            this.checkBoxCistern.AutoSize = true;
            this.checkBoxCistern.Location = new System.Drawing.Point(22, 136);
            this.checkBoxCistern.Name = "checkBoxCistern";
            this.checkBoxCistern.Size = new System.Drawing.Size(220, 24);
            this.checkBoxCistern.TabIndex = 4;
            this.checkBoxCistern.Text = "Наличие бака под топливо";
            this.checkBoxCistern.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(104, 81);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(90, 27);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(104, 43);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(90, 27);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(22, 45);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(76, 20);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Скорость:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(62, 83);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(36, 20);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес:";
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(17, 70);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(250, 150);
            this.pictureBoxObject.TabIndex = 1;
            this.pictureBoxObject.TabStop = false;
            // 
            // panelObject
            // 
            this.panelObject.AllowDrop = true;
            this.panelObject.Controls.Add(this.labelDopColor);
            this.panelObject.Controls.Add(this.labelBaseColor);
            this.panelObject.Controls.Add(this.pictureBoxObject);
            this.panelObject.Location = new System.Drawing.Point(598, 23);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(284, 234);
            this.panelObject.TabIndex = 7;
            this.panelObject.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelObject_DragDrop);
            this.panelObject.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelObject_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(152, 15);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(115, 40);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(17, 15);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(115, 40);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(615, 264);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(115, 30);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(750, 264);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 303);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "FormTruckConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание объекта";
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxConfig;
        private CheckBox checkBoxFlasher;
        private CheckBox checkBoxCistern;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private Label labelWeight;
        private GroupBox groupBoxColors;
        private Label labelSimpleObject;
        private Label labelModifiedObject;
        private Panel panelPurple;
        private Panel panelGray;
        private Panel panelBlack;
        private Panel panelWhite;
        private Panel panelBlue;
        private Panel panelGreen;
        private Panel panelYellow;
        private Panel panelRed;
        private PictureBox pictureBoxObject;
        private Panel panelObject;
        private Label labelDopColor;
        private Label labelBaseColor;
        private Button buttonOK;
        private Button buttonCancel;
    }
}