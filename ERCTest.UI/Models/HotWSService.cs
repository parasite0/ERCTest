using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCTest.UI.Models
{
    /// <summary>
    /// Горячее водоснабжение
    /// </summary>
    public class HotWSService : Service
    {
        /// <summary>
        /// Тариф тепловой энергии
        /// </summary>
        protected double TETariff { get; set; } = 998.69;
        /// <summary>
        /// Тариф теплоносителя
        /// </summary>
        protected double TNTariff { get; set; } = 35.78;
        /// <summary>
        /// Норматив тепловой энергии
        /// </summary>
        protected double TENorm { get; set; } = 0.05349;
        /// <summary>
        /// Норматив теплоносителя
        /// </summary>
        protected double TNNorm { get; set; } = 4.01;

        /// <summary>
        /// Общий алгоритм расчета ГВС Теплоноситель
        /// </summary>
        /// <returns></returns>
        public double CalculateTNNorm()
        {
            return (Residents * TNNorm) * TNTariff;
        }
        
        /// <summary>
        /// Общий алгоритм расчета ГВС Тепловая энергия
        /// </summary>
        /// <returns></returns>
        public double CalculateTENorm()
        {
            return (Residents * TNNorm) * TENorm * TETariff;
        }

        /// <summary>
        /// Алгоритм расчета по показаниям приборов учета ГВС Теплоноситель
        /// </summary>
        /// <returns></returns>
        public double CalculateTNDevice()
        {
            return ((IndCurr - IndPrev) * TNNorm) * TNTariff;
        }

        /// <summary>
        /// Алгоритм расчета по показаниям приборов учета ГВС Тепловая энергия
        /// </summary>
        /// <returns></returns>
        public double CalculateTEDevice()
        {
            return ((IndCurr - IndPrev) * TNNorm) * TENorm * TETariff;
        }

        /// <summary>
        /// Общий алгоритм
        /// </summary>
        /// <returns></returns>
        public override double CalculateIndicationsNorm()
        {
            return CalculateTNNorm() + CalculateTENorm();
        }

        /// <summary>
        /// Алгоритм расчета по показаниям приборов учета
        /// </summary>
        /// <returns></returns>
        public override double CalculateIndicationsDevice()
        {
            return CalculateTNDevice() + CalculateTEDevice();
        }
    }
}
