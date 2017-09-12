using Mipha.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mipha.Services
{
    public class SelectionMockDataStore: SelectionViewModel
    {
       // static object locker = new object();
        //readonly SQLiteConnection database;
        public SelectionMockDataStore()
        {
            database.DeleteAll<Host>();
            database.DeleteAll<Condition>();
            database.Insert(new Host
            {
                Host_ID="XXZ1",
                Host_Name="Horse",
                Species= "Aminal"
            });
            database.Insert(new Host
            {
                Host_ID = "XXZ2",
                Host_Name = "Person",
                Species = "Human"
            });
            database.Insert(new Host
            {
                Host_ID = "XXZ3",
                Host_Name = "Dog",
                Species = "Aminal"
            });
            database.Insert(new Host
            {
                Host_ID = "XXZ4",
                Host_Name = "Wheat",
                Species = "Plant"
            });
            database.Insert(new Host
            {
                Host_ID = "XXZ5",
                Host_Name = "Maize",
                Species = "Plant"
            });
           
            database.Insert(new Host
            {
                Host_ID = "XXZ7",
                Host_Name = "Hemp",
                Species = "Plant"
            });
            database.Insert(new Host
            {
                Host_ID = "XXZ8",
                Host_Name = "Sugar Cane",
                Species = "Plant"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA1",
                Condition_Name = "Malaria",
              
                Host = "Person"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA2",
                Condition_Name = "Rabies",
              
                Host = "Person"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA3",
                Condition_Name = "Fall Army Worm",
               
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA4",
                Condition_Name = "African Stalk Borer",
               
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA5",
                Condition_Name = "Cutworm",
               
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "A15",
                Condition_Name = "Cutworm",

                Host = "Human"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA6",
                Condition_Name = "Bolloworm",
              
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA7",
                Condition_Name = "African Army Worm",
                //CrossPlant = true,
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA8",
                Condition_Name = "Not Sure Which one",
               // CrossPlant = true,
                Host = "Hemp"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA9",
                Condition_Name = "Not Sure Which one",
                //CrossPlant = true,
                Host = "Maize"
            });
            database.Insert(new Condition
            {
                Condition_ID = "AA10",
                Condition_Name = "Not Sure Which one",
             
                Host = "Maize"
                
            });
        }
    }
}
