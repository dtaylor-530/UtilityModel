using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityModel
{
    public class Disposable : IDisposable
    {
     
        private bool isDisposed = false;
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    //    if (_wplayer != null) _wplayer.Dispose();
                }
            }
            isDisposed = true;
        }
  
    }
}
