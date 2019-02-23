namespace vtdiGatelog
{
    partial class LogInForms
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
            this.btUsername = new System.Windows.Forms.TextBox();
            this.btPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btUsername
            // 
            this.btUsername.Location = new System.Drawing.Point(338, 97);
            this.btUsername.Margin = new System.Windows.Forms.Padding(4);
            this.btUsername.Name = "btUsername";
            this.btUsername.Size = new System.Drawing.Size(148, 25);
            this.btUsername.TabIndex = 2;
            this.btUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btPassword
            // 
            this.btPassword.Location = new System.Drawing.Point(338, 162);
            this.btPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btPassword.Name = "btPassword";
            this.btPassword.Size = new System.Drawing.Size(148, 25);
            this.btPassword.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btLogin.Location = new System.Drawing.Point(175, 238);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(112, 32);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(374, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogInForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btPassword);
            this.Controls.Add(this.btUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogInForms";
            this.Text = "LogInForms";
            this.Load += new System.EventHandler(this.LogInForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btUsername;
        private System.Windows.Forms.TextBox btPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button button2;
    }
}