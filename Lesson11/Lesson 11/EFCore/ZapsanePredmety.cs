using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.EFCore
{
    internal class ZapsanePredmety
    {
        [Key]
        public Guid ZapsanePredmetyId { get; set; }

        public int IdStudenta { get; set; }

        public string ZkratkaPredmetu { get; set; }
    }
}
