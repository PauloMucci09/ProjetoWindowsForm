using System.Drawing.Text;

namespace WindowsForminc
{
    public partial class Frminc : Form
    {
        //Variaveis Global
        float imc = 0;
        public Frminc()
        {
            InitializeComponent();
        }

        private float CalculoInc(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;
        }
            
          private void btninc_Click(object sender, EventArgs e)
       
        {
            CalculoInc(float.Parse(txtpeso.Text), float.Parse(txtaltura.Text));
            string tipoImc;
            
            

            switch(imc)
            {
                case >= 40:
                    tipoImc = "Obesidade III";
                    break;

                case >= 35:
                    tipoImc = "Obesidade II";
                    break;
                case >= 30:
                    tipoImc = "Obesidade I";
                    break;
                case >= 25:
                    tipoImc = "Levemente acima do peso";
                    break;
                case >= 18:
                    tipoImc = "Peso ideal";
                    break;
                default:
                    tipoImc = "Abaixo do peso";
                    break ;
            }

            MessageBox.Show($"IMC:{imc:F2}\n"+$"Grau:{tipoImc} ");





        }
        



    }

}
