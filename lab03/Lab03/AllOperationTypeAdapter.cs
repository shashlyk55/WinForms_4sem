using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class AllOperationTypeAdapter
    {
        public static string GetString(AllOperationType type)
        {
            switch (type)
            {
                case AllOperationType.AddItem:
                    return "добавление записи";
                case AllOperationType.ClearForm:
                    return "очистка формы";
                case AllOperationType.FindItem:
                    return "поиск";
                case AllOperationType.LoadItem:
                    return "загрузка записей";
                case AllOperationType.Redo:
                    return "вперед";
                case AllOperationType.RemoveItem:
                    return "удаление записи";
                case AllOperationType.Saving:
                    return "сохраненение";
                case AllOperationType.ShowAboutProgram:
                    return "вывод информации о программе";
                case AllOperationType.SortItemsByControlType:
                    return "сортировка по типу контроля";
                case AllOperationType.SortItemsByHourCounty:
                    return "сортировка по количеству часов";
                case AllOperationType.Undo:
                    return "назад";
                case AllOperationType.Launch:
                    return "программа запущена";
                case AllOperationType.Undefined:
                    return "";
                default:
                    return "";
            }
        }
    }
}
