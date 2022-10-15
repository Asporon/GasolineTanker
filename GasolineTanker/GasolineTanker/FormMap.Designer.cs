namespace GasolineTanker
{
    partial class FormMap
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBodyColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.buttonCreateModif = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSpeed,
            this.toolStripStatusLabelWeight,
            this.toolStripStatusLabelBodyColor});
            this.statusStrip.Location = new System.Drawing.Point(0, 427);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(882, 26);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabelSpeed.Text = "Скорость:";
            // 
            // toolStripStatusLabelWeight
            // 
            this.toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            this.toolStripStatusLabelWeight.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabelWeight.Text = "Вес:";
            // 
            // toolStripStatusLabelBodyColor
            // 
            this.toolStripStatusLabelBodyColor.Name = "toolStripStatusLabelBodyColor";
            this.toolStripStatusLabelBodyColor.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabelBodyColor.Text = "Цвет:";
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTruck.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(882, 427);
            this.pictureBoxTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTruck.TabIndex = 1;
            this.pictureBoxTruck.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Location = new System.Drawing.Point(12, 385);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 30);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(804, 349);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(768, 385);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(840, 385);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::GasolineTanker.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(804, 385);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта",
            "Нефтехранилище"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSelectorMap.TabIndex = 7;
            this.comboBoxSelectorMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectorMap_SelectedIndexChanged);
            // 
            // buttonCreateModif
            // 
            this.buttonCreateModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateModif.Location = new System.Drawing.Point(128, 385);
            this.buttonCreateModif.Name = "buttonCreateModif";
            this.buttonCreateModif.Size = new System.Drawing.Size(150, 30);
            this.buttonCreateModif.TabIndex = 8;
            this.buttonCreateModif.Text = "Модифицировать";
            this.buttonCreateModif.UseVisualStyleBackColor = true;
            this.buttonCreateModif.Click += new System.EventHandler(this.ButtonCreateModif_Click);
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateModif);
            this.Controls.Add(this.comboBoxSelectorMap);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxTruck);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelSpeed;
        private ToolStripStatusLabel toolStripStatusLabelWeight;
        private ToolStripStatusLabel toolStripStatusLabelBodyColor;
        private PictureBox pictureBoxTruck;
        private Button buttonCreate;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonDown;
        private ComboBox comboBoxSelectorMap;
        private Button buttonCreateModif;
    }
}