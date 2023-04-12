INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (240147, 'Dalibor', 'Drevojanek', '2001-10-29');
INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (265431, 'Preclik', 'Soleny', '2000-9-20');
INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (265421, 'Brambor', 'Soleny', '2001-9-20');
INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (165239, 'Muffin', 'Peceny', '2003-8-21');
INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (986532, 'Rizek', 'Smazeny', '2003-7-22');
INSERT INTO Studenti(ID, Jmeno, Prijmeni, Datum_Narozeni) VALUES (784512, 'Susenka', 'Krupava', '2004-6-23');

INSERT INTO Predmety(Zkratka, Nazev) VALUES ('PC2', 'Pocitace a Programovani 2');
INSERT INTO Predmety(Zkratka, Nazev) VALUES ('PC1', 'Pocitace a Programovani 1');
INSERT INTO Predmety(Zkratka, Nazev) VALUES ('OOP', 'Objektove orientovane programovani');
INSERT INTO Predmety(Zkratka, Nazev) VALUES ('MA1', 'Matematika 1');
INSERT INTO Predmety(Zkratka, Nazev) VALUES ('EL2', 'Elektrotechnika 2');

INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(240147, 'MA1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(240147, 'PC1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(240147, 'MA1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(265431, 'EL2');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(265431, 'OOP');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(265431, 'PC1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(265431, 'MA1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(784512, 'PC2');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(784512, 'MA1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(784512, 'PC1');
INSERT INTO ZapsanePredmety(Student_ID, Predmet_Zkratka) VALUES(784512, 'EL2');

INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(240147, 'MA1', '2019-04-12', 1);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(240147, 'PC1', '2020-04-12', 10);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(784512, 'PC2', '2021-05-09', 8);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(265431, 'EL2', '2023-03-10', 6);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(265431, 'MA1', '2022-04-12', 9);

INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(165239, 'MA1', '2019-04-12', 3);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(165239, 'PC1', '2020-04-12', 11);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(165239, 'PC2', '2021-05-09', 9);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(165239, 'EL2', '2023-03-10', 4);
INSERT INTO Hodnoceni(Student_ID, Predmet_Zkratka, Datum_Hodnoceni, Hodnoceni)
	VALUES(784512, 'MA1', '2022-04-12', 2);