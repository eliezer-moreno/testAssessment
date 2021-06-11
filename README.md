![Image of Ariox](https://images.squarespace-cdn.com/content/5d7967ad390e2854723922f4/1581104335639-FP6E3PJLAZ1P8SE6GKMB/Ariox_connecting_slogan.png?content-type=image%2Fpng)

# testAssessment
This is a technical assessment

Instructions:

1. Please clone this repo.
2. Please create a branch with your name.
3. Please implement the bootstrap theme (zip file startbootstrap-sb-admin-2-gh-pages), remove all non-sense items, leave the left menu with links to:
  -  Home (root)
  -  Products
4. Please create a new Model with the corresponding View-Controller for entity Store as:

Column | Type
------------ | -------------
store_id | id, PK :key:
store_name | varchar(255), required
store_description | varchar(500)
created_date | datetime
updated_date | datetime

5. Add the created_date, updated_date fields tot he entity Products (using the same definition as in store table).
6. Add a FK for store in products table, the result will looks like this:

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

7. Create a new controller to provide the full resultset Store->Product as JSON, this controller doesn't need any view.
8. Modify the scaffolded files to use buttons instead of links (edit/details/delete links in grids)
9. Implement the datatables [datatables](https://datatables.net/) in Products & Store grids
10. At the end please push all your changes :floppy_disk:

More info with eliezer.moreno@gmail.com
