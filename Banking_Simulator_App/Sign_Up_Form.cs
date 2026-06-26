/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 12/6/2026
 * Time: 2:42 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class Sign_Up_Form : Form
	{
		public Sign_Up_Form()
		{
			InitializeComponent();
		}
		
		void BtnSignUpClick(object sender, EventArgs e)
		{
			string username = txbUsername.Text;
			string email = txbEmail.Text;
			string phonenumber = txbPhoneNumber.Text; 
			string password = txbPassword.Text;
			string ConfirmPass = txbConfirmPass.Text;
			long number = 0;
			
			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("No email given.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(username))
			{
				MessageBox.Show("No username given.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(phonenumber))
			{
				MessageBox.Show("No phone number fiven.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("No password given.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if(checkboxTermsCondition.Checked == false)
			{
				MessageBox.Show("Please accept the Terms and Condition first.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (email.Contains("@") == false)
			{
				MessageBox.Show("Incorrect Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (UserDataBase.UserExists(email))
			{
				MessageBox.Show("User Exist, maybe you type wrong?.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if(password != ConfirmPass)
			{
				MessageBox.Show("Password Incorrect [Different to the one you input].", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if(!long.TryParse(phonenumber, out number))
			{
				MessageBox.Show("Error not a phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (phonenumber.Length != 10 && phonenumber.Length != 11)
			{
				MessageBox.Show("Please enter a valid phone number (10–11 digits).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
    			return;
			}
			
			UserDataBase.SaveUser(username, email, phonenumber, password);
			MessageBox.Show("Account created!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		
		//guides user what to put in the txtbox
		void HelpFuncClick(object sender, EventArgs e)
		{
			MessageBox.Show("Username:\n"+
			                "Your username that will be used in the Bank Simulator\n\n"+
			                "Email:\n"+
			                "Enter your email address\n\n"+
			                "Phone Number:\n"+
			                "Enter your Phone Number\n\n"+
			                "Password:\n"+
			                "Enter your password\n(Recommended at 8 characters)\n\n"+
			                "Confirm your Password:\n"+
			                "Just repeat the password you write:}",
			                "Stuck? Let Me Help You",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Information
			               );
		}
		
		void TxbPhoneNumberKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
		    {
		        e.Handled = true; //prevents user to type a string/symbols
		    }
		}
		
		void Btn_exitClick(object sender, EventArgs e)
		{
			//exits the signup form
			this.Close();
		}
		
		void LblTermsConditionsClick(object sender, EventArgs e)
		{
			MessageBox.Show("SHINYBILLS - Terms and Conditions\n\n"+
			                "1: This Simulation is created for solely use for educational,\n"+
			                "and portfolio purposes only, It is NOT a Real Bank/Financial service.\n\n"+
			                "2: No real money, accounts, or transaction are involved. All Balance, "+
			                "Transactions, Deposits and even Transfered Funds are only exists within"+
			                "this program local data files\n" +
			                "[can be found via: Banking_Simulator_App/bin/Debug/UserDatabase.txt].\n\n" +
			                "3: All Data is stored in a '.txt' file on your local machine.\n" +
			                "The data is not Encrypted and cannot be treated as a secure storage.\n\n" +
			                "4.The Developer[ItsByro] is not liable for any data loss, corruption," +
			                "or even misuse from the users use of software.\n\n" +
			                "By using this application, you are agreeing that this application/simulator" +
			                "is a 'demonstrating project', and will be used accordingly\n\n" +
			                "Thank you for using ShinyBills\n" +
			                "- ItsByro (o^<)",
			                "Terms & Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information
			               );
		}
		
		
	}
}
