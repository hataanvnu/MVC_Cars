CREATE TABLE [dbo].[Car]
(
	[ID] INT NOT NULL identity PRIMARY KEY,
	Brand nvarchar(20),
	Doors int,
	TopSpeed int
)
