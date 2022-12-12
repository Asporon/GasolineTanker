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
            this.groupBoxMaps = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.textBoxNewMapName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonShowStorage = new System.Windows.Forms.Button();
            this.buttonRemoveTruck = new System.Windows.Forms.Button();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSortByType = new System.Windows.Forms.Button();
            this.buttonSortByColor = new System.Windows.Forms.Button();
            this.groupBoxTool.SuspendLayout();
            this.groupBoxMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.buttonSortByColor);
            this.groupBoxTool.Controls.Add(this.buttonSortByType);
            this.groupBoxTool.Controls.Add(this.groupBoxMaps);
            this.groupBoxTool.Controls.Add(this.buttonShowOnMap);
            this.groupBoxTool.Controls.Add(this.buttonLeft);
            this.groupBoxTool.Controls.Add(this.buttonRight);
            this.groupBoxTool.Controls.Add(this.buttonDown);
            this.groupBoxTool.Controls.Add(this.buttonUp);
            this.groupBoxTool.Controls.Add(this.buttonShowStorage);
            this.groupBoxTool.Controls.Add(this.buttonRemoveTruck);
            this.groupBoxTool.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxTool.Controls.Add(this.buttonAddTruck);
            this.groupBoxTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTool.Location = new System.Drawing.Point(962, 28);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(220, 725);
            this.groupBoxTool.TabIndex = 0;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "Инструменты";
            // 
            // groupBoxMaps
            // 
            this.groupBoxMaps.Controls.Add(this.buttonDeleteMap);
            this.groupBoxMaps.Controls.Add(this.listBoxMaps);
            this.groupBoxMaps.Controls.Add(this.buttonAddMap);
            this.groupBoxMaps.Controls.Add(this.textBoxNewMapName);
            this.groupBoxMaps.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxMaps.Location = new System.Drawing.Point(6, 26);
            this.groupBoxMaps.Name = "groupBoxMaps";
            this.groupBoxMaps.Size = new System.Drawing.Size(210, 294);
            this.groupBoxMaps.TabIndex = 10;
            this.groupBoxMaps.TabStop = false;
            this.groupBoxMaps.Text = "Карты";
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Location = new System.Drawing.Point(5, 256);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(200, 30);
            this.buttonDeleteMap.TabIndex = 13;
            this.buttonDeleteMap.Text = "Удалить карту";
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.ButtonDeleteMap_Click);
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 20;
            this.listBoxMaps.Location = new System.Drawing.Point(6, 146);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(200, 104);
            this.listBoxMaps.TabIndex = 12;
            this.listBoxMaps.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaps_SelectedIndexChanged);
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Location = new System.Drawing.Point(5, 110);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(200, 30);
            this.buttonAddMap.TabIndex = 11;
            this.buttonAddMap.Text = "Добавить карту";
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.ButtonAddMap_Click);
            // 
            // textBoxNewMapName
            // 
            this.textBoxNewMapName.Location = new System.Drawing.Point(5, 28);
            this.textBoxNewMapName.Name = "textBoxNewMapName";
            this.textBoxNewMapName.Size = new System.Drawing.Size(200, 27);
            this.textBoxNewMapName.TabIndex = 1;
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта",
            "Нефтехранилище"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(5, 61);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSelectorMap.TabIndex = 0;
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(12, 582);
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
            this.buttonLeft.Location = new System.Drawing.Point(48, 672);
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
            this.buttonRight.Location = new System.Drawing.Point(140, 672);
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
            this.buttonDown.Location = new System.Drawing.Point(94, 672);
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
            this.buttonUp.Location = new System.Drawing.Point(95, 627);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonShowStorage
            // 
            this.buttonShowStorage.Location = new System.Drawing.Point(12, 531);
            this.buttonShowStorage.Name = "buttonShowStorage";
            this.buttonShowStorage.Size = new System.Drawing.Size(200, 30);
            this.buttonShowStorage.TabIndex = 4;
            this.buttonShowStorage.Text = "Посмотреть хранилище";
            this.buttonShowStorage.UseVisualStyleBackColor = true;
            this.buttonShowStorage.Click += new System.EventHandler(this.ButtonShowStorage_Click);
            // 
            // buttonRemoveTruck
            // 
            this.buttonRemoveTruck.Location = new System.Drawing.Point(12, 483);
            this.buttonRemoveTruck.Name = "buttonRemoveTruck";
            this.buttonRemoveTruck.Size = new System.Drawing.Size(200, 30);
            this.buttonRemoveTruck.TabIndex = 3;
            this.buttonRemoveTruck.Text = "Удалить грузовик";
            this.buttonRemoveTruck.UseVisualStyleBackColor = true;
            this.buttonRemoveTruck.Click += new System.EventHandler(this.ButtonRemoveTruck_Click);
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(12, 450);
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(200, 27);
            this.maskedTextBoxPosition.TabIndex = 2;
            this.maskedTextBoxPosition.Text = "_";
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Location = new System.Drawing.Point(12, 414);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(200, 30);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Добавить грузовик";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.ButtonAddTruck_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(962, 725);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.SaveToolStripMenuItem.Text = "Сохранение";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.LoadToolStripMenuItem.Text = "Загрузка";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSortByType
            // 
            this.buttonSortByType.Location = new System.Drawing.Point(12, 335);
            this.buttonSortByType.Name = "buttonSortByType";
            this.buttonSortByType.Size = new System.Drawing.Size(196, 29);
            this.buttonSortByType.TabIndex = 11;
            this.buttonSortByType.Text = "Сортировать по типу";
            this.buttonSortByType.UseVisualStyleBackColor = true;
            this.buttonSortByType.Click += new System.EventHandler(this.ButtonSortByType_Click);
            // 
            // buttonSortByColor
            // 
            this.buttonSortByColor.Location = new System.Drawing.Point(12, 370);
            this.buttonSortByColor.Name = "buttonSortByColor";
            this.buttonSortByColor.Size = new System.Drawing.Size(200, 29);
            this.buttonSortByColor.TabIndex = 12;
            this.buttonSortByColor.Text = "Сортировать по цвету";
            this.buttonSortByColor.UseVisualStyleBackColor = true;
            this.buttonSortByColor.Click += new System.EventHandler(this.ButtonSortByColor_Click);
            // 
            // FormMapWithSetTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxTool);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMapWithSetTrucks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта с набором объектов";
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            this.groupBoxMaps.ResumeLayout(false);
            this.groupBoxMaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox groupBoxMaps;
        private Button buttonDeleteMap;
        private ListBox listBoxMaps;
        private Button buttonAddMap;
        private TextBox textBoxNewMapName;
        private MenuStrip menuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button buttonSortByColor;
        private Button buttonSortByType;
    }
}