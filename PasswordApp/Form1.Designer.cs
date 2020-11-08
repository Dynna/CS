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
            this.fullName = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Location = new System.Drawing.Point(379, 447);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(116, 19);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "Confirmation code:";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.CausesValidation = false;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(382, 466);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(203, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.enter_button.Location = new System.Drawing.Point(425, 495);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(119, 39);
            this.enter_button.TabIndex = 2;
            this.enter_button.Text = "Confirm";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.BackColor = System.Drawing.Color.Transparent;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.hello_label.Location = new System.Drawing.Point(375, 9);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(211, 55);
            this.hello_label.TabIndex = 3;
            this.hello_label.Text = "H e l l o !";
            this.hello_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E - mail:";
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.send_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.send_button.Location = new System.Drawing.Point(425, 376);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(119, 39);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Register";
            this.send_button.UseVisualStyleBackColor = false;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailBox.Location = new System.Drawing.Point(382, 289);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(203, 23);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.email_label_TextChanged);
            // 
            // info_label
            // 
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.info_label.Location = new System.Drawing.Point(92, 78);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(760, 52);
            this.info_label.TabIndex = 8;
            this.info_label.Text = "To complete registration, it is mandatory to enter your valid e-mail through whic" +
    "h you will receive a unique confirmation code.";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eye_label
            // 
            this.eye_label.BackColor = System.Drawing.Color.Transparent;
            this.eye_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eye_label.Location = new System.Drawing.Point(538, 447);
            this.eye_label.Name = "eye_label";
            this.eye_label.Size = new System.Drawing.Size(22, 19);
            this.eye_label.TabIndex = 10;
            this.eye_label.Text = "👁️";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(569, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(16, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fullName
            // 
            this.fullName.BackColor = System.Drawing.SystemColors.Window;
            this.fullName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fullName.Location = new System.Drawing.Point(382, 189);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(203, 23);
            this.fullName.TabIndex = 12;
            this.fullName.TextChanged += new System.EventHandler(this.fullName_TextChanged);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(382, 241);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirth.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(379, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(379, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date of birth:";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.SystemColors.Window;
            this.passBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passBox.Location = new System.Drawing.Point(382, 347);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(203, 23);
            this.passBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(566, 329);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(16, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "👁️";
            // 
            // PasswordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.fullName);
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
            this.Text = "v";
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
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
    }
}

