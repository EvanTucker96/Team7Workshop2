# Team 7 Workshop 2
OOSD Threaded Project for Team 7 2020.

## Objective
    In order that employees of Travel Experts can administer the data stored on their database, they need an application that will provide a graphical interface for viewing and modifying the data.  At this point, they have identified the tables that are most important, and request that access to these be developed as a prototype.

The database that will be used for this workshop has been provided on the O: drive in the pickup\PROJ207 Threaded Workshop\Database Files directory, and must be imported into a SQLServer database.  You can build your application using the existing database structure. However, there may be minor improvements that would make your programming easier, so you are free to make improvements to the database.

The agents need to add/edit travel packages.  This function must allow the user to enter data for the package, and select from a product list to add products to the package. Your application will need functionality that will allow the user to maintain the data in the tables listed below.

The tables that will be used by this part of the project are:
- Packages
- Products
- Products_suppliers
- Suppliers
- Packages_products_suppliers
Make sure that you validate the data before creating the package:
- the Agency Commission cannot be greater than the Base Price
- the Package End Date must be later than Package Start Date
- Package Name and Package Description cannot be null

## Documentation
All documentation is within the .cs source files within the production branch.

## Members
- (@Evan Tucker)[https://github.com/EvanTucker96/]
- (@Steven Hillman)[https://github.com/steven-hillman]