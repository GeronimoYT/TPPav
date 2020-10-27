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
            this.vueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmbarque = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vueloToolStripMenuItem.Text = "Vuelo";
            this.vueloToolStripMenuItem.Click += new System.EventHandler(this.vueloToolStripMenuItem_Click);
            // 
            // pasajeToolStripMenuItem
            // 
            this.pasajeToolStripMenuItem.Name = "pasajeToolStripMenuItem";
            this.pasajeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pasajeToolStripMenuItem.Text = "Pasaje";
            this.pasajeToolStripMenuItem.Click += new System.EventHandler(this.pasajeToolStripMenuItem_Click);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeropuertoToolStripMenuItem,
            this.vueloToolStripMenuItem,
            this.pasajeToolStripMenuItem,
            this.avionToolStripMenuItem,
            this.pasajeroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(71, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 88);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEmbarque
            // 
            this.lblEmbarque.AutoSize = true;
            this.lblEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarque.Location = new System.Drawing.Point(89, 82);
            this.lblEmbarque.Name = "lblEmbarque";
            this.lblEmbarque.Size = new System.Drawing.Size(63, 13);
            this.lblEmbarque.TabIndex = 3;
            this.lblEmbarque.Text = "Embarque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Location = new System.Drawing.Point(-176, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmbarque);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem aeropuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeroToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEmbarque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}