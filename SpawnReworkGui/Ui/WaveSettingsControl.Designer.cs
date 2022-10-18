namespace SpawnReworkGui.Ui
{
    partial class WaveSettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.numWaves = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numInstant = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numSlotMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSlotMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Waves";
            // 
            // numWaves
            // 
            this.numWaves.Location = new System.Drawing.Point(131, 3);
            this.numWaves.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWaves.Name = "numWaves";
            this.numWaves.Size = new System.Drawing.Size(77, 22);
            this.numWaves.TabIndex = 6;
            this.numWaves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Instant Waves";
            // 
            // numInstant
            // 
            this.numInstant.Location = new System.Drawing.Point(351, 3);
            this.numInstant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInstant.Name = "numInstant";
            this.numInstant.Size = new System.Drawing.Size(77, 22);
            this.numInstant.TabIndex = 8;
            this.numInstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 31);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Slot Max";
            // 
            // numSlotMax
            // 
            this.numSlotMax.Location = new System.Drawing.Point(351, 31);
            this.numSlotMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSlotMax.Name = "numSlotMax";
            this.numSlotMax.Size = new System.Drawing.Size(77, 22);
            this.numSlotMax.TabIndex = 12;
            this.numSlotMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Slot Min";
            // 
            // numSlotMin
            // 
            this.numSlotMin.Location = new System.Drawing.Point(131, 31);
            this.numSlotMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSlotMin.Name = "numSlotMin";
            this.numSlotMin.Size = new System.Drawing.Size(77, 22);
            this.numSlotMin.TabIndex = 10;
            this.numSlotMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WaveSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSlotMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSlotMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numInstant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numWaves);
            this.Name = "WaveSettingsControl";
            this.Size = new System.Drawing.Size(437, 153);
            ((System.ComponentModel.ISupportInitialize)(this.numWaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInstant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSlotMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSlotMin;
    }
}
