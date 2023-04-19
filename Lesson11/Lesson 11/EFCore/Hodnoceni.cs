using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.EFCore
{
    internal class Hodnoceni
    {
        [Key]
        public Guid HodnoceniId { get; set; }

        public int IdStudenta { get; set; }

        public string ZkratkaPredmetu { get; set; }

        public DateTimeOffset DatumHodnoceni { get; set; }

        public int HodnoceniStudenta { get; set; }
    }
}
