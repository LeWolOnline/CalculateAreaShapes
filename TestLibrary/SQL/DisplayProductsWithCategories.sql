DROP TABLE IF EXISTS ProductToCategory;
DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS Category;

CREATE TABLE Product (
    Id int PRIMARY KEY,
    Name varchar(255) NOT NULL
);

CREATE TABLE Category (
    Id int PRIMARY KEY,
    Name varchar(255) NULL
);

CREATE TABLE ProductToCategory (
    ProductId int FOREIGN KEY REFERENCES Product(id),
    CategoryId int FOREIGN KEY REFERENCES Category(id)
);

INSERT INTO Product (Id, Name) VALUES ('1', 'Apple');
INSERT INTO Product (Id, Name) VALUES ('2', 'Pear');
INSERT INTO Product (Id, Name) VALUES ('3', 'Cucumber');
INSERT INTO Product (Id, Name) VALUES ('4', 'Winter');
INSERT INTO Product (Id, Name) VALUES ('5', 'Spring');

INSERT INTO Category (Id, Name) VALUES ('1', 'Fruit');
INSERT INTO Category (Id, Name) VALUES ('2', 'Food');

INSERT INTO ProductToCategory (productid, categoryid) VALUES ('1', '1');
INSERT INTO ProductToCategory (productid, categoryid) VALUES ('1', '2');
INSERT INTO ProductToCategory (productid, categoryid) VALUES ('2', '1');
INSERT INTO ProductToCategory (productid, categoryid) VALUES ('2', '2');
INSERT INTO ProductToCategory (productid, categoryid) VALUES ('3', '2');

SELECT Product.Name, Category.Name 
FROM Product
LEFT JOIN ProductToCategory ON Product.id = ProductToCategory.productid
LEFT JOIN Category ON Category.id = ProductToCategory.categoryid;