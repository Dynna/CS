using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PasswordApp
{
    public partial class PasswordApp : Form
    {
        public PasswordApp()
        {
            InitializeComponent();
        }

        // Each password is 8 characters long
        public string password = PasswordGenerator.CreatePassword(8);

        // When click send button, the application is shipping a valid password to the user through e-mail
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
                msg.Subject = "Your password for APP";
                msg.Body = "This is your unique password to access application: " + password;
           
                client.Send(msg);
                MessageBox.Show("Password sent successfully! Check your e-mail within 1 minute.");
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

        // When click enter button, the application processes the password and shows welcome message only if it's correct, else error message
        private void enter_button_Click(object sender, EventArgs e)
        {

            if (passwordBox.Text == "")
            {
                MessageBox.Show("Please enter password!");
            }
            else if (passwordBox.Text == password)
            {
                MessageBox.Show("Welcome, friend! 🙂 Thank you for joining #ApplicationTest.");
            }
            else
            {
                MessageBox.Show("Wrong password! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    } 
}
