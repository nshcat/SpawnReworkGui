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
        }

        protected void LoadValues()
        {
            this.numInstant.Value = this.WaveSettings.InstaSpawnWaves;
            this.numWaves.Value = this.WaveSettings.WaveTotal;
            this.numSlotMin.Value = this.WaveSettings.SlotMin;
            this.numSlotMax.Value = this.WaveSettings.SlotMax;
        }
    }
}
