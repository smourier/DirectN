using System;
using System.Threading;

namespace DirectN
{
    public abstract class InterlockedDisposable<T> : IDisposable where T : class, IDisposable
    {
        private T _disposable;

        public InterlockedDisposable(T disposable)
        {
            if (disposable == null)
                throw new ArgumentNullException(nameof(disposable));

            _disposable = disposable;
        }

        protected T Disposable
        {
            get
            {
                var disposable = _disposable;
                if (disposable == null)
                    throw new ObjectDisposedException(nameof(Disposable));

                return disposable;
            }
        }

        public virtual void Dispose()
        {
            var disposable = Interlocked.Exchange(ref _disposable, null);
            disposable?.Dispose();
        }
    }
}
