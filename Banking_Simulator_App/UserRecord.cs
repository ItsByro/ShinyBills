/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 15/7/2026
 * Time: 2:40 pm
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Banking_Simulator_App
{
	public class UserRecord
	{
		public string Username;
		public string Email;
		public string PhoneNumber;
	    public string Password;
	    public double Balance;
	    public string PIN;
	    
	    //get every info in one
	    public static UserRecord GetUserbyPin(string PIN)
	    {
	    	if (File.Exists("UserDatabase.txt") == false)
	    	{
	    		return null;
	    	}
	    	
	    	string[] lines = File.ReadAllLines("UserDatabase.txt");
	    	foreach (string line in lines) 
	    	{
	    		string[] parts = line.Split('|');
	    		if (parts.Length >= 6 && parts[5] == PIN)
	    		{
	    			UserRecord user = new UserRecord();
	    			user.Username = parts[0];
	    			user.Email = parts[1];
	    			user.PhoneNumber = parts[2];
	    			user.Password = parts[3];
	    			user.Balance = double.Parse(parts[4]);
	    			user.PIN = parts[5];
	    			return user;
	    		}
	    	}
	    	return null;
	    }
	    
			    
	}
}
