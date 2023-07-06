using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCTest.UI.Views
{
    public interface IService
    {
        /// <summary>
        /// Количество проживающих в помещении
        /// </summary>
        int Residents { get; set; }
        /// <summary>
        /// Текущие показания ХВС
        /// </summary>
        double ColdWS { get; set; }
        /// <summary>
        /// Текущие показания ГВС
        /// </summary>
        double HotWS { get; set; }
        /// <summary>
        /// Текущие показания дневной ЭЭ
        /// </summary>
        double ElectricityDay { get; set; }
        /// <summary>
        /// Текущие показания ночной ЭЭ
        /// </summary>
        double ElectricityNight { get; set; }
        /// <summary>
        /// Итоговая сумма к оплате
        /// </summary>
        double Result { get; set; }
        /// <summary>
        /// Сумма к оплате за ХВС
        /// </summary>
        double ColdWSResult { get; set; }
        /// <summary>
        /// Сумма к оплате за ГВС
        /// </summary>
        double HotWSResult { get; set; }
        /// <summary>
        /// Сумма к оплате за ГВС Теплоноситель
        /// </summary>
        double HWSTNResult { get; set; }
        /// <summary>
        /// Сумма к оплате за ГВС Тепловая энергия
        /// </summary>
        double HWSTEResult { get; set; }
        /// <summary>
        /// Сумма к оплате за ЭЭ
        /// </summary>
        double ElectricityResult { get; set; }
        /// <summary>
        /// Наличие прибора учёта по услуге ХВС
        /// </summary>
        bool DeviceCWSAvailable { get; set; }
        /// <summary>
        /// Наличие прибора учёта по услуге ГВС
        /// </summary>
        bool DeviceHWSAvailable { get; set; }
        /// <summary>
        /// Наличие прибора учёта по услуге ЭЭ
        /// </summary>
        bool DeviceElectAvailable { get; set; }
    }
}
