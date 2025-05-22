namespace Lab7CSharp
{
    partial class Form2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.pictureBoxColorSample = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSample)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.titleLabel.Location = new System.Drawing.Point(10, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(180, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Інструмент піпетка";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            this.btnLoad.Font = new System.Drawing.Font("Garamond", 10F);
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnLoad.Location = new System.Drawing.Point(10, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(180, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Завантажити зображення";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            this.btnSave.Font = new System.Drawing.Font("Garamond", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnSave.Location = new System.Drawing.Point(10, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Зберегти зображення";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(200, 50);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(450, 350);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 3;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseClick);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.labelHex);
            this.colorGroupBox.Controls.Add(this.labelB);
            this.colorGroupBox.Controls.Add(this.labelG);
            this.colorGroupBox.Controls.Add(this.labelR);
            this.colorGroupBox.Controls.Add(this.pictureBoxColorSample);
            this.colorGroupBox.Font = new System.Drawing.Font("Garamond", 10F);
            this.colorGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.colorGroupBox.Location = new System.Drawing.Point(10, 140);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(180, 300);
            this.colorGroupBox.TabIndex = 4;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Інформація про колір";
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.labelHex.Location = new System.Drawing.Point(20, 240);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(117, 20);
            this.labelHex.TabIndex = 4;
            this.labelHex.Text = "Hex: #FFFFFF";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelB.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelB.Location = new System.Drawing.Point(20, 210);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(63, 20);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B: 255";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelG.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelG.Location = new System.Drawing.Point(20, 180);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(63, 20);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "G: 255";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelR.ForeColor = System.Drawing.Color.DarkRed;
            this.labelR.Location = new System.Drawing.Point(20, 150);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(63, 20);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "R: 255";
            // 
            // pictureBoxColorSample
            // 
            this.pictureBoxColorSample.BackColor = System.Drawing.Color.White;
            this.pictureBoxColorSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorSample.Location = new System.Drawing.Point(40, 30);
            this.pictureBoxColorSample.Name = "pictureBoxColorSample";
            this.pictureBoxColorSample.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxColorSample.TabIndex = 0;
            this.pictureBoxColorSample.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файли зображень|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Всі файли|*.*";
            this.openFileDialog.Title = "Виберіть зображення";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "jpg";
            this.saveFileDialog.Filter = "Файли JPEG|*.jpg|Файли PNG|*.png|Файли BMP|*.bmp|Всі файли|*.*";
            this.saveFileDialog.Title = "Зберегти зображення як";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Інструмент піпетка - Lab 7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.PictureBox pictureBoxColorSample;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}