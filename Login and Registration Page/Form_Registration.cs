using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_Page
{
    public partial class Form_Registration : Form
    {
        public Form_Registration()
        {
            InitializeComponent();
        }

        private void btn_capctha_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_Regist_username.Text != "" && txtbox_Regist_password.Text != "" && txtbox_confirmPassword.Text != ""
                    && txtbox_confirmPassword.Text==txtbox_Regist_password.Text)
                {
                    /* əgər file exist deyilsə yaradacaq, və faylın adini özüm username textboxunun adını qoymuşamki
                     * istənilən sistemdə bir username-ə bir dəfə qeydiyyatdan keçmək olur məsələn elcan adlı username 
                     * və 123 passvordda hesab yaratdımsa men təzədən elcan adında passvordu fərqli hesab yarada bilmərəm
                     * gedib baxacaq c diskində elcan adlı file var yaratmayacaq ve ekrana messagebox çıxaracaq
                     */
                    if (!File.Exists("C:\\" + txtbox_Regist_username.Text + "\\login.ID"))
                    {
                        /*burda yuxarıda dediyim kimi əgər file exist deyilsə sw və swp adlı iki file yaradacaq ve onu 
                         * usernamein adında olan folder yaradıb orda saxlayacaq burda yaradırıq ki, logində həmin
                         * filleri oxusun və check eləsin belə username və passvordda qeydiyyatdan keçilibmi deyə.
                         * File yaratdıqdan sonra yəni registration qeyd edilir və bu forumu bağlayıb 
                         * conguralitons forumuna keçid edəcək.
                         */
                        Form_conguralitons frmcong = new Form_conguralitons();
                        var sw = new System.IO.StreamWriter("C:\\" + txtbox_Regist_username.Text + "\\login.ID");
                        var swp = new System.IO.StreamWriter("C:\\" + txtbox_Regist_username.Text + "\\login.password");
                        sw.Write(txtbox_Regist_username.Text);
                        swp.Write(txtbox_Regist_password.Text);
                        sw.Close();
                        swp.Close();
                        this.Hide();
                        frmcong.Show();
                    }
                    else if(File.Exists("C:\\" + txtbox_Regist_username.Text + "\\login.ID"))
                    {
                        //eger o username adinda bir defe qeydiyyatdan kecilibse ekrana messagebox cixaracaq
                        MessageBox.Show("This username already has a profile, please use another username!","Error!" ,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /*asagidaki caselerde biri bos olub ve ya ikisi birden bos olub ve ya confirm 
                 * passwordla password uygun hərəsinin özünə uyğun messagebox çıxaracaq*/
                else if (txtbox_Regist_username.Text == "" && txtbox_Regist_password.Text == "" && txtbox_confirmPassword.Text == "")
                {
                    MessageBox.Show("Please enter the username, password and confirm password","Error!",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (txtbox_Regist_username.Text=="")
                {
                    MessageBox.Show("Please enter the username", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtbox_Regist_password.Text=="")
                {
                    MessageBox.Show("Please enter the password" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtbox_confirmPassword.Text=="")
                {
                    MessageBox.Show("Please enter the confirm password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtbox_Regist_username.Text!="" && txtbox_Regist_password!=txtbox_confirmPassword)
                {
                    MessageBox.Show("You confirm password is not equal password, please try again", "Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            catch(System.IO.DirectoryNotFoundException ex)
            {
                /*catch içində o yazılıbki run müddətində hər hansısa qırılma olsa belə əgər o adda file yoxdursa
                 * file yaratsın və bu forumu bağlayıb conguralitons forumuna keçid edəcək.
                 * Catchin içində yenə try catch yazmışam ki digər cathcda da əgər o adda file varsa artıq
                 * ekrana message box çıxarsın ki, bu adda username var artıq sistemdə başqa username seçin özünüzə
                 */
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\" + txtbox_Regist_username.Text);
                    var sw = new System.IO.StreamWriter("C:\\" + txtbox_Regist_username.Text + "\\login.ID");
                    sw.Write(txtbox_Regist_username.Text);
                    sw.Close();


                    System.IO.Directory.CreateDirectory("C:\\" + txtbox_Regist_username.Text);
                    var swp = new System.IO.StreamWriter("C:\\" + txtbox_Regist_username.Text + "\\login.password");
                    swp.Write(txtbox_Regist_password.Text);
                    swp.Close();
                    Form_conguralitons frmcong = new Form_conguralitons();
                    this.Hide();
                    frmcong.Show();
                }
                catch
                {
                    MessageBox.Show("There is already an account with this username, please choose another username for yourself!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Regist_clear_Click(object sender, EventArgs e)
        {
            //clear butonudur textboxlardaki yazilari silecek  ve username textboxunu fokuslayacaq
            txtbox_Regist_username.Clear();
            txtbox_Regist_password.Clear();
            txtbox_confirmPassword.Clear();
            txtbox_Regist_username.Focus();
        }

        private void checkBox_Regist_password_CheckedChanged(object sender, EventArgs e)
        {
            /*bu if else ona görə istifadə etmişəm ki, password textboxuna passwordchar olaraq '*' təyin etmişəm
             * və bu if check eliyir əgər textbox təyin etdiyim '*'-la yazılıbsa ona basdıqda ulduz əvəzinə passwordu show
             * eliyir, yox əgər showdusa ulduza qaytarır
             */
            if (checkBox_Regist_password.Checked)
            {
                txtbox_Regist_password.PasswordChar = '\0';
                txtbox_confirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtbox_Regist_password.PasswordChar = '*';
                txtbox_confirmPassword.PasswordChar = '*';
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //backe basdıqda bu forumu bağlayıb logine qayıdacaq
            Form_Login formlogin= new Form_Login();
            this.Hide();
            formlogin.ShowDialog();
        }
    }
}
