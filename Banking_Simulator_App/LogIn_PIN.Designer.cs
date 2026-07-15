/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 10/7/2026
 * Time: 4:18 pm
 */
namespace Banking_Simulator_App
{
	partial class LogIn_PIN
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lbltext = new System.Windows.Forms.Label();
			this.btnExitPage = new System.Windows.Forms.Button();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.txbPIN = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.White;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTitle.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(32, 27);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(431, 44);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Welcome to ShinyBills";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbltext
			// 
			this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltext.Location = new System.Drawing.Point(153, 103);
			this.lbltext.Name = "lbltext";
			this.lbltext.Size = new System.Drawing.Size(180, 43);
			this.lbltext.TabIndex = 2;
			this.lbltext.Text = "Enter your PIN";
			this.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnExitPage
			// 
			this.btnExitPage.BackColor = System.Drawing.Color.LemonChiffon;
			this.btnExitPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExitPage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitPage.ForeColor = System.Drawing.Color.Black;
			this.btnExitPage.Location = new System.Drawing.Point(295, 248);
			this.btnExitPage.Name = "btnExitPage";
			this.btnExitPage.Size = new System.Drawing.Size(140, 58);
			this.btnExitPage.TabIndex = 9;
			this.btnExitPage.Text = "Exit";
			this.btnExitPage.UseVisualStyleBackColor = false;
			this.btnExitPage.Click += new System.EventHandler(this.BtnExitPageClick);
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.LemonChiffon;
			this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogIn.ForeColor = System.Drawing.Color.Black;
			this.btnLogIn.Location = new System.Drawing.Point(58, 248);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(140, 58);
			this.btnLogIn.TabIndex = 10;
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.BtnLogInClick);
			// 
			// txbPIN
			// 
			this.txbPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPIN.Location = new System.Drawing.Point(32, 160);
			this.txbPIN.MaxLength = 4;
			this.txbPIN.Name = "txbPIN";
			this.txbPIN.Size = new System.Drawing.Size(431, 35);
			this.txbPIN.TabIndex = 11;
			this.txbPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPINKeyPress);
			// 
			// LogIn_PIN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(492, 359);
			this.Controls.Add(this.txbPIN);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.btnExitPage);
			this.Controls.Add(this.lbltext);
			this.Controls.Add(this.lblTitle);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "LogIn_PIN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn PIN";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txbPIN;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.Button btnExitPage;
		private System.Windows.Forms.Label lbltext;
		private System.Windows.Forms.Label lblTitle;
	}
}
