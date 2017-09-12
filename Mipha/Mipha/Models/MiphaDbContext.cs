using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace Mipha.Models
{
    public class MiphaDbContext
    {
        public readonly SQLiteConnection database;
        public MiphaDbContext()
        {
            database = DependencyService.Get<ISqlite>().GetConnection();

            //database.DeleteAll<Client>();
            //database.DeleteAll<Report>();
            //database.DeleteAll<Questions>();
            //database.DeleteAll<Contact>();
            //database.DeleteAll<Host>();
            //database.DeleteAll<Species>();
            //database.DeleteAll<Condition>();
            //database.DeleteAll<ConditionQuestions>();
            //database.DeleteAll<Condition_Host>();
            //database.DeleteAll<Condition_Test>();
            //database.DeleteAll<Tutorial>();
            //database.DeleteAll<Test>();
            //database.DeleteAll<Report_Questions>();

            database.CreateTable<Client>();
            database.CreateTable<Report>();
            database.CreateTable<Questions>();
            database.CreateTable<Contact>();
            database.CreateTable<Host>();
            database.CreateTable<Species>();
            database.CreateTable<Condition>();
            database.CreateTable<ConditionQuestions>();
            database.CreateTable<Condition_Host>();
            database.CreateTable<Condition_Test>();
            database.CreateTable<Tutorial>();
            database.CreateTable<Test>();
            database.CreateTable<Report_Questions>();
              //  database.CreateTable<Client, Report, Questions, Contact, Host, Species, Condition, ConditionQuestions, Condition_Host, Condition_Test, Tutorial, Test, Report_Questions>()
        }
    }
}
