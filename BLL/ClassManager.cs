﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ClassManager
    {
        public static List<classes> GetClasses()
        {
            return ClassService.GetClasses();
        }
    }
}
