Hello 👋 

This is "**ShinyBills**": A Desktop Banking Simulation, simulating what a real bank/ATM is:

### FEATURES
* **Deposit**: Add funds to your account balance with input validation (rejects invalid/negative amounts).
* **Withdrawal**: Withdraw funds with balance checks to prevent overdrawing.
* **Transfer Funds**: Let users send money between accounts locally.
* **Transaction History** — view your transaction history like deposit, withdraw, and even transfer funds.
* All users will be stored **locally** in their PC via a ".txt" file [can be found via: "ShinyBills\Banking_Simulator_App\bin\Debug\UserDatabase.txt"].

### Incoming Features Being Implemented
* A Randomized PIN given by the system to simulate a real ATM.

### STATUS 
- Active development since 6/11/26.

### Notes / Security Notes
- This is an Active Learning Project for C#, so expect rougher edges and security risks.
- Sometimes when the balance reaches up to 19 digits long, it may be difficult to reduce/change the balance, best to create another account.
- Transfer Fund updates the user and receiver balance separately, so a failure mid-transfer could cause funds to be deducted without reaching the recipient (no rollback yet).
- This is NOT a Production System only a mere learning project by myself.
  
More known issues:
- Password only stored locally and in plain text.
- No encryption for user data files.

### Development Tools
- SharpDevelop v5.0
- .NET Framework v4.5.1
- Language: C#
- UI Framework: WinForms
- Data Persistence: text file (.txt)

  
