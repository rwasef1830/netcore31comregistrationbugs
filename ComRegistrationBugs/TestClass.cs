using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComHostingSelfContainedPublishRegistrationFailure
{
    [ComVisible(true)]
    [Guid("A0154EB6-E662-4E34-8E8B-AFF567903D2E")]
    public class TestClass
    {
        public void Test()
        {
            MessageBox.Show("Test");
        }
    }
}
