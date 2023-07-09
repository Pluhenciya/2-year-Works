-- 1 �������
INSERT INTO Book
                         (Title, PublicationYear, IdAuthor)
VALUES        (N'������� ���������', 1999, 3);

-- 2 �������
DELETE FROM Customer
WHERE        (Phone IS NULL);

-- 3 ������� 
UPDATE       Book
SET                Price -= 100
WHERE        (Title LIKE N'%������%');

-- 4 �������
SELECT surname, name, title, price, PublicationYear
INTO              Prose
FROM  Book JOIN Author ON Book.IdAuthor = Author.IdAuthor
WHERE        (Genre = N'�����')

-- ������� 5
DELETE [Order]
WHERE         [Order].IdOrder NOT IN
                             (SELECT DISTINCT IdOrder
                               FROM            Composition )

-- ������� 6
UPDATE       Book
SET                Price += 100
FROM Book JOIN Author ON Book.IdAuthor = Author.IdAuthor
WHERE   (Country= '������');

-- ������� 7
UPDATE Book
SET Price = CASE Genre
WHEN '�����' THEN Price * 0.9
WHEN '������' THEN Price + 100
ELSE Price
END