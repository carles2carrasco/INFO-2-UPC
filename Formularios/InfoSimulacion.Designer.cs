namespace Formularios
{
    partial class InfoSimulacion
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
            this.Ciclobox = new System.Windows.Forms.TextBox();
            this.Distanciabox = new System.Windows.Forms.TextBox();
            this.botoninfolisto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ciclobox
            // 
            this.Ciclobox.Location = new System.Drawing.Point(141, 117);
            this.Ciclobox.Name = "Ciclobox";
            this.Ciclobox.Size = new System.Drawing.Size(100, 20);
            this.Ciclobox.TabIndex = 0;
            // 
            // Distanciabox
            // 
            this.Distanciabox.Location = new System.Drawing.Point(141, 57);
            this.Distanciabox.Name = "Distanciabox";
            this.Distanciabox.Size = new System.Drawing.Size(100, 20);
            this.Distanciabox.TabIndex = 1;
            // 
            // botoninfolisto
            // 
            this.botoninfolisto.Location = new System.Drawing.Point(101, 195);
            this.botoninfolisto.Name = "botoninfolisto";
            this.botoninfolisto.Size = new System.Drawing.Size(75, 23);
            this.botoninfolisto.TabIndex = 2;
            this.botoninfolisto.Text = "LISTO";
            this.botoninfolisto.UseVisualStyleBackColor = true;
            this.botoninfolisto.Click += new System.EventHandler(this.botoninfolisto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distancia de Seguridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo de Ciclo";
            // 
            // InfoSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botoninfolisto);
            this.Controls.Add(this.Distanciabox);
            this.Controls.Add(this.Ciclobox);
            this.Name = "InfoSimulacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ciclobox;
        private System.Windows.Forms.TextBox Distanciabox;
        private System.Windows.Forms.Button botoninfolisto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}