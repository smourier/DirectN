using System;
using System.Diagnostics;
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

#if DEBUG
            Id = Interlocked.Increment(ref _id);
            ConstructorThreadId = Environment.CurrentManagedThreadId;
            Trace("+");
#endif
        }

        public bool IsDisposed => _object == null;
        public object Object
        {
            get
            {
                var obj = _object;
                if (obj == null)
                {
#if DEBUG
                    Trace("!!!", "Already disposed");
#endif
                    throw new ObjectDisposedException(nameof(Object));
                }

                return obj;
            }
        }

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

        public T As<T>(bool throwOnError = false) where T : class
        {
            if (throwOnError)
                return (T)Object; // will throw

            return Object as T;
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

        protected virtual void Dispose(bool disposing)
        {
            //#if DEBUG
            //            Trace("~", "disposing: " + disposing + " duration: " + Duration.Milliseconds);
            //#endif
            if (!IsDisposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                var obj = Interlocked.Exchange(ref _object, null);
                if (obj != null)
                {
#if DEBUG
                    //var typeName = GetType().FullName;
                    //if (typeName.IndexOf("textlayout", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    //    typeName.IndexOf("textformat", StringComparison.OrdinalIgnoreCase) >= 0)
                    //    return;

                    var count = Marshal.ReleaseComObject(obj);
                    Trace("~", "disposing: " + disposing + " count: " + count);
#else
                    Marshal.ReleaseComObject(obj);
#endif

                }
            }
        }

        ~ComObject() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }

        public static void FinalDispose(ComObject comObject)
        {
            if (comObject == null || comObject.IsDisposed)
                return;

            var obj = Interlocked.Exchange(ref comObject._object, null);
            if (obj != null)
            {
#if DEBUG
                //var typeName = GetType().FullName;
                //if (typeName.IndexOf("textlayout", StringComparison.OrdinalIgnoreCase) >= 0 ||
                //    typeName.IndexOf("textformat", StringComparison.OrdinalIgnoreCase) >= 0)
                //    return;

                Marshal.FinalReleaseComObject(obj);
#else
                Marshal.FinalReleaseComObject(obj);
#endif
            }
        }

        public static int FinalRelease(object comObject)
        {
            if (comObject == null)
                return 0;

            if (!Marshal.IsComObject(comObject))
                throw new ArgumentException("Argument is not a COM object", nameof(comObject));

            return Marshal.FinalReleaseComObject(comObject);
        }

        public static int Release(object comObject)
        {
            if (comObject == null)
                return 0;

            if (!Marshal.IsComObject(comObject))
                throw new ArgumentException("Argument is not a COM object", nameof(comObject));

            return Marshal.ReleaseComObject(comObject);
        }

#if DEBUG
        public static ILogger Logger { get; set; }
        protected virtual string ObjectTypeName => null;
        private static long _id;

        protected void Trace(string methodName, string message = null)
        {
            // many COM objects (like DXGI ones) dont' like to be used on different threads
            // so we tracks calls on different threads
            string s = Id.ToString();

            var tid = Thread.CurrentThread.ManagedThreadId;
            if (tid != ConstructorThreadId)
            {
                s += "!" + ConstructorThreadId + "!";
            }

            var tn = ObjectTypeName;
            if (tn != null)
            {
                s += "<" + tn + ">";
            }

            if (message != null)
            {
                s += " " + message;
            }

            Logger?.Log(TraceLevel.Info, s, methodName);
        }

        public long Id { get; }
        public int ConstructorThreadId { get; }

        public override string ToString()
        {
            string s = null;
            if (IsDisposed)
            {
                s = "<disposed>";
            }

            var ot = ObjectTypeName;
            if (ot != null)
            {
                if (s != null)
                {
                    s += " ";
                }
                s += ot;
            }

            if (s != null)
                return Id + " " + s;

            return Id.ToString();
        }
#endif
    }

    public class ComObject<T> : ComObject, IComObject<T>
    {
        public ComObject(T comObject)
            : base(comObject)
        {
        }

        public new T Object => (T)base.Object;

#if DEBUG
        protected override string ObjectTypeName => typeof(T).Name;
#endif

        //public static implicit operator ComObject<T>(T value) => new ComObject<T>(value);
        //public static implicit operator T(ComObject<T> value) => value.Object;
    }

    public interface IComObject<out T> : IDisposable
    {
        T Object { get; }
        bool IsDisposed { get; }
        I As<I>(bool throwOnError = false) where I : class;
    }
}
