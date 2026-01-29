CREATE DATABASE student;
use student;

CREATE TABLE students(
 id int primary key identity(1,1),
 first_name varchar(20),
 last_name varchar(20),
 age int,
 grade varchar(2)
);

INSERT INTO Students (first_name, last_name , age, grade) VALUES
('Monkey D', 'Luffy', 19, 'A+'),
('Roronoa', 'Zoro', 21, 'A+'),
('Vinsmoke', 'Sanji', 21, 'A+'),
('Tony Tony', 'Chopper', 17, 'B+'),
('Nico', 'Robin', 30, 'A');

SELECT * FROM students;

SELECT first_name , last_name FROM students;

SELECT * FROM students
WHERE age<=18;

SELECT * FROM students
WHERE grade in('A+','A');

-------------------------------------------------

CREATE DATABASE book;
use book;

CREATE TABLE books (
    id INT PRIMARY KEY,
    title VARCHAR(160),
    author VARCHAR(60),
    published_year INT,
    price DECIMAL(10, 2)
);

INSERT INTO Books VALUES
(101, 'How to be King of Pirates', 'Monkey D. Luffy', 1997, 500.00),
(102, 'Mastering Three Sword Style', 'Roronoa Zoro', 1998, 320.00),
(103, 'The All Blue Cookbook', 'Vinsmoke Sanji', 2009, 40.00),
(104, 'Mapping the Grand Line', 'Nami', 2004, 66.00),
(105, 'The Void Century Secrets', 'Nico Robin', 2001, 100.00);

SELECT * FROM books;

UPDATE books SET
published_year = 1999,
price = 177.00
WHERE id = 103;

SELECT * FROM books
ORDER BY published_year;

DELETE FROM books 
WHERE id = 104;

SELECT * FROM books
WHERE published_year < 2000;
