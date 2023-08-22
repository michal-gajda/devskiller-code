using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserDataRegistration.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    [TestClass]
    public class StructureReadonlyTest
    {
        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [TestMethod]
        public void TestStructure()
        {
            // verification for UserDataRegistration.Model
            var assembly0 = Assembly.Load(Decode("VXNlckRhdGFSZWdpc3RyYXRpb24uTW9kZWw="));
            Assert.IsNotNull(assembly0, "Missing assembly: " + Decode("VXNlckRhdGFSZWdpc3RyYXRpb24uTW9kZWw="));
            // verification for UserDataRegistration.Model.UserDataViewModel
            Type type0 = assembly0.GetTypes().FirstOrDefault(a => a.Name == Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            Assert.IsNotNull(type0, "Missing: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            Assert.AreEqual(true, type0.IsPublic, "Incorrect: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            Assert.AreEqual(false, type0.IsSealed, "Incorrect: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            Assert.AreEqual(false, type0.IsAbstract, "Incorrect: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            // verification of constructors for UserDataRegistration.Model.UserDataViewModel
            Assert.AreEqual(1, type0.GetConstructors().Count());

            // verification of method UserDataRegistration.Model.UserDataViewModel.add_PropertyChanged
            var method_0_0 = type0.GetMethods().FirstOrDefault(w => w.Name == Decode("YWRkX1Byb3BlcnR5Q2hhbmdlZA==") && w.GetParameters().Count() == 1 && w.GetParameters().Any(p => p.Name == Decode("dmFsdWU=") && p.ParameterType.Name == Decode("UHJvcGVydHlDaGFuZ2VkRXZlbnRIYW5kbGVy")));
            Assert.IsNotNull(method_0_0, "Method declaration was changed: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            // verification of method UserDataRegistration.Model.UserDataViewModel.remove_PropertyChanged
            var method_0_1 = type0.GetMethods().FirstOrDefault(w => w.Name == Decode("cmVtb3ZlX1Byb3BlcnR5Q2hhbmdlZA==") && w.GetParameters().Count() == 1 && w.GetParameters().Any(p => p.Name == Decode("dmFsdWU=") && p.ParameterType.Name == Decode("UHJvcGVydHlDaGFuZ2VkRXZlbnRIYW5kbGVy")));
            Assert.IsNotNull(method_0_1, "Method declaration was changed: " + Decode("VXNlckRhdGFWaWV3TW9kZWw="));
            // verification of property UserDataRegistration.Model.UserDataViewModel.FirstName
            Assert.IsTrue(type0.GetProperties().Any(p => p.Name == Decode("Rmlyc3ROYW1l") && p.PropertyType.Name == Decode("U3RyaW5n")), "Property declaration was changed: " + Decode("Rmlyc3ROYW1l"));
            // verification of property UserDataRegistration.Model.UserDataViewModel.LastName
            Assert.IsTrue(type0.GetProperties().Any(p => p.Name == Decode("TGFzdE5hbWU=") && p.PropertyType.Name == Decode("U3RyaW5n")), "Property declaration was changed: " + Decode("TGFzdE5hbWU="));
            // verification of property UserDataRegistration.Model.UserDataViewModel.Agree
            Assert.IsTrue(type0.GetProperties().Any(p => p.Name == Decode("QWdyZWU=") && p.PropertyType.Name == Decode("Qm9vbGVhbg==")), "Property declaration was changed: " + Decode("QWdyZWU="));
            // verification for UserDataRegistration.WPF
            var assembly1 = Assembly.Load(Decode("VXNlckRhdGFSZWdpc3RyYXRpb24uV1BG"));
            Assert.IsNotNull(assembly1, "Missing assembly: " + Decode("VXNlckRhdGFSZWdpc3RyYXRpb24uV1BG"));

            // verification for UserDataRegistration.WPF.App
            Type type2 = assembly1.GetTypes().FirstOrDefault(a => a.Name == Decode("QXBw"));
            Assert.IsNotNull(type2, "Missing: " + Decode("QXBw"));
            Assert.AreEqual(true, type2.IsPublic, "Incorrect: " + Decode("QXBw"));
            Assert.AreEqual(false, type2.IsSealed, "Incorrect: " + Decode("QXBw"));
            Assert.AreEqual(false, type2.IsAbstract, "Incorrect: " + Decode("QXBw"));
            // verification of constructors for UserDataRegistration.WPF.App
            Assert.AreEqual(1, type2.GetConstructors().Count());

            // verification of method UserDataRegistration.WPF.App.InitializeComponent
            var method_2_0 = type2.GetMethods().FirstOrDefault(w => w.Name == Decode("SW5pdGlhbGl6ZUNvbXBvbmVudA==") && w.GetParameters().Count() == 0);
            Assert.IsNotNull(method_2_0, "Method declaration was changed: " + Decode("QXBw"));
            // verification of method UserDataRegistration.WPF.App.Main
            var method_2_1 = type2.GetMethods().FirstOrDefault(w => w.Name == Decode("TWFpbg==") && w.GetParameters().Count() == 0);
            Assert.IsNotNull(method_2_1, "Method declaration was changed: " + Decode("QXBw"));
            // verification for UserDataRegistration.WPF.RegisterUserWindow
            Type type3 = assembly1.GetTypes().FirstOrDefault(a => a.Name == Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            Assert.IsNotNull(type3, "Missing: " + Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            Assert.AreEqual(true, type3.IsPublic, "Incorrect: " + Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            Assert.AreEqual(false, type3.IsSealed, "Incorrect: " + Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            Assert.AreEqual(false, type3.IsAbstract, "Incorrect: " + Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            // verification of constructors for UserDataRegistration.WPF.RegisterUserWindow
            Assert.AreEqual(1, type3.GetConstructors().Count());

            // verification of method UserDataRegistration.WPF.RegisterUserWindow.InitializeComponent
            var method_3_0 = type3.GetMethods().FirstOrDefault(w => w.Name == Decode("SW5pdGlhbGl6ZUNvbXBvbmVudA==") && w.GetParameters().Count() == 0);
            Assert.IsNotNull(method_3_0, "Method declaration was changed: " + Decode("UmVnaXN0ZXJVc2VyV2luZG93"));
            // verification of property UserDataRegistration.WPF.RegisterUserWindow.OnRegister
            Assert.IsTrue(type3.GetProperties().Any(p => p.Name == Decode("T25SZWdpc3Rlcg==") && p.PropertyType.Name == Decode("RnVuY2Ax")), "Property declaration was changed: " + Decode("T25SZWdpc3Rlcg=="));
            // verification of property UserDataRegistration.WPF.RegisterUserWindow.UserData
            Assert.IsTrue(type3.GetProperties().Any(p => p.Name == Decode("VXNlckRhdGE=") && p.PropertyType.Name == Decode("VXNlckRhdGFWaWV3TW9kZWw=")), "Property declaration was changed: " + Decode("VXNlckRhdGE="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.grid
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("Z3JpZA==") && p.IsPublic && p.FieldType.Name == Decode("R3JpZA==")), "Field declaration was changed: " + Decode("Z3JpZA=="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.labTitle
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("bGFiVGl0bGU=") && p.IsPublic && p.FieldType.Name == Decode("TGFiZWw=")), "Field declaration was changed: " + Decode("bGFiVGl0bGU="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.labFirstName
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("bGFiRmlyc3ROYW1l") && p.IsPublic && p.FieldType.Name == Decode("TGFiZWw=")), "Field declaration was changed: " + Decode("bGFiRmlyc3ROYW1l"));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.edFirstName
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("ZWRGaXJzdE5hbWU=") && p.IsPublic && p.FieldType.Name == Decode("VGV4dEJveA==")), "Field declaration was changed: " + Decode("ZWRGaXJzdE5hbWU="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.labLastName
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("bGFiTGFzdE5hbWU=") && p.IsPublic && p.FieldType.Name == Decode("TGFiZWw=")), "Field declaration was changed: " + Decode("bGFiTGFzdE5hbWU="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.edLastName
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("ZWRMYXN0TmFtZQ==") && p.IsPublic && p.FieldType.Name == Decode("VGV4dEJveA==")), "Field declaration was changed: " + Decode("ZWRMYXN0TmFtZQ=="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.edAggree
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("ZWRBZ2dyZWU=") && p.IsPublic && p.FieldType.Name == Decode("Q2hlY2tCb3g=")), "Field declaration was changed: " + Decode("ZWRBZ2dyZWU="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.btnRegister
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("YnRuUmVnaXN0ZXI=") && p.IsPublic && p.FieldType.Name == Decode("QnV0dG9u")), "Field declaration was changed: " + Decode("YnRuUmVnaXN0ZXI="));
            // verification of field UserDataRegistration.WPF.RegisterUserWindow.labResult
            Assert.IsTrue(type3.GetFields().Any(p => p.Name == Decode("bGFiUmVzdWx0") && p.IsPublic && p.FieldType.Name == Decode("TGFiZWw=")), "Field declaration was changed: " + Decode("bGFiUmVzdWx0"));
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
