using System;
using System.Windows.Forms;

namespace Oefening2
{

    public partial class Dialoog : Form
    {
        public Dialoog()
        {
            InitializeComponent();
        }
        public double number { get; set; }

        private void btn_Waarde_Click(object sender, EventArgs e)
        {
            this.number = double.Parse(tb_Waarde.Text);
        }
    }
}
