using System;

namespace BIT.Qemu.Manager.Module.BusinessObjects
{
    public class ProcessStarter
    {
        
      
        public static void ExecuteProcess(string Executable,string Arguments)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = Executable;

                startInfo.Arguments = Arguments;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

            }
            catch (Exception e)
            {
                //string[] temp = e.ToString().Split('\'');
                //string ex = temp[0] + "\n" + temp[1];
                //temp = ex.Split(new string[] { ": " }, StringSplitOptions.None);
                
            }
        }
    }
}