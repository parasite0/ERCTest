using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCTest.UI.Models
{
    /// <summary>
    /// Электроэнергия
    /// </summary>
    public class Electricity : Service
    {
        /// <summary>
        /// Текущие показания дневной электроэнергии
        /// </summary>
        public double ElecDay { get; set; }
        /// <summary>
        /// Текущие показания ночной электроэнергии
        /// </summary>
        public double ElecNight { get; set; }
        /// <summary>
        /// Предыдущие показания дневной электроэнергии
        /// </summary>
        public double ElecDayPrev { get; set; }
        /// <summary>
        /// Предыдущие показания ночной электроэнергии
        /// </summary>
        public double ElecNightPrev { get; set; }
        /// <summary>
        /// Дневной тариф ЭЭ
        /// </summary>
        public double ElectTariffDay { get; set; } = 4.9;
        /// <summary>
        /// Ночной тариф ЭЭ
        /// </summary>
        public double ElectTariffNight { get; set; } = 2.31;
        
        public Electricity()
        {
            Norm = 164;
            Tariff = 4.28;
        }

        /// <summary>
        /// Алгоритм расчета по показаниям приборов учета
        /// </summary>
        /// <returns></returns>
        public override double CalculateIndicationsDevice()
        {
            return (ElecDay - ElecDayPrev) * ElectTariffDay + (ElecNight - ElecNightPrev) * ElectTariffNight;
        }
    }
}
