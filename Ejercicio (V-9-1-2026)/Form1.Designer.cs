namespace Ejercicio__V_9_1_2026_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Lcali = new Label();
            Lencasode = new Label();
            tbxp1 = new TextBox();
            tbxp4 = new TextBox();
            tbxp3 = new TextBox();
            tbxp2 = new TextBox();
            tbxencasode = new TextBox();
            bcalcular = new Button();
            bcerrar = new Button();
            bguardar = new Button();
            blimpia = new Button();
            pictureBox1 = new PictureBox();
            gbRecuperacion = new GroupBox();
            LExtraordinario = new Label();
            txbextra = new TextBox();
            txbrefor = new TextBox();
            LReforzamiento = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbRecuperacion.SuspendLayout();
            SuspendLayout();
            // 
            // Lcali
            // 
            Lcali.AutoSize = true;
            Lcali.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Lcali.Location = new Point(136, 110);
            Lcali.Margin = new Padding(4, 0, 4, 0);
            Lcali.Name = "Lcali";
            Lcali.Size = new Size(214, 19);
            Lcali.TabIndex = 0;
            Lcali.Text = "INGRESAR CALIFICACIONES";
            // 
            // Lencasode
            // 
            Lencasode.AutoSize = true;
            Lencasode.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Lencasode.Location = new Point(7, 45);
            Lencasode.Margin = new Padding(4, 0, 4, 0);
            Lencasode.Name = "Lencasode";
            Lencasode.Size = new Size(84, 19);
            Lencasode.TabIndex = 1;
            Lencasode.Text = "Completivo\r\n";
            Lencasode.Click += Lencasode_Click;
            // 
            // tbxp1
            // 
            tbxp1.Location = new Point(57, 157);
            tbxp1.Name = "tbxp1";
            tbxp1.Size = new Size(56, 26);
            tbxp1.TabIndex = 2;
            // 
            // tbxp4
            // 
            tbxp4.Location = new Point(346, 157);
            tbxp4.Name = "tbxp4";
            tbxp4.Size = new Size(56, 26);
            tbxp4.TabIndex = 3;
            // 
            // tbxp3
            // 
            tbxp3.Location = new Point(256, 157);
            tbxp3.Name = "tbxp3";
            tbxp3.Size = new Size(56, 26);
            tbxp3.TabIndex = 4;
            // 
            // tbxp2
            // 
            tbxp2.Location = new Point(155, 157);
            tbxp2.Name = "tbxp2";
            tbxp2.Size = new Size(56, 26);
            tbxp2.TabIndex = 5;
            // 
            // tbxencasode
            // 
            tbxencasode.Location = new Point(124, 45);
            tbxencasode.Name = "tbxencasode";
            tbxencasode.Size = new Size(65, 21);
            tbxencasode.TabIndex = 6;
            // 
            // bcalcular
            // 
            bcalcular.Location = new Point(89, 239);
            bcalcular.Name = "bcalcular";
            bcalcular.Size = new Size(75, 23);
            bcalcular.TabIndex = 7;
            bcalcular.Text = "Calcular";
            bcalcular.UseVisualStyleBackColor = true;
            bcalcular.Click += bcalcular_Click;
            // 
            // bcerrar
            // 
            bcerrar.Location = new Point(734, 439);
            bcerrar.Name = "bcerrar";
            bcerrar.Size = new Size(75, 23);
            bcerrar.TabIndex = 8;
            bcerrar.Text = "Cerrar";
            bcerrar.UseVisualStyleBackColor = true;
            bcerrar.Click += blimpiar_Click;
            // 
            // bguardar
            // 
            bguardar.Location = new Point(94, 183);
            bguardar.Name = "bguardar";
            bguardar.Size = new Size(75, 23);
            bguardar.TabIndex = 9;
            bguardar.Text = "Guardar";
            bguardar.UseVisualStyleBackColor = true;
            bguardar.Click += bguardar_Click;
            // 
            // blimpia
            // 
            blimpia.Location = new Point(266, 239);
            blimpia.Name = "blimpia";
            blimpia.Size = new Size(75, 23);
            blimpia.TabIndex = 10;
            blimpia.Text = "Limpiar";
            blimpia.UseVisualStyleBackColor = true;
            blimpia.Click += blimpia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // gbRecuperacion
            // 
            gbRecuperacion.Controls.Add(LExtraordinario);
            gbRecuperacion.Controls.Add(txbextra);
            gbRecuperacion.Controls.Add(txbrefor);
            gbRecuperacion.Controls.Add(bguardar);
            gbRecuperacion.Controls.Add(LReforzamiento);
            gbRecuperacion.Controls.Add(label1);
            gbRecuperacion.Controls.Add(Lencasode);
            gbRecuperacion.Controls.Add(tbxencasode);
            gbRecuperacion.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRecuperacion.Location = new Point(528, 38);
            gbRecuperacion.Name = "gbRecuperacion";
            gbRecuperacion.Size = new Size(259, 224);
            gbRecuperacion.TabIndex = 12;
            gbRecuperacion.TabStop = false;
            gbRecuperacion.Text = "Recuperacion";
            gbRecuperacion.Visible = false;
            gbRecuperacion.Enter += groupBox1_Enter;
            // 
            // LExtraordinario
            // 
            LExtraordinario.AutoSize = true;
            LExtraordinario.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LExtraordinario.Location = new Point(7, 139);
            LExtraordinario.Margin = new Padding(4, 0, 4, 0);
            LExtraordinario.Name = "LExtraordinario";
            LExtraordinario.Size = new Size(105, 19);
            LExtraordinario.TabIndex = 14;
            LExtraordinario.Text = "Extraordinario\r\n";
            // 
            // txbextra
            // 
            txbextra.Location = new Point(124, 137);
            txbextra.Name = "txbextra";
            txbextra.Size = new Size(65, 21);
            txbextra.TabIndex = 13;
            // 
            // txbrefor
            // 
            txbrefor.Location = new Point(124, 92);
            txbrefor.Name = "txbrefor";
            txbrefor.Size = new Size(65, 21);
            txbrefor.TabIndex = 13;
            // 
            // LReforzamiento
            // 
            LReforzamiento.AutoSize = true;
            LReforzamiento.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LReforzamiento.Location = new Point(6, 94);
            LReforzamiento.Margin = new Padding(4, 0, 4, 0);
            LReforzamiento.Name = "LReforzamiento";
            LReforzamiento.Size = new Size(102, 19);
            LReforzamiento.TabIndex = 13;
            LReforzamiento.Text = "Reforzamiento\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 487);
            Controls.Add(gbRecuperacion);
            Controls.Add(pictureBox1);
            Controls.Add(blimpia);
            Controls.Add(bcerrar);
            Controls.Add(bcalcular);
            Controls.Add(tbxp2);
            Controls.Add(tbxp3);
            Controls.Add(tbxp4);
            Controls.Add(tbxp1);
            Controls.Add(Lcali);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbRecuperacion.ResumeLayout(false);
            gbRecuperacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lcali;
        private Label Lencasode;
        private TextBox tbxp1;
        private TextBox tbxp4;
        private TextBox tbxp3;
        private TextBox tbxp2;
        private TextBox tbxencasode;
        private Button bcalcular;
        private Button bcerrar;
        private Button bguardar;
        private Button blimpia;
        private PictureBox pictureBox1;
        private GroupBox gbRecuperacion;
        private Label label1;
        private Label LReforzamiento;
        private TextBox txbrefor;
        private Label LExtraordinario;
        private TextBox txbextra;
    }
}
