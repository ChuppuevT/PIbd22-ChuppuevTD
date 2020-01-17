namespace WindowsFormsLainers
{
    partial class FormShipConfig
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
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLainer = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelShip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShip.Location = new System.Drawing.Point(27, 23);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(140, 78);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLainer);
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип судна";
            // 
            // labelLainer
            // 
            this.labelLainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLainer.Location = new System.Drawing.Point(6, 71);
            this.labelLainer.Name = "labelLainer";
            this.labelLainer.Size = new System.Drawing.Size(95, 34);
            this.labelLainer.TabIndex = 3;
            this.labelLainer.Text = "Лайнер";
            this.labelLainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLainer_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(6, 27);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(95, 34);
            this.labelShip.TabIndex = 2;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Controls.Add(this.labelBaseColor);
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(217, 35);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(197, 243);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(36, 167);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(123, 37);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(36, 119);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(123, 37);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(446, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.Location = new System.Drawing.Point(77, 184);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(39, 35);
            this.panelGold.TabIndex = 7;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(17, 184);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(39, 35);
            this.panelGray.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(77, 133);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(39, 35);
            this.panelYellow.TabIndex = 5;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(17, 133);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(39, 35);
            this.panelRed.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(77, 82);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(39, 35);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(17, 82);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(39, 35);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(77, 32);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(39, 35);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(17, 32);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(39, 35);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(29, 219);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(82, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormShipConfig";
            this.Text = "FormShipConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Label labelLainer;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}