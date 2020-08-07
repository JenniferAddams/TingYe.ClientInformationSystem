using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClientInformationSystem.Core.Entities
{
    public class Clients
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Phones { get; set; }
        public string Address { get; set; }
        public DateTime AddedOn { get; set; }
        public ICollection<Interactions> Interactions { get; set; }
    }
}
