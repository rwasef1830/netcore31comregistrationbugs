using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace TestLibrary
{
    [ComVisible(true)]
    [Guid("6111F530-625A-411D-97D8-CD1409811077")]
    public class RegistrationFunctionClass
    {
        [ComRegisterFunction]
        public static void Register(Type t)
        {
            MessageBox.Show("Registering type from dependency: " + t.Name);
        }

        [ComUnregisterFunction]
        public static void Unregister(Type t)
        {
            MessageBox.Show("Unregistering type from dependency: " + t.Name);
        }
    }
}