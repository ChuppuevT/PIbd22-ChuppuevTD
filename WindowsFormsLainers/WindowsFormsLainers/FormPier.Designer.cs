namespace WindowsFormsLainers
{
    partial class FormPier
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
            this.pictureBoxPier = new System.Windows.Forms.PictureBox();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.buttonSetLainer = new System.Windows.Forms.Button();
            this.groupBoxShip = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).BeginInit();
            this.groupBoxShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPier
            // 
            this.pictureBoxPier.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxPier.Name = "pictureBoxPier";
            this.pictureBoxPier.Size = new System.Drawing.Size(744, 460);
            this.pictureBoxPier.TabIndex = 0;
            this.pictureBoxPier.TabStop = false;
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(760, 30);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(115, 47);
            this.buttonSetShip.TabIndex = 1;
            this.buttonSetShip.Text = "Поставить корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // buttonSetLainer
            // 
            this.buttonSetLainer.Location = new System.Drawing.Point(760, 92);
            this.buttonSetLainer.Name = "buttonSetLainer";
            this.buttonSetLainer.Size = new System.Drawing.Size(115, 47);
            this.buttonSetLainer.TabIndex = 2;
            this.buttonSetLainer.Text = "Поставить лайнер";
            this.buttonSetLainer.UseVisualStyleBackColor = true;
            this.buttonSetLainer.Click += new System.EventHandler(this.buttonSetLainer_Click);
            // 
            // groupBoxShip
            // 
            this.groupBoxShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxShip.Controls.Add(this.pictureBoxTakeShip);
            this.groupBoxShip.Controls.Add(this.maskedTextBox);
            this.groupBoxShip.Controls.Add(this.label);
            this.groupBoxShip.Location = new System.Drawing.Point(755, 290);
            this.groupBoxShip.Name = "groupBoxShip";
            this.groupBoxShip.Size = new System.Drawing.Size(120, 160);
            this.groupBoxShip.TabIndex = 3;
            this.groupBoxShip.TabStop = false;
            this.groupBoxShip.Text = "Забрать судно";
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(11, 80);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(109, 80);
            this.pictureBoxTakeShip.TabIndex = 2;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(55, 19);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 0;
            this.label.Text = "место";
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(26, 52);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.groupBoxShip);
            this.Controls.Add(this.buttonSetLainer);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.pictureBoxPier);
            this.Name = "FormPier";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).EndInit();
            this.groupBoxShip.ResumeLayout(false);
            this.groupBoxShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPier;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Button buttonSetLainer;
        private System.Windows.Forms.GroupBox groupBoxShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
    }
}