
namespace GraphicsPackage
{
    partial class Home
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.ddaBtn = new System.Windows.Forms.Button();
            this.bresenhamLineBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(308, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(138, 38);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(308, 69);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(147, 20);
            this.chooseLabel.TabIndex = 1;
            this.chooseLabel.Text = "Choose an algorithm";
            // 
            // ddaBtn
            // 
            this.ddaBtn.Location = new System.Drawing.Point(308, 126);
            this.ddaBtn.Name = "ddaBtn";
            this.ddaBtn.Size = new System.Drawing.Size(138, 29);
            this.ddaBtn.TabIndex = 2;
            this.ddaBtn.Text = "DDA Algorithm";
            this.ddaBtn.UseVisualStyleBackColor = true;
            // 
            // bresenhamLineBtn
            // 
            this.bresenhamLineBtn.Location = new System.Drawing.Point(308, 194);
            this.bresenhamLineBtn.Name = "bresenhamLineBtn";
            this.bresenhamLineBtn.Size = new System.Drawing.Size(138, 29);
            this.bresenhamLineBtn.TabIndex = 3;
            this.bresenhamLineBtn.Text = "Bresenham Line";
            this.bresenhamLineBtn.UseVisualStyleBackColor = true;
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(308, 257);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(138, 29);
            this.ellipseBtn.TabIndex = 4;
            this.ellipseBtn.Text = "Ellipse Algorithm";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(308, 325);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(138, 29);
            this.circleBtn.TabIndex = 5;
            this.circleBtn.Text = "Circle Algorithm";
            this.circleBtn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.bresenhamLineBtn);
            this.Controls.Add(this.ddaBtn);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button ddaBtn;
        private System.Windows.Forms.Button bresenhamLineBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button circleBtn;
    }
}