namespace TorresHanoi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlPlaneacion = new System.Windows.Forms.Panel();
            this.nmrDiscos = new System.Windows.Forms.NumericUpDown();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.Torres = new System.Windows.Forms.Panel();
            this.pnlTorre2 = new System.Windows.Forms.Panel();
            this.pnlTorre3 = new System.Windows.Forms.Panel();
            this.pnlTorre1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlPlaneacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscos)).BeginInit();
            this.pnlJuego.SuspendLayout();
            this.Torres.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneacion
            // 
            this.pnlPlaneacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlaneacion.Controls.Add(this.nmrDiscos);
            this.pnlPlaneacion.Controls.Add(this.lblDiscos);
            this.pnlPlaneacion.Controls.Add(this.txtJugador);
            this.pnlPlaneacion.Controls.Add(this.lblJugador);
            this.pnlPlaneacion.Controls.Add(this.btnJugar);
            this.pnlPlaneacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlaneacion.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaneacion.Name = "pnlPlaneacion";
            this.pnlPlaneacion.Size = new System.Drawing.Size(822, 73);
            this.pnlPlaneacion.TabIndex = 0;
            // 
            // nmrDiscos
            // 
            this.nmrDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDiscos.Location = new System.Drawing.Point(461, 22);
            this.nmrDiscos.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nmrDiscos.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmrDiscos.Name = "nmrDiscos";
            this.nmrDiscos.Size = new System.Drawing.Size(120, 29);
            this.nmrDiscos.TabIndex = 4;
            this.nmrDiscos.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscos.ForeColor = System.Drawing.Color.White;
            this.lblDiscos.Location = new System.Drawing.Point(382, 28);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(78, 24);
            this.lblDiscos.TabIndex = 3;
            this.lblDiscos.Text = "Discos:";
            // 
            // txtJugador
            // 
            this.txtJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador.Location = new System.Drawing.Point(130, 20);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(188, 29);
            this.txtJugador.TabIndex = 2;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.White;
            this.lblJugador.Location = new System.Drawing.Point(32, 22);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(92, 24);
            this.lblJugador.TabIndex = 1;
            this.lblJugador.Text = "Jugador:";
            // 
            // btnJugar
            // 
            this.btnJugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJugar.BackgroundImage")));
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.Location = new System.Drawing.Point(632, 0);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(79, 73);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pnlJuego
            // 
            this.pnlJuego.BackColor = System.Drawing.Color.White;
            this.pnlJuego.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlJuego.BackgroundImage")));
            this.pnlJuego.Controls.Add(this.lblTiempo);
            this.pnlJuego.Controls.Add(this.lblMovimientos);
            this.pnlJuego.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJuego.Location = new System.Drawing.Point(0, 455);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(822, 30);
            this.pnlJuego.TabIndex = 1;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(711, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(111, 25);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = " 00:00:00";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.lblMovimientos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.ForeColor = System.Drawing.Color.White;
            this.lblMovimientos.Location = new System.Drawing.Point(0, 0);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(224, 25);
            this.lblMovimientos.TabIndex = 0;
            this.lblMovimientos.Text = "Movimientos: 0 de 0";
            // 
            // Torres
            // 
            this.Torres.BackColor = System.Drawing.Color.Transparent;
            this.Torres.Controls.Add(this.pnlTorre2);
            this.Torres.Controls.Add(this.pnlTorre3);
            this.Torres.Controls.Add(this.pnlTorre1);
            this.Torres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Torres.Location = new System.Drawing.Point(0, 73);
            this.Torres.Name = "Torres";
            this.Torres.Size = new System.Drawing.Size(822, 382);
            this.Torres.TabIndex = 2;
            // 
            // pnlTorre2
            // 
            this.pnlTorre2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTorre2.Location = new System.Drawing.Point(274, 0);
            this.pnlTorre2.Name = "pnlTorre2";
            this.pnlTorre2.Size = new System.Drawing.Size(274, 382);
            this.pnlTorre2.TabIndex = 2;
            // 
            // pnlTorre3
            // 
            this.pnlTorre3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTorre3.Location = new System.Drawing.Point(548, 0);
            this.pnlTorre3.Name = "pnlTorre3";
            this.pnlTorre3.Size = new System.Drawing.Size(274, 382);
            this.pnlTorre3.TabIndex = 1;
            // 
            // pnlTorre1
            // 
            this.pnlTorre1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTorre1.Location = new System.Drawing.Point(0, 0);
            this.pnlTorre1.Name = "pnlTorre1";
            this.pnlTorre1.Size = new System.Drawing.Size(274, 382);
            this.pnlTorre1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.Torres);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlPlaneacion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPlaneacion.ResumeLayout(false);
            this.pnlPlaneacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscos)).EndInit();
            this.pnlJuego.ResumeLayout(false);
            this.pnlJuego.PerformLayout();
            this.Torres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlaneacion;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.NumericUpDown nmrDiscos;
        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Panel Torres;
        private System.Windows.Forms.Panel pnlTorre2;
        private System.Windows.Forms.Panel pnlTorre3;
        private System.Windows.Forms.Panel pnlTorre1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Timer timer;

    }
}

