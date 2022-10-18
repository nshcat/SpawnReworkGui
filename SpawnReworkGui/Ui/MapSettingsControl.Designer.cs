namespace SpawnReworkGui.Ui
{
    partial class MapSettingsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMapRules = new System.Windows.Forms.TextBox();
            this.numMaxSpawnTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxBotPerZone = new System.Windows.Forms.NumericUpDown();
            this.chkBotSpawnWithBoss = new System.Windows.Forms.CheckBox();
            this.chkHasBoss = new System.Windows.Forms.CheckBox();
            this.chkSameBossSpawn = new System.Windows.Forms.CheckBox();
            this.chkBossScavSpawns = new System.Windows.Forms.CheckBox();
            this.chkBossRaiderSpawns = new System.Windows.Forms.CheckBox();
            this.chkCultistOwnLoc = new System.Windows.Forms.CheckBox();
            this.chkCultistAsBossLimit = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxBosses = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScavOpenzones = new System.Windows.Forms.TextBox();
            this.waveTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSpawnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBotPerZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBosses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Map Rules";
            // 
            // txtMapRules
            // 
            this.txtMapRules.Location = new System.Drawing.Point(260, 3);
            this.txtMapRules.Name = "txtMapRules";
            this.txtMapRules.Size = new System.Drawing.Size(252, 22);
            this.txtMapRules.TabIndex = 3;
            // 
            // numMaxSpawnTime
            // 
            this.numMaxSpawnTime.Location = new System.Drawing.Point(260, 31);
            this.numMaxSpawnTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxSpawnTime.Name = "numMaxSpawnTime";
            this.numMaxSpawnTime.Size = new System.Drawing.Size(252, 22);
            this.numMaxSpawnTime.TabIndex = 4;
            this.numMaxSpawnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Spawn Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Bots Per Zone";
            // 
            // numMaxBotPerZone
            // 
            this.numMaxBotPerZone.Location = new System.Drawing.Point(260, 59);
            this.numMaxBotPerZone.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxBotPerZone.Name = "numMaxBotPerZone";
            this.numMaxBotPerZone.Size = new System.Drawing.Size(252, 22);
            this.numMaxBotPerZone.TabIndex = 6;
            this.numMaxBotPerZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkBotSpawnWithBoss
            // 
            this.chkBotSpawnWithBoss.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBotSpawnWithBoss.Location = new System.Drawing.Point(2, 144);
            this.chkBotSpawnWithBoss.Name = "chkBotSpawnWithBoss";
            this.chkBotSpawnWithBoss.Size = new System.Drawing.Size(252, 21);
            this.chkBotSpawnWithBoss.TabIndex = 8;
            this.chkBotSpawnWithBoss.Text = "Allow Bot Spawn With Boss";
            this.chkBotSpawnWithBoss.UseVisualStyleBackColor = true;
            // 
            // chkHasBoss
            // 
            this.chkHasBoss.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasBoss.Location = new System.Drawing.Point(2, 169);
            this.chkHasBoss.Name = "chkHasBoss";
            this.chkHasBoss.Size = new System.Drawing.Size(252, 20);
            this.chkHasBoss.TabIndex = 9;
            this.chkHasBoss.Text = "Has Boss";
            this.chkHasBoss.UseVisualStyleBackColor = true;
            // 
            // chkSameBossSpawn
            // 
            this.chkSameBossSpawn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSameBossSpawn.Location = new System.Drawing.Point(260, 144);
            this.chkSameBossSpawn.Name = "chkSameBossSpawn";
            this.chkSameBossSpawn.Size = new System.Drawing.Size(252, 21);
            this.chkSameBossSpawn.TabIndex = 10;
            this.chkSameBossSpawn.Text = "Allow Same Boss Spawn";
            this.chkSameBossSpawn.UseVisualStyleBackColor = true;
            // 
            // chkBossScavSpawns
            // 
            this.chkBossScavSpawns.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBossScavSpawns.Location = new System.Drawing.Point(2, 193);
            this.chkBossScavSpawns.Name = "chkBossScavSpawns";
            this.chkBossScavSpawns.Size = new System.Drawing.Size(252, 20);
            this.chkBossScavSpawns.TabIndex = 11;
            this.chkBossScavSpawns.Text = "Bosses At Scav Spawns";
            this.chkBossScavSpawns.UseVisualStyleBackColor = true;
            // 
            // chkBossRaiderSpawns
            // 
            this.chkBossRaiderSpawns.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBossRaiderSpawns.Location = new System.Drawing.Point(2, 218);
            this.chkBossRaiderSpawns.Name = "chkBossRaiderSpawns";
            this.chkBossRaiderSpawns.Size = new System.Drawing.Size(252, 20);
            this.chkBossRaiderSpawns.TabIndex = 12;
            this.chkBossRaiderSpawns.Text = "Bosses At Raider Spawns";
            this.chkBossRaiderSpawns.UseVisualStyleBackColor = true;
            // 
            // chkCultistOwnLoc
            // 
            this.chkCultistOwnLoc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCultistOwnLoc.Location = new System.Drawing.Point(260, 168);
            this.chkCultistOwnLoc.Name = "chkCultistOwnLoc";
            this.chkCultistOwnLoc.Size = new System.Drawing.Size(252, 21);
            this.chkCultistOwnLoc.TabIndex = 13;
            this.chkCultistOwnLoc.Text = "Cultists Spawn At Own Locations";
            this.chkCultistOwnLoc.UseVisualStyleBackColor = true;
            // 
            // chkCultistAsBossLimit
            // 
            this.chkCultistAsBossLimit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCultistAsBossLimit.Location = new System.Drawing.Point(260, 192);
            this.chkCultistAsBossLimit.Name = "chkCultistAsBossLimit";
            this.chkCultistAsBossLimit.Size = new System.Drawing.Size(252, 21);
            this.chkCultistAsBossLimit.TabIndex = 14;
            this.chkCultistAsBossLimit.Text = "Cultists Count For Boss Limit";
            this.chkCultistAsBossLimit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max Bosses";
            // 
            // numMaxBosses
            // 
            this.numMaxBosses.Location = new System.Drawing.Point(260, 87);
            this.numMaxBosses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxBosses.Name = "numMaxBosses";
            this.numMaxBosses.Size = new System.Drawing.Size(252, 22);
            this.numMaxBosses.TabIndex = 15;
            this.numMaxBosses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Scav Openzones";
            // 
            // txtScavOpenzones
            // 
            this.txtScavOpenzones.Location = new System.Drawing.Point(260, 115);
            this.txtScavOpenzones.Name = "txtScavOpenzones";
            this.txtScavOpenzones.Size = new System.Drawing.Size(252, 22);
            this.txtScavOpenzones.TabIndex = 18;
            // 
            // waveTabControl
            // 
            this.waveTabControl.Location = new System.Drawing.Point(6, 244);
            this.waveTabControl.Name = "waveTabControl";
            this.waveTabControl.SelectedIndex = 0;
            this.waveTabControl.Size = new System.Drawing.Size(506, 348);
            this.waveTabControl.TabIndex = 19;
            // 
            // MapSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.waveTabControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtScavOpenzones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMaxBosses);
            this.Controls.Add(this.chkCultistAsBossLimit);
            this.Controls.Add(this.chkCultistOwnLoc);
            this.Controls.Add(this.chkBossRaiderSpawns);
            this.Controls.Add(this.chkBossScavSpawns);
            this.Controls.Add(this.chkSameBossSpawn);
            this.Controls.Add(this.chkHasBoss);
            this.Controls.Add(this.chkBotSpawnWithBoss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaxBotPerZone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMaxSpawnTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMapRules);
            this.Name = "MapSettingsControl";
            this.Size = new System.Drawing.Size(515, 595);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSpawnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBotPerZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBosses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMapRules;
        private System.Windows.Forms.NumericUpDown numMaxSpawnTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxBotPerZone;
        private System.Windows.Forms.CheckBox chkBotSpawnWithBoss;
        private System.Windows.Forms.CheckBox chkHasBoss;
        private System.Windows.Forms.CheckBox chkSameBossSpawn;
        private System.Windows.Forms.CheckBox chkBossScavSpawns;
        private System.Windows.Forms.CheckBox chkBossRaiderSpawns;
        private System.Windows.Forms.CheckBox chkCultistOwnLoc;
        private System.Windows.Forms.CheckBox chkCultistAsBossLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxBosses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScavOpenzones;
        private System.Windows.Forms.TabControl waveTabControl;
    }
}
