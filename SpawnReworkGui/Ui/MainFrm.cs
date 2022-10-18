using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace SpawnReworkGui.Ui
{
    public partial class MainFrm : Form
    {
        protected Model.PatternSettings CurrentPattern { get; set; }

        protected string LastPath { get; set; } = "";

        public MainFrm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";
            ofd.Multiselect = false;
            ofd.Title = "Select a JSON spawn pattern to load";
            if(ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                try
                {
                    var jsonTxt = File.ReadAllText(ofd.FileName);
                    this.CurrentPattern = JsonConvert.DeserializeObject<Model.PatternSettings>(jsonTxt);
                    this.GenerateMapTabs();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to load pattern json: {ex.Message}\n\nDetails:\n{ex.StackTrace}", "Failed to load pattern",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTabPage(string title, Model.MapSettings settings)
        {
            var control = new MapSettingsControl(settings);
            control.Dock = DockStyle.Fill;

            var page = new TabPage(title);
            page.Controls.Add(control);
            page.Tag = (object)control;

            this.mapTabContainer.TabPages.Add(page);
        }

        private void GenerateMapTabs()
        {
            this.mapTabContainer.TabPages.Clear();

            this.AddTabPage("Customs", this.CurrentPattern.Spawns.CustomsSettings);
            this.AddTabPage("Shoreline", this.CurrentPattern.Spawns.ShorelineSettings);
            this.AddTabPage("Interchange", this.CurrentPattern.Spawns.InterchangeSettings);
            this.AddTabPage("Factory (Day)", this.CurrentPattern.Spawns.FactoryDaySettings);
            this.AddTabPage("Factory (Night)", this.CurrentPattern.Spawns.FactoryNightSettings);
            this.AddTabPage("Reserve", this.CurrentPattern.Spawns.ReserveSettings);
            this.AddTabPage("Labs", this.CurrentPattern.Spawns.LabsSettings);
            this.AddTabPage("Lighthouse", this.CurrentPattern.Spawns.LighthouseSettings);
        }

        private void SaveTo(string path)
        {
            try
            {
                // Commit all changes
                foreach(TabPage page in this.mapTabContainer.TabPages)
                {
                    if(page.Tag is MapSettingsControl control)
                    {
                        control.Commit();
                    }
                }

                // Serialize to JSON
                var jsonTxt = JsonConvert.SerializeObject(this.CurrentPattern, Formatting.Indented);
                File.WriteAllText(path, jsonTxt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save pattern json: {ex.Message}\n\nDetails:\n{ex.StackTrace}", "Failed to load pattern",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LastPath == "")
                return;

            if (this.CurrentPattern == null)
                return;

            this.SaveTo(this.LastPath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CurrentPattern == null)
                return;

            var sfd = new SaveFileDialog();
            sfd.Filter = "JSON files (*.json)|*.json";
            sfd.Title = "Select pattern file name to save to";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                this.SaveTo(sfd.FileName);
                this.LastPath = sfd.FileName;
            }
        }
    }
}
