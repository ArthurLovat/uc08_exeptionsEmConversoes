namespace uc08_exeptionsEmConversoes
{
    public partial class Form1 : Form
    {
        float totalValores;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valor, valorParcela;
            int parcelas;

            if (ValidarForm())
            {
                valor = float.Parse(txtValor.Text);
                parcelas = Convert.ToInt32(txtParcelas.Text);
                valorParcela = valor / parcelas;

                txtValorTotal.Text = valorParcela.ToString();

                totalValores += valor;
                txtTotalAcumulado.Text = txtValorTotal.ToString();
            }
            else
                MessageBox.Show("Alguns erros foream encontrados");
        }

        private bool ValidarForm()
        {
            bool resultado = true;
            float tempfloat;
            int tempint = 0;

            //Se o valor foi preenchido
            if(string.IsNullOrEmpty(txtValor.Text) ) //se é vazio
            {
                resultado = false;
                MessageBox.Show("O Valor não pode ser vazio!");
            }

            //se é um float valido
            else if(!float.TryParse(txtValor.Text, out  tempfloat)) //"!" = se nao foi convertido
            {
                resultado = false;
                MessageBox.Show("Valor Invalido!");
            }

            //se é um valor maior que zero
            else if (tempfloat <= 0.0f)
            {
                resultado = false;
                MessageBox.Show("O valor precisa ser maior que zero!");
            }

            if (string.IsNullOrEmpty(txtParcelas.Text))
            {
                resultado = false;
                MessageBox.Show("Parcelas não pode ser vazio");
            }
            else if(tempint <= 0.0f)
            {
                resultado = false;
                MessageBox.Show("Parcelas precisa ser maior que zero");
            }
            else if(!int.TryParse(txtParcelas.Text, out tempint))
            {
                resultado = false;
                MessageBox.Show("Parcela invalida!");
            }



            return resultado;
        }
    }
}
