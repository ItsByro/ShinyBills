Hello 👋 

This is "**ShinyBills**": A Desktop Banking Simulation, simulating what a real bank/ATM is:

## FEATURES
* **Deposit**: Add funds to your account balance with input validation (rejects invalid/negative amounts).
* **Withdrawal**: Withdraw funds with balance checks to prevent overdrawing.
* **Transfer Funds**: Let users send money between accounts locally.
* **Transaction History** — view your transaction history like deposit, withdraw, and even transfer funds.
* A Randomized PIN given by the system to simulate a real ATM.
* [Update 8/8/26] Now Passwords stores hashed **PBKDF2** (100,000 iterations + SHA256) instead of plain text.

## IMPORTANT
* All users will be stored **locally** in their PC via a ".txt" file [can be found via: "ShinyBills\Banking_Simulator_App\bin\Debug\UserDatabase.txt"].
* All User Transaction History can also be viewed **locally** in their PC via a ".txt" file [can be found also via: "ShinyBills\Banking_Simulator_App\bin\Debug\TransactionHistory.txt"].
* These files are **auto-generated** once an account is created, no manual setup needed.
* Format of the .txt files(UserDatabase) usually was: "Username|Email|PhoneNumber|Password(hash)|Balance|PIN|salt"

## STATUS 
- Active development since 6/11/26.

## Notes / Security Notes
- This is an Active Learning Project for C#, so expect rougher edges and security risks.
- Sometimes when the balance reaches up to 19 digits long, it may be difficult to reduce/change the balance, best to create another account.
- Transfer Funds have partial rollback: if balance update fails, both recipient and sender balances have reverted, however, Transaction History may still be show "Complete" for a transfer that was reverted.
- This is NOT a Production System only a mere learning project by myself.
  
#### More known issues:
- Manually editing the ".txt file" can corrupt the password hash or salt, breaking login for that account.
- PIN is stored in **plain text**.
- No encryption for user data files (only password was hashed, not the whole file)

## PREVIEW

#### Logging In
<img width="350" height="400" alt="Login SHINYBILLS" src="https://github.com/user-attachments/assets/beb5ba48-8514-4a7f-9d09-2943cab88c04" />

#### Depositing Money
<img width="350" height="400" alt="depositingmoney SHINYBILLS" src="https://github.com/user-attachments/assets/30dd0431-b109-4a11-afc3-f2f3f7ddc040" />

#### Checking Transaction History
<img width="350" height="400" alt="CheckingHistory SHINYBILLS" src="https://github.com/user-attachments/assets/fef9f238-e218-44cd-bf99-5eda00c8261f" />

#### Transferring Funds
<img width="350" height="400" alt="TransferFunds SHINYBILLS" src="https://github.com/user-attachments/assets/b4836fd2-7370-46c8-9943-c2a2cb681619" />


### Development Tools
- SharpDevelop v5.0
- .NET Framework v4.5.1
- Language: C#
- UI Framework: WinForms
- Data Persistence: text file (.txt)

  
