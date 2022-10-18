namespace SpawnReworkGui.Ui
{
    partial class BossSettingsControl
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
            this.lstBosses = new System.Windows.Forms.ListBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBosses
            // 
            this.lstBosses.FormattingEnabled = true;
            this.lstBosses.ItemHeight = 16;
            this.lstBosses.Location = new System.Drawing.Point(3, 3);
            this.lstBosses.Name = "lstBosses";
            this.lstBosses.Size = new System.Drawing.Size(431, 180);
            this.lstBosses.TabIndex = 0;
            this.lstBosses.SelectedIndexChanged += new System.EventHandler(this.lstBosses_SelectedIndexChanged);
            this.lstBosses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBosses_MouseDoubleClick);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(359, 189);
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
            this.bttRemove.Location = new System.Drawing.Point(278, 189);
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
            this.bttEdit.Location = new System.Drawing.Point(197, 189);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 3;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // BossSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttRemove);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.lstBosses);
            this.Name = "BossSettingsControl";
            this.Size = new System.Drawing.Size(437, 289);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBosses;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEdit;
    }
}
