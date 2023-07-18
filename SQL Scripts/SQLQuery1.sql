CREATE TABLE Game(
  Id int identity(1,1) PRIMARY KEY NOT NUll,

);

CREATE TABLE Leaderbord(
  Id int identity(1,1) PRIMARY KEY NOT NULL, 
  Username VARCHAR(30) NOT NULL,
  Points int NOT NULL,
  GameId int FOREIGN KEY REFERENCES Game(Id)
);

CREATE TABLE Description(
  Title VARCHAR(30) PRIMARY KEY NOT NULL,
  Descripe VARCHAR(MAX) NOT NULL,
  GameId int FOREIGN KEY REFERENCES Game(Id)
);