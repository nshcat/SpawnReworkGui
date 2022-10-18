using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnReworkGui.Ui
{
    public partial class BossEditFrm : Form
    {
        protected Model.BossSetting Setting { get; set; }

        protected List<Model.BossSupport> TempFollowers { get; set; }

        public BossEditFrm(Model.BossSetting setting)
        {
            this.Setting = setting;
            InitializeComponent();
            this.LoadValues();
        }

        protected void LoadValues()
        {
            this.txtName.Text = this.Setting.Name;
            this.numChance.Value = this.Setting.Chance;
            this.txtDifficulty.Text = this.Setting.Difficulty;
            this.numWaveTotal.Value = this.Setting.WaveTotal;
            this.numSpawnTimeMin.Value = this.Setting.WaveSpawnTimeForEachMin;
            this.numSpawnTimeMax.Value = this.Setting.WaveSpawnTimeForEachMax;
            this.txtLocations.Text = Utilities.DictToString(this.Setting.SpawnLocations);
            this.txtTriggerID.Text = this.Setting.TriggerId;
            this.txtTriggerName.Text = this.Setting.TriggerName;
            this.chkRandomTimeSpawns.Checked = this.Setting.RandomTimeSpawn;
            this.chkSpawnSameLoc.Checked = this.Setting.WaveSpawnAllSameLocation;

            this.TempFollowers = this.CloneFollowers(
                this.Setting.Supports != null ? this.Setting.Supports : new List<Model.BossSupport>());

            this.RefreshList();
        }

        private void EditIndex(int index)
        {
            var dialog = new FollowerEditFrm(this.TempFollowers[index]);
            dialog.ShowDialog();
            this.RefreshList();
        }

        private void updateButtonState()
        {
            var index = this.lstFollowers.SelectedIndex;
            var interactionPossible = (index != -1);
            this.bttRemove.Enabled = interactionPossible;
            this.bttEdit.Enabled = interactionPossible;
        }

        protected void RefreshList()
        {
            this.lstFollowers.Items.Clear();
            foreach(var follower in this.TempFollowers)
            {
                this.lstFollowers.Items.Add($"Follower: {follower.BossEscortType}");
            }
            this.updateButtonState();
        }

        protected void SaveValues()
        {
            this.Setting.Name = this.txtName.Text;
            this.Setting.Chance = (int)this.numChance.Value;
            this.Setting.Difficulty = this.txtDifficulty.Text;
            this.Setting.WaveTotal = (int)this.numWaveTotal.Value;
            this.Setting.WaveSpawnTimeForEachMin = (int)this.numSpawnTimeMin.Value;
            this.Setting.WaveSpawnTimeForEachMax = (int)this.numSpawnTimeMax.Value;
            this.Setting.SpawnLocations = Utilities.StringToDict(this.txtLocations.Text);
            this.Setting.TriggerId = this.txtTriggerID.Text;
            this.Setting.TriggerName = this.txtTriggerName.Text;
            this.Setting.RandomTimeSpawn = this.chkRandomTimeSpawns.Checked;
            this.Setting.WaveSpawnAllSameLocation = this.chkSpawnSameLoc.Checked;
            this.Setting.Supports = this.CloneFollowers(this.TempFollowers);
        }


        private List<Model.BossSupport> CloneFollowers(List<Model.BossSupport> src)
        {
            var newList = new List<Model.BossSupport>();

            foreach(var follower in src)
            {
                var newFollower = new Model.BossSupport();
                newFollower.BossEscortDifficult = follower.BossEscortDifficult;
                newFollower.BossEscortAmountMin = follower.BossEscortAmountMin;
                newFollower.BossEscortAmountMax = follower.BossEscortAmountMax;
                newFollower.BossEscortType = follower.BossEscortType;
                newList.Add(newFollower);
            }

            return newList;
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            this.SaveValues();
            this.Close();
        }

        private void lstFollowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateButtonState();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            var follower = new Model.BossSupport();
            follower.BossEscortType = "None";
            this.TempFollowers.Add(follower);
            this.RefreshList();
        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            var index = this.lstFollowers.SelectedIndex;
            if (index != -1)
            {
                this.TempFollowers.RemoveAt(index);
                this.RefreshList();
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            var index = this.lstFollowers.SelectedIndex;
            if (index != -1)
            {
                this.EditIndex(index);
            }
        }

        private void lstFollowers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = this.lstFollowers.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                this.EditIndex(index);
            }
        }
    }
}
