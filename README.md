# Test Assessment
This is a technical assessment

Pre-requisites:
- VS 2022
- MS net8
- MVC asp .net
- MS SQL Dev edition
- MS entityframework
- Javascript
- jQuery


Instructions:

1. Please clone this repo.
2. Please create a branch with your name.
3. Please create a new Model with the corresponding View-Controller for entity Store as:

Column | Type
------------ | -------------
store_id | id, PK :key:
store_name | varchar(255), required
store_description | varchar(500)
created_date | datetime
updated_date | datetime

4. Add the created_date, updated_date fields tot he entity Products (using the same definition as in store table).
5. Add a FK for store in products table, the result will looks like this:

Column | Type
------------ | -------------
product_id | id, PK :key:
store_id | id, FK :key:
external_productid | varchar(50)
product_name | varchar(100), required
product_description | varchar(500)
unitprice | decimal(18,3)
created_date | datetime
updated_date | datetime

6. Create a new net5 MVC controller to provide the full resultset Store->Product as JSON, this controller doesn't need any view.
    - net5/MVC Model is the class which describe the entity.
    - net5/MVC Controller is the class which accepts the inputs and convert to commands to be represented later by a View (net5/MVC View class).
    - net5/MVC View is the class used to view or visualize the data.
8. Modify the scaffolded files to use buttons instead of links (edit/details/delete links in grids)
9. Implement the datatables framework [datatables](https://datatables.net/) in Products & Store grids (filtering, search, css styles).
10. Please implement the bootstrap theme (zip file startbootstrap-sb-admin-2-gh-pages), remove all non-sense items, leave the left menu with links to:
    -  Home (root)
    -  Store
    -  Products
11. At the end please push all your changes :floppy_disk:

More info with eliezer.moreno@gmail.com
