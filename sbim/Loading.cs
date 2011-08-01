using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sbim
{
    public class Loading
    {
        public event EventHandler<LoadingEventArgs> ProgressChanged;
        public event EventHandler LoadingDone;

        public void DoLoading()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 50000; j++)
                {
                    Math.Pow(i, j);
                }
                this.OnProgressChanged(i);
            }

            this.OnLoadingDone();
        }

        private void OnProgressChanged(int progress)
        {
            var handler = this.ProgressChanged;
            if (handler != null)
            {
                handler(this, new LoadingEventArgs(progress));
            }
        }

        private void OnLoadingDone()
        {
            var handler = this.LoadingDone;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }

    public class LoadingEventArgs : EventArgs
    {
        public LoadingEventArgs(int progress)
        {
            this.Progress = progress;
        }

        public int Progress
        {
            get;
            private set;
        }
    }
}

    
