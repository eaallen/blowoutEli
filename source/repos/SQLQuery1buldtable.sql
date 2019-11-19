CREATE TABLE [dbo].[Cars] (
    [carID]   INT          IDENTITY (1, 1) NOT NULL,
    [carName] VARCHAR (30) NOT NULL,
    [ownerID] INT          NULL,
    PRIMARY KEY CLUSTERED ([carID] ASC)
);
CREATE TABLE [dbo].[Owner] (
    [ownerID]        INT          IDENTITY (1, 1) NOT NULL,
    [ownerLastName]  VARCHAR (30) NOT NULL,
    [ownerFirstName] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([ownerID] ASC)
);