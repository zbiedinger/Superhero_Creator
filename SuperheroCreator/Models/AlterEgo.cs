using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroCreator.Models
{
    public class AlterEgo
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string Home { get; set; }
        public string RelationshipStatus { get; set; }

        [ForeignKey("Superhero")]
        public int SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}
