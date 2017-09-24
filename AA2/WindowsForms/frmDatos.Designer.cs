namespace WindowsForms
{
    partial class frmDatos
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Enabled = false;
            this.txtDatos.Location = new System.Drawing.Point(25, 31);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(573, 250);
            this.txtDatos.TabIndex = 0;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 314);
            this.Controls.Add(this.txtDatos);
            this.Name = "frmDatos";
            this.Text = "Datos de usuarios";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
    }
}