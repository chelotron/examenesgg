using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeGender
    {

        Male,
        Female,

    }
    public class Student
    {

        [Key]
        public int StudentID { get; set; }
        [Required(ErrorMessage="Please Enter Name")]
        public string  Name { get; set; }
        [Required]
        public TypeGender Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DataType BirthDate { get; set; }


    }
}