/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 13/6/2026
 * Time: 8:23 pm
 */	
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking_Simulator_App
{
	public partial class DashBoard_Menu : Form
	{
		public DashBoard_Menu()
		{
			InitializeComponent();
		}
		
		void RefreshBoardData()
		{
			lblGreet.Text = "Hello " + string.Format("[{0}]", Session.Username);
			lblBalance.Text = "Balance : "+ string.Format("₱{0}",Session.Balance.ToString("F2"));
		}
		
		void BtnDepositClick(object sender, EventArgs e)
		{
			this.Hide();
			DepositForm Deposit_form = new DepositForm();
			Deposit_form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void BtnWithdrawClick(object sender, EventArgs e)
		{
			this.Hide();
			WithdrawForm Withdraw_Form = new WithdrawForm();
			Withdraw_Form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void BtnTransferFundsClick(object sender, EventArgs e)
		{
			this.Hide();
			TransferFundForm TransferFund_Form = new TransferFundForm();
			TransferFund_Form.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void BtnTransactionClick(object sender, EventArgs e)
		{
			this.Hide();
			TransactionHistoryForm TransactionHistory = new TransactionHistoryForm();
			TransactionHistory.ShowDialog();
			this.Show();
			RefreshBoardData();
		}
		
		void DashBoard_MenuLoad(object sender, EventArgs e)
		{
			RefreshBoardData();
		}
		
		void BtnLogOutClick(object sender, EventArgs e)
		{
			this.Close();	
			RefreshBoardData();
		}
		
		void BtnTermsandConditionsClick(object sender, EventArgs e)
		{
			MessageBox.Show("SHINYBILLS - Terms and Conditions\n\n"+
			                "1: This Simulation is created for solely use for educational,\n"+
			                "and portfolio purposes only, It is NOT a Real Bank/Financial service.\n\n"+
			                "2: No real money, accounts, or transaction are involved. All Balance,"+
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
			                "- ItsByro (*^*)",
			                "Terms & Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information
			               );
		}
	}
}
