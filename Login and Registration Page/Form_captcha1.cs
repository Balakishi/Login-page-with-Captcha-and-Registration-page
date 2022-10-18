using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_Page
{
    public partial class Form_captcha1 : Form
    {
        public Form_captcha1()
        {
            InitializeComponent();
        }

        private void btn_capctha_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text=="")
            {
                Creater();
            }
            
        }
        //captcha labeline random reqem ve herfler cixarsin deye method yaratmışıq
        private void Creater()
        {
            Random random = new Random();
            string capctha = "";
            //hansı ki, labelin uzunluğu 6 ilə 10 arasında dəyişəcək
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    capctha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                capctha += char.ConvertFromUtf32(random.Next(48, 58));
            }
            label_capctha.Text = capctha;
        }

        /*əgər başa düşmədik captchanı refresh butonuyla təzələyə bilərik
         * amma və lakin input etdiyimiz textboxu boş saxlamaq şərtilə
         * yəni yaza yaza refresh edə bilmərsiniz, başa düşmədiniz capcthani silin yazdığınızı və
         * refresh verin yeni captchanı sınayın
         */
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text=="")
            {
                Creater();
            }
        }
        /*əgər input boşdusa ekrana messagebox çıxacaq ki, captcha daxil etməmisiniz 
         * əgər textboxla captcha eynidisə sizi welcome forumuna yönləndirəcək yəni siz artıq sistemə öz hesabınıza
         * giriş etmiş olacaqsız
         */
        private void btn_result_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                MessageBox.Show("You haven't the captcha, please enter the capctha", "Enter the capctha!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (label_capctha.Text == textBox_input.Text)
            {
                    Form_Welcome form = new Form_Welcome();
                    this.Hide();
                    form.ShowDialog();   
            }
            else
            {
                /*əgər textbox inputla captcha labeli eyni deyilsə message box çıxacaq ki sehv girdiz yeniden deniyin
                 * və oku bassanız textbox inputu və labeli təmizləyəcək siz yenidən click edərək captcha çıxara bilərsiniz
                 */
                DialogResult dialogresult = MessageBox.Show("You have entered incorrectly,Please try again to do the login", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.OK)
                {
                    textBox_input.Text = "";
                    label_capctha.Text = "";

                }
            }
        }
    }
}
