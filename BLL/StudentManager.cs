using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class StudentManager
    {
        public static List<students> GetStudents()
        {
            return StudentService.GetStudents();
        }
        public static int Del(int id)
        {
            return StudentService.Del(id);
        }
        public static int Add(students stu)
        {
            return StudentService.Add(stu);
        }
        public static students ByIdGetStu(int id)
        {
            return StudentService.ByIdGetStu(id);
        }
        public static int Edit(students stu)
        {
            return StudentService.Edit(stu);
        }
        public static List<students> PageList(int pageIndex, int pageSize)
        {
            return StudentService.PageList(pageIndex, pageSize);
        }
        public static int GetCount(int pageSize)
        {
            int rows = StudentService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
    }
}
