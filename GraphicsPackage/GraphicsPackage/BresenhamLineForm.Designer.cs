
namespace GraphicsPackage
{
    partial class BresenhamLineForm
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
            this.picToDrawLine = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.xStartLabel = new System.Windows.Forms.Label();
            this.xStartTextBox = new System.Windows.Forms.TextBox();
            this.yStartLabel = new System.Windows.Forms.Label();
            this.yStartTextBox = new System.Windows.Forms.TextBox();
            this.xEndLabel = new System.Windows.Forms.Label();
            this.xEndTextBox = new System.Windows.Forms.TextBox();
            this.yEndLabel = new System.Windows.Forms.Label();
            this.yEndTextBox = new System.Windows.Forms.TextBox();
            this.bresenhamLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintContLabel = new System.Windows.Forms.Label();
            this.linesResultTable = new System.Windows.Forms.DataGridView();
            this.lineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAndY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRangeLabel = new System.Windows.Forms.Label();
            this.yRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // picToDrawLine
            // 
            this.picToDrawLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.picToDrawLine.Location = new System.Drawing.Point(714, 1);
            this.picToDrawLine.Name = "picToDrawLine";
            this.picToDrawLine.Size = new System.Drawing.Size(899, 568);
            this.picToDrawLine.TabIndex = 0;
            this.picToDrawLine.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(95, 540);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 29);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(266, 540);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(447, 540);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(94, 29);
            this.drawBtn.TabIndex = 3;
            this.drawBtn.Text = "DrawLine";
            this.drawBtn.UseVisualStyleBackColor = true;
            // 
            // xStartLabel
            // 
            this.xStartLabel.AutoSize = true;
            this.xStartLabel.Location = new System.Drawing.Point(25, 207);
            this.xStartLabel.Name = "xStartLabel";
            this.xStartLabel.Size = new System.Drawing.Size(29, 20);
            this.xStartLabel.TabIndex = 4;
            this.xStartLabel.Text = "X0:";
            // 
            // xStartTextBox
            // 
            this.xStartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xStartTextBox.Location = new System.Drawing.Point(60, 205);
            this.xStartTextBox.MaxLength = 4;
            this.xStartTextBox.Name = "xStartTextBox";
            this.xStartTextBox.Size = new System.Drawing.Size(83, 27);
            this.xStartTextBox.TabIndex = 5;
            // 
            // yStartLabel
            // 
            this.yStartLabel.AutoSize = true;
            this.yStartLabel.Location = new System.Drawing.Point(25, 266);
            this.yStartLabel.Name = "yStartLabel";
            this.yStartLabel.Size = new System.Drawing.Size(28, 20);
            this.yStartLabel.TabIndex = 6;
            this.yStartLabel.Text = "Y0:";
            // 
            // yStartTextBox
            // 
            this.yStartTextBox.Location = new System.Drawing.Point(60, 263);
            this.yStartTextBox.MaxLength = 4;
            this.yStartTextBox.Name = "yStartTextBox";
            this.yStartTextBox.Size = new System.Drawing.Size(83, 27);
            this.yStartTextBox.TabIndex = 7;
            // 
            // xEndLabel
            // 
            this.xEndLabel.AutoSize = true;
            this.xEndLabel.Location = new System.Drawing.Point(10, 328);
            this.xEndLabel.Name = "xEndLabel";
            this.xEndLabel.Size = new System.Drawing.Size(44, 20);
            this.xEndLabel.TabIndex = 8;
            this.xEndLabel.Text = "xEnd:";
            // 
            // xEndTextBox
            // 
            this.xEndTextBox.Location = new System.Drawing.Point(60, 325);
            this.xEndTextBox.MaxLength = 4;
            this.xEndTextBox.Name = "xEndTextBox";
            this.xEndTextBox.Size = new System.Drawing.Size(83, 27);
            this.xEndTextBox.TabIndex = 9;
            // 
            // yEndLabel
            // 
            this.yEndLabel.AutoSize = true;
            this.yEndLabel.Location = new System.Drawing.Point(9, 386);
            this.yEndLabel.Name = "yEndLabel";
            this.yEndLabel.Size = new System.Drawing.Size(44, 20);
            this.yEndLabel.TabIndex = 10;
            this.yEndLabel.Text = "yEnd:";
            // 
            // yEndTextBox
            // 
            this.yEndTextBox.Location = new System.Drawing.Point(60, 383);
            this.yEndTextBox.MaxLength = 4;
            this.yEndTextBox.Name = "yEndTextBox";
            this.yEndTextBox.Size = new System.Drawing.Size(83, 27);
            this.yEndTextBox.TabIndex = 11;
            // 
            // bresenhamLabel
            // 
            this.bresenhamLabel.AutoSize = true;
            this.bresenhamLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bresenhamLabel.Location = new System.Drawing.Point(200, 9);
            this.bresenhamLabel.Name = "bresenhamLabel";
            this.bresenhamLabel.Size = new System.Drawing.Size(225, 38);
            this.bresenhamLabel.TabIndex = 12;
            this.bresenhamLabel.Text = "Bresenham Line";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(209, 58);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(176, 20);
            this.hintLabel.TabIndex = 13;
            this.hintLabel.Text = "Enter co-ordinates below";
            // 
            // hintContLabel
            // 
            this.hintContLabel.AutoSize = true;
            this.hintContLabel.Location = new System.Drawing.Point(12, 95);
            this.hintContLabel.Name = "hintContLabel";
            this.hintContLabel.Size = new System.Drawing.Size(664, 20);
            this.hintContLabel.TabIndex = 14;
            this.hintContLabel.Text = "Or use mouse by using a single click for starting co-ordinates and double click f" +
    "or end co-ordinates";
            // 
            // linesResultTable
            // 
            this.linesResultTable.AllowUserToAddRows = false;
            this.linesResultTable.AllowUserToDeleteRows = false;
            this.linesResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linesResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNum,
            this.octant,
            this.Slope,
            this.K,
            this.pk,
            this.X,
            this.Y,
            this.xAndY});
            this.linesResultTable.Location = new System.Drawing.Point(149, 141);
            this.linesResultTable.Name = "linesResultTable";
            this.linesResultTable.ReadOnly = true;
            this.linesResultTable.RowHeadersVisible = false;
            this.linesResultTable.RowHeadersWidth = 51;
            this.linesResultTable.RowTemplate.Height = 29;
            this.linesResultTable.Size = new System.Drawing.Size(559, 381);
            this.linesResultTable.TabIndex = 15;
            // 
            // lineNum
            // 
            this.lineNum.HeaderText = "LineNo.";
            this.lineNum.MinimumWidth = 6;
            this.lineNum.Name = "lineNum";
            this.lineNum.ReadOnly = true;
            this.lineNum.Width = 125;
            // 
            // octant
            // 
            this.octant.HeaderText = "Octant";
            this.octant.MinimumWidth = 6;
            this.octant.Name = "octant";
            this.octant.ReadOnly = true;
            this.octant.Width = 125;
            // 
            // Slope
            // 
            this.Slope.HeaderText = "Slope";
            this.Slope.MinimumWidth = 6;
            this.Slope.Name = "Slope";
            this.Slope.ReadOnly = true;
            this.Slope.Width = 125;
            // 
            // K
            // 
            this.K.HeaderText = "K";
            this.K.MinimumWidth = 6;
            this.K.Name = "K";
            this.K.ReadOnly = true;
            this.K.Width = 125;
            // 
            // pk
            // 
            this.pk.HeaderText = "PK";
            this.pk.MinimumWidth = 6;
            this.pk.Name = "pk";
            this.pk.ReadOnly = true;
            this.pk.Width = 125;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 125;
            // 
            // xAndY
            // 
            this.xAndY.HeaderText = "(X, Y)";
            this.xAndY.MinimumWidth = 6;
            this.xAndY.Name = "xAndY";
            this.xAndY.ReadOnly = true;
            this.xAndY.Width = 125;
            // 
            // xRangeLabel
            // 
            this.xRangeLabel.AutoSize = true;
            this.xRangeLabel.Location = new System.Drawing.Point(40, 141);
            this.xRangeLabel.Name = "xRangeLabel";
            this.xRangeLabel.Size = new System.Drawing.Size(72, 20);
            this.xRangeLabel.TabIndex = 16;
            this.xRangeLabel.Text = "x < range";
            // 
            // yRangeLabel
            // 
            this.yRangeLabel.AutoSize = true;
            this.yRangeLabel.Location = new System.Drawing.Point(40, 174);
            this.yRangeLabel.Name = "yRangeLabel";
            this.yRangeLabel.Size = new System.Drawing.Size(72, 20);
            this.yRangeLabel.TabIndex = 17;
            this.yRangeLabel.Text = "y < range";
            // 
            // BresenhamLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 574);
            this.Controls.Add(this.yRangeLabel);
            this.Controls.Add(this.xRangeLabel);
            this.Controls.Add(this.linesResultTable);
            this.Controls.Add(this.hintContLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.bresenhamLabel);
            this.Controls.Add(this.yEndTextBox);
            this.Controls.Add(this.yEndLabel);
            this.Controls.Add(this.xEndTextBox);
            this.Controls.Add(this.xEndLabel);
            this.Controls.Add(this.yStartTextBox);
            this.Controls.Add(this.yStartLabel);
            this.Controls.Add(this.xStartTextBox);
            this.Controls.Add(this.xStartLabel);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.picToDrawLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BresenhamLineForm";
            this.Text = "BresenhamLine";
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picToDrawLine;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label xStartLabel;
        private System.Windows.Forms.TextBox xStartTextBox;
        private System.Windows.Forms.Label yStartLabel;
        private System.Windows.Forms.TextBox yStartTextBox;
        private System.Windows.Forms.Label xEndLabel;
        private System.Windows.Forms.TextBox xEndTextBox;
        private System.Windows.Forms.Label yEndLabel;
        private System.Windows.Forms.TextBox yEndTextBox;
        private System.Windows.Forms.Label bresenhamLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label hintContLabel;
        private System.Windows.Forms.DataGridView linesResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn octant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slope;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAndY;
        private System.Windows.Forms.Label xRangeLabel;
        private System.Windows.Forms.Label yRangeLabel;
    }
}