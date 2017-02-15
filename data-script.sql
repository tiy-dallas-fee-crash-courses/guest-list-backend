--This is SQL! (pronounced "Sequal")

--This deletes a table
DROP TABLE dbo.PersonList


--This creates a table
CREATE TABLE dbo.PersonList (
	PersonId INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	TimeOfSignIn DATETIME NOT NULL
)
GO





INSERT INTO Guestbook.dbo.PersonList (FirstName, LastName, TimeOfSignIn) VALUES ('Jack', 'Black', '2017-02-14 19:13');
INSERT INTO Guestbook.dbo.PersonList (FirstName, LastName, TimeOfSignIn) VALUES ('Jack', 'Bauer', '2017-02-13 13:45');
INSERT INTO Guestbook.dbo.PersonList (FirstName, LastName, TimeOfSignIn) VALUES ('Jack', 'Nicholson', '2017-02-13 8:30');
INSERT INTO Guestbook.dbo.PersonList (FirstName, LastName, TimeOfSignIn) VALUES ('Peter', 'Cullen', '2017-02-14 15:09');
INSERT INTO Guestbook.dbo.PersonList (FirstName, LastName, TimeOfSignIn) VALUES ('Tasslehoff', 'Burrfoot', '2017-02-15 9:00');

SELECT * FROM PersonList


