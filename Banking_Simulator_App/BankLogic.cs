/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 17/7/2026
 * Time: 1:18 pm
 */
using System;

namespace Banking_Simulator_App
{
	/// <summary>
	/// this includes all logic from across windows form.
	/// </summary>
	public class BankLogic
	{
		private static readonly object _transferlock = new object();
		
		public static void DepositLogic(decimal amount)
		{
			decimal oldBalance = Session.Balance;
			decimal anticipitatedBalance = Session.Balance + amount;
			
			try 
			{
				Session.Balance = anticipitatedBalance;	
				UserDataBase.UpdateBalance(Session.Email, Session.Balance);	
				UserDataBase.LogTransaction("Deposit", amount, Session.Balance, Session.Email, "Complete");
			}
			catch (Exception) 
			{
				Session.Balance = oldBalance;
				throw;
			}
		}
		
		public static void WithdrawalLogic(decimal amount)
		{
			decimal oldBalance = Session.Balance;
			decimal anticipitatedBalance = Session.Balance - amount;
			
			try 
			{
				Session.Balance = anticipitatedBalance;	
				UserDataBase.UpdateBalance(Session.Email, Session.Balance);	
				UserDataBase.LogTransaction("Withdraw", amount, Session.Balance, Session.Email, "Complete");
			}
			catch (Exception) 
			{
				Session.Balance = oldBalance;
				throw;
			}
		}
		
		public static void TransferFundLogic(string RecipientEmail, decimal TransferAmount)
		{
			lock(_transferlock)
			{
				decimal senderOldBalance = Session.Balance;
				decimal recipientOldBalance = UserDataBase.GetBalance(RecipientEmail);	
				decimal senderNewBalance = senderOldBalance - TransferAmount;
				decimal recipientNewBalance = recipientOldBalance + TransferAmount;
				
				bool senderUpdated = false;
				
				try 
				{
					UserDataBase.UpdateBalance(Session.Email, senderNewBalance);
					senderUpdated = true;		
					UserDataBase.UpdateBalance(RecipientEmail, recipientNewBalance);
					Session.Balance = senderNewBalance;
					UserDataBase.LogTransaction("Transfer Out to " + RecipientEmail, TransferAmount, senderNewBalance, Session.Email, "Complete");
					UserDataBase.LogTransaction("Transfer In from "+ Session.Email, TransferAmount, recipientNewBalance, RecipientEmail, "Complete");
					
				} 
				catch (Exception) 
				{
					if (senderUpdated) 
					{
						UserDataBase.UpdateBalance(Session.Email, senderOldBalance);
					}
					throw;
				}	
			}
		}
	}
}
