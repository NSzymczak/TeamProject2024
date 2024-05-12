-- Uzupe³nienie tabeli Owner danymi
INSERT INTO Owner (Name, Surname, Address, PhoneNumber, Email)
VALUES 
    ('John', 'Doe', '123 Main St', '123-456-7890', 'john@example.com'),
    ('Alice', 'Smith', '456 Elm St', '456-789-0123', 'alice@example.com'),
    ('Bob', 'Johnson', '789 Oak St', '789-012-3456', 'bob@example.com');

-- Uzupe³nienie tabeli Animal danymi
INSERT INTO Animal (Name, OwnerID)
VALUES 
    ('Fluffy', 1),
    ('Spot', 2),
    ('Buddy', 3);

-- Uzupe³nienie tabeli Details danymi
INSERT INTO Details (Breed, Color, AnimalID)
VALUES 
    ('Labrador', 'Golden', 1),
    ('Dalmatian', 'White with black spots', 2),
    ('German Shepherd', 'Brown and black', 3);

-- Uzupe³nienie tabeli FeedingRules danymi
INSERT INTO FeedingRules (FoodType, Frequency, Hours, AdditionalNotes, AnimalID)
VALUES 
    ('Dry food', 2, '8:00, 18:00', 'Special diet', 1),
    ('Canned food', 1, '12:00', 'No additional notes', 2),
    ('Raw food', 1, '7:00, 17:00', 'No additional notes', 3);

-- Uzupe³nienie tabeli Health danymi
INSERT INTO Health (HealthStatus, Vaccination, AdditionalNotes, AnimalID)
VALUES 
    ('Good', '2023-01-01', 'Regular check-ups needed', 1),
    ('Excellent', '2022-12-15', 'No health issues', 2),
    ('Fair', '2022-11-30', 'Recent vaccination', 3);

-- Uzupe³nienie tabeli DailyActivity danymi
INSERT INTO DailyActivity (Date, Hour, AdditionalNotes, AnimalID)
VALUES 
    ('2024-05-01', '10:00', 'Morning walk', 1),
    ('2024-05-02', '15:00', 'Playtime in the backyard', 2),
    ('2024-05-03', '12:30', 'Training session', 3);

-- Uzupe³nienie tabeli User danymi
INSERT INTO [User] (Login, Password)
VALUES 
    ('admin', 'admin123'),
    ('user1', 'password1'),
    ('user2', 'password2');

-- Uzupe³nienie tabeli Visit danymi
INSERT INTO Visit (BeginDate, EndDate, AnimalID)
VALUES 
    ('2024-05-01 08:00:00', '2024-05-01 12:00:00', 1),
    ('2024-05-02 10:00:00', '2024-05-02 14:00:00', 2),
    ('2024-05-03 09:00:00', '2024-05-03 13:00:00', 3);

-- Uzupe³nienie tabeli WalksRules danymi
INSERT INTO WalksRules (Hours, Length, AnimalID)
VALUES 
    ('Morning, Afternoon', 30, 1),
    ('Afternoon, Evening', 45, 2),
    ('Morning, Evening', 60, 3);
