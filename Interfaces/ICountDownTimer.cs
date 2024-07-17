using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CountDownTimer.Interfaces
{
    public interface ICountDownTimer
    {

        public DispatcherTimer Timer { get; }

        public void StartTimer();

        public void StopTimer();

    }
}
