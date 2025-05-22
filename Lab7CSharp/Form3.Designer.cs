namespace Lab7CSharp
{
    partial class Form3
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.listBoxFigures = new System.Windows.Forms.ListBox();
            this.labelFigures = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = false;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(760, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Лабораторна робота 7 - Малювання геометричних фігур";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 65);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(550, 450);
            this.pictureBoxCanvas.TabIndex = 1;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.labelInfo);
            this.controlPanel.Controls.Add(this.labelCount);
            this.controlPanel.Controls.Add(this.numericUpDownCount);
            this.controlPanel.Controls.Add(this.labelFigures);
            this.controlPanel.Controls.Add(this.listBoxFigures);
            this.controlPanel.Controls.Add(this.btnMove);
            this.controlPanel.Controls.Add(this.btnClear);
            this.controlPanel.Controls.Add(this.btnGenerate);
            this.controlPanel.Location = new System.Drawing.Point(580, 65);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 450);
            this.controlPanel.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(15, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 35);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Генерувати фігури";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(15, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистити полотно";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(15, 150);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(170, 35);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Перемістити фігури";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // listBoxFigures
            // 
            this.listBoxFigures.Font = new System.Drawing.Font("Consolas", 8F);
            this.listBoxFigures.FormattingEnabled = true;
            this.listBoxFigures.ItemHeight = 13;
            this.listBoxFigures.Location = new System.Drawing.Point(15, 220);
            this.listBoxFigures.Name = "listBoxFigures";
            this.listBoxFigures.Size = new System.Drawing.Size(170, 160);
            this.listBoxFigures.TabIndex = 3;
            this.listBoxFigures.SelectedIndexChanged += new System.EventHandler(this.listBoxFigures_SelectedIndexChanged);
            // 
            // labelFigures
            // 
            this.labelFigures.AutoSize = true;
            this.labelFigures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFigures.Location = new System.Drawing.Point(15, 200);
            this.labelFigures.Name = "labelFigures";
            this.labelFigures.Size = new System.Drawing.Size(102, 15);
            this.labelFigures.TabIndex = 4;
            this.labelFigures.Text = "Список фігур:";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownCount.Location = new System.Drawing.Point(130, 20);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(55, 25);
            this.numericUpDownCount.TabIndex = 5;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCount.Location = new System.Drawing.Point(15, 25);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(109, 15);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "Кількість фігур:";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelInfo.Location = new System.Drawing.Point(15, 390);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(170, 50);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Клікніть на фігуру для вибору";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 7 - Малювання фігур";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListBox listBoxFigures;
        private System.Windows.Forms.Label labelFigures;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelInfo;
    }
}