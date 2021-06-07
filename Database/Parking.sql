CREATE TABLE [dbo].[Parking]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ParkingName] NVARCHAR(50) NULL, 
    [ParkingLocation] NVARCHAR(50) NOT NULL, 
    [Longitude] NVARCHAR(50) NOT NULL, 
    [Latitude] NVARCHAR(50) NOT NULL
)
