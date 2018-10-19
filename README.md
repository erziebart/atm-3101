# atm-3101
atm implementation in C# with .NET framework


Usage Tutorial

(1) Upon download, open accounts.json. This is a starter list with valid accounts. 
    For this example, let's use the account associated with CardNum : 1 and Pin : 1234.
    
(2) Run the program and enter the chosen account's credentials. You will be guided to a menu
    with three options: "Check Balance", "Depost", and "Withdraw". Click "Check Balance." 
    You will see a balance of $7340 appear. Click "Close".
    
(3) Click "Withdraw." A new menu will appear. You can choose any of the options-- if you choose
    "Other", you will be able to use the "+" and "-" buttons to increase and decrease your 
    desired withdraw amount by $20.If you attempt to withdraw more than you have left in your balance,
    the program will not complete your transaction. Otherwise, you will see a success notification, 
    and your balance will reflect your withdrawal.
    
(4) Now click "Deposit". Go ahead and try depositing an amount-- any whole dollar amount will work.

(5) Now click "Logout" in the upper left hand corner.

(6) Let's try using an incorrect password. Try logging into the same account the wrong password.
    After 3 failed attempts, your account will be locked out. Note that these failed attempts do not
    need to consecutive to lock your account. Once your account is locked, you will have to manually 
    unlock your account by changing your account information inside the accounts.json file-- simply
    change the value of "IsLocked" to false.
    
(7) If you at any point wish to create new accounts, you will have to manually open the accounts.json file
    and add a new account.
    
    And that's it! Thank you for checking out our program!
    
     
     





Each members contributions:

Layne Britton - lmb2289
Most of my work was done in the MainMenu portion of the project. I wrote most
of the bindings and logic from the UI elements to the code and logic for program.
I also wrote the Deposit, Withdraw, and Logout functions of the main menu, bound the labels
and connected them with the other portions of the system. Set up control for how internal variables
interact with the UI components. Planned out the general design of the UI, set up the panel design, and
also worked with Sam to resdesign some of the element layouts. 

Sam Muller - sjm2221
I worked with Evan to plan out the general flow and components (e.g. classes and corresponding variables/methods) of the ATM. Specifically in the code, I wrote the JSON file, Account class, and AccountList class. I also helped implement the locking of acconts in Login. In the Main menu I did some work redesigning the UI. I added the Check Balance button and contributed to the designed of the Check Balance, Deposit, and Withdraw panels. However, other team members worked on the logic of each button/element within these panels.

Evan Ziebart - erz2109
I worked with Sam to plan out the project: classes, attributes, and functions, and wrote a specification that the team used to develop our atm. For my part, I handled development of the login menu UI and functionality, including account verification and locking. I was also the one in charge of managing the source control of the project as well as our code repository on github.

Kelley Valentine - kpv2106
Implemented the ATM Class, which ties the JSON file, Account class, and AccountList class into a single, easy to use object.
Also created the dummy classes DepositSlot and WithdrawSlot per assignment requirements. These simply served as placeholders for a couple static functions. Also wrote usage tutorial.
