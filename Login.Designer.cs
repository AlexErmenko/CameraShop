using System;

namespace CameraShop
{
    partial class Login
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
			this.PasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.SignIn = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SelectAccount = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// PasswordField
			// 
			this.PasswordField.Depth = 0;
			this.PasswordField.Hint = "";
			this.PasswordField.Location = new System.Drawing.Point(29, 154);
			this.PasswordField.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordField.MouseState = MaterialSkin.MouseState.HOVER;
			this.PasswordField.Name = "PasswordField";
			this.PasswordField.PasswordChar = '\0';
			this.PasswordField.SelectedText = "";
			this.PasswordField.SelectionLength = 0;
			this.PasswordField.SelectionStart = 0;
			this.PasswordField.Size = new System.Drawing.Size(249, 23);
			this.PasswordField.TabIndex = 0;
			this.PasswordField.UseSystemPasswordChar = true;
			this.PasswordField.VisibleChanged += new System.EventHandler(this.PasswordField_VisibleChanged);
			// 
			// SignIn
			// 
			this.SignIn.Depth = 0;
			this.SignIn.Location = new System.Drawing.Point(33, 209);
			this.SignIn.Margin = new System.Windows.Forms.Padding(4);
			this.SignIn.MouseState = MaterialSkin.MouseState.HOVER;
			this.SignIn.Name = "SignIn";
			this.SignIn.Primary = true;
			this.SignIn.Size = new System.Drawing.Size(245, 52);
			this.SignIn.TabIndex = 1;
			this.SignIn.Text = "Вхід";
			this.SignIn.UseVisualStyleBackColor = true;
			this.SignIn.Click += new System.EventHandler(this.SingInClick);
			// 
			// SelectAccount
			// 
			this.SelectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SelectAccount.FormattingEnabled = true;
			this.SelectAccount.Items.AddRange(new object[] {
            "Користувач",
            "Адміністратор"});
			this.SelectAccount.Location = new System.Drawing.Point(29, 84);
			this.SelectAccount.Margin = new System.Windows.Forms.Padding(4);
			this.SelectAccount.Name = "SelectAccount";
			this.SelectAccount.Size = new System.Drawing.Size(248, 24);
			this.SelectAccount.TabIndex = 2;
			this.SelectAccount.SelectedIndexChanged += new System.EventHandler(this.SelectAccountChanged);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 301);
			this.Controls.Add(this.SelectAccount);
			this.Controls.Add(this.SignIn);
			this.Controls.Add(this.PasswordField);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Login";
			this.Text = "Вікно авторизації";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
			this.ResumeLayout(false);

        }

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField PasswordField;
		private MaterialSkin.Controls.MaterialRaisedButton SignIn;
		private System.Windows.Forms.ComboBox SelectAccount;
	}
}