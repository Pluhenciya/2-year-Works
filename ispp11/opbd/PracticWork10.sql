-- Задание 1
CREATE TABLE Discount(
	IdDiscount int IDENTITY(1,1) NOT NULL,
	Name nvarchar(50) NOT NULL,
	Description nvarchar(200) NULL,
	Amount  int NOT NULL,
	DateStart date NOT NULL DEFAULT GetDate(),
	DateFinish date NULL,
	PRIMARY KEY (IdDiscount)
);

-- Задание 2
CREATE TABLE DiscountProduct(
	IdDiscount int NOT NULL,
	IdBook int NOT NULL,
	PRIMARY KEY (IdDiscount, IdBook),
	CONSTRAINT FK_Discount_DiscountProduct
		FOREIGN KEY (IdDiscount)
		REFERENCES Discount 
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FK_Book_DiscountProduct
		FOREIGN KEY (IdBook)
		REFERENCES Book 
		ON DELETE NO ACTION
		ON UPDATE CASCADE
);

-- Задание 3
ALTER TABLE Discount
ADD Type nvarchar(5) NULL;

-- Задание 4
ALTER TABLE Discount
ADD CONSTRAINT DF_TypeDiscount
DEFAULT '%' FOR Type;

-- Задание 5
ALTER TABLE Discount
ADD 
CONSTRAINT CK_TypeDiscount
CHECK (Type='%' OR Type='руб.'),
CONSTRAINT CK_DiscountAmount
CHECK (Amount>0);

-- Задание 6
ALTER TABLE Discount
ADD CONSTRAINT UQ_Name_DateStart
UNIQUE (Name, DateStart);

-- Задание 7
ALTER TABLE DiscountProduct
DROP CONSTRAINT FK_Discount_DiscountProduct;
DROP TABLE Discount;