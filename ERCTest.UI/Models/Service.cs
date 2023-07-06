using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCTest.UI.Models
{
    /// <summary>
    /// ЖКХ услуга
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Текущие показания
        /// </summary>
        public double IndCurr { get; set; }
        /// <summary>
        /// Предыдущие показания
        /// </summary>
        public double IndPrev { get; set; }
        /// <summary>
        /// Норматив потребления услуги на одного человека
        /// </summary>
        protected double Norm { get; set; }
        /// <summary>
        /// Количество проживающих в помещении
        /// </summary>
        public int Residents { get; set; }
        /// <summary>
        /// Тариф
        /// </summary>
        protected double Tariff { get; set; }
        /// <summary>
        /// Наличие прибора учёта по услуге
        /// </summary>
        public bool DeviceAvailable { get; set; }

        /// <summary>
        /// Общий алгоритм
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateIndicationsNorm()
        {
            return (Residents * Norm) * Tariff;
        }

        /// <summary>
        /// Алгоритм расчета по показаниям приборов учета
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateIndicationsDevice()
        {
            return (IndCurr - IndPrev) * Tariff;
        }
    }
}
