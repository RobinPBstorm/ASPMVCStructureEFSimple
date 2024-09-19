using System.ComponentModel;

namespace StructrureEFSimple.Models
{
    public class PersonneViewModel
    {
        [DisplayName("Identifiant")]
        public int Id { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }
        public PersonneViewModel? Referent { get; set; }
    }
}
