using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Entities
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int? ReferentId { get; set; }
        public Personne? Referent { get; set; }
    }
}
