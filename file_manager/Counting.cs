using System.Threading.Tasks;
using System.Timers;

namespace CountADay{

    public class Counting
    {
        private Timer _timer;
        public Manager fileManager { get; set; }

        private readonly string DEFAULT_PATH = Constants.DefaultPath;

        public Counting()
        {            
            _timer  = new Timer(10000) { AutoReset = true, Enabled = true };
            _timer.Elapsed += TimerElapsed;   
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {   
            fileManager = new Manager(DEFAULT_PATH);
        }

        public void StartTimer() => _timer.Start();
        public void StopTimer() => _timer.Stop();

    }

}