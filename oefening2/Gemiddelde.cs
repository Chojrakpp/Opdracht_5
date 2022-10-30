using System;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Gemiddelde : Form
    {
        public Gemiddelde()
        {
            InitializeComponent();
        }

        private void btn_NieuwGetal_Click(object sender, EventArgs e)
        {
            Dialoog dialogWindow = new Dialoog();
            dialogWindow.ShowDialog();

            if (dialogWindow.DialogResult == DialogResult.OK)
            {
                VoegToeAanLijst(dialogWindow.number);
                berekenGemiddelde();

                dialogWindow.Dispose();
            }
        }

        public void VoegToeAanLijst(double waarde)
        {
            InputGetal.Items.Add(waarde);
        }

        public void berekenGemiddelde()
        {
            double gemiddelde = 0;

            for (int i = 0; i < InputGetal.Items.Count; i++)
            {
                gemiddelde = gemiddelde + double.Parse(InputGetal.Items[i].ToString());
            }

            gemiddelde = (gemiddelde / InputGetal.Items.Count);
            tb_Gemiddelde.Text = gemiddelde.ToString();
        }
    }
}
