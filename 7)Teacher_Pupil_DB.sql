

CREATE TABLE Teacher
(
	[TeacherId] INT IDENTITY(1,1) PRIMARY KEY,
	[FirstName] Varchar(50) NOT NULL,
	[LastName] Varchar(50),
	[Gender] Varchar(50) NOT NULL,
	[Subject] Varchar(50) NOT NULL
)

INSERT INTO Teacher (FirstName, LastName, Gender, Subject)
VALUES 
('Yennefer', NULL, 'Female', 'Physics'),
('Triss', 'Merigold', 'Female', 'Chemistry'),
('Geralt', NULL, 'Male', 'Sport')


CREATE TABLE Pupil
(
	[PupilId] INT IDENTITY(1,1) PRIMARY KEY,
	[FirstName] Varchar(50) NOT NULL,
	[LastName] Varchar(50),
	[Gender] Varchar(50) NOT NULL,
	[Grade] Varchar(50) NOT NULL
	
)

INSERT INTO Pupil (FirstName, LastName, Gender, Grade)
VALUES 
('Ciri', NULL, 'Female', '12'),
('Sandro', 'Rusitashvili', 'Male', '12'),
('Giorgi', 'Chelidze', 'Male', '10'),
('Salome', 'Giorgadze', 'Female', '12')


CREATE TABLE Classroom
(
	[Teacher_Id] INT NOT NULL FOREIGN KEY REFERENCES Teacher(TeacherId),
	[Pupil_Id] INT NOT NULL FOREIGN KEY REFERENCES Pupil(PupilId),
)

INSERT INTO Classroom (Teacher_Id, Pupil_Id)
VALUES
(3,1),
(1,4),
(2,4),
(2,3),
(3,2),
(1,1),
(2,2),
(3,3)


--DROP TABLE Teacher
--DROP TABLE Pupil
--DROP TABLE Classroom



--select * from Teacher
--select * from Pupil
--select * from Classroom

select Teacher.FirstName, Teacher.LastName, Teacher.Gender, Subject
from Classroom
JOIN Teacher
	ON Classroom.Teacher_Id = TeacherId
JOIN Pupil
	ON Classroom.Pupil_Id = PupilId
WHERE Pupil.FirstName = 'Giorgi'
