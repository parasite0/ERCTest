using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCTest.UI.Models
{
    /// <summary>
    /// Холодное водоснабжение
    /// </summary>
    public class ColdWSServise : Service
    {
        public ColdWSServise()
        {
            Tariff = 35.78;
            Norm = 4.85;
        }
    }
}
