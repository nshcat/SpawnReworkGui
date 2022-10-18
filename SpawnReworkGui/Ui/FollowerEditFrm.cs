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
    public partial class FollowerEditFrm : Form
    {
        protected Model.BossSupport Setting { get; set; }

        public FollowerEditFrm(Model.BossSupport setting)
        {
            this.Setting = setting;
            InitializeComponent();
            this.LoadValues();
        }

        protected void LoadValues()
        {
            this.txtType.Text = this.Setting.BossEscortType;
            this.txtDifficulty.Text = this.ListToString(this.Setting.BossEscortDifficult);
            this.numMin.Value = this.Setting.BossEscortAmountMin;
            this.numMax.Value = this.Setting.BossEscortAmountMax;
        }

        protected void SaveValues()
        {
            this.Setting.BossEscortType = this.txtType.Text;
            this.Setting.BossEscortDifficult = this.StringToList(this.txtDifficulty.Text);
            this.Setting.BossEscortAmountMin = (int)this.numMin.Value;
            this.Setting.BossEscortAmountMax = (int)this.numMax.Value;
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            this.SaveValues();
            this.Close();
        }

        private string ListToString(List<string> src)
        {
            var result = new StringBuilder();
            bool isFirst = true;
            foreach (var entry in src)
            {
                if (isFirst)
                    isFirst = false;
                else
                    result.Append(";");

                result.Append(entry);
            }
            return result.ToString();
        }

        private List<string> StringToList(string src)
        {
            return src.Split(new char[] { ';' }).ToList();
        }
    }
}
