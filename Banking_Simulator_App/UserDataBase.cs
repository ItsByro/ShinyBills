/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 12/6/2026
 * Time: 3:06 pm
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Banking_Simulator_App
{
	public class UserDataBase
	{
		/*Saves user in a  ".txt" file
		 * always used in "Sign In Form"
		 */
		public static void SaveUser(string Username, string Email, string Phone_Number, string Password, string PIN)
		{
			//				  0		 1		  2			3	   	 4	   5
			//Formatting [Username|Email|PhoneNumber|Password|Balance|PIN]					   always start at 0 when creating new account
			string line = Username + "|" + Email + "|" + Phone_Number + "|" + Password + "|" + "0.00" + "|" + PIN;
			
			File.AppendAllText("UserDatabase.txt", line + Environment.NewLine);
		}
		
		//checks for user if exist through email 
		public static bool UserExists(string Email)
		{
			if (File.Exists("UserDatabase.txt") == false) 
			{
				return false;	
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == Email)
				{
					return true;
				}
			}
			return false;
		}
		
		//checks user if exist through PIN
		public static bool UserPinExists(string PIN)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return false;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts.Length >= 6 && parts[5] == PIN)
				{
					return true;
				}
			}
			return false;
		}
		
		/*checks if user is in, more like an authentication check
 		 *so checks the email and password if it exists in the "UserDatabase.txt",
		 *if so, updates the session class with the user's data
		 */
		public static bool LogInUser(string email, string password)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return false;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			//checks each line in "UserDatabase.txt"
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == email && parts[3] == password) 
				{
					Session.Username = parts[0];
					Session.Email = parts[1];
					Session.Balance = decimal.Parse(parts[4]);
					return true;
				}
			}
			return false;
		}
		
		//update balances based on changes from the session class
		public static void UpdateBalance(string email, decimal newBalance)
		{
			if (File.Exists("UserDatabase.txt") == false)
			{
				return;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			for (int i = 0; i < lines.Length; i++) 
			{
				string[] parts = lines[i].Split('|');
				if (parts[1] == email) 
				{
					lines[i] = parts[0] + '|' + email + '|' + parts[2] + '|' + parts[3] + '|' + newBalance.ToString("F2") + '|' + parts[5];
				}
			}
			File.WriteAllLines("UserDatabase.txt", lines);
		}
		
		public static decimal GetBalance(string email)
		{
			if (!File.Exists("UserDatabase.txt"))
			{
				return -1;
			}
			
			string[] lines = File.ReadAllLines("UserDatabase.txt");
			
			foreach (string line in lines) 
			{
				string[] parts = line.Split('|');
				if (parts[1] == email) 
				{
					return decimal.Parse(parts[4]);
				}
			}
			return -1;
		}
		//										0				1				2		    	3				4
		public static void LogTransaction(string type, decimal amount, decimal balanceAfter, string email, string status)
		{//									0									1				2				
		    string line = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "|" + type + "|" + amount.ToString("F2") + "|" +
		                  balanceAfter.ToString("F2") + "|" + //3
		                  email + "|" + //4
		                  status; //5
		
		    File.AppendAllText("TransactionHistory.txt", line + Environment.NewLine);
		}
		
		public static List<string[]> GetTransactionHistory(string email)
		{
		    List<string[]> history = new List<string[]>();
		
		    if (!File.Exists("TransactionHistory.txt"))
		        return history;
		
		    string[] lines = File.ReadAllLines("TransactionHistory.txt");
		
		    foreach (string line in lines)
		    {
		        string[] parts = line.Split('|');
		        if (parts[4] == email)
		        {
		            history.Add(parts);
		        }
		    }
		
		    return history;
		}
	}
}
