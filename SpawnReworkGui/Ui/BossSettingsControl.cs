using SpawnReworkGui.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnReworkGui.Ui
{
    public partial class BossSettingsControl : UserControl
    {
        protected List<Model.BossSetting> Settings { get; set; }

        public BossSettingsControl(List<Model.BossSetting> settings)
        {
            this.Settings = settings;
            InitializeComponent();
            this.LoadValues();
        }

        public void Commit()
        {
        }

        protected void LoadValues()
        {
            this.RefreshList();
        }

        protected void RefreshList()
        {
            this.lstBosses.Items.Clear();
            foreach(BossSetting boss in this.Settings)
            {
                this.lstBosses.Items.Add($"Boss: {boss.Name}");
            }
            this.updateButtonState();
        }

        private void lstBosses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateButtonState();   
        }

        private void updateButtonState()
        {
            var index = this.lstBosses.SelectedIndex;
            var interactionPossible = (index != -1);
            this.bttRemove.Enabled = interactionPossible;
            this.bttEdit.Enabled = interactionPossible;
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            var index = this.lstBosses.SelectedIndex;
            if (index != -1)
            {
                this.EditIndex(index);
            }
        }

        private void EditIndex(int index)
        {
            var dialog = new BossEditFrm(this.Settings[index]);
            dialog.ShowDialog();
            this.RefreshList();
        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            var index = this.lstBosses.SelectedIndex;
            if(index != -1)
            {
                this.Settings.RemoveAt(index);
                this.RefreshList();
            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            var boss = new BossSetting();
            boss.Name = "none";
            boss.Supports = new List<BossSupport>();
            this.Settings.Add(boss);
            this.RefreshList();
        }

        private void lstBosses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = this.lstBosses.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                this.EditIndex(index);
            }
        }
    }
}
