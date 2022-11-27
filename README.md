# factory-management-app

A web application that manages a factory consisting of employees, departments, shifts and only authenticated users are allowed to connect to the system and then the users can perform CRUD operations and each operation has a number of restrictions given to it that day.
 Built from a rational SQL Server database designed in an efficient and correct way of the relationships between the tables, a server consisting of ASP.NET Entity Framework is used so that working with the database is much simpler, and on the client side with Html and Css
 - The Factory has employees
- Each employee belongs to a department
- Each employee works several shifts.
- Each shift compose from one or more employees
- All The users will be pre-defined in the system

General :
- Only registered users can work on the system (They must log-in)
- Each user has a limited number of actions can be done per day.
- Once a user logged-in , his Full Name will be shown in EVERY page
- Every Page also has a “Log-Out” link which redirect the user back to the Log-In Page
- Each user has a limited actions per day. Each action a user request ( like getting the list
of employees, create a new department etc..) will reduce from his credit (actions).
When he reached to the maximum actions allowed, he will be redirected out of the
system for that day.
