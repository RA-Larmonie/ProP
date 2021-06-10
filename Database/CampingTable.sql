CREATE TABLE Camping (
CampID			Int				NOT NULL,
EventStatusID	Int 			NULL,
UserID			Int				NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
CampSpots		Int				NOT NULL,
Status			VARCHAR(50)		NULL,

CONSTRAINT		CampID	 PRIMARY KEY(CampID),
CONSTRAINT     UserID FOREIGN KEY(UserID) REFERENCES visitor(UserID),
CONSTRAINT     EventStatusID FOREIGN KEY(EventStatusID) REFERENCES event_status(EventStatusID)    
);