using System;
using System.ComponentModel.DataAnnotations;

namespace Mission3Walkthrough.Models
{
    public class GradeCalculatorModel
    {
        [Range(0, 100)]
        public int assignmentGrade { get; set; }
        //[Required]
        [Range(0, 100)]
        public int groupGrade { get; set; }
        //[Required]
        [Range(0, 100)]
        public int quizGrade { get; set; }
        //[Required]
        [Range(0, 100)]
        public int examGrade { get; set; }
        //[Required]
        [Range(0, 100)]
        public int intexGrade { get; set; }

        //public GradeCalculatorModel()
        //{

        //}
    }
}
