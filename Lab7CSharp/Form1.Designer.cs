namespace Lab7CSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.centerButton = new System.Windows.Forms.Button();
            this.rotatingPanel = new System.Windows.Forms.Panel();
            this.controlButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(175, 148);
            this.centerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 32);
            this.centerButton.TabIndex = 0;
            this.centerButton.Text = "Центр";
            this.centerButton.UseVisualStyleBackColor = true;
            // 
            // rotatingPanel
            // 
            this.rotatingPanel.BackColor = System.Drawing.Color.Orange;
            this.rotatingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rotatingPanel.Location = new System.Drawing.Point(282, 148);
            this.rotatingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotatingPanel.Name = "rotatingPanel";
            this.rotatingPanel.Size = new System.Drawing.Size(60, 41);
            this.rotatingPanel.TabIndex = 1;
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(126, 279);
            this.controlButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(75, 24);
            this.controlButton.TabIndex = 2;
            this.controlButton.Text = "Старт/Стоп";
            this.controlButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(220, 279);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 24);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрити";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.LightGreen;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Blue;
            this.titleLabel.Location = new System.Drawing.Point(171, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(96, 22);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Lab 7. C#";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 368);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.rotatingPanel);
            this.Controls.Add(this.centerButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab 7. C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Panel rotatingPanel;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer animationTimer;
    }
}