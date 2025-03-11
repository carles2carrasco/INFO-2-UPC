namespace Formularios
{
    partial class Simulador
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
            this.panelSIM = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSIM
            // 
            this.panelSIM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSIM.Location = new System.Drawing.Point(504, 65);
            this.panelSIM.Name = "panelSIM";
            this.panelSIM.Size = new System.Drawing.Size(500, 500);
            this.panelSIM.TabIndex = 0;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 646);
            this.Controls.Add(this.panelSIM);
            this.Name = "Simulador";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Simulador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSIM;
    }
}