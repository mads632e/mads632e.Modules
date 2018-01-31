using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.DataAccess;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryBase repositoryBase = new RepositoryBase("ModulesDB");
            DataSet ds = repositoryBase.GetTestData("SELECT * FROM Test");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
