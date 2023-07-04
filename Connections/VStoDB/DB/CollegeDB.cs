using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStoDB.DB
{
    public partial class CollegeDB: DbContext

    {
        public CollegeDB() : base("MyConnection")
        {

        }
        public virtual DbSet<StudentDB> students { get; set; }
    }
}
