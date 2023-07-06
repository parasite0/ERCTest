
namespace ERCTest.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResidents = new System.Windows.Forms.Label();
            this.countResidents = new System.Windows.Forms.NumericUpDown();
            this.lblCWS = new System.Windows.Forms.Label();
            this.indCWS = new System.Windows.Forms.NumericUpDown();
            this.lblHWS = new System.Windows.Forms.Label();
            this.indHWS = new System.Windows.Forms.NumericUpDown();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.indElecDay = new System.Windows.Forms.NumericUpDown();
            this.claculateInd = new System.Windows.Forms.Button();
            this.deviceAvailCWS = new System.Windows.Forms.CheckBox();
            this.indElecNight = new System.Windows.Forms.NumericUpDown();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblCWSPay = new System.Windows.Forms.Label();
            this.lblHWSPay = new System.Windows.Forms.Label();
            this.lblElectPay = new System.Windows.Forms.Label();
            this.lblCWSResult = new System.Windows.Forms.Label();
            this.lblHWSResult = new System.Windows.Forms.Label();
            this.lblElectResult = new System.Windows.Forms.Label();
            this.lblResultPay = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.deviceAvailHWS = new System.Windows.Forms.CheckBox();
            this.deviceAvailElect = new System.Windows.Forms.CheckBox();
            this.lblDeviceAvail = new System.Windows.Forms.Label();
            this.lblHWSTNPay = new System.Windows.Forms.Label();
            this.lblHWSTEPay = new System.Windows.Forms.Label();
            this.lblHWSTNResult = new System.Windows.Forms.Label();
            this.lblHWSTEResult = new System.Windows.Forms.Label();
            this.lblHWSSumPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indCWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indHWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indElecDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indElecNight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResidents
            // 
            this.lblResidents.AutoSize = true;
            this.lblResidents.Location = new System.Drawing.Point(12, 20);
            this.lblResidents.Name = "lblResidents";
            this.lblResidents.Size = new System.Drawing.Size(141, 26);
            this.lblResidents.TabIndex = 2;
            this.lblResidents.Text = "Количество проживающих\r\nв помещении:";
            // 
            // countResidents
            // 
            this.countResidents.Location = new System.Drawing.Point(166, 20);
            this.countResidents.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countResidents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countResidents.Name = "countResidents";
            this.countResidents.Size = new System.Drawing.Size(120, 20);
            this.countResidents.TabIndex = 3;
            this.countResidents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCWS
            // 
            this.lblCWS.AutoSize = true;
            this.lblCWS.Location = new System.Drawing.Point(12, 101);
            this.lblCWS.Name = "lblCWS";
            this.lblCWS.Size = new System.Drawing.Size(105, 13);
            this.lblCWS.TabIndex = 4;
            this.lblCWS.Text = "Показания по ХВС:";
            // 
            // indCWS
            // 
            this.indCWS.DecimalPlaces = 2;
            this.indCWS.Enabled = false;
            this.indCWS.Location = new System.Drawing.Point(166, 101);
            this.indCWS.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.indCWS.Name = "indCWS";
            this.indCWS.Size = new System.Drawing.Size(120, 20);
            this.indCWS.TabIndex = 5;
            this.indCWS.ThousandsSeparator = true;
            // 
            // lblHWS
            // 
            this.lblHWS.AutoSize = true;
            this.lblHWS.Location = new System.Drawing.Point(12, 143);
            this.lblHWS.Name = "lblHWS";
            this.lblHWS.Size = new System.Drawing.Size(104, 13);
            this.lblHWS.TabIndex = 6;
            this.lblHWS.Text = "Показания по ГВС:";
            // 
            // indHWS
            // 
            this.indHWS.DecimalPlaces = 2;
            this.indHWS.Enabled = false;
            this.indHWS.Location = new System.Drawing.Point(166, 143);
            this.indHWS.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.indHWS.Name = "indHWS";
            this.indHWS.Size = new System.Drawing.Size(120, 20);
            this.indHWS.TabIndex = 7;
            this.indHWS.ThousandsSeparator = true;
            // 
            // lblElectricity
            // 
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.Location = new System.Drawing.Point(14, 196);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(98, 13);
            this.lblElectricity.TabIndex = 8;
            this.lblElectricity.Text = "Показания по ЭЭ:";
            // 
            // indElecDay
            // 
            this.indElecDay.DecimalPlaces = 2;
            this.indElecDay.Enabled = false;
            this.indElecDay.Location = new System.Drawing.Point(165, 196);
            this.indElecDay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.indElecDay.Name = "indElecDay";
            this.indElecDay.Size = new System.Drawing.Size(54, 20);
            this.indElecDay.TabIndex = 9;
            this.indElecDay.ThousandsSeparator = true;
            // 
            // claculateInd
            // 
            this.claculateInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.claculateInd.Location = new System.Drawing.Point(165, 243);
            this.claculateInd.Name = "claculateInd";
            this.claculateInd.Size = new System.Drawing.Size(121, 49);
            this.claculateInd.TabIndex = 10;
            this.claculateInd.Text = "Рассчитать";
            this.claculateInd.UseVisualStyleBackColor = true;
            this.claculateInd.Click += new System.EventHandler(this.claculateInd_Click);
            // 
            // deviceAvailCWS
            // 
            this.deviceAvailCWS.AutoSize = true;
            this.deviceAvailCWS.Location = new System.Drawing.Point(327, 103);
            this.deviceAvailCWS.Name = "deviceAvailCWS";
            this.deviceAvailCWS.Size = new System.Drawing.Size(15, 14);
            this.deviceAvailCWS.TabIndex = 13;
            this.deviceAvailCWS.UseVisualStyleBackColor = true;
            this.deviceAvailCWS.CheckedChanged += new System.EventHandler(this.deviceAvailCWS_CheckedChanged);
            // 
            // indElecNight
            // 
            this.indElecNight.DecimalPlaces = 2;
            this.indElecNight.Enabled = false;
            this.indElecNight.Location = new System.Drawing.Point(231, 196);
            this.indElecNight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.indElecNight.Name = "indElecNight";
            this.indElecNight.Size = new System.Drawing.Size(54, 20);
            this.indElecNight.TabIndex = 15;
            this.indElecNight.ThousandsSeparator = true;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(162, 177);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 13);
            this.lblDay.TabIndex = 17;
            this.lblDay.Text = "День:";
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Location = new System.Drawing.Point(228, 177);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(35, 13);
            this.lblNight.TabIndex = 18;
            this.lblNight.Text = "Ночь:";
            // 
            // lblCWSPay
            // 
            this.lblCWSPay.AutoSize = true;
            this.lblCWSPay.Location = new System.Drawing.Point(413, 101);
            this.lblCWSPay.Name = "lblCWSPay";
            this.lblCWSPay.Size = new System.Drawing.Size(86, 13);
            this.lblCWSPay.TabIndex = 22;
            this.lblCWSPay.Text = "Оплата за ХВС:";
            // 
            // lblHWSPay
            // 
            this.lblHWSPay.AutoSize = true;
            this.lblHWSPay.Location = new System.Drawing.Point(413, 143);
            this.lblHWSPay.Name = "lblHWSPay";
            this.lblHWSPay.Size = new System.Drawing.Size(85, 13);
            this.lblHWSPay.TabIndex = 23;
            this.lblHWSPay.Text = "Оплата за ГВС:";
            // 
            // lblElectPay
            // 
            this.lblElectPay.AutoSize = true;
            this.lblElectPay.Location = new System.Drawing.Point(413, 227);
            this.lblElectPay.Name = "lblElectPay";
            this.lblElectPay.Size = new System.Drawing.Size(79, 13);
            this.lblElectPay.TabIndex = 24;
            this.lblElectPay.Text = "Оплата за ЭЭ:";
            // 
            // lblCWSResult
            // 
            this.lblCWSResult.AutoSize = true;
            this.lblCWSResult.Location = new System.Drawing.Point(517, 101);
            this.lblCWSResult.Name = "lblCWSResult";
            this.lblCWSResult.Size = new System.Drawing.Size(0, 13);
            this.lblCWSResult.TabIndex = 25;
            // 
            // lblHWSResult
            // 
            this.lblHWSResult.AutoSize = true;
            this.lblHWSResult.Location = new System.Drawing.Point(567, 196);
            this.lblHWSResult.Name = "lblHWSResult";
            this.lblHWSResult.Size = new System.Drawing.Size(0, 13);
            this.lblHWSResult.TabIndex = 26;
            // 
            // lblElectResult
            // 
            this.lblElectResult.AutoSize = true;
            this.lblElectResult.Location = new System.Drawing.Point(517, 227);
            this.lblElectResult.Name = "lblElectResult";
            this.lblElectResult.Size = new System.Drawing.Size(0, 13);
            this.lblElectResult.TabIndex = 27;
            // 
            // lblResultPay
            // 
            this.lblResultPay.AutoSize = true;
            this.lblResultPay.Location = new System.Drawing.Point(413, 277);
            this.lblResultPay.Name = "lblResultPay";
            this.lblResultPay.Size = new System.Drawing.Size(87, 13);
            this.lblResultPay.TabIndex = 28;
            this.lblResultPay.Text = "Итого к оплате:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(517, 277);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 29;
            // 
            // deviceAvailHWS
            // 
            this.deviceAvailHWS.AutoSize = true;
            this.deviceAvailHWS.Location = new System.Drawing.Point(327, 145);
            this.deviceAvailHWS.Name = "deviceAvailHWS";
            this.deviceAvailHWS.Size = new System.Drawing.Size(15, 14);
            this.deviceAvailHWS.TabIndex = 30;
            this.deviceAvailHWS.UseVisualStyleBackColor = true;
            this.deviceAvailHWS.CheckedChanged += new System.EventHandler(this.deviceAvailHWS_CheckedChanged);
            // 
            // deviceAvailElect
            // 
            this.deviceAvailElect.AutoSize = true;
            this.deviceAvailElect.Location = new System.Drawing.Point(327, 196);
            this.deviceAvailElect.Name = "deviceAvailElect";
            this.deviceAvailElect.Size = new System.Drawing.Size(15, 14);
            this.deviceAvailElect.TabIndex = 31;
            this.deviceAvailElect.UseVisualStyleBackColor = true;
            this.deviceAvailElect.CheckedChanged += new System.EventHandler(this.deviceAvailElect_CheckedChanged);
            // 
            // lblDeviceAvail
            // 
            this.lblDeviceAvail.AutoSize = true;
            this.lblDeviceAvail.Location = new System.Drawing.Point(288, 62);
            this.lblDeviceAvail.Name = "lblDeviceAvail";
            this.lblDeviceAvail.Size = new System.Drawing.Size(95, 26);
            this.lblDeviceAvail.TabIndex = 32;
            this.lblDeviceAvail.Text = "Наличие прибора\r\nучёта:";
            this.lblDeviceAvail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHWSTNPay
            // 
            this.lblHWSTNPay.AutoSize = true;
            this.lblHWSTNPay.Location = new System.Drawing.Point(517, 142);
            this.lblHWSTNPay.Name = "lblHWSTNPay";
            this.lblHWSTNPay.Size = new System.Drawing.Size(48, 13);
            this.lblHWSTNPay.TabIndex = 33;
            this.lblHWSTNPay.Text = "ГВС ТН:";
            // 
            // lblHWSTEPay
            // 
            this.lblHWSTEPay.AutoSize = true;
            this.lblHWSTEPay.Location = new System.Drawing.Point(599, 142);
            this.lblHWSTEPay.Name = "lblHWSTEPay";
            this.lblHWSTEPay.Size = new System.Drawing.Size(47, 13);
            this.lblHWSTEPay.TabIndex = 34;
            this.lblHWSTEPay.Text = "ГВС ТЭ:";
            // 
            // lblHWSTNResult
            // 
            this.lblHWSTNResult.AutoSize = true;
            this.lblHWSTNResult.Location = new System.Drawing.Point(517, 164);
            this.lblHWSTNResult.Name = "lblHWSTNResult";
            this.lblHWSTNResult.Size = new System.Drawing.Size(0, 13);
            this.lblHWSTNResult.TabIndex = 35;
            // 
            // lblHWSTEResult
            // 
            this.lblHWSTEResult.AutoSize = true;
            this.lblHWSTEResult.Location = new System.Drawing.Point(599, 164);
            this.lblHWSTEResult.Name = "lblHWSTEResult";
            this.lblHWSTEResult.Size = new System.Drawing.Size(0, 13);
            this.lblHWSTEResult.TabIndex = 36;
            // 
            // lblHWSSumPay
            // 
            this.lblHWSSumPay.AutoSize = true;
            this.lblHWSSumPay.Location = new System.Drawing.Point(517, 196);
            this.lblHWSSumPay.Name = "lblHWSSumPay";
            this.lblHWSSumPay.Size = new System.Drawing.Size(44, 13);
            this.lblHWSSumPay.TabIndex = 37;
            this.lblHWSSumPay.Text = "Сумма:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 324);
            this.Controls.Add(this.lblHWSSumPay);
            this.Controls.Add(this.lblHWSTEResult);
            this.Controls.Add(this.lblHWSTNResult);
            this.Controls.Add(this.lblHWSTEPay);
            this.Controls.Add(this.lblHWSTNPay);
            this.Controls.Add(this.lblDeviceAvail);
            this.Controls.Add(this.deviceAvailElect);
            this.Controls.Add(this.deviceAvailHWS);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultPay);
            this.Controls.Add(this.lblElectResult);
            this.Controls.Add(this.lblHWSResult);
            this.Controls.Add(this.lblCWSResult);
            this.Controls.Add(this.lblElectPay);
            this.Controls.Add(this.lblHWSPay);
            this.Controls.Add(this.lblCWSPay);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.indElecNight);
            this.Controls.Add(this.deviceAvailCWS);
            this.Controls.Add(this.claculateInd);
            this.Controls.Add(this.indElecDay);
            this.Controls.Add(this.lblElectricity);
            this.Controls.Add(this.indHWS);
            this.Controls.Add(this.lblHWS);
            this.Controls.Add(this.indCWS);
            this.Controls.Add(this.lblCWS);
            this.Controls.Add(this.countResidents);
            this.Controls.Add(this.lblResidents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Расчёт платы за коммунальные услуги";
            ((System.ComponentModel.ISupportInitialize)(this.countResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indCWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indHWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indElecDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indElecNight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResidents;
        private System.Windows.Forms.NumericUpDown countResidents;
        private System.Windows.Forms.Label lblCWS;
        private System.Windows.Forms.NumericUpDown indCWS;
        private System.Windows.Forms.Label lblHWS;
        private System.Windows.Forms.NumericUpDown indHWS;
        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.NumericUpDown indElecDay;
        private System.Windows.Forms.Button claculateInd;
        private System.Windows.Forms.CheckBox deviceAvailCWS;
        private System.Windows.Forms.NumericUpDown indElecNight;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblCWSPay;
        private System.Windows.Forms.Label lblHWSPay;
        private System.Windows.Forms.Label lblElectPay;
        private System.Windows.Forms.Label lblCWSResult;
        private System.Windows.Forms.Label lblHWSResult;
        private System.Windows.Forms.Label lblElectResult;
        private System.Windows.Forms.Label lblResultPay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox deviceAvailHWS;
        private System.Windows.Forms.CheckBox deviceAvailElect;
        private System.Windows.Forms.Label lblDeviceAvail;
        private System.Windows.Forms.Label lblHWSTNPay;
        private System.Windows.Forms.Label lblHWSTEPay;
        private System.Windows.Forms.Label lblHWSTNResult;
        private System.Windows.Forms.Label lblHWSTEResult;
        private System.Windows.Forms.Label lblHWSSumPay;
    }
}

