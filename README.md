In the Application WinFormsApp1:

RegisterForm.cs - It is form for registering users. The codes in file uses MySql Database and
pushing the variables to local database;

LoginPage.cs - is for entering users to Application with checking database of users' variables(account, password);

MainPage.cs - it is main page of Application that contains information of users' card. The button
 "Card Add" is opening CardAdd.cs class and filling the blanks --- ;
The users can add and delete their cards. In cards we can see three variables - 1)id or number of card, 
2) users username and surename 3) Balance; The balance is the count of users money.
(There we have yet 2 radio buttons 
that will take money and give money(I will do it in the future, i hope));

MainPage.cs also have logout button. It is return to Registration page;
The button "delete" is available in each cards that added users. On click the button we
open the DeletingObjects.cs class to confirm of our action;

All information are working with database and the database is refreshing on showing new page;



