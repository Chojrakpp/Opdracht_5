namespace Oefening2
{
    partial class Dialoog
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
            this.lb_Waarde = new System.Windows.Forms.Label();
            this.tb_Waarde = new System.Windows.Forms.TextBox();
            this.btn_Waarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Waarde
            // 
            this.lb_Waarde.AutoSize = true;
            this.lb_Waarde.Location = new System.Drawing.Point(21, 25);
            this.lb_Waarde.Name = "lb_Waarde";
            this.lb_Waarde.Size = new System.Drawing.Size(47, 15);
            this.lb_Waarde.TabIndex = 0;
            this.lb_Waarde.Text = "Waarde";
            // 
            // tb_Waarde
            // 
            this.tb_Waarde.Location = new System.Drawing.Point(74, 25);
            this.tb_Waarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Waarde.Name = "tb_Waarde";
            this.tb_Waarde.Size = new System.Drawing.Size(110, 23);
            this.tb_Waarde.TabIndex = 1;
            // 
            // btn_Waarde
            // 
            this.btn_Waarde.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Waarde.Location = new System.Drawing.Point(12, 52);
            this.btn_Waarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Waarde.Name = "btn_Waarde";
            this.btn_Waarde.Size = new System.Drawing.Size(172, 36);
            this.btn_Waarde.TabIndex = 2;
            this.btn_Waarde.Text = "OK";
            this.btn_Waarde.UseVisualStyleBackColor = true;
            this.btn_Waarde.Click += new System.EventHandler(this.btn_Waarde_Click);
            // 
            // Dialoog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 114);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Waarde);
            this.Controls.Add(this.tb_Waarde);
            this.Controls.Add(this.lb_Waarde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dialoog";
            this.Text = "Dialoog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Waarde;
        public System.Windows.Forms.TextBox tb_Waarde;
        private System.Windows.Forms.Button btn_Waarde;
    }
}