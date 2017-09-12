//using Mipha.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Mipha.Services
//{
//    public class ServiceData
//    {
//        List<Species> lstSpecies = new List<Species>()
//        {
//            new Species{id=1, name="Aminal"},
//            new Species{id=2, name="Human"},
//            new Species {id=3, name ="Plant" }
//        };
//        List<Host> lstHost = new List<Host>()
//        {
//            new Host{id=1, name="Horse", type="Aminal"},
//            new Host{id=2, name="Person",type="Human"},
//            new Host{id=4, name="Dog", type="Aminal"},
//             new Host{id=5, name="Elephant", type="Aminal"},
//            new Host {id=3, name ="Maize",type="Plant" },
//            new Host {id=6, name ="Wheat",type="Plant" },
//            new Host {id=6, name ="Hemp",type="Plant" },
//            new Host {id=6, name ="Sugar Cane",type="Plant" }
//        };
//        List<Condition> lstCondi = new List<Condition>()
//        {
//            new Condition {id=1, name="Pregnancy", species="Human"},
//            new Condition {id=2, name="Fall Army Worm", species="Plant"},
//            new Condition {id=3, name="African Stalk Borer", species="Plant"},
//             new Condition {id=4, name="Cutworm", species="Plant"},
//              new Condition {id=5, name="Bollworm", species="Plant"},
//               new Condition {id=6, name="African Army Worm", species="Plant"},
//                new Condition {id=7, name="African Horse sickness", species="Aminal"},
//                new Condition {id=8, name="Pregnancy", species="Aminal"},
//                new Condition {id=9, name="Malaria", species="Human"},
//                 new Condition {id=10, name="HIV", species="Human"},
//                  new Condition {id=11, name="Avian Influenza", species="Human"},
//                   new Condition {id=12, name="Rables", species="Human"}
//        };
//        public List<Host> FindHost(string host)
//        {
//            List<Host> hst = new List<Host>();
//            foreach (var x in lstHost)
//            {
//                if (x.type.ToLower().Equals(host.ToLower()))
//                {
//                    hst.Add(x);
//                }
//            }
//            return hst;
//        }
//        public List<Condition> GetCond()
//        {
//            return lstCondi;
//        }
//    }
//}
