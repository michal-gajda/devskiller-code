using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserDataRegistration.WPF;

namespace UserDataRegistration.Tests
{
    [TestClass]
    public class StylesTests
    {
        [TestMethod]
        public void TitleLayoutTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(0, System.Windows.Controls.Grid.GetColumn(window.labTitle));
            Assert.AreEqual(0, System.Windows.Controls.Grid.GetRow(window.labTitle));
            Assert.AreEqual(1, System.Windows.Controls.Grid.GetRowSpan(window.labTitle));
            Assert.AreEqual(4, System.Windows.Controls.Grid.GetColumnSpan(window.labTitle));
        }

        [TestMethod]
        public void TitleFontTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.IsNotNull(window.labTitle.FontFamily);
            Assert.IsNotNull(window.labTitle.FontFamily.Source);
            Assert.AreEqual("tahoma", window.labTitle.FontFamily.Source.ToLower());
        }

        [TestMethod]
        public void FirstNameLayoutTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(0, System.Windows.Controls.Grid.GetColumn(window.labFirstName));
            Assert.AreEqual(1, System.Windows.Controls.Grid.GetRow(window.labFirstName));
            Assert.AreEqual(1, System.Windows.Controls.Grid.GetRowSpan(window.labFirstName));
            Assert.AreEqual(1, System.Windows.Controls.Grid.GetColumnSpan(window.labFirstName));
        }

        [TestMethod]
        public void LastNameLayoutTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(System.Windows.HorizontalAlignment.Right, window.labLastName.HorizontalAlignment);
        }

        [TestMethod]
        public void ButtonLayoutTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(2, System.Windows.Controls.Grid.GetColumnSpan(window.btnRegister));
        }

        [TestMethod]
        public void GridRowsHeightTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(100, window.grid.RowDefinitions[0].Height.Value);
            Assert.AreEqual(40, window.grid.RowDefinitions[1].Height.Value);
            Assert.AreEqual(40, window.grid.RowDefinitions[2].Height.Value);
            Assert.AreEqual(40, window.grid.RowDefinitions[3].Height.Value);
        }

        [TestMethod]
        public void LabelResultLayoutTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            Assert.AreEqual(4, System.Windows.Controls.Grid.GetRow(window.labResult));
            Assert.AreEqual(0, System.Windows.Controls.Grid.GetColumn(window.labResult));
        }
    }
}
