using System;
using System.Collections.Generic;
using System.Text;

namespace ClientInformationSystem.Core.Entities
{
    public class Interactions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmpId { get; set; }
        public string IntType { get; set; }

        public DateTime Intdate { get; set; }
        public string Remarks { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
