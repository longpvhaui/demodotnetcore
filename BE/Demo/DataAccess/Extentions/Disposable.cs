using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Extentions
{
    public class Disposable :IDisposable
    {
        private bool disposed;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);   //xả bộ nhớ 
        }
        private void Dispose(bool disosing)
        {
            if(!disposed && disosing)
            {
                DisposeCore();
            }
            disposed = true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
