using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class DataList
    {
        //static public list 
        static public List<Person> dataList = new List<Person>();

        //static constractor for this class
        static DataList()
        {
            DataList.dataList.Add(new Person {Id=1,  Name="Saleh", City= "karlskrona", Phone="0764191954" });
            DataList.dataList.Add(new Person { Id = 2, Name = "Ulf", City = "Ryd", Phone = "0764XXXXX" });
        }
    }
}