using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Example.Model.Test_DB
{
    //Описываем таблицу
    class Test_DB_Object
    {
        public int id { get; set; }
        public int TG_ID { get; set; }
        public string User_Name_TG { get; set; }
        public string Last_Message { get; set; }
    }
}
