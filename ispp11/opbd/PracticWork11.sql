-- 1 задание
INSERT INTO Book
                         (Title, PublicationYear, IdAuthor)
VALUES        (N'Сборник рассказов', 1999, 3);

-- 2 Задание
DELETE FROM Customer
WHERE        (Phone IS NULL);

-- 3 Задание 
UPDATE       Book
SET                Price -= 100
WHERE        (Title LIKE N'%Сказки%');

-- 4 Задание
SELECT surname, name, title, price, PublicationYear
INTO              Prose
FROM  Book JOIN Author ON Book.IdAuthor = Author.IdAuthor
WHERE        (Genre = N'проза')

-- Задание 5
DELETE [Order]
WHERE         [Order].IdOrder NOT IN
                             (SELECT DISTINCT IdOrder
                               FROM            Composition )

-- Задание 6
UPDATE       Book
SET                Price += 100
FROM Book JOIN Author ON Book.IdAuthor = Author.IdAuthor
WHERE   (Country= 'Россия');

-- Задание 7
UPDATE Book
SET Price = CASE Genre
WHEN 'проза' THEN Price * 0.9
WHEN 'поэзия' THEN Price + 100
ELSE Price
END