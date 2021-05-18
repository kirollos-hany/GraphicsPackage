
namespace GraphicsPackage
{
    partial class EllipseForm
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
            this.picToDrawEllipse = new System.Windows.Forms.PictureBox();
            this.ellipseLabel = new System.Windows.Forms.Label();
            this.rxLabel = new System.Windows.Forms.Label();
            this.ryLabel = new System.Windows.Forms.Label();
            this.rxTextBox = new System.Windows.Forms.TextBox();
            this.ryTextBox = new System.Windows.Forms.TextBox();
            this.xcLabel = new System.Windows.Forms.Label();
            this.xcTextBox = new System.Windows.Forms.TextBox();
            this.ycLabel = new System.Windows.Forms.Label();
            this.ycTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.xRangeLabel = new System.Windows.Forms.Label();
            this.yRangeLabel = new System.Windows.Forms.Label();
            this.ellipseResultTable = new System.Windows.Forms.DataGridView();
            this.ellipseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAndY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // picToDrawEllipse
            // 
            this.picToDrawEllipse.BackColor = System.Drawing.Color.RoyalBlue;
            this.picToDrawEllipse.Location = new System.Drawing.Point(715, 3);
            this.picToDrawEllipse.Name = "picToDrawEllipse";
            this.picToDrawEllipse.Size = new System.Drawing.Size(899, 568);
            this.picToDrawEllipse.TabIndex = 0;
            this.picToDrawEllipse.TabStop = false;
            // 
            // ellipseLabel
            // 
            this.ellipseLabel.AutoSize = true;
            this.ellipseLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ellipseLabel.Location = new System.Drawing.Point(212, 9);
            this.ellipseLabel.Name = "ellipseLabel";
            this.ellipseLabel.Size = new System.Drawing.Size(243, 38);
            this.ellipseLabel.TabIndex = 1;
            this.ellipseLabel.Text = "Ellipse Algorithm";
            // 
            // rxLabel
            // 
            this.rxLabel.AutoSize = true;
            this.rxLabel.Location = new System.Drawing.Point(4, 162);
            this.rxLabel.Name = "rxLabel";
            this.rxLabel.Size = new System.Drawing.Size(30, 20);
            this.rxLabel.TabIndex = 2;
            this.rxLabel.Text = "RX:";
            // 
            // ryLabel
            // 
            this.ryLabel.AutoSize = true;
            this.ryLabel.Location = new System.Drawing.Point(4, 236);
            this.ryLabel.Name = "ryLabel";
            this.ryLabel.Size = new System.Drawing.Size(29, 20);
            this.ryLabel.TabIndex = 3;
            this.ryLabel.Text = "RY:";
            // 
            // rxTextBox
            // 
            this.rxTextBox.Location = new System.Drawing.Point(40, 159);
            this.rxTextBox.MaxLength = 4;
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.Size = new System.Drawing.Size(96, 27);
            this.rxTextBox.TabIndex = 4;
            // 
            // ryTextBox
            // 
            this.ryTextBox.Location = new System.Drawing.Point(39, 233);
            this.ryTextBox.MaxLength = 4;
            this.ryTextBox.Name = "ryTextBox";
            this.ryTextBox.Size = new System.Drawing.Size(96, 27);
            this.ryTextBox.TabIndex = 5;
            // 
            // xcLabel
            // 
            this.xcLabel.AutoSize = true;
            this.xcLabel.Location = new System.Drawing.Point(4, 311);
            this.xcLabel.Name = "xcLabel";
            this.xcLabel.Size = new System.Drawing.Size(30, 20);
            this.xcLabel.TabIndex = 6;
            this.xcLabel.Text = "XC:";
            // 
            // xcTextBox
            // 
            this.xcTextBox.Location = new System.Drawing.Point(39, 308);
            this.xcTextBox.MaxLength = 4;
            this.xcTextBox.Name = "xcTextBox";
            this.xcTextBox.Size = new System.Drawing.Size(97, 27);
            this.xcTextBox.TabIndex = 7;
            // 
            // ycLabel
            // 
            this.ycLabel.AutoSize = true;
            this.ycLabel.Location = new System.Drawing.Point(4, 383);
            this.ycLabel.Name = "ycLabel";
            this.ycLabel.Size = new System.Drawing.Size(28, 20);
            this.ycLabel.TabIndex = 8;
            this.ycLabel.Text = "YC:";
            // 
            // ycTextBox
            // 
            this.ycTextBox.Location = new System.Drawing.Point(38, 380);
            this.ycTextBox.MaxLength = 4;
            this.ycTextBox.Name = "ycTextBox";
            this.ycTextBox.Size = new System.Drawing.Size(97, 27);
            this.ycTextBox.TabIndex = 9;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(60, 511);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 29);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(293, 511);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(552, 511);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(94, 29);
            this.drawBtn.TabIndex = 12;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            // 
            // xRangeLabel
            // 
            this.xRangeLabel.AutoSize = true;
            this.xRangeLabel.Location = new System.Drawing.Point(4, 89);
            this.xRangeLabel.Name = "xRangeLabel";
            this.xRangeLabel.Size = new System.Drawing.Size(144, 20);
            this.xRangeLabel.TabIndex = 13;
            this.xRangeLabel.Text = "-Range < X < Range";
            // 
            // yRangeLabel
            // 
            this.yRangeLabel.AutoSize = true;
            this.yRangeLabel.Location = new System.Drawing.Point(4, 124);
            this.yRangeLabel.Name = "yRangeLabel";
            this.yRangeLabel.Size = new System.Drawing.Size(143, 20);
            this.yRangeLabel.TabIndex = 14;
            this.yRangeLabel.Text = "-Range < Y < Range";
            // 
            // ellipseResultTable
            // 
            this.ellipseResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ellipseResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ellipseNum,
            this.region,
            this.decision,
            this.x,
            this.y,
            this.xAndY});
            this.ellipseResultTable.Location = new System.Drawing.Point(154, 89);
            this.ellipseResultTable.Name = "ellipseResultTable";
            this.ellipseResultTable.RowHeadersVisible = false;
            this.ellipseResultTable.RowHeadersWidth = 51;
            this.ellipseResultTable.RowTemplate.Height = 29;
            this.ellipseResultTable.Size = new System.Drawing.Size(555, 397);
            this.ellipseResultTable.TabIndex = 15;
            // 
            // ellipseNum
            // 
            this.ellipseNum.HeaderText = "EllipseNo.";
            this.ellipseNum.MinimumWidth = 6;
            this.ellipseNum.Name = "ellipseNum";
            this.ellipseNum.ReadOnly = true;
            this.ellipseNum.Width = 125;
            // 
            // region
            // 
            this.region.HeaderText = "Region";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Width = 125;
            // 
            // decision
            // 
            this.decision.HeaderText = "Decision";
            this.decision.MinimumWidth = 6;
            this.decision.Name = "decision";
            this.decision.ReadOnly = true;
            this.decision.Width = 125;
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Width = 125;
            // 
            // xAndY
            // 
            this.xAndY.HeaderText = "(X,Y)";
            this.xAndY.MinimumWidth = 6;
            this.xAndY.Name = "xAndY";
            this.xAndY.ReadOnly = true;
            this.xAndY.Width = 125;
            // 
            // EllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 574);
            this.Controls.Add(this.ellipseResultTable);
            this.Controls.Add(this.yRangeLabel);
            this.Controls.Add(this.xRangeLabel);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ycTextBox);
            this.Controls.Add(this.ycLabel);
            this.Controls.Add(this.xcTextBox);
            this.Controls.Add(this.xcLabel);
            this.Controls.Add(this.ryTextBox);
            this.Controls.Add(this.rxTextBox);
            this.Controls.Add(this.ryLabel);
            this.Controls.Add(this.rxLabel);
            this.Controls.Add(this.ellipseLabel);
            this.Controls.Add(this.picToDrawEllipse);
            this.Name = "EllipseForm";
            this.Text = "EllipseForm";
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picToDrawEllipse;
        private System.Windows.Forms.Label ellipseLabel;
        private System.Windows.Forms.Label rxLabel;
        private System.Windows.Forms.Label ryLabel;
        private System.Windows.Forms.TextBox rxTextBox;
        private System.Windows.Forms.TextBox ryTextBox;
        private System.Windows.Forms.Label xcLabel;
        private System.Windows.Forms.TextBox xcTextBox;
        private System.Windows.Forms.Label ycLabel;
        private System.Windows.Forms.TextBox ycTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label xRangeLabel;
        private System.Windows.Forms.Label yRangeLabel;
        private System.Windows.Forms.DataGridView ellipseResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ellipseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn decision;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAndY;
    }
}