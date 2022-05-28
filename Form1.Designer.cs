namespace MascotaVirtualProyecto3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTiempoReal = new System.Windows.Forms.Label();
            this.labelVida = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSaludo = new System.Windows.Forms.TextBox();
            this.RBact1 = new System.Windows.Forms.RadioButton();
            this.RBact2 = new System.Windows.Forms.RadioButton();
            this.RBact4 = new System.Windows.Forms.RadioButton();
            this.RBact3 = new System.Windows.Forms.RadioButton();
            this.RBact6 = new System.Windows.Forms.RadioButton();
            this.RBact5 = new System.Windows.Forms.RadioButton();
            this.RBact8 = new System.Windows.Forms.RadioButton();
            this.RBact7 = new System.Windows.Forms.RadioButton();
            this.RBact9 = new System.Windows.Forms.RadioButton();
            this.RBact10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.RBVacio = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(110, 35);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MascotaVirtualProyecto3.Properties.Resources.Perrito;
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTiempoReal
            // 
            this.labelTiempoReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTiempoReal.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoReal.Location = new System.Drawing.Point(612, 58);
            this.labelTiempoReal.Name = "labelTiempoReal";
            this.labelTiempoReal.Size = new System.Drawing.Size(265, 33);
            this.labelTiempoReal.TabIndex = 2;
            this.labelTiempoReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTiempoReal.Click += new System.EventHandler(this.labelTiempoReal_Click);
            // 
            // labelVida
            // 
            this.labelVida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelVida.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVida.Location = new System.Drawing.Point(610, 105);
            this.labelVida.Name = "labelVida";
            this.labelVida.Size = new System.Drawing.Size(267, 33);
            this.labelVida.TabIndex = 3;
            this.labelVida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxSaludo
            // 
            this.textBoxSaludo.BackColor = System.Drawing.Color.Teal;
            this.textBoxSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaludo.ForeColor = System.Drawing.Color.White;
            this.textBoxSaludo.Location = new System.Drawing.Point(119, 43);
            this.textBoxSaludo.Multiline = true;
            this.textBoxSaludo.Name = "textBoxSaludo";
            this.textBoxSaludo.ReadOnly = true;
            this.textBoxSaludo.Size = new System.Drawing.Size(299, 72);
            this.textBoxSaludo.TabIndex = 4;
            this.textBoxSaludo.Text = "¡¡Hola!!, soy alex, tu mascota virtual";
            // 
            // RBact1
            // 
            this.RBact1.AutoSize = true;
            this.RBact1.BackColor = System.Drawing.Color.Transparent;
            this.RBact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact1.Location = new System.Drawing.Point(6, 50);
            this.RBact1.Name = "RBact1";
            this.RBact1.Size = new System.Drawing.Size(136, 29);
            this.RBact1.TabIndex = 5;
            this.RBact1.TabStop = true;
            this.RBact1.Text = "Desallunar";
            this.RBact1.UseVisualStyleBackColor = false;
            // 
            // RBact2
            // 
            this.RBact2.AutoSize = true;
            this.RBact2.BackColor = System.Drawing.Color.Transparent;
            this.RBact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact2.Location = new System.Drawing.Point(6, 85);
            this.RBact2.Name = "RBact2";
            this.RBact2.Size = new System.Drawing.Size(101, 29);
            this.RBact2.TabIndex = 6;
            this.RBact2.TabStop = true;
            this.RBact2.Text = "Pasear";
            this.RBact2.UseVisualStyleBackColor = false;
            // 
            // RBact4
            // 
            this.RBact4.AutoSize = true;
            this.RBact4.BackColor = System.Drawing.Color.Transparent;
            this.RBact4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact4.Location = new System.Drawing.Point(6, 155);
            this.RBact4.Name = "RBact4";
            this.RBact4.Size = new System.Drawing.Size(226, 29);
            this.RBact4.TabIndex = 8;
            this.RBact4.TabStop = true;
            this.RBact4.Text = "Estimulacion Mental";
            this.RBact4.UseVisualStyleBackColor = false;
            // 
            // RBact3
            // 
            this.RBact3.AutoSize = true;
            this.RBact3.BackColor = System.Drawing.Color.Transparent;
            this.RBact3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact3.Location = new System.Drawing.Point(6, 120);
            this.RBact3.Name = "RBact3";
            this.RBact3.Size = new System.Drawing.Size(97, 29);
            this.RBact3.TabIndex = 7;
            this.RBact3.TabStop = true;
            this.RBact3.Text = "Comer";
            this.RBact3.UseVisualStyleBackColor = false;
            // 
            // RBact6
            // 
            this.RBact6.AutoSize = true;
            this.RBact6.BackColor = System.Drawing.Color.Transparent;
            this.RBact6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact6.Location = new System.Drawing.Point(6, 225);
            this.RBact6.Name = "RBact6";
            this.RBact6.Size = new System.Drawing.Size(211, 29);
            this.RBact6.TabIndex = 10;
            this.RBact6.TabStop = true;
            this.RBact6.Text = "Bañarlo o limpiarlo";
            this.RBact6.UseVisualStyleBackColor = false;
            // 
            // RBact5
            // 
            this.RBact5.AutoSize = true;
            this.RBact5.BackColor = System.Drawing.Color.Transparent;
            this.RBact5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact5.Location = new System.Drawing.Point(6, 190);
            this.RBact5.Name = "RBact5";
            this.RBact5.Size = new System.Drawing.Size(323, 29);
            this.RBact5.TabIndex = 9;
            this.RBact5.TabStop = true;
            this.RBact5.Text = "Salir a hacer sus necesidades";
            this.RBact5.UseVisualStyleBackColor = false;
            // 
            // RBact8
            // 
            this.RBact8.AutoSize = true;
            this.RBact8.BackColor = System.Drawing.Color.Transparent;
            this.RBact8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact8.Location = new System.Drawing.Point(6, 293);
            this.RBact8.Name = "RBact8";
            this.RBact8.Size = new System.Drawing.Size(88, 29);
            this.RBact8.TabIndex = 12;
            this.RBact8.TabStop = true;
            this.RBact8.Text = "Jugar";
            this.RBact8.UseVisualStyleBackColor = false;
            // 
            // RBact7
            // 
            this.RBact7.AutoSize = true;
            this.RBact7.BackColor = System.Drawing.Color.Transparent;
            this.RBact7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact7.Location = new System.Drawing.Point(6, 258);
            this.RBact7.Name = "RBact7";
            this.RBact7.Size = new System.Drawing.Size(136, 29);
            this.RBact7.TabIndex = 11;
            this.RBact7.TabStop = true;
            this.RBact7.Text = "Descansar";
            this.RBact7.UseVisualStyleBackColor = false;
            // 
            // RBact9
            // 
            this.RBact9.AutoSize = true;
            this.RBact9.BackColor = System.Drawing.Color.Transparent;
            this.RBact9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact9.Location = new System.Drawing.Point(6, 328);
            this.RBact9.Name = "RBact9";
            this.RBact9.Size = new System.Drawing.Size(92, 29);
            this.RBact9.TabIndex = 14;
            this.RBact9.TabStop = true;
            this.RBact9.Text = "Cenar";
            this.RBact9.UseVisualStyleBackColor = false;
            // 
            // RBact10
            // 
            this.RBact10.AutoSize = true;
            this.RBact10.BackColor = System.Drawing.Color.Transparent;
            this.RBact10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBact10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBact10.Location = new System.Drawing.Point(6, 363);
            this.RBact10.Name = "RBact10";
            this.RBact10.Size = new System.Drawing.Size(96, 29);
            this.RBact10.TabIndex = 13;
            this.RBact10.TabStop = true;
            this.RBact10.Text = "Dormir";
            this.RBact10.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.RBVacio);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.RBact5);
            this.groupBox1.Controls.Add(this.RBact1);
            this.groupBox1.Controls.Add(this.RBact9);
            this.groupBox1.Controls.Add(this.RBact2);
            this.groupBox1.Controls.Add(this.RBact10);
            this.groupBox1.Controls.Add(this.RBact3);
            this.groupBox1.Controls.Add(this.RBact8);
            this.groupBox1.Controls.Add(this.RBact4);
            this.groupBox1.Controls.Add(this.RBact7);
            this.groupBox1.Controls.Add(this.RBact6);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 411);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(462, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tiempo real";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(460, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vida mascota";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(432, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 29);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(432, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 29);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(432, 120);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 29);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(432, 154);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 29);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(432, 189);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 29);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(432, 224);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(302, 29);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(432, 258);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(302, 29);
            this.textBox7.TabIndex = 31;
            this.textBox7.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(432, 292);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(302, 29);
            this.textBox8.TabIndex = 32;
            this.textBox8.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(432, 327);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(302, 29);
            this.textBox9.TabIndex = 33;
            this.textBox9.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(432, 362);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(302, 29);
            this.textBox10.TabIndex = 34;
            this.textBox10.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RBVacio
            // 
            this.RBVacio.AutoSize = true;
            this.RBVacio.BackColor = System.Drawing.Color.Transparent;
            this.RBVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBVacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RBVacio.Location = new System.Drawing.Point(6, 21);
            this.RBVacio.Name = "RBVacio";
            this.RBVacio.Size = new System.Drawing.Size(151, 29);
            this.RBVacio.TabIndex = 35;
            this.RBVacio.TabStop = true;
            this.RBVacio.Text = "Sin elección";
            this.RBVacio.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MascotaVirtualProyecto3.Properties.Resources.mascotasblue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 575);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSaludo);
            this.Controls.Add(this.labelVida);
            this.Controls.Add(this.labelTiempoReal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mi mascota virtual";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTiempoReal;
        private System.Windows.Forms.Label labelVida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxSaludo;
        private System.Windows.Forms.RadioButton RBact1;
        private System.Windows.Forms.RadioButton RBact2;
        private System.Windows.Forms.RadioButton RBact4;
        private System.Windows.Forms.RadioButton RBact3;
        private System.Windows.Forms.RadioButton RBact6;
        private System.Windows.Forms.RadioButton RBact5;
        private System.Windows.Forms.RadioButton RBact8;
        private System.Windows.Forms.RadioButton RBact7;
        private System.Windows.Forms.RadioButton RBact9;
        private System.Windows.Forms.RadioButton RBact10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RBVacio;
    }
}