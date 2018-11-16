using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public class ComObject : IDisposable
    {
        private object _object;

        public ComObject(object comObject)
        {
            if (comObject == null)
                throw new ArgumentNullException(nameof(comObject));

            if (!Marshal.IsComObject(comObject))
                throw new ArgumentException("Argument is not a COM object", nameof(comObject));

            _object = comObject;
        }

        public object Object
        {
            get
            {
                var obj = _object;
                if (obj == null)
                    throw new ObjectDisposedException(nameof(Object));

                return obj;
            }
        }

        public void Dispose()
        {
            var obj = Interlocked.Exchange(ref _object, null);
            if (obj != null)
            {
                Marshal.ReleaseComObject(obj);
            }
        }

        public bool IsDisposed => _object == null;

        public static ComObject<T> From<T>(T comObject) => comObject == null ? null : new ComObject<T>(comObject);

        public static object Unwrap(object obj)
        {
            if (obj is ComObject co)
                return co.Object;

            if (!Marshal.IsComObject(obj))
                throw new ArgumentException("Argument is not a COM object", nameof(obj));

            return obj;
        }

        public static T Unwrap<T>(object obj)
        {
            if (obj is ComObject co)
                return (T)co.Object;

            if (!Marshal.IsComObject(obj))
                throw new ArgumentException("Argument is not a COM object", nameof(obj));

            return (T)obj;
        }
    }

    public class ComObject<T> : ComObject
    {
        public ComObject(T comObject)
            : base(comObject)
        {
        }

        public new T Object => (T)base.Object;

        public ComObject<Ti> Cast<Ti>() => new ComObject<Ti>((Ti)base.Object);

        public ComObject<Ti> As<Ti>()
        {
            if (!typeof(Ti).IsAssignableFrom(Object.GetType()))
                return null;

            return new ComObject<Ti>((Ti)base.Object);
        }
        //public static implicit operator ComObject<T>(T value) => new ComObject<T>(value);
        //public static implicit operator T(ComObject<T> value) => value.Object;
    }
}
