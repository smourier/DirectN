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
                throw new ArgumentException(null, nameof(comObject));

            _object = comObject;
        }

        public string Name { get; set; }

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
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                var obj = Interlocked.Exchange(ref _object, null);
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                }
            }
        }

        public bool IsDisposed => _object == null;

        public override string ToString()
        {
            string s = null;
            if (_object == null)
            {
                s = "<disposed>";
            }

            if (Name != null)
            {
                if (s != null)
                {
                    s += " ";
                }
                s += Name;
            }
            return s;
        }

        public static ComObject<T> From<T>(T comObject) => comObject == null ? null : new ComObject<T>(comObject);

        public static object Unwrap(object obj)
        {
            if (obj is ComObject co)
                return co.Object;

            if (!Marshal.IsComObject(obj))
                throw new ArgumentException(null, nameof(obj));

            return obj;
        }

        public static T Unwrap<T>(object obj)
        {
            if (obj is ComObject co)
                return (T)co.Object;

            if (!Marshal.IsComObject(obj))
                throw new ArgumentException(null, nameof(obj));

            return (T)obj;
        }

        public ComObject<T> As<T>(bool throwOnError = true) where T : class
        {
            T obj;
            if (throwOnError)
            {
                obj = (T)Object;
            }
            else
            {
                obj = Object as T;
            }
            return obj != null ? new ComObject<T>(obj) : null;
        }

        public static ComObject WrapAsGeneric(Type comType, object instance)
        {
            if (comType == null)
                throw new ArgumentNullException(nameof(comType));

            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            if (!comType.IsAssignableFrom(instance.GetType()))
                throw new ArgumentNullException(nameof(instance));

            var type = typeof(ComObject<>).MakeGenericType(comType);
            var ctor = type.GetConstructor(new[] { comType });
            return (ComObject)ctor.Invoke(new[] { instance });
        }

        public static bool IsGenericComObjectType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ComObject<>);
        }

        public static Type GetGenericComObjectComType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(ComObject<>))
                return null;

            return type.GetGenericArguments()[0];
        }

    }

    public class ComObject<T> : ComObject
    {
        public ComObject(T comObject)
            : base(comObject)
        {
#if DEBUG
            // note _start is first so we don't get negative values...
            Id = _sw.ElapsedTicks;
            ConstructorThreadId = Environment.CurrentManagedThreadId;
            Trace("+ComObject");
#endif
        }

#if DEBUG
        public new T Object
        {
            get
            {
                try
                {
                    return (T)base.Object;
                }
                catch (Exception e)
                {
                    Trace("-ComObjectQI", e.Message);
                    throw;
                }
            }
        }
#else
        public new T Object => (T)base.Object;
#endif

#if DEBUG
        // use that guid in TraceSpy's ETW Trace Provider (https://github.com/smourier/TraceSpy) 
        // or use is with MFTrace https://msdn.microsoft.com/en-us/library/windows/desktop/ff685116 as MFTrace can also display our custom traces
        // you can use trace.bat and config.xml in the project. Make sure you use mftrace X64 if this is ran as X4 also.
        private static readonly System.Diagnostics.Eventing.EventProvider _provider = new System.Diagnostics.Eventing.EventProvider(new Guid("92f01f42-b22a-4d49-8be6-3f06355841aa"));
        private static readonly System.Diagnostics.Stopwatch _sw = new System.Diagnostics.Stopwatch();

        static ComObject()
        {
            _sw.Start();
        }

        private void Trace(string method, string message = null)
        {
            // many COM objects (like DXGI ones) dont' like to be used on different threads
            // so we tracks calls on different threads
            var tir = Thread.CurrentThread.ManagedThreadId;
            var ti = tir.ToString();
            if (tir != ConstructorThreadId)
            {
                ti += "!" + ConstructorThreadId;
            }

            string s = ti + method + "<" + typeof(T).Name + ">" + ToString();
            if (message != null)
            {
                s += " " + message;
            }
            _provider.WriteMessageEvent(s, 0, 0);
        }

        public long Id { get; }
        public int ConstructorThreadId { get; }
        public TimeSpan Duration => _sw.Elapsed;

        public override string ToString()
        {
            var s = base.ToString();
            if (s != null)
                return Id + ":" + s;

            return Id.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            Trace("-ComObject", "duration=" + Duration.Milliseconds);
            base.Dispose(disposing);
        }
#endif


        //public static implicit operator ComObject<T>(T value) => new ComObject<T>(value);
        //public static implicit operator T(ComObject<T> value) => value.Object;
    }
}
