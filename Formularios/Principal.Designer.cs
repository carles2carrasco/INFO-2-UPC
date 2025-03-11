namespace Formularios
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoSimubox = new System.Windows.Forms.ToolStripMenuItem();
            this.SIM = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(568, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPlanToolStripMenuItem,
            this.InfoSimubox});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirPlanToolStripMenuItem
            // 
            this.añadirPlanToolStripMenuItem.Name = "añadirPlanToolStripMenuItem";
            this.añadirPlanToolStripMenuItem.Size = new System.Drawing.Size(256, 36);
            this.añadirPlanToolStripMenuItem.Text = "Añadir Plan";
            this.añadirPlanToolStripMenuItem.Click += new System.EventHandler(this.añadirPlanToolStripMenuItem_Click);
            // 
            // InfoSimubox
            // 
            this.InfoSimubox.Name = "InfoSimubox";
            this.InfoSimubox.Size = new System.Drawing.Size(256, 36);
            this.InfoSimubox.Text = "Info Simulación";
            this.InfoSimubox.Click += new System.EventHandler(this.InfoSimubox_Click);
            // 
            // SIM
            // 
            this.SIM.Location = new System.Drawing.Point(25, 70);
            this.SIM.Name = "SIM";
            this.SIM.Size = new System.Drawing.Size(167, 93);
            this.SIM.TabIndex = 1;
            this.SIM.Text = "Simular";
            this.SIM.UseVisualStyleBackColor = true;
            this.SIM.Click += new System.EventHandler(this.SIM_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.SIM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoSimubox;
        private System.Windows.Forms.Button SIM;
    }
}

