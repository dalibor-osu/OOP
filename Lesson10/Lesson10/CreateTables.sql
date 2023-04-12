CREATE TABLE Predmety (
Zkratka VARCHAR(10) NOT NULL PRIMARY KEY,
Nazev VARCHAR(50) NOT NULL
);

CREATE TABLE Studenti(
ID INT NOT NULL PRIMARY KEY,
Jmeno VARCHAR(50) NOT NULL,
Prijmeni VARCHAR(50) NOT NULL,
Datum_Narozeni DATE NOT NULL
);

CREATE TABLE ZapsanePredmety(
ID INT PRIMARY KEY IDENTITY(1, 1),
Student_ID INT,
Predmet_Zkratka VARCHAR(10),
FOREIGN KEY (Student_ID) REFERENCES Studenti(ID),
FOREIGN KEY (Predmet_Zkratka) REFERENCES Predmety(Zkratka)
);

CREATE TABLE Hodnoceni(
Student_ID INT NOT NULL,
Predmet_Zkratka VARCHAR(10) NOT NULL,
Datum_Hodnoceni DATE NOT NULL,
Hodnoceni INT NOT NULL,
PRIMARY KEY (Student_ID, Predmet_Zkratka)
);