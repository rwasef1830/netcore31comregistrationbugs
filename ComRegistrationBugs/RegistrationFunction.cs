using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace ComHostingSelfContainedPublishRegistrationFailure
{
    [ComVisible(true)]
    [Guid("7111F530-625A-411D-97D8-CD1409811077")]
    public class RegistrationFunctionClass
    {
        [ComRegisterFunction]
        public static void Register(Type t)
        {
            MessageBox.Show("Registering type from main assembly: " + t.Name);
        }

        [ComUnregisterFunction]
        public static void Unregister(Type t)
        {
            MessageBox.Show("Unregistering type from main assembly: " + t.Name);
        }
    }
}