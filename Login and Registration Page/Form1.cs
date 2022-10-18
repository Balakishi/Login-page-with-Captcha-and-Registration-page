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
    public partial class Form_Login : Form
    {

        public string password, username;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            //sign up butonuna basdıqda bu forumu bağlayıb, registration forumunu açacaq
            Form_Registration frm= new Form_Registration();
            this.Hide();
            frm.ShowDialog();
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            /*bu if else ona görə istifadə etmişəm ki, password textboxuna passwordchar olaraq '*' təyin etmişəm
             * və bu if check eliyir əgər textbox təyin etdiyim '*'-la yazılıbsa ona basdıqda ulduz əvəzinə passwordu show
             * eliyir, yox əgər showdusa ulduza qaytarır
             */
            if (checkBox_password.Checked)
            {
                txtbox_password.PasswordChar = '\0';
            }
            else
            {
                txtbox_password.PasswordChar = '*';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //clear butonuna basdıqda passoword və username textboxunu clear edir və fokusu username textboxuna verir
            txtbox_password.Clear();
            txtbox_username.Clear();
            txtbox_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_username.Text != "" && txtbox_password.Text != "")
                {
                    /*əgər username ve passvord textboxu boş deyilsə( sr və srp adı altında iki papka yaratmışıq biz 
                     * registration pageində) getsin sr ve srp fayylarini oxusun sr username beraber etmisem srp-i
                     * passvorda bərabər etmişəm
                     */
                    var sr = new System.IO.StreamReader("C:\\" + txtbox_username.Text + "\\login.ID");
                    var srp = new System.IO.StreamReader("C:\\" + txtbox_username.Text + "\\login.password");
                    username = sr.ReadLine();
                    password = srp.ReadLine();
                    sr.Close();
                    srp.Close();


                    /*əgər username textboxusername və passvordda textboxpassvorda bərabərdisə
                     * messagebox çıxacaqki username ve passvordu düz girdiz sizi captchaya yonlendiririk
                     * əgər oka bassanız bu captcha forumunu açacaq cancel etsəniz açmayacaq
                     */
                    if (username == txtbox_username.Text && password == txtbox_password.Text)
                    {
                        DialogResult result = MessageBox.Show("Username and password are correct, now you need to pass capctha to login!", "Capctha",
                        MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            Form_captcha1 form = new Form_captcha1();
                            form.ShowDialog();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            Form_captcha1 form1 = new Form_captcha1();
                            form1.Close();
                        }
                    }
                    //əgər passvordla textboxpassvord uyğun gelmese ekrana messagebox çıxaracaq
                    else if (password != txtbox_password.Text)
                        MessageBox.Show("Password is wrong! please enter the correct password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               /*aşağıdaki hallarda ki ikisi birdən boş olanda və ya biri boş olub digəri dolu olduqda hərəsinə
                * uyğun messageboxlar çıxaracaq
                */
                else if (txtbox_password.Text == "" && txtbox_username.Text == "")
                    MessageBox.Show("Please enter the username and password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtbox_username.Text == "")
                    MessageBox.Show("Please enter the username", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtbox_password.Text == "")
                    MessageBox.Show("Please enter the password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            /* catchda ise yuxardaki nezere aldiqim caselerden elave username duz olub passvord sehv olduqda ve ya
            ikisi birden sehv olduqda veya password duz olub username sehv olduqda ekrana message box cixaracaq */
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("authentication failed! Username or password is incorrect", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
