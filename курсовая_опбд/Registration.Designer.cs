namespace курсовая_опбд
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_zareg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(135, 69);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(135, 107);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(125, 27);
            this.textBox_surname.TabIndex = 6;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(135, 145);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(125, 27);
            this.textBox_phone.TabIndex = 7;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(135, 179);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(125, 27);
            this.textBox_login.TabIndex = 8;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(135, 219);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(125, 27);
            this.textBox_pass.TabIndex = 9;
            // 
            // button_zareg
            // 
            this.button_zareg.Location = new System.Drawing.Point(47, 279);
            this.button_zareg.Name = "button_zareg";
            this.button_zareg.Size = new System.Drawing.Size(213, 29);
            this.button_zareg.TabIndex = 10;
            this.button_zareg.Text = "Зарегистрироваться";
            this.button_zareg.UseVisualStyleBackColor = true;
            this.button_zareg.Click += new System.EventHandler(this.button_zareg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "регистрация";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_zareg);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_phone;
        private TextBox textBox_login;
        private TextBox textBox_pass;
        private Button button_zareg;
        private Label label6;
    }
}