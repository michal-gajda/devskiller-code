using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using System.Windows.Controls;
using UserDataRegistration.WPF;

namespace UserDataRegistration.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void ButtonEmptyValuesTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            window.UserData.FirstName = "";
            window.UserData.LastName = "";
            window.UserData.Agree = true;

            window.OnRegister = TextAction;
            window.btnRegister.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("The form is not correctly completed!", window.labResult.Content);
        }

        [TestMethod]
        public void ButtonCorrectValuesTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            window.UserData.FirstName = "John";
            window.UserData.LastName = "White";
            window.UserData.Agree = true;

            window.OnRegister = TextAction;
            window.btnRegister.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("result1", window.labResult.Content);
        }

        [TestMethod]
        public void BindingReadTest()
        {
            RegisterUserWindow window = new RegisterUserWindow();
            window.UserData.FirstName = "one";
            window.UserData.LastName = "two";
            window.UserData.Agree = true;

            Assert.AreEqual("one", window.edFirstName.Text);
            Assert.AreEqual("two", window.edLastName.Text);
            Assert.AreEqual(true, window.edAggree.IsChecked);
        }

        public string TextAction ()
        {
            return "result1";
        }
    }
}
