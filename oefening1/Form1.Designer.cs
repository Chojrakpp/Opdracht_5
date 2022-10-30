
namespace oef1
{
    partial class Menus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.file_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.format_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.color_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.red_Color_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.green_Color_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.blue_Color_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.back_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.red_Backcolor_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.green_Backcolor_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.blue_Backcolor_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.font_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.small_Font_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.normal_Font_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.large_Font_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Main = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Main
            // 
            this.menu_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_Menu_Item,
            this.format_Menu_Item});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu_Main.Size = new System.Drawing.Size(1058, 24);
            this.menu_Main.TabIndex = 1;
            this.menu_Main.Text = "menuStrip1";
            // 
            // file_Menu_Item
            // 
            this.file_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_Menu_Item});
            this.file_Menu_Item.Name = "file_Menu_Item";
            this.file_Menu_Item.Size = new System.Drawing.Size(37, 20);
            this.file_Menu_Item.Text = "File";
            // 
            // exit_Menu_Item
            // 
            this.exit_Menu_Item.Name = "exit_Menu_Item";
            this.exit_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.exit_Menu_Item.Text = "Exit";
            this.exit_Menu_Item.Click += new System.EventHandler(this.exit_Menu_Item_Click);
            // 
            // format_Menu_Item
            // 
            this.format_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.color_Menu_Item,
            this.back_Menu_Item,
            this.font_Menu_Item});
            this.format_Menu_Item.Name = "format_Menu_Item";
            this.format_Menu_Item.Size = new System.Drawing.Size(57, 20);
            this.format_Menu_Item.Text = "Format";
            // 
            // color_Menu_Item
            // 
            this.color_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.red_Color_Menu_Item,
            this.green_Color_Menu_Item,
            this.blue_Color_Menu_Item});
            this.color_Menu_Item.Name = "color_Menu_Item";
            this.color_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.color_Menu_Item.Text = "Color";
            // 
            // red_Color_Menu_Item
            // 
            this.red_Color_Menu_Item.Name = "red_Color_Menu_Item";
            this.red_Color_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.red_Color_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.red_Color_Menu_Item.Text = "Red";
            this.red_Color_Menu_Item.Click += new System.EventHandler(this.red_Color_Menu_Item_Click);
            // 
            // green_Color_Menu_Item
            // 
            this.green_Color_Menu_Item.Name = "green_Color_Menu_Item";
            this.green_Color_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.green_Color_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.green_Color_Menu_Item.Text = "Green";
            this.green_Color_Menu_Item.Click += new System.EventHandler(this.green_Color_Menu_Item_Click);
            // 
            // blue_Color_Menu_Item
            // 
            this.blue_Color_Menu_Item.Name = "blue_Color_Menu_Item";
            this.blue_Color_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.blue_Color_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.blue_Color_Menu_Item.Text = "Blue";
            this.blue_Color_Menu_Item.Click += new System.EventHandler(this.blue_Color_Menu_Item_Click);
            // 
            // back_Menu_Item
            // 
            this.back_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.red_Backcolor_Menu_Item,
            this.green_Backcolor_Menu_Item,
            this.blue_Backcolor_Menu_Item});
            this.back_Menu_Item.Name = "back_Menu_Item";
            this.back_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.back_Menu_Item.Text = "Background-Color";
            // 
            // red_Backcolor_Menu_Item
            // 
            this.red_Backcolor_Menu_Item.Name = "red_Backcolor_Menu_Item";
            this.red_Backcolor_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.red_Backcolor_Menu_Item.Text = "Red";
            this.red_Backcolor_Menu_Item.Click += new System.EventHandler(this.red_Backcolor_Menu_Item_Click);
            // 
            // green_Backcolor_Menu_Item
            // 
            this.green_Backcolor_Menu_Item.Name = "green_Backcolor_Menu_Item";
            this.green_Backcolor_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.green_Backcolor_Menu_Item.Text = "Green";
            this.green_Backcolor_Menu_Item.Click += new System.EventHandler(this.green_Backcolor_Menu_Item_Click);
            // 
            // blue_Backcolor_Menu_Item
            // 
            this.blue_Backcolor_Menu_Item.Name = "blue_Backcolor_Menu_Item";
            this.blue_Backcolor_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.blue_Backcolor_Menu_Item.Text = "Blue";
            this.blue_Backcolor_Menu_Item.Click += new System.EventHandler(this.blue_Backcolor_Menu_Item_Click);
            // 
            // font_Menu_Item
            // 
            this.font_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.small_Font_Menu_Item,
            this.normal_Font_Menu_Item,
            this.large_Font_Menu_Item});
            this.font_Menu_Item.Name = "font_Menu_Item";
            this.font_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.font_Menu_Item.Text = "Font";
            // 
            // small_Font_Menu_Item
            // 
            this.small_Font_Menu_Item.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.small_Font_Menu_Item.Name = "small_Font_Menu_Item";
            this.small_Font_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.small_Font_Menu_Item.Size = new System.Drawing.Size(193, 32);
            this.small_Font_Menu_Item.Text = "Small";
            this.small_Font_Menu_Item.Click += new System.EventHandler(this.small_Font_Menu_Item_Click);
            // 
            // normal_Font_Menu_Item
            // 
            this.normal_Font_Menu_Item.Name = "normal_Font_Menu_Item";
            this.normal_Font_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.normal_Font_Menu_Item.Size = new System.Drawing.Size(193, 32);
            this.normal_Font_Menu_Item.Text = "Normal";
            this.normal_Font_Menu_Item.Click += new System.EventHandler(this.normal_Font_Menu_Item_Click);
            // 
            // large_Font_Menu_Item
            // 
            this.large_Font_Menu_Item.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.large_Font_Menu_Item.Name = "large_Font_Menu_Item";
            this.large_Font_Menu_Item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.large_Font_Menu_Item.Size = new System.Drawing.Size(193, 32);
            this.large_Font_Menu_Item.Text = "Large";
            this.large_Font_Menu_Item.Click += new System.EventHandler(this.large_Font_Menu_Item_Click);
            // 
            // tb_Main
            // 
            this.tb_Main.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Main.Location = new System.Drawing.Point(0, 24);
            this.tb_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Main.Multiline = true;
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.Size = new System.Drawing.Size(1058, 430);
            this.tb_Main.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1058, 454);
            this.Controls.Add(this.tb_Main);
            this.Controls.Add(this.menu_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menus";
            this.Text = "Menus";
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem file_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem exit_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem format_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem color_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem red_Color_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem green_Color_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem blue_Color_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem back_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem red_Backcolor_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem green_Backcolor_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem blue_Backcolor_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem font_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem small_Font_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem normal_Font_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem large_Font_Menu_Item;
        private System.Windows.Forms.TextBox tb_Main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
