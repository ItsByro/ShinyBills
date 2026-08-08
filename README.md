Hello 👋 

This is "**ShinyBills**": A Desktop Banking Simulation, simulating what a real bank/ATM is:

### FEATURES
* **Deposit**: Add funds to your account balance with input validation (rejects invalid/negative amounts).
* **Withdrawal**: Withdraw funds with balance checks to prevent overdrawing.
* **Transfer Funds**: Let users send money between accounts locally.
* **Transaction History** — view your transaction history like deposit, withdraw, and even transfer funds.
* A Randomized PIN given by the system to simulate a real ATM.
* [Update 8/8/26] Now Passwords stores hashed **PBKDF2** (100,000 iterations + SHA256) instead of plain text.

### IMPORTANT
* All users will be stored **locally** in their PC via a ".txt" file [can be found via: "ShinyBills\Banking_Simulator_App\bin\Debug\UserDatabase.txt"].
* All User Transaction History can also be viewed **locally** in their PC via a ".txt" file [can be found also via: "ShinyBills\Banking_Simulator_App\bin\Debug\TransactionHistory.txt"].
* These files are **auto-generated** once an account is created, no manual setup needed.
* Format of the .txt files(UserDatabase) usually was: "Username|Email|PhoneNumber|Password(hash)|Balance|PIN|salt"

### STATUS 
- Active development since 6/11/26.

### Notes / Security Notes
- This is an Active Learning Project for C#, so expect rougher edges and security risks.
- Sometimes when the balance reaches up to 19 digits long, it may be difficult to reduce/change the balance, best to create another account.
- Transfer Funds have partial rollback: if balance update fails, both recipient and sender balances have reverted, however, Transaction History may still be show "Complete" for a transfer that was reverted.
- This is NOT a Production System only a mere learning project by myself.
  
#### More known issues:
- Manually editing the ".txt file" can corrupt the password hash or salt, breaking login for that account.
- PIN is stored in **plain text**.
- No encryption for user data files (only password was hashed, not the whole file)

### Development Tools
- SharpDevelop v5.0
- .NET Framework v4.5.1
- Language: C#
- UI Framework: WinForms
- Data Persistence: text file (.txt)

  
