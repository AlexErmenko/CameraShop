using System;

namespace CameraShop
{
    partial class Start
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
			this.ToLogin = new MaterialSkin.Controls.MaterialFlatButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ToLogin
			// 
			this.ToLogin.AutoSize = true;
			this.ToLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ToLogin.Depth = 0;
			this.ToLogin.Location = new System.Drawing.Point(171, 273);
			this.ToLogin.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.ToLogin.MouseState = MaterialSkin.MouseState.HOVER;
			this.ToLogin.Name = "ToLogin";
			this.ToLogin.Primary = false;
			this.ToLogin.Size = new System.Drawing.Size(203, 36);
			this.ToLogin.TabIndex = 0;
			this.ToLogin.Text = "Перейти до демонстрації";
			this.ToLogin.UseVisualStyleBackColor = true;
			this.ToLogin.Click += new System.EventHandler(this.ToLoginClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 126);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Тема КП";
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 372);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ToLogin);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Start";
			this.Text = "Початкове вікно";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private MaterialSkin.Controls.MaterialFlatButton ToLogin;
		private System.Windows.Forms.Label label1;
	}
}