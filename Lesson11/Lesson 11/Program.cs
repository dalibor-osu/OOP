using Lesson_11.EFCore;
using Microsoft.EntityFrameworkCore;

namespace Lesson_11
{
    public class Program
    {
        public static void Main() => new Program().App();

        private void App()
        {
            using (VyukaContex context = new VyukaContex())
            {
                AddDefaultValues(context);

                Console.WriteLine("Predmety s poctem studentu:");
                PrintSubjectsWithStudentCount(context);

                Console.WriteLine("\nPredmety s prumernym hodnocenim:");
                PrintSubjectsWithAverageGrade(context);

                Console.WriteLine("\nStudenti predmetu MA1:");
                foreach (var student in SubjectStudents(context, "MA1"))
                {
                    Console.WriteLine($"\t{student.Jmeno} {student.Prijmeni}, {student.DatumNarozeni.Date}, {student.IdStudenta}");
                }

                Console.WriteLine("\nPredmety studenta 240147:");
                foreach (var predmet in StudentsSubjects(context, 240147))
                {
                    Console.WriteLine($"\t{predmet.Nazev}");
                }
            }
        }

        private void PrintSubjectsWithStudentCount(VyukaContex context)
        {
            var result = from p in context.Predmets
                         join zp in context.ZapsanePredmets on p.Zkratka equals zp.ZkratkaPredmetu into g
                         select new { Predmet = p.Nazev, Studenti = g.Count() };

            foreach (var item in result)
            {
                Console.WriteLine("\t" + $"{item.Predmet} - {item.Studenti}");
            }
        }

