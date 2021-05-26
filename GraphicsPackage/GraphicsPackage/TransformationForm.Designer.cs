
namespace GraphicsPackage
{
    partial class TransformationForm
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
            this.picToDraw = new System.Windows.Forms.PictureBox();
            this.transformationLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.translationXTB = new System.Windows.Forms.TextBox();
            this.reflectLabel = new System.Windows.Forms.Label();
            this.reflectTB = new System.Windows.Forms.TextBox();
            this.translationYTB = new System.Windows.Forms.TextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scaleXTB = new System.Windows.Forms.TextBox();
            this.scaleYTB = new System.Windows.Forms.TextBox();
            this.shearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picToDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picToDraw
            // 
            this.picToDraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.picToDraw.Location = new System.Drawing.Point(715, 3);
            this.picToDraw.Name = "picToDraw";
            this.picToDraw.Size = new System.Drawing.Size(899, 568);
            this.picToDraw.TabIndex = 1;
            this.picToDraw.TabStop = false;
            // 
            // transformationLabel
            // 
            this.transformationLabel.AutoSize = true;
            this.transformationLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transformationLabel.Location = new System.Drawing.Point(214, 9);
            this.transformationLabel.Name = "transformationLabel";
            this.transformationLabel.Size = new System.Drawing.Size(264, 38);
            this.transformationLabel.TabIndex = 2;
            this.transformationLabel.Text = "2D Transformation";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 520);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 29);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(278, 520);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(553, 520);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(94, 29);
            this.drawBtn.TabIndex = 13;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Location = new System.Drawing.Point(12, 84);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(84, 20);
            this.translationLabel.TabIndex = 14;
            this.translationLabel.Text = "Translation:";
            // 
            // translationXTB
            // 
            this.translationXTB.Location = new System.Drawing.Point(103, 84);
            this.translationXTB.MaxLength = 4;
            this.translationXTB.Name = "translationXTB";
            this.translationXTB.Size = new System.Drawing.Size(125, 27);
            this.translationXTB.TabIndex = 15;
            this.translationXTB.Text = "dx";
            // 
            // reflectLabel
            // 
            this.reflectLabel.AutoSize = true;
            this.reflectLabel.Location = new System.Drawing.Point(12, 159);
            this.reflectLabel.Name = "reflectLabel";
            this.reflectLabel.Size = new System.Drawing.Size(58, 20);
            this.reflectLabel.TabIndex = 16;
            this.reflectLabel.Text = "Reflect:";
            // 
            // reflectTB
            // 
            this.reflectTB.Location = new System.Drawing.Point(103, 156);
            this.reflectTB.MaxLength = 1;
            this.reflectTB.Name = "reflectTB";
            this.reflectTB.Size = new System.Drawing.Size(125, 27);
            this.reflectTB.TabIndex = 17;
            this.reflectTB.Text = "quarter";
            // 
            // translationYTB
            // 
            this.translationYTB.Location = new System.Drawing.Point(278, 84);
            this.translationYTB.MaxLength = 4;
            this.translationYTB.Name = "translationYTB";
            this.translationYTB.Size = new System.Drawing.Size(125, 27);
            this.translationYTB.TabIndex = 18;
            this.translationYTB.Text = "dy";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(12, 226);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(47, 20);
            this.scaleLabel.TabIndex = 19;
            this.scaleLabel.Text = "Scale:";
            // 
            // scaleXTB
            // 
            this.scaleXTB.Location = new System.Drawing.Point(103, 219);
            this.scaleXTB.MaxLength = 4;
            this.scaleXTB.Name = "scaleXTB";
            this.scaleXTB.Size = new System.Drawing.Size(125, 27);
            this.scaleXTB.TabIndex = 20;
            this.scaleXTB.Text = "sx";
            // 
            // scaleYTB
            // 
            this.scaleYTB.Location = new System.Drawing.Point(278, 219);
            this.scaleYTB.MaxLength = 4;
            this.scaleYTB.Name = "scaleYTB";
            this.scaleYTB.Size = new System.Drawing.Size(125, 27);
            this.scaleYTB.TabIndex = 21;
            this.scaleYTB.Text = "sy";
            // 
            // shearLabel
            // 
            this.shearLabel.AutoSize = true;
            this.shearLabel.Location = new System.Drawing.Point(12, 299);
            this.shearLabel.Name = "shearLabel";
            this.shearLabel.Size = new System.Drawing.Size(49, 20);
            this.shearLabel.TabIndex = 22;
            this.shearLabel.Text = "Shear:";
            // 
            // TransformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 574);
            this.Controls.Add(this.shearLabel);
            this.Controls.Add(this.scaleYTB);
            this.Controls.Add(this.scaleXTB);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.translationYTB);
            this.Controls.Add(this.reflectTB);
            this.Controls.Add(this.reflectLabel);
            this.Controls.Add(this.translationXTB);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.transformationLabel);
            this.Controls.Add(this.picToDraw);
            this.Name = "TransformationForm";
            this.Text = "TransformationForm";
            ((System.ComponentModel.ISupportInitialize)(this.picToDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picToDraw;
        private System.Windows.Forms.Label transformationLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.TextBox translationXTB;
        private System.Windows.Forms.Label reflectLabel;
        private System.Windows.Forms.TextBox reflectTB;
        private System.Windows.Forms.TextBox translationYTB;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TextBox scaleXTB;
        private System.Windows.Forms.TextBox scaleYTB;
        private System.Windows.Forms.Label shearLabel;
    }
}