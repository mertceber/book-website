CREATE DATABASE bookDB;
USE bookDB;
CREATE TABLE Books (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Title NVARCHAR(MAX) NULL,
    Author NVARCHAR(MAX) NULL,
    Description NVARCHAR(MAX) NULL,
    Rate FLOAT NULL,
    DateStart DATETIME2 NULL,
    DateRead DATETIME2 NULL
);

INSERT INTO Books ( Title, Description, Author, Rate, DateStart, DateRead)
VALUES 
( 'Managing Oneself', 'We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...', 'Peter Ducker', 4.9, '2019-01-20', NULL),
( 'Büyücü', 'Roman türünde bir kitap', 'John Fowles', 4.9, '2019-01-20', NULL),
('1984', 'Roman türünde bir kitap', 'George Orwell', 4.9, '2019-01-20', NULL),
( 'Körlük', 'Roman türünde bir kitap', 'José Saramago', 4.9, '2019-01-20', NULL),
( 'Açlık', 'Roman türünde bir kitap', 'Knut Hamsun', 4.9, '2019-01-20', NULL);
