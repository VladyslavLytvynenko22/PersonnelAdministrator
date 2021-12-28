using System;

namespace PersonnelAdministrator.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
        public Guid LastChangeUserId { get; set; }
    }
}
