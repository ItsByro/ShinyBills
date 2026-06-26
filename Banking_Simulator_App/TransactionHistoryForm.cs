/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 24/6/2026
 * Time: 12:49 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Banking_Simulator_App
{
	public partial class TransactionHistoryForm : Form
	{
		public TransactionHistoryForm()
		{
			InitializeComponent();
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TransactionHistoryFormLoad(object sender, EventArgs e)
		{
			dgvHistory.Columns.Add("Timestamp", "Date/Time"); //0
			dgvHistory.Columns.Add("Type", "Type"); //1
			dgvHistory.Columns.Add("Amount", "Amount"); //2 
			dgvHistory.Columns.Add("BalanceAfter", "Balance After"); //3
			dgvHistory.Columns.Add("Status", "Status"); //4
			
			List<string[]> transactions = UserDataBase.GetTransactionHistory(Session.Email);
			
			foreach (string[] t in transactions)
			{
			    dgvHistory.Rows.Add(t[0], t[1], t[2], t[3], t[5]);
			}
		}
	}
}
