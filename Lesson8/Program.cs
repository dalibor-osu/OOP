using Lesson8;

ArchivTeplot archiv = new ();
archiv.Load("./archiv.txt");

archiv.TiskTeplot();
archiv.TiskPrumernychRocnichTeplot();
archiv.TiskPrumernychMesicnichTeplot();

archiv.Kalibrace(1);

archiv.TiskTeplot();
archiv.Save("./archiv2.txt");