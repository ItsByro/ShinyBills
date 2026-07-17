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
		public static void DepositLogic(double amount)
		{
			double oldBalance = Session.Balance;
			double anticipitatedBalance = Session.Balance + amount;
			
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
		
		public static void WithdrawalLogic(double amount)
		{
			double oldBalance = Session.Balance;
			double anticipitatedBalance = Session.Balance - amount;
			
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
	}
}
