using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERCTest.UI.Models;

namespace ERCTest.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        /// <summary>
        /// Тест проверки общего алгоритма для ХВС
        /// </summary>
        [TestMethod]
        public void CalculateCWSNormAlgorithm()
        {
            // Arrange
            ColdWSServise cws = new ColdWSServise();
            cws.Residents = 3;
            double expected = 520.60;

            // Act
            double result = Math.Round(cws.CalculateIndicationsNorm(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест проверки алгоритма по показаниям приборов учета для ХВС
        /// </summary>
        [TestMethod]
        public void CalculateCWSDeviceAlgorithm()
        {
            // Arrange
            ColdWSServise cws = new ColdWSServise();
            cws.IndCurr = 10;
            cws.IndPrev = 5;
            double expected = 178.9;

            // Act
            double result = Math.Round(cws.CalculateIndicationsDevice(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест проверки общего алгоритма для ГВС
        /// </summary>
        [TestMethod]
        public void CalculateHWSNormAlgorithm()
        {
            // Arrange
            HotWSService hws = new HotWSService();
            hws.Residents = 2;
            double expected = 715.38;

            // Act
            double result = Math.Round(hws.CalculateIndicationsNorm(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест проверки алгоритма по показаниям приборов учета для ГВС
        /// </summary>
        [TestMethod]
        public void CalculateHWSDeviceAlgorithm()
        {
            // Arrange
            HotWSService hws = new HotWSService();
            hws.IndCurr = 7.7;
            hws.IndPrev = 6.0;
            double expected = 608.08;

            // Act
            double result = Math.Round(hws.CalculateIndicationsDevice(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест проверки общего алгоритма для ЭЭ
        /// </summary>
        [TestMethod]
        public void CalculateElectricityNormAlgorithm()
        {
            // Arrange
            Electricity electricity = new Electricity();
            electricity.Residents = 5;
            double expected = 3509.6;

            // Act
            double result = Math.Round(electricity.CalculateIndicationsNorm(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест проверки алгоритма по показаниям приборов учета для ЭЭ
        /// </summary>
        [TestMethod]
        public void CalculateElectricityDeviceAlgorithm()
        {
            // Arrange
            Electricity electricity = new Electricity();
            electricity.ElecDay = 15.5;
            electricity.ElecDayPrev = 10;
            electricity.ElecNight = 11.6;
            electricity.ElecNightPrev = 9.1;
            double expected = 32.72;

            // Act
            double result = Math.Round(electricity.CalculateIndicationsDevice(), 2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
