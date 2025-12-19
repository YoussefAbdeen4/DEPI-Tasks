CREATE DATABASE ddl_task;

USE ddl_task;

CREATE TABLE customers(
id INT PRIMARY KEY,
name VARCHAR(80) NOT NULL,
email VARCHAR(80) NOT NULL UNIQUE,
address VARCHAR(100) NOT NULL,
);

CREATE TABLE categories(
id INT PRIMARY KEY,
name VARCHAR(80) NOT NULL,
[description] TEXT NOT NULL
);

CREATE TABLE customers_phones(
id INT PRIMARY KEY,
customer_id INT NOT NULL,
phone VARCHAR(16) NOT NULL UNIQUE,

CONSTRAINT FK_customer_phone FOREIGN KEY (customer_id)REFERENCES customers(id)
);

CREATE TABLE orders(
id INT PRIMARY KEY,
customer_id INT NOT NULL,
[date] DATE NOT NULL,
total FLOAT NOT NULL,
CONSTRAINT FK_customer_order FOREIGN KEY (customer_id)REFERENCES customers(id)
);

CREATE TABLE products(
id INT PRIMARY KEY,
category_id INT NOT NULL,
name VARCHAR(80) NOT NULL,
[description] TEXT NOT NULL,
price FLOAT NOT NULL,
qty VARCHAR NOT NULL
);

ALTER TABLE products 
ADD CONSTRAINT FK_category_product FOREIGN KEY (category_id)REFERENCES categories(id);

CREATE TABLE order_details(
id INT PRIMARY KEY,
order_id INT NOT NULL,
product_id INT NOT NULL,
unit_price FLOAT NOT NULL,
qty VARCHAR NOT NULL
);

ALTER TABLE order_details 
	ADD CONSTRAINT FK_order_details_order FOREIGN KEY (order_id)REFERENCES orders(id),
	CONSTRAINT FK_order_details_product FOREIGN KEY (product_id)REFERENCES products(id);

DROP DATABASE ddl_task;