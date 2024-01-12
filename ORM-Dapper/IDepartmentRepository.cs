﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IDepartmentRepository
    {
        // method called GetAllDepartments that returns a collection
        // that confirms to IEnumerable<T>
        IEnumerable<Department> GetAllDepartments();

    }
}
