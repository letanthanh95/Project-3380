# Project Description
The zoo managerment is the program that manages the animals, staffs, customers, ticktes, and items which sale in shops. The staffs,include managers, will manage the animals, tickets, and shops. Many staffs can be in one department,and they take care many animals and shops. Moreover, they also design the public events, and private events if any customers want to book the place. The animals will be taken care by staffs; they have to report the animals' status that is stored in database. Each customer can buy many tickets at the same time and they can book a place for events like birthday, wedding, picnic, etc.  We keep track the items, tickets, and private events by getting the customer's information. Customer's information, such as Name, Address, Email, and their purchases will be stored in database, the account will be store in AspNetUser with encrypted password, and staffs will get report every months for revenues from customers' purchases. 
# File Description
We use ASP NET Core 3.0 on Visual Studio 2017 or 2019 to write the program for front-end and back-end. Our database is MySql WorkBench
- Whole project is store in `Zooe` folder
- Front-end is stored in `Views` folders
- Back-end is stored in `Team10` and `Controllers` folders 
- CSS-JS files, images are stored in `wwwroot` folders   
# User Roles
We have two main roles: Admin and User
- Admin will update the changes like edit and delete staffs', animals' and customers' information. Admin can create User account and other admin account. Moreover, admin can buy tickets, items and book events
- User cannot access to admin's functions. They only can create user account. They can buy tickets, booking private events and buy items.
# Triggers
**Three Triggers** 
- The email cannot be duplicated
- You can only buy a ticket for a private event if it isn't already at full capacity
- Removes inventory from shops and prevents stock going below 0
# Author
- Thanh Le
- Ana Alcocer
- Jose Hernandez 
- Michael Veliz
- Jesus Del
