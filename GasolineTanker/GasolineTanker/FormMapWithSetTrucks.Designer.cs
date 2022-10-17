namespace GasolineTanker
{
    partial class FormMapWithSetTrucks
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
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonShowStorage = new System.Windows.Forms.Button();
            this.buttonRemoveTruck = new System.Windows.Forms.Button();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.buttonShowOnMap);
            this.groupBoxTool.Controls.Add(this.buttonLeft);
            this.groupBoxTool.Controls.Add(this.buttonRight);
            this.groupBoxTool.Controls.Add(this.buttonDown);
            this.groupBoxTool.Controls.Add(this.buttonUp);
            this.groupBoxTool.Controls.Add(this.buttonShowStorage);
            this.groupBoxTool.Controls.Add(this.buttonRemoveTruck);
            this.groupBoxTool.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxTool.Controls.Add(this.buttonAddTruck);
            this.groupBoxTool.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTool.Location = new System.Drawing.Point(962, 0);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(220, 753);
            this.groupBoxTool.TabIndex = 0;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "Инструменты";
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(10, 510);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(200, 30);
            this.buttonShowOnMap.TabIndex = 9;
            this.buttonShowOnMap.Text = "Посмотреть карту";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(50, 700);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(140, 700);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(95, 700);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(95, 655);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonShowStorage
            // 
            this.buttonShowStorage.Location = new System.Drawing.Point(10, 398);
            this.buttonShowStorage.Name = "buttonShowStorage";
            this.buttonShowStorage.Size = new System.Drawing.Size(200, 30);
            this.buttonShowStorage.TabIndex = 4;
            this.buttonShowStorage.Text = "Посмотреть хранилище";
            this.buttonShowStorage.UseVisualStyleBackColor = true;
            this.buttonShowStorage.Click += new System.EventHandler(this.ButtonShowStorage_Click);
            // 
            // buttonRemoveTruck
            // 
            this.buttonRemoveTruck.Location = new System.Drawing.Point(10, 350);
            this.buttonRemoveTruck.Name = "buttonRemoveTruck";
            this.buttonRemoveTruck.Size = new System.Drawing.Size(200, 30);
            this.buttonRemoveTruck.TabIndex = 3;
            this.buttonRemoveTruck.Text = "Удалить грузовик";
            this.buttonRemoveTruck.UseVisualStyleBackColor = true;
            this.buttonRemoveTruck.Click += new System.EventHandler(this.ButtonRemoveTruck_Click);
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(10, 317);
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(200, 27);
            this.maskedTextBoxPosition.TabIndex = 2;
            this.maskedTextBoxPosition.Text = "_";
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Location = new System.Drawing.Point(10, 281);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(200, 30);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Добавить грузовик";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.ButtonAddTruck_Click);
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта",
            "Нефтехранилище"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(10, 35);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSelectorMap.TabIndex = 0;
            this.comboBoxSelectorMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectorMap_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(962, 753);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // FormMapWithSetTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxTool);
            this.Name = "FormMapWithSetTrucks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта с набором объектов";
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxTool;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonUp;
        private Button buttonShowStorage;
        private Button buttonRemoveTruck;
        private MaskedTextBox maskedTextBoxPosition;
        private Button buttonAddTruck;
        private ComboBox comboBoxSelectorMap;
        private PictureBox pictureBox;
        private Button buttonShowOnMap;
    }
}