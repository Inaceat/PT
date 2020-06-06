using System;
using System.Linq;
using System.Text;

namespace Lab5
{
    [Serializable]
    internal class StudentInfo
    {
        public enum StudentPerfomance
        {
            Отличник,
            Хорошист,
            Троечник
        }

        
        public string Name { get; }

        public int GradeNumber { get; }
        public string GradeIndex { get; }

        public StudentPerfomance Perfomance { get; }


        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public StudentInfo(string name, int gradeNumber, string gradeIndex, StudentPerfomance perfomance)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            
            if (gradeIndex == null)
                throw new ArgumentNullException(nameof(gradeIndex));



            if (0 == name.Trim().Length)
                throw new ArgumentException("Name should contain non-space symbols");
            
            Name = name.Trim();


            GradeNumber = 
                1 <= gradeNumber && gradeNumber <= 11
                ? gradeNumber
                : throw new ArgumentException("Grade number should be between 1 and 11");


            GradeIndex =
                PossibleGradeIndices.Contains(gradeIndex)
                    ? gradeIndex
                    : throw new ArgumentException(PossibleGradeIndices
                                                      .Aggregate(new StringBuilder("Grade index should be one of "),
                                                                 (result, index) => result
                                                                     .Append(", \"")
                                                                     .Append(index)
                                                                     .Append("\""))
                                                      .Remove(0, 2)
                                                      .ToString());


            Perfomance = perfomance;
        }


        private static readonly string[] PossibleGradeIndices = { "А", "Б", "В", "Г" };
    }
}
