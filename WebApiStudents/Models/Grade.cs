using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiStudents.Models
{
    /// <summary>
    /// Ocena studenta z przedmiotu
    /// </summary>
    public class Grade
    {
        public string Subject { get; set; }
        public int Value { get; set; }
    }
}
