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


Instructions of using the Application for students and teachers:

1)(Download and install)Use MAMP and star the MySql/Apache server;
2) Click the button in MAMP "Open WebStart Page" then find on opened page PhPMyAdmin and click;
3) Create database 'db' and tables 'cards' & 'users';
4) create columns for 'cards':
id int(cards id will copy id of users), card_id text, card_user text, balance text;
Also for 'users':
id int unsigned auto_increment, email, password, name and surname are varchar and using 'utf8_general_ci' at Collation;

5) Connect the servers and rewrite to ur local database the code in DB.class 15 line:
MySqlConnection connection = new MySqlConnection("server=localhost;port=8889;username=root;password=root;database=bd;SSL Mode=None");

6)Check the versions of: 
Visual Studio 2022. Not recomended work in 2019 version.The Application writed "Visual Studio 2022";

Good luck!

![diagramWithMethods](https://user-images.githubusercontent.com/76080041/201706573-d81d4580-6829-4f4e-a3de-eb9953af20d9.png)


![diagramWithoutMethods](https://user-images.githubusercontent.com/76080041/201706719-62fa6f36-ec7c-4a95-b11f-487cfbfe66fb.png)

the Registration page:
![registrationSoft](https://user-images.githubusercontent.com/76080041/201711819-7ec7bb75-c6d0-4bad-a13b-2b5070e1dc3b.png)

then the db:

![db](https://user-images.githubusercontent.com/76080041/201711446-b10c6436-eff7-427a-adec-33d671fa588a.png)
Login:
![login](https://user-images.githubusercontent.com/76080041/201711942-f7becd09-8575-49bc-b17c-c64e72d130a6.png)


![mainform](https://user-images.githubusercontent.com/76080041/201711478-88e58082-ffb5-47bc-ad43-48f71380766c.png)
![addCard](https://user-images.githubusercontent.com/76080041/201711504-f1401ac3-0670-4b8f-9730-79b89fb17c2b.png)
![afterAdded](https://user-images.githubusercontent.com/76080041/201711534-03635d8d-6631-4e89-9c68-0a30710e9d62.png)

