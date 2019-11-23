using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI
{
    public static class DateExtensions
    {
        public static int CalcularIdade(this DateTime atual, DateTime nasc)
        {
            nasc = nasc.AddYears(1);

            int idade = 0;
            while (nasc <= atual)
            {
                idade++;
                nasc = nasc.AddYears(1);
            }
            return idade;
        }


    }
}
