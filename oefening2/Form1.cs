using System;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Gemiddelde_Main : Form
    {
        Gemiddelde gemiddeldeVenster = new Gemiddelde();

        public Gemiddelde_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            gemiddeldeVenster.MdiParent = this;
            gemiddeldeVenster.Show();
        }
    }
}
