using System.Windows.Forms.Design;
using ConsumirApiNoviosTs.Service;

namespace ConsumirApiNoviosTs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var api = new NovioService();
            var success = await api.LoginAsync("admin", "123");

            if (success)
            {
                MessageBox.Show("Login exitoso!");
                var novios = await api.GetNoviosAsync();
                dataGridView1.DataSource = novios;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
