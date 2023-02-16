
namespace HRMS
{
    partial class BONUS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bonusName = new System.Windows.Forms.TextBox();
            this.bonusAmount = new System.Windows.Forms.TextBox();
            this.bonusSave = new System.Windows.Forms.Button();
            this.bonusEdit = new System.Windows.Forms.Button();
            this.bonusDelete = new System.Windows.Forms.Button();
            this.bonusDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AMOUNT:";
            // 
            // bonusName
            // 
            this.bonusName.Location = new System.Drawing.Point(69, 125);
            this.bonusName.Name = "bonusName";
            this.bonusName.Size = new System.Drawing.Size(156, 20);
            this.bonusName.TabIndex = 1;
            // 
            // bonusAmount
            // 
            this.bonusAmount.Location = new System.Drawing.Point(312, 125);
            this.bonusAmount.Name = "bonusAmount";
            this.bonusAmount.Size = new System.Drawing.Size(156, 20);
            this.bonusAmount.TabIndex = 1;
            // 
            // bonusSave
            // 
            this.bonusSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bonusSave.Location = new System.Drawing.Point(69, 182);
            this.bonusSave.Name = "bonusSave";
            this.bonusSave.Size = new System.Drawing.Size(75, 23);
            this.bonusSave.TabIndex = 2;
            this.bonusSave.Text = "SAVE";
            this.bonusSave.UseVisualStyleBackColor = false;
            // 
            // bonusEdit
            // 
            this.bonusEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bonusEdit.Location = new System.Drawing.Point(247, 182);
            this.bonusEdit.Name = "bonusEdit";
            this.bonusEdit.Size = new System.Drawing.Size(75, 23);
            this.bonusEdit.TabIndex = 2;
            this.bonusEdit.Text = "EDIT";
            this.bonusEdit.UseVisualStyleBackColor = false;
            // 
            // bonusDelete
            // 
            this.bonusDelete.BackColor = System.Drawing.Color.Red;
            this.bonusDelete.Location = new System.Drawing.Point(393, 182);
            this.bonusDelete.Name = "bonusDelete";
            this.bonusDelete.Size = new System.Drawing.Size(75, 23);
            this.bonusDelete.TabIndex = 2;
            this.bonusDelete.Text = "DELETE";
            this.bonusDelete.UseVisualStyleBackColor = false;
            // 
            // bonusDGV
            // 
            this.bonusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bonusDGV.Location = new System.Drawing.Point(2, 211);
            this.bonusDGV.Name = "bonusDGV";
            this.bonusDGV.Size = new System.Drawing.Size(611, 200);
            this.bonusDGV.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRMS.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(575, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BONUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 423);
            this.Controls.Add(this.bonusDGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bonusDelete);
            this.Controls.Add(this.bonusEdit);
            this.Controls.Add(this.bonusSave);
            this.Controls.Add(this.bonusAmount);
            this.Controls.Add(this.bonusName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BONUS";
            this.Text = "BONUS";
            ((System.ComponentModel.ISupportInitialize)(this.bonusDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bonusName;
        private System.Windows.Forms.TextBox bonusAmount;
        private System.Windows.Forms.Button bonusSave;
        private System.Windows.Forms.Button bonusEdit;
        private System.Windows.Forms.Button bonusDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView bonusDGV;
    }
}