namespace SpawnReworkGui.Ui
{
    partial class FollowerEditFrm
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
            this.bttOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(354, 70);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 0;
            this.bttOk.Text = "Ok";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 38);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Maximum Amount";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(352, 38);
            this.numMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(77, 22);
            this.numMax.TabIndex = 32;
            this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Minimum Amount";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(131, 10);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(77, 22);
            this.txtType.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Difficulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Type";
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(352, 10);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(77, 22);
            this.txtDifficulty.TabIndex = 34;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(131, 38);
            this.numMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(77, 22);
            this.numMin.TabIndex = 35;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FollowerEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 100);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FollowerEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Boss Follower";
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.NumericUpDown numMin;
    }
}