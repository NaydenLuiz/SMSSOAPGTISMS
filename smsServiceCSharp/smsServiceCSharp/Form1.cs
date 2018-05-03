using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smsServiceCSharp
{
    public partial class Form1 : Form
    {
        public System.DateTime dtInicial = System.DateTime.Parse("01/02/2018");

        public System.DateTime dtFinal = System.DateTime.Parse("11/02/2018");
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //'Testa se o web service responde e dar as mensagens de boas vindas no Cabeçalho do form
            try
            {
                //Instancia do WebService
                wsSMS.SMSServiceSoapClient sms = new wsSMS.SMSServiceSoapClient();
                // E necessário pois algumas vezes o tempo de resposta do webservice pode ser maior do que 
                // a que o sistema aceita esperar
                System.Net.ServicePointManager.Expect100Continue = false;

                this.Text = sms.envioTeste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Acessar webService:" + ex.Message);
            }

        }



        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            wsSMS.SMSServiceSoapClient sms = new wsSMS.SMSServiceSoapClient();
            string strretorno = null;
            //Pega o retorno em String de todas as mensagens recebidas
            strretorno = sms.ChecarRecebidas("seu@email.com", "12345", dtInicial, dtFinal);

            MessageBox.Show(strretorno);
        }

        private void Button2_Click(System.Object sender, System.EventArgs e)
        {
            wsSMS.SMSServiceSoapClient sms = new wsSMS.SMSServiceSoapClient();
            System.Data.DataTable dtretorno = null;
            //
            //Pega as mensagens recebidas em um DataTable
            dtretorno = sms.ChecarRecebidasData("seu@email.com", "12345", dtInicial, dtFinal);
            if ((dtretorno != null))
            {
                MessageBox.Show("Data table retornou " + dtretorno.Rows.Count + " registros.");
            }
            else
            {
                MessageBox.Show("Data table não retornou registros.");
            }

        }

        private void Button3_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                wsSMS.SMSServiceSoapClient sms = new wsSMS.SMSServiceSoapClient();
                long StrRetorno = 0 ;
                //Realiza o envio de mensagem e pega o retorno.
                
                StrRetorno = sms.envioMessagem("seu@email.com", "12345", txtMensagem.Text, txtNumero.Text, "1");
                
                MessageBox.Show("Retorno:" + StrRetorno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem: " + ex.Message);
            }
        }

        private void Button4_Click(System.Object sender, System.EventArgs e)
        {
            string qtdCreditos = null;
            wsSMS.SMSServiceSoapClient sms = new wsSMS.SMSServiceSoapClient();
            System.Net.ServicePointManager.MaxServicePointIdleTime = 240;
            System.Net.ServicePointManager.Expect100Continue = true;
            //o webservice demora mais tempo pra processar a quantidade de créditos do que as demais funções, por isso aumento o timeout de espera pra 240.
            qtdCreditos = sms.verificaCredito("seu@email.com", "12345");
            MessageBox.Show(" Créditos:" + qtdCreditos);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
