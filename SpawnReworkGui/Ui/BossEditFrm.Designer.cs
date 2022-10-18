namespace SpawnReworkGui.Ui
{
    partial class BossEditFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numChance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numWaveTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numSpawnTimeMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numSpawnTimeMin = new System.Windows.Forms.NumericUpDown();
            this.txtLocations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTriggerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSpawnSameLoc = new System.Windows.Forms.CheckBox();
            this.chkRandomTimeSpawns = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstFollowers = new System.Windows.Forms.ListBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaveTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnTimeMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(355, 377);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 0;
            this.bttOk.Text = "Ok";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chance";
            // 
            // numChance
            // 
            this.numChance.Location = new System.Drawing.Point(353, 12);
            this.numChance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numChance.Name = "numChance";
            this.numChance.Size = new System.Drawing.Size(77, 22);
            this.numChance.TabIndex = 12;
            this.numChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(77, 22);
            this.txtName.TabIndex = 21;
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(132, 40);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(77, 22);
            this.txtDifficulty.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 40);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Wave Total";
            // 
            // numWaveTotal
            // 
            this.numWaveTotal.Location = new System.Drawing.Point(353, 40);
            this.numWaveTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWaveTotal.Name = "numWaveTotal";
            this.numWaveTotal.Size = new System.Drawing.Size(77, 22);
            this.numWaveTotal.TabIndex = 24;
            this.numWaveTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 68);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Spawn Time Max";
            // 
            // numSpawnTimeMax
            // 
            this.numSpawnTimeMax.Location = new System.Drawing.Point(353, 68);
            this.numSpawnTimeMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSpawnTimeMax.Name = "numSpawnTimeMax";
            this.numSpawnTimeMax.Size = new System.Drawing.Size(77, 22);
            this.numSpawnTimeMax.TabIndex = 28;
            this.numSpawnTimeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Spawn Time Min";
            // 
            // numSpawnTimeMin
            // 
            this.numSpawnTimeMin.Location = new System.Drawing.Point(132, 68);
            this.numSpawnTimeMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSpawnTimeMin.Name = "numSpawnTimeMin";
            this.numSpawnTimeMin.Size = new System.Drawing.Size(77, 22);
            this.numSpawnTimeMin.TabIndex = 30;
            this.numSpawnTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLocations
            // 
            this.txtLocations.Location = new System.Drawing.Point(132, 96);
            this.txtLocations.Name = "txtLocations";
            this.txtLocations.Size = new System.Drawing.Size(298, 22);
            this.txtLocations.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Spawn Locations";
            // 
            // txtTriggerID
            // 
            this.txtTriggerID.Location = new System.Drawing.Point(132, 124);
            this.txtTriggerID.Name = "txtTriggerID";
            this.txtTriggerID.Size = new System.Drawing.Size(77, 22);
            this.txtTriggerID.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Trigger ID";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Location = new System.Drawing.Point(353, 124);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(77, 22);
            this.txtTriggerName.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 124);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Trigger Name";
            // 
            // chkSpawnSameLoc
            // 
            this.chkSpawnSameLoc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSpawnSameLoc.Location = new System.Drawing.Point(234, 152);
            this.chkSpawnSameLoc.Name = "chkSpawnSameLoc";
            this.chkSpawnSameLoc.Size = new System.Drawing.Size(196, 20);
            this.chkSpawnSameLoc.TabIndex = 37;
            this.chkSpawnSameLoc.Text = "Spawn All Same Location";
            this.chkSpawnSameLoc.UseVisualStyleBackColor = true;
            // 
            // chkRandomTimeSpawns
            // 
            this.chkRandomTimeSpawns.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRandomTimeSpawns.Location = new System.Drawing.Point(10, 152);
            this.chkRandomTimeSpawns.Name = "chkRandomTimeSpawns";
            this.chkRandomTimeSpawns.Size = new System.Drawing.Size(199, 20);
            this.chkRandomTimeSpawns.TabIndex = 38;
            this.chkRandomTimeSpawns.Text = "Random Time Spawns";
            this.chkRandomTimeSpawns.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttEdit);
            this.groupBox1.Controls.Add(this.bttRemove);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.lstFollowers);
            this.groupBox1.Location = new System.Drawing.Point(10, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 193);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Followers";
            // 
            // lstFollowers
            // 
            this.lstFollowers.FormattingEnabled = true;
            this.lstFollowers.ItemHeight = 16;
            this.lstFollowers.Location = new System.Drawing.Point(6, 21);
            this.lstFollowers.Name = "lstFollowers";
            this.lstFollowers.Size = new System.Drawing.Size(406, 132);
            this.lstFollowers.TabIndex = 0;
            this.lstFollowers.SelectedIndexChanged += new System.EventHandler(this.lstFollowers_SelectedIndexChanged);
            this.lstFollowers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFollowers_MouseDoubleClick);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(337, 159);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 1;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttRemove
            // 
            this.bttRemove.Enabled = false;
            this.bttRemove.Location = new System.Drawing.Point(256, 159);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(75, 23);
            this.bttRemove.TabIndex = 2;
            this.bttRemove.Text = "Remove";
            this.bttRemove.UseVisualStyleBackColor = true;
            this.bttRemove.Click += new System.EventHandler(this.bttRemove_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Enabled = false;
            this.bttEdit.Location = new System.Drawing.Point(175, 159);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 3;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // BossEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkRandomTimeSpawns);
            this.Controls.Add(this.chkSpawnSameLoc);
            this.Controls.Add(this.txtTriggerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTriggerID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocations);
            this.Controls.Add(this.numSpawnTimeMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSpawnTimeMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numWaveTotal);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numChance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BossEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Boss Spawn";
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaveTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnTimeMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWaveTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSpawnTimeMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSpawnTimeMin;
        private System.Windows.Forms.TextBox txtLocations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTriggerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSpawnSameLoc;
        private System.Windows.Forms.CheckBox chkRandomTimeSpawns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.ListBox lstFollowers;
    }
}