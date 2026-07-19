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
			decimal senderOldBalance = Session.Balance;
			decimal senderNewBalance = Session.Balance - TransferAmount;
			decimal recipientOldBalance = UserDataBase.GetBalance(RecipientEmail);
			decimal recipientNewBalance = recipientOldBalance + TransferAmount;
			
			
			try 
			{
				Session.Balance = senderNewBalance;
				UserDataBase.UpdateBalance(Session.Email, senderNewBalance);
				UserDataBase.UpdateBalance(RecipientEmail, recipientNewBalance);
				UserDataBase.LogTransaction("Transfer Out to " + RecipientEmail, TransferAmount, senderNewBalance, Session.Email, "Complete");
				UserDataBase.LogTransaction("Transfer In from "+ Session.Email, TransferAmount, recipientNewBalance, RecipientEmail, "Complete");
				
			} 
			catch (Exception) 
			{
				Session.Balance = senderOldBalance;
				UserDataBase.UpdateBalance(Session.Email, senderOldBalance);
				UserDataBase.UpdateBalance(RecipientEmail, recipientOldBalance);
				throw;
			}
		}
	}
}
