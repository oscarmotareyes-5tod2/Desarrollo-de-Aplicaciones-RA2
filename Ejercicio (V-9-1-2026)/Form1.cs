namespace Ejercicio__V_9_1_2026_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bcalcular_Click(object sender, EventArgs e)
        {
            int p1 = int.Parse(tbxp1.Text);
            int p2 = int.Parse(tbxp2.Text);
            int p3 = int.Parse(tbxp3.Text);
            int p4 = int.Parse(tbxp4.Text);
            double promedio;
            promedio = (p1 + p2 + p3 + p4) / 4;
            if (promedio <= 69)
            {
               gbRecuperacion.Visible=true;

                MessageBox.Show($"REPROBADO💣💣{promedio}", "ESTADO");
            }

            else
            {

                MessageBox.Show($"Aprobado con {promedio}😊👌", "Promedio");
            }


        }

        private void blimpiar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado");
        }

        private void blimpia_Click(object sender, EventArgs e)
        {
            tbxp1.Clear();
            tbxp2.Clear();
            tbxp3.Clear();
            tbxp4.Clear();
            tbxencasode.Clear();
            txbextra.Clear();
            txbrefor.Clear();

            gbRecuperacion.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lencasode_Click(object sender, EventArgs e)
        {

        }
    }
}
