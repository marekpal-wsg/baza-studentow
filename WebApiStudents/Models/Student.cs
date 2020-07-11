using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiStudents.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Album { get; set; }

        public int MothersName { get; set; }

        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Adres zamieszkania studenta
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Oceny studenta
        /// </summary>
        List<Grade> Grades { get; set; }

        /// <summary>
        /// Ukończona szkoła średnia
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Dodatkowa informacja - poprawka komentarza (Marek)
        /// </summary>
        public string AdditionalInformation { get; set; }
    }
}
