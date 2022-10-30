namespace Oefening2
{
    partial class Gemiddelde
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputGetal = new System.Windows.Forms.ListBox();
            this.btn_NieuwGetal = new System.Windows.Forms.Button();
            this.lb_Gemiddelde = new System.Windows.Forms.Label();
            this.tb_Gemiddelde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputGetal
            // 
            this.InputGetal.FormattingEnabled = true;
            this.InputGetal.ItemHeight = 15;
            this.InputGetal.Location = new System.Drawing.Point(12, 11);
            this.InputGetal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputGetal.Name = "InputGetal";
            this.InputGetal.ScrollAlwaysVisible = true;
            this.InputGetal.Size = new System.Drawing.Size(149, 169);
            this.InputGetal.TabIndex = 0;
            // 
            // btn_NieuwGetal
            // 
            this.btn_NieuwGetal.Location = new System.Drawing.Point(12, 184);
            this.btn_NieuwGetal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NieuwGetal.Name = "btn_NieuwGetal";
            this.btn_NieuwGetal.Size = new System.Drawing.Size(149, 32);
            this.btn_NieuwGetal.TabIndex = 1;
            this.btn_NieuwGetal.Text = "Nieuw Getal";
            this.btn_NieuwGetal.UseVisualStyleBackColor = true;
            this.btn_NieuwGetal.Click += new System.EventHandler(this.btn_NieuwGetal_Click);
            // 
            // lb_Gemiddelde
            // 
            this.lb_Gemiddelde.AutoSize = true;
            this.lb_Gemiddelde.Location = new System.Drawing.Point(167, 11);
            this.lb_Gemiddelde.Name = "lb_Gemiddelde";
            this.lb_Gemiddelde.Size = new System.Drawing.Size(71, 15);
            this.lb_Gemiddelde.TabIndex = 2;
            this.lb_Gemiddelde.Text = "Gemiddelde";
            // 
            // tb_Gemiddelde
            // 
            this.tb_Gemiddelde.Enabled = false;
            this.tb_Gemiddelde.Location = new System.Drawing.Point(167, 28);
            this.tb_Gemiddelde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Gemiddelde.Name = "tb_Gemiddelde";
            this.tb_Gemiddelde.Size = new System.Drawing.Size(110, 23);
            this.tb_Gemiddelde.TabIndex = 3;
            // 
            // Gemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 227);
            this.Controls.Add(this.tb_Gemiddelde);
            this.Controls.Add(this.lb_Gemiddelde);
            this.Controls.Add(this.btn_NieuwGetal);
            this.Controls.Add(this.InputGetal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_NieuwGetal;
        private System.Windows.Forms.Label lb_Gemiddelde;
        public System.Windows.Forms.ListBox InputGetal;
        public System.Windows.Forms.TextBox tb_Gemiddelde;
    }
}