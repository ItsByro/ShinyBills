/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 1/7/2026
 * Time: 4:18 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class LogIn_PIN : Form
	{
		public LogIn_PIN()
		{
			InitializeComponent();
			
		}
		
		void BtnLogInClick(object sender, EventArgs e)
		{
			//variables
			string UserPIN = txbPIN.Text;
			
			if (string.IsNullOrWhiteSpace(UserPIN))
			{
				MessageBox.Show("No PIN Given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (!UserDataBase.UserPinExists(UserPIN))
			{
				MessageBox.Show("PIN Incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			UserRecord LoggedinUser = UserRecord.GetUserbyPin(UserPIN);
			Session.Username = LoggedinUser.Username;
			Session.Balance = LoggedinUser.Balance;
			
			MessageBox.Show(string.Format("Welcome back {0}!", Session.Username),"Welcome Back!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DashBoard_Menu Dashboard = new DashBoard_Menu();
			Dashboard.FormClosed += (s, args) => this.Show();
			Dashboard.Show();
			this.Hide();
			txbPIN.Clear();
		}
		
		void BtnExitPageClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TxbPINKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
		    {
		        e.Handled = true; //prevents user to type a string/symbols
		    }
		}
	}
}
