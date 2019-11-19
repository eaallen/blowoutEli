CREATE TABLE [dbo].[Player] (
    [playerID]        INT          IDENTITY (1, 1) NOT NULL,
    [playerLastName]  VARCHAR (30) NOT NULL,
    [playerFirstName] VARCHAR (30) NOT NULL,
    [positionCode]    VARCHAR (2)  NOT NULL,
    [teamID]          VARCHAR (2)  NULL,
    PRIMARY KEY CLUSTERED ([playerID] ASC)
);

CREATE TABLE [dbo].[Position] (
    [positionCode] VARCHAR (2)  NOT NULL,
    [positionDesc] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([positionCode] ASC)
);

CREATE TABLE [dbo].[Team] (
    [teamID]   VARCHAR (2)  NOT NULL,
    [teamName] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([teamID] ASC)
);


Insert into [dbo].[Position] (positionCode, positionDesc)
Values ('C', 'CENTER'), ('F', 'FORWARD'), ('G', 'GUARD');


Insert into [dbo].[Team] (teamID, teamName)
Values ('JA', 'JAZZ'), ('NU', 'NUGGETS'), ('HE', 'HEAT'), ('GS', 'GOLDEN STATE');

Insert into [dbo].[Player] (playerLastName, playerFirstName, positionCode, teamID)
Values 
('JONES', 'BOB', 'G', 'JA'),
('SMITH', 'JOHN', 'F', 'JA'),
('WHITE', 'MACK', 'C', 'NU'),
('HOWARD', 'DERRICK', 'G', 'NU'),
('DURRANT', 'KEVIN', 'F', 'NU'),
('CURRY', 'STEPHEN', 'G', 'GS');

Select Team.teamID, Team.teamName, Player.playerID, Player.playerLastName, Player.playerFirstName, Position.positionCode, Position.positionDesc
FROM Team, Player, Position
WHERE Team.teamID = Player.teamID AND
Player.positionCode = Position.positionCode
Order by Team.teamName, Player.playerLastName, Player.playerFirstName;