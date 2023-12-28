using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public abstract class ComObject : IComObject
    {
        private object _object;
        private readonly bool _dispose;

        public ComObject(object comObject, bool dispose = true)
        {
            if (comObject == null)
                throw new ArgumentNullException(nameof(comObject));

            if (!Marshal.IsComObject(comObject))
                throw new ArgumentException("Argument is not a COM object", nameof(comObject));

            _object = comObject;
            _dispose = dispose;

#if DEBUG
            Id = Interlocked.Increment(ref _id);
            ConstructorThreadId = Environment.CurrentManagedThreadId;
            Trace("+");
#endif
        }

        public abstract Type InterfaceType { get; }
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

        public IntPtr GetInterfacePointer<T>(bool throwOnError = false)
        {
            try
            {
                return Marshal.GetComInterfaceForObject(Object, typeof(T));
            }
            catch
            {
                if (throwOnError)
                    throw;
            }
            return IntPtr.Zero;
        }

        public T As<T>(bool throwOnError = false, bool addRef = false) where T : class
        {
            T obj;
            if (throwOnError)
            {
                obj = (T)Object; // will throw
            }
            else
            {
                obj = Object as T;
            }

            if (obj != null && addRef)
            {
                AddRefComObject(obj, throwOnError);
            }
            return obj;
        }

        public IComObject<T> AsComObject<T>(bool throwOnError = false, bool addRef = false, bool dispose = false) where T : class
        {
            if (throwOnError)
            {
                var com = new ComObject<T>((T)Object, dispose); // will throw
                if (addRef)
                {
                    AddRefComObject(com.Object, throwOnError);
                }
                return com;
            }

            if (!(Object is T obj))
                return null;

            var co = new ComObject<T>(obj, dispose);
            if (addRef)
            {
                AddRefComObject(co.Object, throwOnError);
            }
            return co;
        }

        public static object AddRefComObject(object obj, bool throwOnError = true) // reverse of Marshal.ReleaseComObject (which is not the same as Marshal.AddRef)
        {
            // unwrap
            if (obj is ComObject co)
            {
                obj = co.Object;
            }

            try
            {
                var ptr = Marshal.GetIUnknownForObject(obj);
                try
                {
                    return Marshal.GetObjectForIUnknown(ptr);
                }
                finally
                {
                    Marshal.Release(ptr);
                }
            }
            catch
            {
                if (throwOnError)
                    throw;

                return null;
            }
        }

        public static ComObject<T> WrapAsGeneric<T>(object instance) => (ComObject<T>)WrapAsGeneric(typeof(T), instance);
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
            if (!_dispose)
                return;

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

        public static void WithComPointer<T>(object comObject, Action<IntPtr> action) => WithComPointer(comObject, typeof(T), action);
        public static void WithComPointer(object comObject, Type type, Action<IntPtr> action)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var ptr = comObject != null ? Marshal.GetComInterfaceForObject(Unwrap(comObject), type) : IntPtr.Zero;
            try
            {
                action(ptr);
            }
            finally
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.Release(ptr);
                }
            }
        }

        public static T WithComPointer<T, TType>(object comObject, Func<IntPtr, T> func) => WithComPointer<T>(comObject, typeof(TType), func);
        public static T WithComPointer<T>(object comObject, Type type, Func<IntPtr, T> func)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var ptr = comObject != null ? Marshal.GetComInterfaceForObject(Unwrap(comObject), type) : IntPtr.Zero;
            try
            {
                return func(ptr);
            }
            finally
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.Release(ptr);
                }
            }
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
        public ComObject(T comObject, bool dispose = true)
            : base(comObject, dispose)
        {
        }

        public new T Object => (T)base.Object;
        public override Type InterfaceType => typeof(T);

#if DEBUG
        protected override string ObjectTypeName => typeof(T).Name;
#endif
    }

    public interface IComObject : IDisposable
    {
        bool IsDisposed { get; }
        object Object { get; }
        Type InterfaceType { get; }
        I As<I>(bool throwOnError = false, bool addRef = false) where I : class;
        IntPtr GetInterfacePointer<T>(bool throwOnError = false);
        IComObject<I> AsComObject<I>(bool throwOnError = false, bool addRef = false, bool dispose = false) where I : class;
    }

    public interface IComObject<out T> : IComObject
    {
        new T Object { get; }
    }

    public static class ComObjectExtensions
    {
        public static void SafeDispose(this IComObject comObject)
        {
            if (comObject == null || comObject.IsDisposed)
                return;

            comObject.Dispose();
        }
    }

    public sealed class ComObjectWrapper<T> : IDisposable
    {
        private readonly IComObject<T> _cot;

        public ComObjectWrapper(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            _cot = obj as IComObject<T>;
            if (_cot == null)
            {
                if (obj is T t)
                {
                    _cot = new ComObject<T>(t);
                }
                else
                {
                    if (obj is IComObject co)
                    {
                        if (co.IsDisposed)
                            throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));

                        if (co.Object is T t2)
                        {
                            _cot = new ComObject<T>(t2);
                        }
                    }

                    if (_cot == null)
                        throw new ArgumentException("Input of type '" + obj.GetType() + "' must be assignable to type '" + typeof(T) + "'.", nameof(obj));
                }
            }

            if (_cot.IsDisposed)
                throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));
        }

        public T Object => _cot.Object;
        public IComObject<T> ComObject => _cot;

        public void Dispose()
        {
            if (_cot.IsDisposed)
                return;

            _cot.Dispose();
        }
    }
}
