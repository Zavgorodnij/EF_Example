using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Example.Model.Test_DB;

namespace EF_Example.Core.Model
{
    class MSSQLContext : DbContext
    {
        //Так добавляются новые таблицы в БД
        public DbSet<Test_DB_Object> test_DB_Objects { get; set; }

        public MSSQLContext()
        {
            //Строка удаляющая бд, применять при изменение модели(Классы бд) после удаления, закомментировать
            //Database.EnsureDeleted();

            //Строка запускающая первичное создание бд при условии что бд нет
            Database.EnsureCreated();
        }
        //Строка конфигурации указывающая локальную БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Test_DB;Trusted_Connection=True;");
        }
    }
}
