
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
            this.transformBtn = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.translationXTB = new System.Windows.Forms.TextBox();
            this.reflectLabel = new System.Windows.Forms.Label();
            this.translationYTB = new System.Windows.Forms.TextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scaleXTB = new System.Windows.Forms.TextBox();
            this.scaleYTB = new System.Windows.Forms.TextBox();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.thetaTB = new System.Windows.Forms.TextBox();
            this.thetaDegLabel = new System.Windows.Forms.Label();
            this.reflectCB = new System.Windows.Forms.ComboBox();
            this.transformResultTable = new System.Windows.Forms.DataGridView();
            this.transformationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shearLabel = new System.Windows.Forms.Label();
            this.shearCB = new System.Windows.Forms.ComboBox();
            this.shearTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picToDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // picToDraw
            // 
            this.picToDraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.picToDraw.Location = new System.Drawing.Point(676, 3);
            this.picToDraw.Name = "picToDraw";
            this.picToDraw.Size = new System.Drawing.Size(938, 568);
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
            // transformBtn
            // 
            this.transformBtn.Location = new System.Drawing.Point(553, 520);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(94, 29);
            this.transformBtn.TabIndex = 13;
            this.transformBtn.Text = "Transform";
            this.transformBtn.UseVisualStyleBackColor = true;
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
            this.reflectLabel.Location = new System.Drawing.Point(386, 84);
            this.reflectLabel.Name = "reflectLabel";
            this.reflectLabel.Size = new System.Drawing.Size(58, 20);
            this.reflectLabel.TabIndex = 16;
            this.reflectLabel.Text = "Reflect:";
            // 
            // translationYTB
            // 
            this.translationYTB.Location = new System.Drawing.Point(234, 84);
            this.translationYTB.MaxLength = 4;
            this.translationYTB.Name = "translationYTB";
            this.translationYTB.Size = new System.Drawing.Size(125, 27);
            this.translationYTB.TabIndex = 18;
            this.translationYTB.Text = "dy";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(12, 139);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(47, 20);
            this.scaleLabel.TabIndex = 19;
            this.scaleLabel.Text = "Scale:";
            // 
            // scaleXTB
            // 
            this.scaleXTB.Location = new System.Drawing.Point(103, 132);
            this.scaleXTB.MaxLength = 4;
            this.scaleXTB.Name = "scaleXTB";
            this.scaleXTB.Size = new System.Drawing.Size(125, 27);
            this.scaleXTB.TabIndex = 20;
            this.scaleXTB.Text = "sx";
            // 
            // scaleYTB
            // 
            this.scaleYTB.Location = new System.Drawing.Point(234, 132);
            this.scaleYTB.MaxLength = 4;
            this.scaleYTB.Name = "scaleYTB";
            this.scaleYTB.Size = new System.Drawing.Size(125, 27);
            this.scaleYTB.TabIndex = 21;
            this.scaleYTB.Text = "sy";
            // 
            // rotationLabel
            // 
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Location = new System.Drawing.Point(387, 135);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(69, 20);
            this.rotationLabel.TabIndex = 22;
            this.rotationLabel.Text = "Rotation:";
            // 
            // thetaTB
            // 
            this.thetaTB.Location = new System.Drawing.Point(477, 132);
            this.thetaTB.MaxLength = 10;
            this.thetaTB.Name = "thetaTB";
            this.thetaTB.Size = new System.Drawing.Size(125, 27);
            this.thetaTB.TabIndex = 23;
            this.thetaTB.Text = "theta";
            // 
            // thetaDegLabel
            // 
            this.thetaDegLabel.AutoSize = true;
            this.thetaDegLabel.Location = new System.Drawing.Point(608, 135);
            this.thetaDegLabel.Name = "thetaDegLabel";
            this.thetaDegLabel.Size = new System.Drawing.Size(62, 20);
            this.thetaDegLabel.TabIndex = 24;
            this.thetaDegLabel.Text = "degrees";
            // 
            // reflectCB
            // 
            this.reflectCB.FormattingEnabled = true;
            this.reflectCB.Items.AddRange(new object[] {
            "X",
            "Y",
            "Origin"});
            this.reflectCB.Location = new System.Drawing.Point(477, 84);
            this.reflectCB.Name = "reflectCB";
            this.reflectCB.Size = new System.Drawing.Size(125, 28);
            this.reflectCB.TabIndex = 25;
            this.reflectCB.Text = "Select Axis";
            // 
            // transformResultTable
            // 
            this.transformResultTable.AllowUserToAddRows = false;
            this.transformResultTable.AllowUserToDeleteRows = false;
            this.transformResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transformResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transformationColumn,
            this.originalPColumn,
            this.newPColumn});
            this.transformResultTable.Location = new System.Drawing.Point(12, 265);
            this.transformResultTable.Name = "transformResultTable";
            this.transformResultTable.ReadOnly = true;
            this.transformResultTable.RowHeadersVisible = false;
            this.transformResultTable.RowHeadersWidth = 51;
            this.transformResultTable.RowTemplate.Height = 29;
            this.transformResultTable.Size = new System.Drawing.Size(635, 249);
            this.transformResultTable.TabIndex = 26;
            // 
            // transformationColumn
            // 
            this.transformationColumn.HeaderText = "Transformation";
            this.transformationColumn.MinimumWidth = 6;
            this.transformationColumn.Name = "transformationColumn";
            this.transformationColumn.ReadOnly = true;
            this.transformationColumn.Width = 125;
            // 
            // originalPColumn
            // 
            this.originalPColumn.HeaderText = "Original Point";
            this.originalPColumn.MinimumWidth = 6;
            this.originalPColumn.Name = "originalPColumn";
            this.originalPColumn.ReadOnly = true;
            this.originalPColumn.Width = 125;
            // 
            // newPColumn
            // 
            this.newPColumn.HeaderText = "New Point";
            this.newPColumn.MinimumWidth = 6;
            this.newPColumn.Name = "newPColumn";
            this.newPColumn.ReadOnly = true;
            this.newPColumn.Width = 125;
            // 
            // shearLabel
            // 
            this.shearLabel.AutoSize = true;
            this.shearLabel.Location = new System.Drawing.Point(13, 191);
            this.shearLabel.Name = "shearLabel";
            this.shearLabel.Size = new System.Drawing.Size(49, 20);
            this.shearLabel.TabIndex = 27;
            this.shearLabel.Text = "Shear:";
            // 
            // shearCB
            // 
            this.shearCB.FormattingEnabled = true;
            this.shearCB.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.shearCB.Location = new System.Drawing.Point(103, 188);
            this.shearCB.Name = "shearCB";
            this.shearCB.Size = new System.Drawing.Size(125, 28);
            this.shearCB.TabIndex = 28;
            this.shearCB.Text = "Select Axis";
            // 
            // shearTB
            // 
            this.shearTB.Location = new System.Drawing.Point(234, 188);
            this.shearTB.MaxLength = 10;
            this.shearTB.Name = "shearTB";
            this.shearTB.Size = new System.Drawing.Size(125, 27);
            this.shearTB.TabIndex = 29;
            this.shearTB.Text = "sh";
            // 
            // TransformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 574);
            this.Controls.Add(this.shearTB);
            this.Controls.Add(this.shearCB);
            this.Controls.Add(this.shearLabel);
            this.Controls.Add(this.transformResultTable);
            this.Controls.Add(this.reflectCB);
            this.Controls.Add(this.thetaDegLabel);
            this.Controls.Add(this.thetaTB);
            this.Controls.Add(this.rotationLabel);
            this.Controls.Add(this.scaleYTB);
            this.Controls.Add(this.scaleXTB);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.translationYTB);
            this.Controls.Add(this.reflectLabel);
            this.Controls.Add(this.translationXTB);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.transformationLabel);
            this.Controls.Add(this.picToDraw);
            this.Name = "TransformationForm";
            this.Text = "TransformationForm";
            this.Load += new System.EventHandler(this.TransformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picToDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picToDraw;
        private System.Windows.Forms.Label transformationLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button transformBtn;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.TextBox translationXTB;
        private System.Windows.Forms.Label reflectLabel;
        private System.Windows.Forms.TextBox translationYTB;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TextBox scaleXTB;
        private System.Windows.Forms.TextBox scaleYTB;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.TextBox thetaTB;
        private System.Windows.Forms.Label thetaDegLabel;
        private System.Windows.Forms.ComboBox reflectCB;
        private System.Windows.Forms.DataGridView transformResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn transformationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newPColumn;
        private System.Windows.Forms.Label shearLabel;
        private System.Windows.Forms.ComboBox shearCB;
        private System.Windows.Forms.TextBox shearTB;
    }
}