        private void PrintSubjectsWithAverageGrade(VyukaContex context)
        {
            var result = from p in context.Predmets
                         join h in context.Hodnocenis on p.Zkratka equals h.ZkratkaPredmetu into g
                         select new { Predmet = p.Nazev, Prumer = g.Count() > 0 ? g.Average(h => h.HodnoceniStudenta) : 0 };

            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.Predmet + " - " + item.Prumer);
            }
        }

        IEnumerable<Student> SubjectStudents(VyukaContex context, string zkratkaPredmetu)
        {
            return from zp in context.ZapsanePredmets
                   join s in context.Students on zp.IdStudenta equals s.IdStudenta
                   where zp.ZkratkaPredmetu == zkratkaPredmetu
                   select s;
        }

        IEnumerable<Predmet> StudentsSubjects(VyukaContex context, int idStudenta)
        {
            return from zp in context.ZapsanePredmets
                   join p in context.Predmets on zp.ZkratkaPredmetu equals p.Zkratka
                   where zp.IdStudenta == idStudenta
                   select p;
        }
        
        private void AddDefaultValues(VyukaContex context)
        {
            context.Database.Migrate();

            foreach (var student in students)
            {
                if (!context.Students.Where(s => s.IdStudenta == student.IdStudenta).Any())
                {
                    context.Students.Add(student);
                }
            }

            foreach (var predmet in predmets)
            {
                if (!context.Predmets.Where(p => p.Zkratka == predmet.Zkratka).Any())
                {
                    context.Predmets.Add(predmet);
                }
            }

            foreach (var predmet in zapsanePredmety)
            {
                if (!context.ZapsanePredmets.Where(p => p.IdStudenta == predmet.IdStudenta && p.ZkratkaPredmetu == predmet.ZkratkaPredmetu).Any())
                {
                    context.ZapsanePredmets.Add(predmet);
                }
            }

            foreach (var hodnoceni in hodnocenis)
            {
                if (!context.Hodnocenis.Where(h => h.ZkratkaPredmetu == hodnoceni.ZkratkaPredmetu && h.IdStudenta == hodnoceni.IdStudenta).Any())
                {
                    context.Hodnocenis.Add(hodnoceni);
                }
            }

            context.SaveChanges();
        }

        Student[] students =
        {
            new Student()
            {
                IdStudenta = 240147,
                Jmeno = "Dalibor",
                Prijmeni = "Drevojanek",
                DatumNarozeni = DateTimeOffset.Parse("2001-10-29")
            },
            new Student()
            {
                IdStudenta = 265431,
                Jmeno = "Preclik",
                Prijmeni = "Soleny",
                DatumNarozeni = DateTimeOffset.Parse("2000-9-20")
            },
            new Student()
            {
                IdStudenta = 265421,
                Jmeno = "Brambor",
                Prijmeni = "Soleny",
                DatumNarozeni = DateTimeOffset.Parse("2001-9-20")
            },
            new Student()
            {
                IdStudenta = 165239,
                Jmeno = "Peceny",
                Prijmeni = "Drevojanek",
                DatumNarozeni = DateTimeOffset.Parse("2003-8-21")
            },
            new Student()
            {
                IdStudenta = 986532,
                Jmeno = "Rizek",
                Prijmeni = "Smazeny",
                DatumNarozeni = DateTimeOffset.Parse("2003-7-22")
            },
            new Student()
            {
                IdStudenta = 784512,
                Jmeno = "Susenka",
                Prijmeni = "Krupava",
                DatumNarozeni = DateTimeOffset.Parse("2004-6-23")
            },
        };

        Predmet[] predmets =
        {
            new Predmet()
            {
                Zkratka = "PC2",
                Nazev = "Pocitace a programovani 2"
            },
            new Predmet()
            {
                Zkratka = "PC1",
                Nazev = "Pocitace a programovani 1"
            },
            new Predmet()
            {
                Zkratka = "OOP",
                Nazev = "Objektove orientovane programovani"
            },
            new Predmet()
            {
                Zkratka = "MA1",
                Nazev = "Matematika 1"
            },
            new Predmet()
            {
                Zkratka = "EL2",
                Nazev = "Elektrotechnika 2"
            }
        };

        ZapsanePredmety[] zapsanePredmety =
        {
            new ZapsanePredmety()
            {
                IdStudenta = 240147,
                ZkratkaPredmetu = "MA1",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 240147,
                ZkratkaPredmetu = "PC1",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 240147,
                ZkratkaPredmetu = "PC2",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "EL2",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "OOP",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "PC1",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "MA1",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 784512,
                ZkratkaPredmetu = "MA1",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 784512,
                ZkratkaPredmetu = "PC2",
            },
            new ZapsanePredmety()
            {
                IdStudenta = 784512,
                ZkratkaPredmetu = "PC1",
            },
        };

        Hodnoceni[] hodnocenis =
        {
            new Hodnoceni()
            {
                IdStudenta = 240147,
                ZkratkaPredmetu = "MA1",
                DatumHodnoceni = DateTimeOffset.Parse("2019-04-12"),
                HodnoceniStudenta = 1
            },
            new Hodnoceni()
            {
                IdStudenta = 240147,
                ZkratkaPredmetu = "PC1",
                DatumHodnoceni = DateTimeOffset.Parse("2020-04-12"),
                HodnoceniStudenta = 10
            },
            new Hodnoceni()
            {
                IdStudenta = 784512,
                ZkratkaPredmetu = "PC2",
                DatumHodnoceni = DateTimeOffset.Parse("2020-05-12"),
                HodnoceniStudenta = 8
            },
            new Hodnoceni()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "EL2",
                DatumHodnoceni = DateTimeOffset.Parse("2018-04-12"),
                HodnoceniStudenta = 75
            },
            new Hodnoceni()
            {
                IdStudenta = 265431,
                ZkratkaPredmetu = "MA1",
                DatumHodnoceni = DateTimeOffset.Parse("2022-04-12"),
                HodnoceniStudenta = 9
            },
            new Hodnoceni()
            {
                IdStudenta = 165239,
                ZkratkaPredmetu = "MA1",
                DatumHodnoceni = DateTimeOffset.Parse("2019-04-13"),
                HodnoceniStudenta = 16
            },
            new Hodnoceni()
            {
                IdStudenta = 165239,
                ZkratkaPredmetu = "PC1",
                DatumHodnoceni = DateTimeOffset.Parse("2019-04-14"),
                HodnoceniStudenta = 67
            },
            new Hodnoceni()
            {
                IdStudenta = 165239,
                ZkratkaPredmetu = "PC2",
                DatumHodnoceni = DateTimeOffset.Parse("2019-04-15"),
                HodnoceniStudenta = 45
            },
            new Hodnoceni()
            {
                IdStudenta = 165239,
                ZkratkaPredmetu = "EL2",
                DatumHodnoceni = DateTimeOffset.Parse("2019-04-16"),
                HodnoceniStudenta = 34
            },
            new Hodnoceni()
            {
                IdStudenta = 784512,
                ZkratkaPredmetu = "MA1",
                DatumHodnoceni = DateTimeOffset.Parse("2022-04-17"),
                HodnoceniStudenta = 2
            },
        };
    }
}