-- Usuniêcie wszystkich tabel
DROP TABLE IF EXISTS WalksRules;
DROP TABLE IF EXISTS Visit;
DROP TABLE IF EXISTS [User];
DROP TABLE IF EXISTS DailyActivity;
DROP TABLE IF EXISTS Owner;
DROP TABLE IF EXISTS Health;
DROP TABLE IF EXISTS FeedingRules;
DROP TABLE IF EXISTS Details;
DROP TABLE IF EXISTS Animal;

-- Utworzenie tabeli Owner
CREATE TABLE Owner (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Surname VARCHAR(100),
    Address VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Email VARCHAR(100)
);

-- Utworzenie tabeli Animal
CREATE TABLE Animal (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    OwnerID INT NOT NULL,
	FOREIGN KEY (OwnerID) REFERENCES Owner(ID)
);

-- Utworzenie tabeli Details
CREATE TABLE Details (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Breed VARCHAR(100),
    Color VARCHAR(50),
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);

-- Utworzenie tabeli FeedingRules
CREATE TABLE FeedingRules (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FoodType VARCHAR(100),
    Frequency INT,
    Hours VARCHAR(100),
    AdditionalNotes VARCHAR(255),
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);

-- Utworzenie tabeli Health
CREATE TABLE Health (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    HealthStatus VARCHAR(100),
    Vaccination DATETIME,
    AdditionalNotes VARCHAR(255),
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);



-- Utworzenie tabeli DailyActivity
CREATE TABLE DailyActivity (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Date DATE,
    Hour VARCHAR(20),
    AdditionalNotes VARCHAR(255),
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);

-- Utworzenie tabeli User
CREATE TABLE [User] (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Login VARCHAR(100),
    Password VARCHAR(100)
);

-- Utworzenie tabeli Visit
CREATE TABLE Visit (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    BeginDate DATETIME,
    EndDate DATETIME,
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);

-- Utworzenie tabeli WalksRules
CREATE TABLE WalksRules (
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Hours VARCHAR(100),
    Length INT,
    AnimalID INT,
    FOREIGN KEY (AnimalID) REFERENCES Animal(ID)
);
