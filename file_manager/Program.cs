using System;
using Topshelf;
using CountADay;
using System.Threading.Tasks;

namespace file_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = 
            HostFactory.Run(x => {
                x.Service<Counting>(s =>
                {
                    s.ConstructUsing(c => new Counting());
                    s.WhenStarted(c=> c.StartTimer());
                    s.WhenStopped(c => c.StopTimer());
                });

                x.RunAsLocalService();
                x.SetServiceName("FileManagerService");
                x.SetDisplayName("File Manager Service");
                x.SetDescription("Rearrange Download files each day");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
