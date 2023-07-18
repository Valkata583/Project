CREATE TABLE Game(
  Id identity(1,1) PRIMARY KEY NOT NUll,

);

CREATE TABLE Leaderbord(
  Id identity(1,1) PRIMARY KEY NOT NULL, 
  Username VARCHAR(30) NOT NULL,
  Points int NOT NULL,
  GameId int FOREIGN KEY REFERENCES Game(Id)
);

CREATE TABLE Description(
  Title VARCHAR PRIMARY KEY NOT NULL,
  Descripe VARCHAR
  GameId int FOREIGN KEY REFERENCES Game(Id)
);

SELECT Username, Points
FROM Game g
LEFT JOIN Leaderbord AS l ON g.Id=l.GameId
WHERE g.Id= 


