# ShopBridgeProductModule

Shop Bridge Product Module API 
Project Overview:
Create a backend solution for Product module to be used by Product Admin, and perform CRUD actions. 
-A product item should require a name, description, and price.

Requirements/Task(s):
1. Add a new item to the inventory 
2. Modify an item in the inventory.
 	3. Delete an item from the inventory. 
4. Lists the items in the inventory.

Tech Stack Used:
1.	.Net Core 6.0 Web API
2.	Microsoft SQL Server 2019
3.	EF Core 

Tools used to Build:
1.	Visual Studio 2022
2.	SQL Server Management Studio 19 preview2
3.	httprepl

Outline the steps/plan for your project:
1.	Create a Product Class with name, Description and Price Properties – 15 mins
2.	Create a DB Context and register it in DI Container – 15 mins
3.	Create a Product Controller using Entity Framework – 10 mins
4.	Implement the functionality of Get, Get/{id}, Put/{id}, Post, Delete/{id} to fulfill the requirements – 15 mins
5.	Test the functionality with httprepl – 20 mins

Testing result from httprepl:

1.	List items in inventory  - Successful
https://localhost:7245/api/products/> get
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Tue, 07 Jun 2022 05:19:22 GMT
Server: Kestrel
Transfer-Encoding: chunked

[
  {
    "id": 2,
    "name": "Wooden Stick",
    "description": "Multi-purpose Wooden Stick",
    "price": 100
  },
  {
    "id": 3,
    "name": "Stick",
    "description": "Multipurpose Wooden Stick",
    "price": 50
  }
]

2.	Add Item to inventory  - Successful
https://localhost:7245/api/products/> post -h Content-Type=application/json -c "{"name":"Cup","Description": "A cup that can hold tea,coffee", "Price": 250}"
HTTP/1.1 201 Created
Content-Type: application/json; charset=utf-8
Date: Tue, 07 Jun 2022 05:20:40 GMT
Location: https://localhost:7245/api/Products/4
Server: Kestrel
Transfer-Encoding: chunked

{
  "id": 4,
  "name": "Cup",
  "description": "A cup that can hold tea,coffee",
  "price": 250
}

3.	Modify item in inventory - Successful
https://localhost:7245/api/products/> connect https://localhost:7245/api/products/3
Using a base address of https://localhost:7245/api/products/3/
Unable to find an OpenAPI description
For detailed tool info, see https://aka.ms/http-repl-doc

https://localhost:7245/api/products/3/> put -h Content-Type=application/json -c "{"id":3,"name":"Mobile Charger","description":"Mobile charger that converts AC to DC","price":500}"
HTTP/1.1 204 No Content
Date: Tue, 07 Jun 2022 05:22:44 GMT
Server: Kestrel




https://localhost:7245/api/products/3/> get
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Tue, 07 Jun 2022 05:22:49 GMT
Server: Kestrel
Transfer-Encoding: chunked

{
  "id": 3,
  "name": "Mobile Charger",
  "description": "Mobile charger that converts AC to DC",
  "price": 500
}

4.	Delete item in inventory - Successful
https://localhost:7245/api/products/3/> delete
HTTP/1.1 204 No Content
Date: Tue, 07 Jun 2022 05:22:57 GMT
Server: Kestrel




https://localhost:7245/api/products/3/> get
HTTP/1.1 404 Not Found
Content-Type: application/problem+json; charset=utf-8
Date: Tue, 07 Jun 2022 05:23:00 GMT
Server: Kestrel
Transfer-Encoding: chunked

{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.4",
  "title": "Not Found",
  "status": 404,
  "traceId": "00-f152405954732d90641a3be448a32842-a6e12a0131f6c6f1-00"
}


https://localhost:7245/api/products/3/> connect https://localhost:7245/api/products/
Using a base address of https://localhost:7245/api/products/
Unable to find an OpenAPI description
For detailed tool info, see https://aka.ms/http-repl-doc

https://localhost:7245/api/products/> get
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Tue, 07 Jun 2022 05:24:30 GMT
Server: Kestrel
Transfer-Encoding: chunked

[
  {
    "id": 2,
    "name": "Wooden Stick",
    "description": "Multi-purpose Wooden Stick",
    "price": 100
  },
  {
    "id": 4,
    "name": "Cup",
    "description": "A cup that can hold tea,coffee",
    "price": 250
  }
]

