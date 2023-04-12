SELECT * FROM ZapsanePredmety
	LEFT JOIN Studenti ON ZapsanePredmety.Student_ID = Studenti.ID
	LEFT JOIN Predmety ON ZapsanePredmety.Predmet_Zkratka = Predmety.Zkratka;

SELECT Prijmeni, COUNT(Prijmeni) AS PocetPrijmeni 
	FROM Studenti 
	GROUP BY Prijmeni 
	ORDER BY PocetPrijmeni DESC;

SELECT Predmet_Zkratka, COUNT(Predmet_Zkratka) as PocetZapsani
	FROM ZapsanePredmety
	LEFT JOIN Predmety ON ZapsanePredmety.Predmet_Zkratka = Predmety.Zkratka

	GROUP BY Predmet_Zkratka
	HAVING COUNT(Predmet_Zkratka) < 3
	ORDER BY PocetZapsani DESC;

SELECT Hodnoceni.Predmet_Zkratka,
	AVG(Hodnoceni.Hodnoceni) AS PrumerneHodnoceni, 
	MAX(Hodnoceni.Hodnoceni) AS MaximalniHodnoceni, 
	MIN(Hodnoceni.Hodnoceni) AS MinimalniHodnoceni,
	COUNT(Studenti.ID) AS PocetStudentu
	FROM Hodnoceni
	LEFT JOIN Studenti ON Hodnoceni.Student_ID = Studenti.ID
	GROUP BY Hodnoceni.Predmet_Zkratka;