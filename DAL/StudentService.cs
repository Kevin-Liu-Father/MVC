using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class StudentService
    {
        public static List<students> GetStudents()
        {
            StudentEntities demo = new StudentEntities();
            //
            return demo.students.ToList();
        }

        public static int Del(int id)
        {
            
                StudentEntities demo = new StudentEntities();
                var obj = from p in demo.students where p.id == id select p;
                demo.students.Remove(obj.First());


            return demo.SaveChanges();
            
        }

        public static int Add(students stu)
        {
            
                StudentEntities demo = new StudentEntities();
                demo.students.Add(stu);
                
                return demo.SaveChanges();
            
        }
        public static students ByIdGetStu(int id)
        {
            StudentEntities demo = new StudentEntities();
            var obj = from p in demo.students where p.id == id select p;
            return obj.First();
        }

        public static int Edit(students stu)
        {

            StudentEntities demo = new StudentEntities();
            var obj = (from p in demo.students where p.id == stu.id select p).First();
            obj.name = stu.name;
            obj.age = stu.age;
            obj.class_id = stu.class_id;
            return demo.SaveChanges();




        }

        public static List<students> PageList(int pageIndex, int pageSize)
        {
            StudentEntities demo = new StudentEntities();
            var obj = from p in demo.students orderby p.id select p;
            return obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        public static int GetRows()
        {
            //实例化linq to sql 对象
            StudentEntities demo = new StudentEntities();
            return demo.students.Count();
        }
    }
}
