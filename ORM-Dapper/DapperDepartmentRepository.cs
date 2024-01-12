using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        //local variables to make querys 
        private readonly IDbConnection _connection;
        public DapperDepartmentRepository(IDbConnection connection) 
        {
            // Constructor
            _connection = connection;

        }



        public IEnumerable<Department> GetAllDepartments()
        {
            var depos = _connection.Query<Department>("SELECT * FROM departments ");

            return depos;
            // second video 27:12 
        }
    }
}
