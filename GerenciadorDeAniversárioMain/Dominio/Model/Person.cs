using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Person
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string BdayDate { get; set; }
        public int PersonId { get; set; }

        public string TimeToBday ()
        {
            DateTime todayDay = DateTime.Today;
            DateTime bdayDay = Convert.ToDateTime(BdayDate);

            DateTime nextBday = bdayDay.AddYears(todayDay.Year - bdayDay.Year);

            if (nextBday < todayDay)
                nextBday = nextBday.AddYears(1);

            int daysTillBday = (nextBday - todayDay).Days;
            return Convert.ToString(daysTillBday);

        }
    }
}
