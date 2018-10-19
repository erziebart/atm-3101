# atm-3101
atm implementation in C# with .NET framework


Usage Instructions





Each members contributions:

Layne Britton - lmb2289
Most of my work was done in the MainMenu portion of the project. I wrote most
of the bindings and logic from the UI elements to the code and logic for program.
I also wrote the Deposit, Withdraw, and Logout functions of the main menu, bound the labels
and connected them with the other portions of the system. Set up control for how internal variables
interact with the UI components. Planned out the general design of the UI, also worked with Sam 
to resdesign some of the element layouts. 

Sam Muller - sjm2221
I worked with Evan to plan out the general flow and components (e.g. classes and corresponding variables/methods) of the ATM. Specifically in the code, I wrote the JSON file, Account class, and AccountList class. I also helped implement the locking of acconts in Login. In the Main menu I did some work redesigning the UI. I added the Check Balance button and contributed to the designed of the Check Balance, Deposit, and Withdraw panels. However, other team members worked on the logic of each button/element within these panels.

Evan Ziebart - erz2109
I worked with Sam to plan out the project: classes, attributes, and functions, and wrote a specification that the team used to develop our atm. For my part, I handled development of the login menu UI and functionality, including account verification and locking. I was also the one in charge of managing the source control of the project as well as our code repository on github.

Kelley Valentine - kpv2106
Implemented the ATM Class, which ties the JSON file, Account class, and AccountList class into a single, easy to use object.
Also created the dummy classes DepositSlot and WithdrawSlot per assignment requirements. These simply served as placeholders for a couple static functions. Also wrote usage tutorial.
