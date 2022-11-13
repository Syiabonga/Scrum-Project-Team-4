using System;
using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TowerDefense_TheRPG
{
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }
        private void show_stats()
        {
            lblKills.Text = FrmMain.kills.ToString();
            lblCounter.Text = FrmMain.storeTimePlayed.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FrmStats_Load(object sender, EventArgs e)
        {
            show_stats();
        }

        private void lblCounter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
