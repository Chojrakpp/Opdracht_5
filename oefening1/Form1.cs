using System;
using System.Drawing;
using System.Windows.Forms;


namespace oef1
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void exit_Menu_Item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Textcolor
        private void red_Color_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.ForeColor = Color.Red;
        }

        private void green_Color_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.ForeColor = Color.Green;
        }

        private void blue_Color_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.ForeColor = Color.Blue;
        }

        // Backcolor
        private void red_Backcolor_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.BackColor = Color.Red;
        }

        private void green_Backcolor_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.BackColor = Color.Green;
        }

        private void blue_Backcolor_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.BackColor = Color.Blue;
        }

        // Font


        private void small_Font_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.Font = Font = new Font(tb_Main.Font.Name, 4,
                    tb_Main.Font.Style, tb_Main.Font.Unit);
        }

        private void normal_Font_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.Font = Font = new Font(tb_Main.Font.Name, 8,
                    tb_Main.Font.Style, tb_Main.Font.Unit);
        }

        private void large_Font_Menu_Item_Click(object sender, EventArgs e)
        {
            tb_Main.Font = Font = new Font(tb_Main.Font.Name, 16,
                    tb_Main.Font.Style, tb_Main.Font.Unit);
        }
    }
}


