namespace PasswordApp
{
    partial class PasswordApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordApp));
            this.password_label = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.hello_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.info_label = new System.Windows.Forms.Label();
            this.eye_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Location = new System.Drawing.Point(379, 333);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(85, 14);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.CausesValidation = false;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(382, 350);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(203, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.enter_button.Location = new System.Drawing.Point(425, 389);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(119, 39);
            this.enter_button.TabIndex = 2;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.BackColor = System.Drawing.Color.Transparent;
            this.hello_label.Font = new System.Drawing.Font("Bodoni MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.hello_label.Location = new System.Drawing.Point(377, 34);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(208, 56);
            this.hello_label.TabIndex = 3;
            this.hello_label.Text = "H e l l o !";
            this.hello_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E - mail:";
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.send_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.send_button.Location = new System.Drawing.Point(425, 253);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(119, 39);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = false;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailBox.Location = new System.Drawing.Point(382, 214);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(203, 23);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.email_label_TextChanged);
            // 
            // info_label
            // 
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.info_label.Location = new System.Drawing.Point(92, 118);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(760, 52);
            this.info_label.TabIndex = 8;
            this.info_label.Text = "To access application, it is mandatory to enter your e-mail through which you wil" +
    "l receive a unique password.";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eye_label
            // 
            this.eye_label.BackColor = System.Drawing.Color.Transparent;
            this.eye_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eye_label.Location = new System.Drawing.Point(541, 329);
            this.eye_label.Name = "eye_label";
            this.eye_label.Size = new System.Drawing.Size(22, 19);
            this.eye_label.TabIndex = 10;
            this.eye_label.Text = "👁️";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(569, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(16, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PasswordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 485);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.eye_label);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.password_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PasswordApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PasswordApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label eye_label;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

