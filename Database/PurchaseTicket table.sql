CREATE TABLE Ticket(
UserID				Int					NOT NULL,
Type_Of_Ticket		VARCHAR(50)			NOT NULL,
Amount				Int					NOT NULL,
Price				DECIMAL				NOT NULL,
Date_Of_Purchase	SYSDATE				NOT NULL,

CONSTANT			UserPK				PRIMARY KEY (UserID),
CONSTRAINT			CheckAmountSold		CHECK(SUM(Amount) < 5000)
)