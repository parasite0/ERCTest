using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERCTest.UI.Models;
using ERCTest.UI.Views;

namespace ERCTest.UI.Presenters
{
    public class ServicePresenter
    {
        IService serviceView;

        public ServicePresenter(IService view)
        {
            serviceView = view;
        }

        public void CalculateIndications()
        {
            DBConnect db = new DBConnect();
            Service service = new Service();
            ColdWSServise coldWSServise = new ColdWSServise();
            HotWSService hotWSService = new HotWSService();
            Electricity electricity = new Electricity();

            service.Residents = coldWSServise.Residents = hotWSService.Residents = electricity.Residents = serviceView.Residents;
            coldWSServise.IndCurr = serviceView.ColdWS;
            hotWSService.IndCurr = serviceView.HotWS;
            electricity.ElecDay = serviceView.ElectricityDay;
            electricity.ElecNight = serviceView.ElectricityNight;
            coldWSServise.DeviceAvailable = serviceView.DeviceCWSAvailable;
            hotWSService.DeviceAvailable = serviceView.DeviceHWSAvailable;
            electricity.DeviceAvailable = serviceView.DeviceElectAvailable;
            coldWSServise.IndPrev = db.GetData(3);
            hotWSService.IndPrev = db.GetData(2);
            electricity.ElecDayPrev = db.GetData(1);
            electricity.ElecNightPrev = db.GetData(0);

            
            serviceView.ColdWSResult = !coldWSServise.DeviceAvailable ? coldWSServise.CalculateIndicationsNorm() : coldWSServise.CalculateIndicationsDevice();
            serviceView.HWSTNResult = !hotWSService.DeviceAvailable ? hotWSService.CalculateTNNorm() : hotWSService.CalculateTNDevice();
            serviceView.HWSTEResult = !hotWSService.DeviceAvailable ? hotWSService.CalculateTENorm() : hotWSService.CalculateTEDevice();
            serviceView.HotWSResult = !hotWSService.DeviceAvailable ? hotWSService.CalculateIndicationsNorm() : hotWSService.CalculateIndicationsDevice();
            serviceView.ElectricityResult = !electricity.DeviceAvailable ? electricity.CalculateIndicationsNorm() : electricity.CalculateIndicationsDevice();
            serviceView.Result = serviceView.ColdWSResult + serviceView.HotWSResult + serviceView.ElectricityResult;

            if ((coldWSServise.DeviceAvailable || hotWSService.DeviceAvailable || electricity.DeviceAvailable) && coldWSServise.IndCurr >= coldWSServise.IndPrev 
                && hotWSService.IndCurr >= hotWSService.IndPrev && electricity.ElecDay >= electricity.ElecDayPrev && electricity.ElecNight >= electricity.ElecNightPrev)
                db.AddData(coldWSServise.IndCurr, hotWSService.IndCurr, electricity.ElecDay, electricity.ElecNight);
        }
    }
}
