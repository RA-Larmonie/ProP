CREATE TABLE Visitor (
UserID			Int			NOT NULL,
EventStatusID	Int			NULL,
UserFirstName	Char(25)	NOT NULL,
UserLastName	Char(25)	NOT NULL,
Email			Char(50)	NOT NULL,
DateOfBirth		DATE		NOT NULL,
Password		Char(25)	NOT NULL,
Balance			DOUBLE		NULL,
CheckedInEvent	BOOLEAN		NOT NULL,
CheckedOutEvent	BOOLEAN		NOT NULL,

CONSTANT		UserPK		PRIMARY KEY (UserID),
CONSTANT		UserAK		UNIQUE		(Email)
);