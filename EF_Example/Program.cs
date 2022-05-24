// See https://aka.ms/new-console-template for more information
using EF_Example.Core.Model;
using EF_Example.Model.Test_DB;

MSSQLContext mSSQLContext = new MSSQLContext();
Console.WriteLine("Пример реализации работы с EFCore");

//Создали объект описанный в классе Test_DB_Object
Test_DB_Object test_DB_Object = new Test_DB_Object()
{
    Last_Message = "test",
    TG_ID = 1,
    User_Name_TG="test",
};
//Добавили объект в таблицу базы данных соответсвующей объекту
mSSQLContext.test_DB_Objects.Add(test_DB_Object);
//Сохранить/Завершить транзакциб
mSSQLContext.SaveChanges();

//Выгрузить первую попавшуюся запись с TG_ID=1
var Return_Views = mSSQLContext.test_DB_Objects.FirstOrDefault(p=>p.TG_ID==1);

//Вывести на экран данные полученные из бд с ID=3
Console.WriteLine($"Добавление и вывод\nID={Return_Views.id}\nTG_ID={Return_Views.TG_ID}\nLast_Message={Return_Views.Last_Message}\nUser_Name_TG={Return_Views.User_Name_TG}");


//Редактирование
//Выгрузить первую попавшуюся запись с TG_ID=1
var Return_Views_Edit = mSSQLContext.test_DB_Objects.FirstOrDefault(p => p.TG_ID == 1);
//Редактирование
Return_Views_Edit.Last_Message = "Меняем";
Return_Views_Edit.TG_ID = 333;
//Обновляем
mSSQLContext.test_DB_Objects.Update(Return_Views_Edit);
//Сохраняем
mSSQLContext.SaveChanges();
//Проверяем
var Return_Views_Edit_Testing = mSSQLContext.test_DB_Objects.FirstOrDefault(p => p.TG_ID == 333);
//Выводим
Console.WriteLine($"Добавление и вывод\nID={Return_Views_Edit_Testing.id}\nTG_ID={Return_Views_Edit_Testing.TG_ID}\nLast_Message={Return_Views_Edit_Testing.Last_Message}\nUser_Name_TG={Return_Views_Edit_Testing.User_Name_TG}");