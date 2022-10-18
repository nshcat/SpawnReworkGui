using SpawnReworkGui.Model;
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
    public partial class WaveSettingsControl : UserControl
    {
        protected Model.GenericWaveSettings WaveSettings { get; set; }

        public WaveSettingsControl(Model.GenericWaveSettings settings)
        {
            this.WaveSettings = settings;
            InitializeComponent();
            this.LoadValues();
        }

        public void Commit()
        {
            this.WaveSettings.InstaSpawnWaves = (int)this.numInstant.Value;
            this.WaveSettings.WaveTotal = (int)this.numWaves.Value;
            this.WaveSettings.SlotMin = (int)this.numSlotMin.Value;
            this.WaveSettings.SlotMax = (int)this.numSlotMax.Value;
            this.WaveSettings.SpawnTimeDelayForEachMin = (int)this.numDelayMin.Value;
            this.WaveSettings.SpawnTimeDelayForEachMax = (int)this.numDelayMax.Value;
            this.WaveSettings.SpawnTimeDelayAfterInstaWave = (int)this.numDelayInstant.Value;
            this.WaveSettings.SpawnLocationType = this.txtLocationType.Text;
            this.WaveSettings.SpawnTimeDelayAccumulateForEachZone = this.chkAccumulate.Checked;
            this.WaveSettings.SpawnLocations = Utilities.StringToDict(this.txtLocations.Text);
            this.WaveSettings.Difficulty = Utilities.StringToDict(this.txtDifficulty.Text);

            if (this.WaveSettings is PmcWaveSettings pmc)
            {
                pmc.SpawnScavRaiderLocationChance = (int)this.numUseScavRaiderSpawn.Value;
            }
            else if (this.WaveSettings is RaiderWaveSettings raider)
            {
                raider.RaiderHighRole = this.chkRaiderHighRole.Checked;
                raider.RaiderHighRoleChance = (int)this.numHighRoleChance.Value;
                raider.RaiderDefaultRole = this.txtRaiderRole.Text;
                raider.RaiderHighRoleList = this.txtRaiderRoles.Text;
            }
        }

        protected void LoadValues()
        {
            this.numInstant.Value = this.WaveSettings.InstaSpawnWaves;
            this.numWaves.Value = this.WaveSettings.WaveTotal;
            this.numSlotMin.Value = this.WaveSettings.SlotMin;
            this.numSlotMax.Value = this.WaveSettings.SlotMax;
            this.numDelayMin.Value = this.WaveSettings.SpawnTimeDelayForEachMin;
            this.numDelayMax.Value = this.WaveSettings.SpawnTimeDelayForEachMax;
            this.numDelayInstant.Value = this.WaveSettings.SpawnTimeDelayAfterInstaWave;
            this.txtLocationType.Text = this.WaveSettings.SpawnLocationType;
            this.chkAccumulate.Checked = this.WaveSettings.SpawnTimeDelayAccumulateForEachZone;
            this.txtDifficulty.Text = Utilities.DictToString(this.WaveSettings.Difficulty);
            this.txtLocations.Text = Utilities.DictToString(this.WaveSettings.SpawnLocations);

            if(this.WaveSettings is PmcWaveSettings pmc)
            {
                this.numUseScavRaiderSpawn.Visible = true;
                this.numUseScavRaiderSpawn.Value = pmc.SpawnScavRaiderLocationChance;
                this.lblPmc.Visible = true;
            }
            else if(this.WaveSettings is RaiderWaveSettings raider)
            {
                this.lblRaider1.Visible = true;
                this.lblRaider2.Visible = true;
                this.lblRaider3.Visible = true;
                this.chkRaiderHighRole.Visible = true;
                this.chkRaiderHighRole.Checked = raider.RaiderHighRole;
                this.numHighRoleChance.Visible = true;
                this.numHighRoleChance.Value = raider.RaiderHighRoleChance;
                this.txtRaiderRole.Visible = true;
                this.txtRaiderRole.Text = raider.RaiderDefaultRole;
                this.txtRaiderRoles.Visible = true;
                this.txtRaiderRoles.Text = raider.RaiderHighRoleList;
            }

        }
    }
}
