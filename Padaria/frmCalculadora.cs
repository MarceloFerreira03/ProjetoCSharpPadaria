using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        //    //Declarando variáveis
        //    //tipo da variável
        //    //E igual o nome da variável
        //    int valor1, valor4;
        //    double valor2;
        //    float valor3;
        //    bool flag;
        //    string nome;
        //    char sexo;

        //    //Inicializar as variáveis
        //    valor1 = 10;
        //    valor4 = 10;

        //Declarando as variáveis


        double num1, num2, resp = 0;

            try
            {


                //Inicializat as variáveis 

                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rdbSomar.Checked)
                {
                    resp = num1 + num1;
                }
                if (rdbSubtrair.Checked)
                {
                    resp = num1 - num1;

                }
                if (rdbMultiplicar.Checked)
                {
                    resp = num1 * num2;
                }
                if (rdbDivisao.Checked)
                {
                    resp = num1 / num2;
                }
                if (num2 == 0)
                {
                    MessageBox.Show("Impossível dividir por zero!", "Mensagem do Sistema",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    resp = 0;
                }
                else
                {
                    resp = num1 / num2;
                }


                txtResposta.Text = resp.ToString();
            } catch(Exception)
            {
                MessageBox.Show("Favor Inserir somente números", "Mesagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }





        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Sair do sistema e encerrar todos
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtResposta.Clear();

            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDivisao.Checked = false;

            txtNumero1.Focus();
                            
        }
    }
}
