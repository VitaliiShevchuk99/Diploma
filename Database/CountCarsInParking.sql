CREATE TABLE [dbo].[CountCarsInParking]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ParkingID] INT NOT NULL references Parking(Id), 
    [NumberOfCars] INT NOT NULL
)
