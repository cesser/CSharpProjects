using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataTableTypeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Data1", typeof(object)));
            dt.Columns.Add(new DataColumn("Data2", typeof(object)));

            DataRow r1 = dt.NewRow();
            r1["Data1"] = 1;
            r1["Data2"] = 1;

            dt.Rows.Add(r1);

            dt.Columns["Data1"].DataType = typeof(int);

            Console.Read();
        }
    }
}
