
namespace GraphicsPackage
{
    partial class CircleForm
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
            this.picToDrawCircle = new System.Windows.Forms.PictureBox();
            this.circleLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.xcLabel = new System.Windows.Forms.Label();
            this.xcTextBox = new System.Windows.Forms.TextBox();
            this.ycLabel = new System.Windows.Forms.Label();
            this.ycTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.xRangeLabel = new System.Windows.Forms.Label();
            this.yRangeLabel = new System.Windows.Forms.Label();
            this.circleResultTable = new System.Windows.Forms.DataGridView();
            this.circleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAndY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // picToDrawCircle
            // 
            this.picToDrawCircle.BackColor = System.Drawing.Color.RoyalBlue;
            this.picToDrawCircle.Location = new System.Drawing.Point(715, 3);
            this.picToDrawCircle.Name = "picToDrawCircle";
            this.picToDrawCircle.Size = new System.Drawing.Size(899, 568);
            this.picToDrawCircle.TabIndex = 0;
            this.picToDrawCircle.TabStop = false;
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleLabel.Location = new System.Drawing.Point(212, 9);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(232, 38);
            this.circleLabel.TabIndex = 1;
            this.circleLabel.Text = "Circle Algorithm";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(4, 245);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(21, 20);
            this.rLabel.TabIndex = 2;
            this.rLabel.Text = "R:";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(40, 242);
            this.rTextBox.MaxLength = 4;
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(96, 27);
            this.rTextBox.TabIndex = 4;
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
            // circleResultTable
            // 
            this.circleResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.circleResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.circleNum,
            this.decision,
            this.x,
            this.y,
            this.xAndY});
            this.circleResultTable.Location = new System.Drawing.Point(154, 89);
            this.circleResultTable.Name = "circleResultTable";
            this.circleResultTable.RowHeadersVisible = false;
            this.circleResultTable.RowHeadersWidth = 51;
            this.circleResultTable.RowTemplate.Height = 29;
            this.circleResultTable.Size = new System.Drawing.Size(555, 397);
            this.circleResultTable.TabIndex = 15;
            // 
            // circleNum
            // 
            this.circleNum.HeaderText = "CircleNo.";
            this.circleNum.MinimumWidth = 6;
            this.circleNum.Name = "circleNum";
            this.circleNum.ReadOnly = true;
            this.circleNum.Width = 125;
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
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 574);
            this.Controls.Add(this.circleResultTable);
            this.Controls.Add(this.yRangeLabel);
            this.Controls.Add(this.xRangeLabel);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ycTextBox);
            this.Controls.Add(this.ycLabel);
            this.Controls.Add(this.xcTextBox);
            this.Controls.Add(this.xcLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.circleLabel);
            this.Controls.Add(this.picToDrawCircle);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            ((System.ComponentModel.ISupportInitialize)(this.picToDrawCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picToDrawCircle;
        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label xcLabel;
        private System.Windows.Forms.TextBox xcTextBox;
        private System.Windows.Forms.Label ycLabel;
        private System.Windows.Forms.TextBox ycTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label xRangeLabel;
        private System.Windows.Forms.Label yRangeLabel;
        private System.Windows.Forms.DataGridView circleResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn circleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn decision;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAndY;
    }
}