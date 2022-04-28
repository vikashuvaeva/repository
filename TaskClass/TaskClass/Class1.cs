using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClass
{
    public class Task // Задача - занятие с клиенткой
    {
        public string name //имя клиентки
        public DateTime date //дата и время занятия
        public DateTime duration //продолжительность занятия
        public int cost //стоимость занятия
        public string note //заметка

    public Task(string customerName, DateTime customerDate, DateTime customerDuration, int customerCost, string customerNote)
        {
            name = customerName;
            date = customerDate;
            cost = customerCost;
            duration = customerDuration;
            note = customerNote;
        }
    }
}
