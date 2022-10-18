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
    public partial class MapSettingsControl : UserControl
    {
        protected Model.MapSettings CurrentSettings { get; set; }

        public MapSettingsControl(Model.MapSettings mapSettings)
        {
            InitializeComponent();
            this.CurrentSettings = mapSettings;
            this.LoadValues();
        }

        

        public void CommitTo(Model.MapSettings otherMap)
        {
            
        }

        public void Commit()
        {
            this.CurrentSettings.MapRules = this.txtMapRules.Text;
            this.CurrentSettings.MaxBotPerZone = (int)this.numMaxBotPerZone.Value;
            this.CurrentSettings.MaxSpawnTime = (int)this.numMaxSpawnTime.Value;
            this.CurrentSettings.AllowOtherBotSpawnWithBoss = this.chkBotSpawnWithBoss.Checked;
            this.CurrentSettings.HasBoss = this.chkHasBoss.Checked;
            this.CurrentSettings.BossesAlsoUseScavSpawnLocations = this.chkBossScavSpawns.Checked;

            this.CurrentSettings.BossesAlsoUseRaidersSpawnLocations = this.chkBossRaiderSpawns.Checked;
            this.CurrentSettings.AllowSameBossSpawn = this.chkSameBossSpawn.Checked;
            this.CurrentSettings.CultistsSpawnCountForMaxBoss = this.chkCultistAsBossLimit.Checked;
            this.CurrentSettings.CultistsSpawnAtOwnLocations = this.chkCultistOwnLoc.Checked;
            this.CurrentSettings.MaxBoss = (int)this.numMaxBosses.Value;
            this.CurrentSettings.ScavMapOpenZones = this.txtScavOpenzones.Text;

            foreach(TabPage page in this.waveTabControl.TabPages)
            {
                if(page.Tag is WaveSettingsControl control)
                {
                    control.Commit();
                }
            }
        }

        protected void LoadValues()
        {
            this.txtMapRules.Text = this.CurrentSettings.MapRules;
            this.numMaxBotPerZone.Value = this.CurrentSettings.MaxBotPerZone;
            this.numMaxSpawnTime.Value = this.CurrentSettings.MaxSpawnTime;
            this.chkBotSpawnWithBoss.Checked = this.CurrentSettings.AllowOtherBotSpawnWithBoss;
            this.chkHasBoss.Checked = this.CurrentSettings.HasBoss;
            this.chkBossScavSpawns.Checked = this.CurrentSettings.BossesAlsoUseScavSpawnLocations;
            this.chkBossRaiderSpawns.Checked = this.CurrentSettings.BossesAlsoUseRaidersSpawnLocations;
            this.chkSameBossSpawn.Checked = this.CurrentSettings.AllowSameBossSpawn;
            this.chkCultistAsBossLimit.Checked = this.CurrentSettings.CultistsSpawnCountForMaxBoss;
            this.chkCultistOwnLoc.Checked = this.CurrentSettings.CultistsSpawnAtOwnLocations;
            this.numMaxBosses.Value = this.CurrentSettings.MaxBoss;
            this.txtScavOpenzones.Text = this.CurrentSettings.ScavMapOpenZones;

            this.CreateWavePages();
        }

        protected void AddWavePage(string title, Model.GenericWaveSettings settings)
        {
            var control = new WaveSettingsControl(settings);
            control.Dock = DockStyle.Fill;

            var page = new TabPage(title);
            page.Controls.Add(control);
            page.Tag = control;
            this.waveTabControl.TabPages.Add(page);
        }

        protected void CreateWavePages()
        {
            this.waveTabControl.TabPages.Clear();

            if (this.CurrentSettings.Waves.ScavWaves != null)
                this.AddWavePage("Scavs", this.CurrentSettings.Waves.ScavWaves);

            if(this.CurrentSettings.Waves.SniperWaves != null)
                this.AddWavePage("Sniper Scavs", this.CurrentSettings.Waves.SniperWaves);

            if (this.CurrentSettings.Waves.PMCWaves != null)
                this.AddWavePage("PMCs", this.CurrentSettings.Waves.PMCWaves);

            if (this.CurrentSettings.Waves.RaiderWaves != null)
                this.AddWavePage("Raiders", this.CurrentSettings.Waves.RaiderWaves);
        }
    }
}
