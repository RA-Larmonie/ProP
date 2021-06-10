CREATE TABLE assignCamping (
TransactionID   Int             Not Null,    
CampID			Int				NOT NULL,
EventStatusID	Int 			NULL,
UserID			Int				NULL,
StartDate		date			NOT NULL,
EndDate			date			 NULL,
CONSTRAINT     TransactionID PRIMARY KEY(TransactionID),
CONSTRAINT	   CampID FOREIGN KEY(CampID) REFERENCES camping(CampID),
CONSTRAINT     UserID FOREIGN KEY(UserID) REFERENCES visitor(UserID),
CONSTRAINT     EventStatusID FOREIGN KEY(EventStatusID) REFERENCES event_status(EventStatusID)    
);