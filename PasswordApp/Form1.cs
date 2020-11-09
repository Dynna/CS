using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordApp
{
    public partial class PasswordApp : Form
    {
        public PasswordApp()
        {
            InitializeComponent();
        }

        // Each code is 8 characters long
        public string code = CodeGenerator.CreateCode(8);

        // When click send button, the application is shipping a confirmation code to the user through e-mail
        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                // Mail service credentials which can be stored in a .config file
                client.Credentials = new NetworkCredential("application.test122@gmail.com", "airplane000");
                MailMessage msg = new MailMessage();
                msg.To.Add(emailBox.Text);
                var eMailValidator = new MailAddress(emailBox.Text);
                msg.From = new MailAddress("application.test122@gmail.com");
                msg.Subject = "Your confirmation code for APP";
                msg.Body = "This is your confirmation code to complete registration: " + code;
           
                client.Send(msg);
                MessageBox.Show("Confirmation code sent successfully! Check your e-mail within 1 minute.");
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is Exception)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
           // This code is used to save user email into database
           /* using (SqlConnection connection = new SqlConnection("Server=localhost;Database=MyApplication;Trusted_Connection=True"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Client_Details] ([Email]) VALUES (@email)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            } */
        }

        // When click enter button, the application processes the confirmation code and shows welcome message only if it's correct, else error message
        private void enter_button_Click(object sender, EventArgs e)
        {

            if (passwordBox.Text == "")
            {
                MessageBox.Show("Please enter password!");
            }
            else if (passwordBox.Text == code)
            {
                TextWriter txt = new StreamWriter(@"C:\Users\User\source\repos\CS\PasswordApp\user_info.txt");
                txt.WriteLine("Full Name: " + fullName.Text);
                txt.WriteLine("Date of birth: " + dateOfBirth.Text);
                txt.WriteLine("Email: " + emailBox.Text);
                txt.WriteLine("Password: " + Encrypt(passBox.Text));
                txt.Close();
                MessageBox.Show("Welcome, " + fullName.Text + "! 🙂 Your registration is complete. Thank you for joining #ApplicationTest.");

            }
            else
            {
                MessageBox.Show("Wrong confirmation code! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {
            
        }

        private void email_label_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordApp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = emailBox;
            passwordBox.UseSystemPasswordChar = true;
            passBox.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                passBox.UseSystemPasswordChar = false;
            }
            else
            {
                passBox.UseSystemPasswordChar = true;
            }
        }
    } 
}
