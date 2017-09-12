using Mipha.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mipha.ViewModels
{
    public class SelectionViewModel: MiphaDbContext
    {
        
        static object locker = new object();
        public Host GetHost()
        {
            
            lock (locker)
            {
                if (database.Table<Host>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Host>().First();
                }
            }
        }
        public List<Host> GetAllHost()
        {
            lock (locker)
            {
                if (database.Table<Host>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Host>().ToList();
                }
            }
        }
        // Look for a list of Host according to the se name
        public List<Host> GetFindListHost(string Species)
        {
            lock (locker)
            {
                if (database.Table<Host>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Host>().Where(x => x.Species.ToLower().Equals(Species.ToLower())).ToList();
                }
            }
        }
        // Look for a List of Condition according to the host
        public List<Condition> GetFindListCondition(string host)
        {
            lock (locker)
            {
                if (database.Table<Condition>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Condition>().Where(x => x.Host.ToLower().Equals(host.ToLower())).ToList();
                }
            }
        }
    }
}
