using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Person;
using _Education;
using _Exam;

namespace _Student
{
    internal class Student
    {
        Person person;
        Education education;
        int numberGroup;
        Exam[] exams;
        public Student(Person p, Education ed, int number)
        {
            person = p;
            education = ed;
            numberGroup = number;
            exams = new Exam[0];
        }
        public Student()
        {
            person = new Person();
            education = Education.Specialist;
            numberGroup = 0;
            exams = new Exam[0];
        }
        public Person Pers
        {
            get { return person; }
            set {  person = value; }
        }
        public Education Educ
        {
            get { return education; }
            set { education = value; }
        }
        public int Group
        {
            get { return numberGroup;}
            set {
                if (value > 0) numberGroup = value;
            }
        }
        public Exam[] Exams
        {
            get { return exams; }
            set { exams= value;}
        }
        public double Gpa
        {
            get
            {
                int sum = 0;
                for(int i=0;i<exams.Length;i++)
                {
                    sum += exams[i].grade;
                }
                return (double)sum/exams.Length;
            }
        }
        public bool this[Education index]
        {
            get { return education == index; }
        }
        public void AddExams(params Exam[] ex)
        {
            if (ex.Length == 0) throw new Exception("Передан массив нулевого размера");
            Exam[] newMas= new Exam[exams.Length + ex.Length];
            for(int i=0;i<exams.Length;i++)
            {
                newMas[i] = exams[i];
            }
            for (int i = exams.Length; i < ex.Length; i++)
            {
                newMas[i] = ex[i];
            }
            exams= newMas;
        }
        public override string ToString()
        {
            string str = "";
            foreach(Exam e in exams)
            {
                str += e.ToString + "\n";
            }
            return $"Студент:{person}\nФорма обучения:{education}\nНомер группы:{numberGroup}\nСданные экзамены:\n{str}";
        }
        public virtual string ToShortString()
        {
            return $"Студент:{person}\nФорма обучения:{education}\nНомер группы:{numberGroup}\nСредний балл за экзамены:{this.Gpa}";
        }
    }
}
