namespace Principal.Ventanas
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.aeropuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipoAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embarquesPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.btnEmbarque = new System.Windows.Forms.Button();
            this.lblEmbarque = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPasaje = new System.Windows.Forms.Label();
            this.btnPasaje = new System.Windows.Forms.Button();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.btnVuelo = new System.Windows.Forms.Button();

            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEquipaje = new System.Windows.Forms.Label();
            this.btnEquipaje = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblNombreUsuario.Location = new System.Drawing.Point(188, 16);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 11);

            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 25);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreUsuario.Visible = false;
            // 
            // aeropuertoToolStripMenuItem
            // 
            this.aeropuertoToolStripMenuItem.Name = "aeropuertoToolStripMenuItem";
            this.aeropuertoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.aeropuertoToolStripMenuItem.Text = "Aeropuerto";
            this.aeropuertoToolStripMenuItem.Click += new System.EventHandler(this.aeropuertoToolStripMenuItem_Click);
            // 
            // avionToolStripMenuItem
            // 
            this.avionToolStripMenuItem.Name = "avionToolStripMenuItem";
            this.avionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.avionToolStripMenuItem.Text = "Avion";
            this.avionToolStripMenuItem.Click += new System.EventHandler(this.avionToolStripMenuItem_Click);
            // 
            // pasajeroToolStripMenuItem
            // 
            this.pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            this.pasajeroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pasajeroToolStripMenuItem.Text = "Pasajero";
            this.pasajeroToolStripMenuItem.Click += new System.EventHandler(this.pasajeroToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeropuertoToolStripMenuItem,
            this.avionToolStripMenuItem,
            this.pasajeroToolStripMenuItem,
            this.tipoAvionToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";

            this.menuStrip1.Size = new System.Drawing.Size(538, 28);

            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);

            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tipoAvionToolStripMenuItem
            // 
            this.tipoAvionToolStripMenuItem.Name = "tipoAvionToolStripMenuItem";
            this.tipoAvionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.tipoAvionToolStripMenuItem.Text = "Tipo Avion";
            this.tipoAvionToolStripMenuItem.Click += new System.EventHandler(this.tipoAvionToolStripMenuItem_Click);

            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.embarquesPorFechaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";

            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.tipoAvionToolStripMenuItem_Click);


            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reporteToolStripMenuItem.Text = "Salidas";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.estadisticasToolStripMenuItem.Text = "Cant Aviones por Tipo";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salidasToolStripMenuItem.Text = "Reportes";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // embarquesPorFechaToolStripMenuItem
            // 
            this.embarquesPorFechaToolStripMenuItem.Name = "embarquesPorFechaToolStripMenuItem";
            this.embarquesPorFechaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.embarquesPorFechaToolStripMenuItem.Text = "Embarques por Nro Vuelo";
            this.embarquesPorFechaToolStripMenuItem.Click += new System.EventHandler(this.embarquesPorFechaToolStripMenuItem_Click);

            // 
            // btnEmbarque
            // 
            this.btnEmbarque.Image = ((System.Drawing.Image)(resources.GetObject("btnEmbarque.Image")));
            this.btnEmbarque.Location = new System.Drawing.Point(142, 105);
            this.btnEmbarque.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmbarque.Name = "btnEmbarque";
            this.btnEmbarque.Size = new System.Drawing.Size(74, 72);
            this.btnEmbarque.TabIndex = 2;
            this.btnEmbarque.UseVisualStyleBackColor = true;
            this.btnEmbarque.Click += new System.EventHandler(this.btnEmbarque_Click);
            // 
            // lblEmbarque
            // 
            this.lblEmbarque.AutoSize = true;
            this.lblEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarque.Location = new System.Drawing.Point(145, 90);
            this.lblEmbarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmbarque.Name = "lblEmbarque";
            this.lblEmbarque.Size = new System.Drawing.Size(81, 17);
            this.lblEmbarque.TabIndex = 3;
            this.lblEmbarque.Text = "Embarque";
            // 
            // groupBox1
            // 

            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-176, 27);

            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);

            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(316, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 

            // lblEquipaje
            // 
            this.lblEquipaje.AutoSize = true;
            this.lblEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipaje.Location = new System.Drawing.Point(343, 92);
            this.lblEquipaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipaje.Name = "lblEquipaje";
            this.lblEquipaje.Size = new System.Drawing.Size(71, 17);
            this.lblEquipaje.TabIndex = 6;
            this.lblEquipaje.Text = "Equipaje";
            // 
            // btnEquipaje
            // 
            this.btnEquipaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipaje.Image")));
            this.btnEquipaje.Location = new System.Drawing.Point(329, 105);
            this.btnEquipaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipaje.Name = "btnEquipaje";
            this.btnEquipaje.Size = new System.Drawing.Size(74, 72);
            this.btnEquipaje.TabIndex = 5;
            this.btnEquipaje.UseVisualStyleBackColor = true;
            this.btnEquipaje.Click += new System.EventHandler(this.btnEquipaje_Click);
            // 


            // lblPasaje
            // 
            this.lblPasaje.AutoSize = true;
            this.lblPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaje.Location = new System.Drawing.Point(154, 205);
            this.lblPasaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasaje.Name = "lblPasaje";
            this.lblPasaje.Size = new System.Drawing.Size(57, 17);
            this.lblPasaje.TabIndex = 8;
            this.lblPasaje.Text = "Pasaje";
            // 
            // btnPasaje
            // 
            this.btnPasaje.Image = ((System.Drawing.Image)(resources.GetObject("btnPasaje.Image")));
            this.btnPasaje.Location = new System.Drawing.Point(142, 220);
            this.btnPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasaje.Name = "btnPasaje";
            this.btnPasaje.Size = new System.Drawing.Size(74, 72);
            this.btnPasaje.TabIndex = 7;
            this.btnPasaje.UseVisualStyleBackColor = true;
            this.btnPasaje.Click += new System.EventHandler(this.btnPasaje_Click);
            // 
            // lblVuelo
            // 
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelo.Location = new System.Drawing.Point(337, 205);
            this.lblVuelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(49, 17);
            this.lblVuelo.TabIndex = 10;
            this.lblVuelo.Text = "Vuelo";
            // 
            // btnVuelo
            // 
            this.btnVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnVuelo.Image")));
            this.btnVuelo.Location = new System.Drawing.Point(318, 220);
            this.btnVuelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVuelo.Name = "btnVuelo";
            this.btnVuelo.Size = new System.Drawing.Size(74, 72);
            this.btnVuelo.TabIndex = 9;
            this.btnVuelo.UseVisualStyleBackColor = true;
            this.btnVuelo.Click += new System.EventHandler(this.btnVuelo_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(392, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 11;
            // 
            // lblEquipaje
            // 

            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);

            this.lblEquipaje.AutoSize = true;
            this.lblEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipaje.Location = new System.Drawing.Point(327, 90);
            this.lblEquipaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipaje.Name = "lblEquipaje";
            this.lblEquipaje.Size = new System.Drawing.Size(56, 13);
            this.lblEquipaje.TabIndex = 13;
            this.lblEquipaje.Text = "Equipaje";
            // 
            // btnEquipaje
            // 
            this.btnEquipaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipaje.Image")));
            this.btnEquipaje.Location = new System.Drawing.Point(318, 105);
            this.btnEquipaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipaje.Name = "btnEquipaje";
            this.btnEquipaje.Size = new System.Drawing.Size(74, 72);
            this.btnEquipaje.TabIndex = 12;
            this.btnEquipaje.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(538, 351);
            this.Controls.Add(this.lblNombreUsuario);

            this.ClientSize = new System.Drawing.Size(534, 331);

            this.Controls.Add(this.lblEquipaje);
            this.Controls.Add(this.btnEquipaje);
            this.Controls.Add(this.lblFecha);

            this.Controls.Add(this.lblVuelo);
            this.Controls.Add(this.btnVuelo);
            this.Controls.Add(this.lblPasaje);
            this.Controls.Add(this.btnPasaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmbarque);
            this.Controls.Add(this.btnEmbarque);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;

            this.Margin = new System.Windows.Forms.Padding(4);

            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem aeropuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeroToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem tipoAvionToolStripMenuItem;

        private System.Windows.Forms.Button btnEmbarque;
        private System.Windows.Forms.Label lblEmbarque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPasaje;
        private System.Windows.Forms.Button btnPasaje;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.Button btnVuelo;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embarquesPorFechaToolStripMenuItem;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEquipaje;
        private System.Windows.Forms.Button btnEquipaje;
    }
}