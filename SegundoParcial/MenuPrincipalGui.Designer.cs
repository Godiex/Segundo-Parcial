namespace SegundoParcial
{
    partial class MenuPrincipalGui
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalGui));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.PanelLateralSuperior = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PbLogoLateral = new System.Windows.Forms.PictureBox();
            this.PbMaximizar = new System.Windows.Forms.PictureBox();
            this.PbRestaurar = new System.Windows.Forms.PictureBox();
            this.PbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbSalir = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.PanelLateral.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogoLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.PanelLateral.Controls.Add(this.BtnConsulta);
            this.PanelLateral.Controls.Add(this.button3);
            this.PanelLateral.Controls.Add(this.button2);
            this.PanelLateral.Controls.Add(this.button1);
            this.PanelLateral.Controls.Add(this.PbLogoLateral);
            this.PanelLateral.Controls.Add(this.PanelLateralSuperior);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(332, 700);
            this.PanelLateral.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(210)))));
            this.PanelSuperior.Controls.Add(this.PbMaximizar);
            this.PanelSuperior.Controls.Add(this.PbRestaurar);
            this.PanelSuperior.Controls.Add(this.PbMinimizar);
            this.PanelSuperior.Controls.Add(this.PbSalir);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(332, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(968, 42);
            this.PanelSuperior.TabIndex = 1;
            // 
            // PanelLateralSuperior
            // 
            this.PanelLateralSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(191)))));
            this.PanelLateralSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLateralSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelLateralSuperior.Name = "PanelLateralSuperior";
            this.PanelLateralSuperior.Size = new System.Drawing.Size(332, 42);
            this.PanelLateralSuperior.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(332, 42);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(968, 658);
            this.PanelContenedor.TabIndex = 2;
            // 
            // PbLogoLateral
            // 
            this.PbLogoLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogoLateral.Location = new System.Drawing.Point(0, 42);
            this.PbLogoLateral.Name = "PbLogoLateral";
            this.PbLogoLateral.Size = new System.Drawing.Size(332, 184);
            this.PbLogoLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogoLateral.TabIndex = 1;
            this.PbLogoLateral.TabStop = false;
            // 
            // PbMaximizar
            // 
            this.PbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PbMaximizar.Image")));
            this.PbMaximizar.Location = new System.Drawing.Point(880, 5);
            this.PbMaximizar.Name = "PbMaximizar";
            this.PbMaximizar.Size = new System.Drawing.Size(35, 35);
            this.PbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMaximizar.TabIndex = 7;
            this.PbMaximizar.TabStop = false;
            this.PbMaximizar.Click += new System.EventHandler(this.PbMaximizar_Click);
            // 
            // PbRestaurar
            // 
            this.PbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PbRestaurar.Image")));
            this.PbRestaurar.Location = new System.Drawing.Point(880, 5);
            this.PbRestaurar.Name = "PbRestaurar";
            this.PbRestaurar.Size = new System.Drawing.Size(35, 35);
            this.PbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbRestaurar.TabIndex = 6;
            this.PbRestaurar.TabStop = false;
            this.PbRestaurar.Click += new System.EventHandler(this.PbRestaurar_Click);
            // 
            // PbMinimizar
            // 
            this.PbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PbMinimizar.Image")));
            this.PbMinimizar.Location = new System.Drawing.Point(839, 5);
            this.PbMinimizar.Name = "PbMinimizar";
            this.PbMinimizar.Size = new System.Drawing.Size(35, 35);
            this.PbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMinimizar.TabIndex = 5;
            this.PbMinimizar.TabStop = false;
            this.PbMinimizar.Click += new System.EventHandler(this.PbMinimizar_Click);
            // 
            // PbSalir
            // 
            this.PbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSalir.Image = ((System.Drawing.Image)(resources.GetObject("PbSalir.Image")));
            this.PbSalir.Location = new System.Drawing.Point(921, 4);
            this.PbSalir.Name = "PbSalir";
            this.PbSalir.Size = new System.Drawing.Size(35, 35);
            this.PbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbSalir.TabIndex = 4;
            this.PbSalir.TabStop = false;
            this.PbSalir.Click += new System.EventHandler(this.PbSalir_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(3, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(3, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(329, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(3, 451);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(329, 50);
            this.BtnConsulta.TabIndex = 5;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // MenuPrincipalGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipalGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelLateral.ResumeLayout(false);
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogoLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelLateralSuperior;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox PbLogoLateral;
        private System.Windows.Forms.PictureBox PbMaximizar;
        private System.Windows.Forms.PictureBox PbRestaurar;
        private System.Windows.Forms.PictureBox PbMinimizar;
        private System.Windows.Forms.PictureBox PbSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

