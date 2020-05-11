namespace SegundoParcial
{
    partial class ConsultaGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaGui));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.PbPuntos = new System.Windows.Forms.PictureBox();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.PanelSuperior.Controls.Add(this.pictureBox1);
            this.PanelSuperior.Controls.Add(this.PbPuntos);
            this.PanelSuperior.Controls.Add(this.LbTitulo);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(952, 98);
            this.PanelSuperior.TabIndex = 0;
            // 
            // PbPuntos
            // 
            this.PbPuntos.Image = ((System.Drawing.Image)(resources.GetObject("PbPuntos.Image")));
            this.PbPuntos.Location = new System.Drawing.Point(32, 3);
            this.PbPuntos.Name = "PbPuntos";
            this.PbPuntos.Size = new System.Drawing.Size(84, 86);
            this.PbPuntos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPuntos.TabIndex = 66;
            this.PbPuntos.TabStop = false;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTitulo.Location = new System.Drawing.Point(155, 19);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(250, 56);
            this.LbTitulo.TabIndex = 65;
            this.LbTitulo.Text = "Consultas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(822, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 619);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaGui";
            this.Text = "ConsultaGui";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox PbPuntos;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}