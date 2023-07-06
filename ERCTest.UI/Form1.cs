using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERCTest.UI.Views;
using ERCTest.UI.Presenters;

namespace ERCTest.UI
{
    public partial class Form1 : Form, IService
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Residents
        {
            get
            {
                return (int)countResidents.Value;
            }
            set
            {
                countResidents.Value = value;
            }
        }
        public double ColdWS
        {
            get
            {
                return (double)indCWS.Value;
            }
            set
            {
                indCWS.Value = (decimal)value;
            }
        }
        public double HotWS
        {
            get
            {
                return (double)indHWS.Value;
            }
            set
            {
                indHWS.Value = (decimal)value;
            }
        }
        public double ElectricityDay
        {
            get
            {
                return (double)indElecDay.Value;
            }
            set
            {
                indElecDay.Value = (decimal)value;
            }
        }
        public double ElectricityNight
        {
            get
            {
                return (double)indElecNight.Value;
            }
            set
            {
                indElecNight.Value = (decimal)value;
            }
        }
        public double Result
        {
            get
            {
                return Convert.ToDouble(lblResult.Text);
            }
            set
            {
                lblResult.Text = Math.Round(value, 2).ToString();
            }
        }
        public bool DeviceCWSAvailable
        {
            get
            {
                return deviceAvailCWS.Checked;
            }
            set
            {
                deviceAvailCWS.Checked = value;
            }
        }
        public bool DeviceHWSAvailable
        {
            get
            {
                return deviceAvailHWS.Checked;
            }
            set
            {
                deviceAvailHWS.Checked = value;
            }
        }
        public bool DeviceElectAvailable
        {
            get
            {
                return deviceAvailElect.Checked;
            }
            set
            {
                deviceAvailElect.Checked = value;
            }
        }
        public double ColdWSResult
        {
            get
            {
                return Convert.ToDouble(lblCWSResult.Text);
            }
            set
            {
                lblCWSResult.Text = Math.Round(value, 2).ToString();
            }
        }
        public double HotWSResult
        {
            get
            {
                return Convert.ToDouble(lblHWSResult.Text);
            }
            set
            {
                lblHWSResult.Text = Math.Round(value, 2).ToString();
            }
        }
        public double HWSTNResult
        {
            get
            {
                return Convert.ToDouble(lblHWSTNResult.Text);
            }
            set
            {
                lblHWSTNResult.Text = Math.Round(value, 2).ToString();
            }
        }
        public double HWSTEResult
        {
            get
            {
                return Convert.ToDouble(lblHWSTEResult.Text);
            }
            set
            {
                lblHWSTEResult.Text = Math.Round(value, 2).ToString();
            }
        }
        public double ElectricityResult
        {
            get
            {
                return Convert.ToDouble(lblElectResult.Text);
            }
            set
            {
                lblElectResult.Text = Math.Round(value, 2).ToString();
            }
        }

        private void claculateInd_Click(object sender, EventArgs e)
        {
            ServicePresenter presenter = new ServicePresenter(this);
            presenter.CalculateIndications();

            if (Convert.ToDouble(lblCWSResult.Text) < 0 || Convert.ToDouble(lblHWSResult.Text) < 0 || Convert.ToDouble(lblElectResult.Text) < 0 || Convert.ToDouble(lblResult.Text) < 0)
            {
                lblCWSResult.Text = lblHWSResult.Text = lblElectResult.Text = lblResult.Text = lblHWSTNResult.Text = lblHWSTEResult.Text = "";
                alertMessage();
            }
        }

        private void deviceAvailCWS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chekBox = (CheckBox)sender;
            if (chekBox.Checked)
                indCWS.Enabled = true;
            else
            {
                indCWS.Enabled = false;
                indCWS.Value = 0;
            }
        }
        private void deviceAvailHWS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chekBox = (CheckBox)sender;
            if (chekBox.Checked)
                indHWS.Enabled = true;
            else
            {
                indHWS.Enabled = false;
                indHWS.Value = 0;
            }
        }

        private void deviceAvailElect_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chekBox = (CheckBox)sender;
            if (chekBox.Checked)
            {
                indElecDay.Enabled = true;
                indElecNight.Enabled = true;
            }
            else
            {
                indElecDay.Enabled = false;
                indElecNight.Enabled = false;
                indElecDay.Value = 0;
                indElecNight.Value = 0;
            }
        }

        /// <summary>
        /// Сообщение об ошибке, когда введённые значения за текущий месяц меньше, чем за предыдущий
        /// </summary>
        private void alertMessage()
        {
            Alert alert = (Alert)Application.OpenForms["Alert"];
            if (alert == null)
            {
                alert = new Alert();
                alert.Show();
            }
            else
            {
                alert.WindowState = FormWindowState.Normal;
                alert.Activate();
            }
        }

        
    }
}
