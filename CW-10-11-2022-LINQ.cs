using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassWork
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class LINQ
    {

        public static void JoinExample()
        {
            var groups = new[]
            {
                new Group
                {
                    Id = 1,
                    Name = "Группа 1"
                },
                new Group
                {
                    Id = 2,
                    Name = "Группа 2"
                },
                new Group
                {
                    Id = 3,
                    Name = "Группа 3"
                }
            };
            var students = new[]
            {
                new Student
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Петр",
                    LastName = "Петров",
                    GroupId = 2
                },
                new Student
                {
                    FirstName = "Сергей",
                    LastName = "Сергеев",
                    GroupId = 3
                },
                new Student
                {
                    FirstName = "Николай",
                    LastName = "Иванов",
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Алексей",
                    LastName = "Алексеев",
                    GroupId = 3
                }
            };

            /*var query1 = from g in groups
                join s in students on g.Id equals s.GroupId into result
                from r in result
                select r;*/
            //var query = from g in groups
            //            join s in students on g.Id equals s.GroupId
            //            select new { FirstName = s.FirstName, LastName = s.LastName, Group = g.Name };

            //Console.WriteLine("Students in groups");
            //foreach (var item in query)
            //{
            //}
        }
    }

    public class School
    {
        private readonly List<Student> _students;
        private readonly List<Group> _groups;

        public Student[] Students => _students.ToArray();
        public Group[] Groups => _groups.ToArray();

        public School()
        {
            _students = new List<Student>();
            _groups = new List<Group>();
        }

        public void AddStudentToGroup(Student student, Group group)
        {
            student.GroupId = group.Id;
            _students.Add(student);
            _groups.Add(group);
        }
    }

    // Реализовать метод, который возвращает коллекцию студентов с именем, начинающимся на букву,
    // переданную в качестве параметра
    // public static IEnumerable<Student> GetStudentsByFirstLetterInName(char letter)

    // Реализовать метод, который возвращает коллекцию студентов, принадлежащих указанной группе
    // public static IEnumerable<Student> GetStudentsByGroupId(int groupId);

    // Реализовать метод, который выводит на печать студентов в формате: "Имя: <FirstName>, Фамилия: <LastName>, Группа: <GroupName>"
    // public static void Print();
    public static class SchoolExtensions
    {
        public static IEnumerable<Student> GetStudentsByFirstLetterInName_Ext(this School school, char letter)
        {
            List<Student> list = school.Students.ToList<Student>();
            IEnumerable<Student> query = from s in list
                                         where s.FirstName.ToUpper()[0] == letter.ToString().ToUpper()[0]
                                         select s;
            return query;
        }

        public static IEnumerable<Student> GetStudentsByGroupId_Ext(this School school, int groupId)
        {
            List<Student> list = school.Students.ToList<Student>();
            IEnumerable<Student> query = from s in list
                                         where s.GroupId == groupId
                                         select s;
            return query;
        }

        public static void Print(this School school)
        {
            List<Student> list = school.Students.ToList<Student>();
            var query = from s in list
                        join g in school.Groups on s.GroupId equals g.Id
                        select new { FirstName = s.FirstName, LastName = s.LastName, Group = g.Name };
            foreach (var item in query)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Group}");
            }
        }

        // Вернуть коллекцию студентов отсортированых по имени или группе с учетом переданного параметра type
        // если OrderedTypes.Asc, то по возрастанию
        // если OrderedTypes.Desc, то по убывнию
        public static IEnumerable<StudentData> GetOrderedStudents(this School school, OrderTypes type)
        {
            List<Student> students = school.Students.ToList();
            var query = from s in students
                        join g in school.Groups on s.GroupId equals g.Id
                        select new StudentData { FirstName = s.FirstName, LastName = s.LastName, GroupName = g.Name };
            switch (type)
            {
                case OrderTypes.Asc:
                    query.ToList<StudentData>().Sort((StudentData s1, StudentData s2) => String.Compare(s1.FirstName.ToUpper(), s2.FirstName.ToUpper()));
                    break;
                case OrderTypes.Desc:
                    query.ToList<StudentData>().Sort((StudentData s1, StudentData s2) => String.Compare(s1.FirstName.ToUpper(), s2.FirstName.ToUpper()) * -1);
                    break;
                default:
                    throw new CustomException("Wrong type.");
            }
            return query;
        }
    }

    public class StudentData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
    }

    public enum OrderTypes
    {
        Asc,
        Desc
    }
}