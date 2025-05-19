using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Projeto
{
    public partial class frmConsultaCep : Form
    {
        public frmConsultaCep()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "");

            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);

                    if (endereco.cep != null)
                    {
                        lblResultado.Text = $"Entregaremos no endereço: {endereco.logradouro}, {endereco.bairro}, {endereco.localidade} - {endereco.uf}";
                    }
                    else
                    {
                        lblResultado.Text = "CEP não encontrado.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCep_Load(object sender, EventArgs e)
        {

        }
    }
}
