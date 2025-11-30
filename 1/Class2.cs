using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Exam
{
    internal class Exam
    {
        public string nameExam {  get; set; }
        public int grade { get; set; }
        public DateTime date { get; set; }
        public Exam(string nameExam, int grade, DateTime date)
        {
            this.nameExam = nameExam;
            this.grade = grade;
            this.date = date;
        }
        public Exam()
        {
            nameExam = "Noname";
            grade = 0;
            date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Название экзамена: {nameExam}, дата проведения экзамена: {date.ToString()}, оценка за экзамен: {grade}";
        }
    }
}
