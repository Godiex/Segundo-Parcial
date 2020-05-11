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
            this.DgvRecibo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbTipo = new System.Windows.Forms.CheckBox();
            this.CbFecha = new System.Windows.Forms.CheckBox();
            this.DtpMesAñoDia = new System.Windows.Forms.DateTimePicker();
            this.CbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LbTotaRecaudo = new System.Windows.Forms.Label();
            this.TbTotalRecaudo = new System.Windows.Forms.TextBox();
            this.TbCantidadRecibo = new System.Windows.Forms.TextBox();
            this.LbCantidadRecibo = new System.Windows.Forms.Label();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecibo)).BeginInit();
            this.panel1.SuspendLayout();
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
            // DgvRecibo
            // 
            this.DgvRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecibo.Location = new System.Drawing.Point(32, 332);
            this.DgvRecibo.Name = "DgvRecibo";
            this.DgvRecibo.Size = new System.Drawing.Size(874, 280);
            this.DgvRecibo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.CbTipo);
            this.panel1.Controls.Add(this.CbFecha);
            this.panel1.Controls.Add(this.DtpMesAñoDia);
            this.panel1.Controls.Add(this.CbTipoConsulta);
            this.panel1.Controls.Add(this.BtnConsultar);
            this.panel1.Location = new System.Drawing.Point(32, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 203);
            this.panel1.TabIndex = 56;
            // 
            // CbTipo
            // 
            this.CbTipo.AutoSize = true;
            this.CbTipo.Location = new System.Drawing.Point(23, 86);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(15, 14);
            this.CbTipo.TabIndex = 62;
            this.CbTipo.UseVisualStyleBackColor = true;
            // 
            // CbFecha
            // 
            this.CbFecha.AutoSize = true;
            this.CbFecha.Location = new System.Drawing.Point(23, 146);
            this.CbFecha.Name = "CbFecha";
            this.CbFecha.Size = new System.Drawing.Size(15, 14);
            this.CbFecha.TabIndex = 60;
            this.CbFecha.UseVisualStyleBackColor = true;
            // 
            // DtpMesAñoDia
            // 
            this.DtpMesAñoDia.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAñoDia.CustomFormat = "mm/yyyy";
            this.DtpMesAñoDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAñoDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpMesAñoDia.Location = new System.Drawing.Point(44, 146);
            this.DtpMesAñoDia.Name = "DtpMesAñoDia";
            this.DtpMesAñoDia.Size = new System.Drawing.Size(177, 37);
            this.DtpMesAñoDia.TabIndex = 56;
            this.DtpMesAñoDia.Value = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            // 
            // CbTipoConsulta
            // 
            this.CbTipoConsulta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoConsulta.FormattingEnabled = true;
            this.CbTipoConsulta.Items.AddRange(new object[] {
            "Todos",
            "Electricaribe",
            "Emdupar",
            "Gases del Caribe"});
            this.CbTipoConsulta.Location = new System.Drawing.Point(44, 86);
            this.CbTipoConsulta.Name = "CbTipoConsulta";
            this.CbTipoConsulta.Size = new System.Drawing.Size(177, 38);
            this.CbTipoConsulta.TabIndex = 56;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(142)))));
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Location = new System.Drawing.Point(23, 20);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(203, 44);
            this.BtnConsultar.TabIndex = 54;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LbTotaRecaudo
            // 
            this.LbTotaRecaudo.AutoSize = true;
            this.LbTotaRecaudo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotaRecaudo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTotaRecaudo.Location = new System.Drawing.Point(369, 109);
            this.LbTotaRecaudo.Name = "LbTotaRecaudo";
            this.LbTotaRecaudo.Size = new System.Drawing.Size(201, 30);
            this.LbTotaRecaudo.TabIndex = 59;
            this.LbTotaRecaudo.Text = "Total Recaudo :";
            // 
            // TbTotalRecaudo
            // 
            this.TbTotalRecaudo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotalRecaudo.Location = new System.Drawing.Point(645, 109);
            this.TbTotalRecaudo.Name = "TbTotalRecaudo";
            this.TbTotalRecaudo.Size = new System.Drawing.Size(153, 37);
            this.TbTotalRecaudo.TabIndex = 60;
            // 
            // TbCantidadRecibo
            // 
            this.TbCantidadRecibo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCantidadRecibo.Location = new System.Drawing.Point(645, 185);
            this.TbCantidadRecibo.Name = "TbCantidadRecibo";
            this.TbCantidadRecibo.Size = new System.Drawing.Size(153, 37);
            this.TbCantidadRecibo.TabIndex = 62;
            // 
            // LbCantidadRecibo
            // 
            this.LbCantidadRecibo.AutoSize = true;
            this.LbCantidadRecibo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadRecibo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCantidadRecibo.Location = new System.Drawing.Point(369, 189);
            this.LbCantidadRecibo.Name = "LbCantidadRecibo";
            this.LbCantidadRecibo.Size = new System.Drawing.Size(281, 30);
            this.LbCantidadRecibo.TabIndex = 61;
            this.LbCantidadRecibo.Text = "Cantidad de Recibos :";
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(142)))));
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportar.Location = new System.Drawing.Point(374, 255);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(183, 44);
            this.BtnExportar.TabIndex = 63;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // ConsultaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 619);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.TbCantidadRecibo);
            this.Controls.Add(this.LbCantidadRecibo);
            this.Controls.Add(this.TbTotalRecaudo);
            this.Controls.Add(this.LbTotaRecaudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvRecibo);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaGui";
            this.Text = "ConsultaGui";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecibo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox PbPuntos;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvRecibo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox CbTipo;
        private System.Windows.Forms.CheckBox CbFecha;
        private System.Windows.Forms.DateTimePicker DtpMesAñoDia;
        private System.Windows.Forms.ComboBox CbTipoConsulta;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LbTotaRecaudo;
        private System.Windows.Forms.TextBox TbTotalRecaudo;
        private System.Windows.Forms.TextBox TbCantidadRecibo;
        private System.Windows.Forms.Label LbCantidadRecibo;
        private System.Windows.Forms.Button BtnExportar;
    }
}