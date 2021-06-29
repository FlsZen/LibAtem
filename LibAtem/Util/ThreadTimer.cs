using System;
using System.Threading;

namespace LibAtem.Util
{
    /// <summary>
    /// A short-term hack to address macOS Timers and ThreadPool / tasks being computationally expensive when running
    /// frequently.
    /// </summary>
    public class ThreadTimer : IDisposable
    {
        private volatile Boolean _disposed;
        
        public ThreadTimer(Action action, Int32 periodMilliseconds)
        {
            new Thread(() =>
            {
                while (!_disposed)
                {
                    Thread.Sleep(periodMilliseconds);
                    action();
                }
            })
            {
                Name = nameof(ThreadTimer),
                IsBackground = true
            }.Start();
        }

        public void Dispose()
        {
            _disposed = true;
        }
    }
}