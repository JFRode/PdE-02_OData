using System;

namespace SanFranciscoSchool.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Guid SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }
    }
}