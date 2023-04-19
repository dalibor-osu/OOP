using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.EFCore
{
    internal class Predmet
    {
        [Key]
        public Guid PredmetId { get; set; }

        [Key]
        public string Zkratka { get; set; }

        public string Nazev { get; set; }
    }
}
