CREATE TABLE Camping (
CampID			Int				NOT NULL,
EventStatusID	Int 			NULL,
UserID			Int				NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
CampSpots		Int				NOT NULL,
Status			VARCHAR(50)		NULL,

CONSTANT		UserPK		UNIQUE (UserID)
)