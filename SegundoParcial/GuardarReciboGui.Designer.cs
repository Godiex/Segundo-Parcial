namespace SegundoParcial
{
    partial class GuardarReciboGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardarReciboGui));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbPuntos = new System.Windows.Forms.PictureBox();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.DtpMesAñoDia = new System.Windows.Forms.DateTimePicker();
            this.TbValorPagado = new System.Windows.Forms.TextBox();
            this.LbIdReciboDePago = new System.Windows.Forms.Label();
            this.TbIdRecibo = new System.Windows.Forms.TextBox();
            this.LbTipoEntidadServicio = new System.Windows.Forms.Label();
            this.LbValorPagado = new System.Windows.Forms.Label();
            this.CmbEntidadServicio = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnVaciarCampos = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).BeginInit();
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
            this.PanelSuperior.Size = new System.Drawing.Size(968, 98);
            this.PanelSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
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
            this.LbTitulo.Size = new System.Drawing.Size(397, 56);
            this.LbTitulo.TabIndex = 65;
            this.LbTitulo.Text = "Guardar Recibo";
            // 
            // DtpMesAñoDia
            // 
            this.DtpMesAñoDia.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAñoDia.CustomFormat = "mm/yyyy";
            this.DtpMesAñoDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAñoDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpMesAñoDia.Location = new System.Drawing.Point(32, 420);
            this.DtpMesAñoDia.Name = "DtpMesAñoDia";
            this.DtpMesAñoDia.Size = new System.Drawing.Size(251, 37);
            this.DtpMesAñoDia.TabIndex = 49;
            this.DtpMesAñoDia.Value = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            // 
            // TbValorPagado
            // 
            this.TbValorPagado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbValorPagado.Location = new System.Drawing.Point(400, 335);
            this.TbValorPagado.Multiline = true;
            this.TbValorPagado.Name = "TbValorPagado";
            this.TbValorPagado.Size = new System.Drawing.Size(216, 36);
            this.TbValorPagado.TabIndex = 47;
            // 
            // LbIdReciboDePago
            // 
            this.LbIdReciboDePago.AutoSize = true;
            this.LbIdReciboDePago.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdReciboDePago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbIdReciboDePago.Location = new System.Drawing.Point(30, 241);
            this.LbIdReciboDePago.Name = "LbIdReciboDePago";
            this.LbIdReciboDePago.Size = new System.Drawing.Size(168, 36);
            this.LbIdReciboDePago.TabIndex = 46;
            this.LbIdReciboDePago.Text = "Id Recibo :";
            // 
            // TbIdRecibo
            // 
            this.TbIdRecibo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdRecibo.Location = new System.Drawing.Point(400, 247);
            this.TbIdRecibo.Multiline = true;
            this.TbIdRecibo.Name = "TbIdRecibo";
            this.TbIdRecibo.Size = new System.Drawing.Size(216, 36);
            this.TbIdRecibo.TabIndex = 45;
            // 
            // LbTipoEntidadServicio
            // 
            this.LbTipoEntidadServicio.AutoSize = true;
            this.LbTipoEntidadServicio.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipoEntidadServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTipoEntidadServicio.Location = new System.Drawing.Point(30, 163);
            this.LbTipoEntidadServicio.Name = "LbTipoEntidadServicio";
            this.LbTipoEntidadServicio.Size = new System.Drawing.Size(257, 36);
            this.LbTipoEntidadServicio.TabIndex = 44;
            this.LbTipoEntidadServicio.Text = "Entidad servicio :";
            // 
            // LbValorPagado
            // 
            this.LbValorPagado.AutoSize = true;
            this.LbValorPagado.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorPagado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbValorPagado.Location = new System.Drawing.Point(30, 329);
            this.LbValorPagado.Name = "LbValorPagado";
            this.LbValorPagado.Size = new System.Drawing.Size(229, 36);
            this.LbValorPagado.TabIndex = 50;
            this.LbValorPagado.Text = "Valor Pagado :";
            // 
            // CmbEntidadServicio
            // 
            this.CmbEntidadServicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEntidadServicio.FormattingEnabled = true;
            this.CmbEntidadServicio.Items.AddRange(new object[] {
            "Electricaribe",
            "Emdupar",
            "Gase del Caribe"});
            this.CmbEntidadServicio.Location = new System.Drawing.Point(400, 170);
            this.CmbEntidadServicio.Name = "CmbEntidadServicio";
            this.CmbEntidadServicio.Size = new System.Drawing.Size(216, 32);
            this.CmbEntidadServicio.TabIndex = 51;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(151)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(31, 501);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGuardar.Size = new System.Drawing.Size(218, 45);
            this.BtnGuardar.TabIndex = 101;
            this.BtnGuardar.Text = "Guardar Recibo";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnVaciarCampos
            // 
            this.BtnVaciarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(151)))));
            this.BtnVaciarCampos.FlatAppearance.BorderSize = 0;
            this.BtnVaciarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVaciarCampos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciarCampos.ForeColor = System.Drawing.Color.White;
            this.BtnVaciarCampos.Image = ((System.Drawing.Image)(resources.GetObject("BtnVaciarCampos.Image")));
            this.BtnVaciarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVaciarCampos.Location = new System.Drawing.Point(306, 501);
            this.BtnVaciarCampos.Name = "BtnVaciarCampos";
            this.BtnVaciarCampos.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.BtnVaciarCampos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnVaciarCampos.Size = new System.Drawing.Size(218, 45);
            this.BtnVaciarCampos.TabIndex = 100;
            this.BtnVaciarCampos.Text = "Vaciar Campos";
            this.BtnVaciarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVaciarCampos.UseVisualStyleBackColor = false;
            this.BtnVaciarCampos.Click += new System.EventHandler(this.BtnVaciarCampos_Click);
            // 
            // GuardarReciboGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 658);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnVaciarCampos);
            this.Controls.Add(this.CmbEntidadServicio);
            this.Controls.Add(this.LbValorPagado);
            this.Controls.Add(this.DtpMesAñoDia);
            this.Controls.Add(this.TbValorPagado);
            this.Controls.Add(this.LbIdReciboDePago);
            this.Controls.Add(this.TbIdRecibo);
            this.Controls.Add(this.LbTipoEntidadServicio);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuardarReciboGui";
            this.Text = "GuardarReciboGui";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbPuntos;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.DateTimePicker DtpMesAñoDia;
        private System.Windows.Forms.TextBox TbValorPagado;
        private System.Windows.Forms.Label LbIdReciboDePago;
        private System.Windows.Forms.TextBox TbIdRecibo;
        private System.Windows.Forms.Label LbTipoEntidadServicio;
        private System.Windows.Forms.Label LbValorPagado;
        private System.Windows.Forms.ComboBox CmbEntidadServicio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnVaciarCampos;
    }
}