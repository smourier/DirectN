using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public class ComObject : IDisposable
    {
        public ComObject(object comObject)
        {
            if (comObject == null)
                throw new ArgumentNullException(nameof(comObject));

            Object = comObject;
        }

        public object Object { get; }
        public void Dispose() => Marshal.ReleaseComObject(Object);

        public static ComObject<T> From<T>(T comObject) => new ComObject<T>(comObject);

        public static object Unwrap(object obj)
        {
            if (obj is ComObject co)
                return co.Object;

            return obj;
        }
    }

    public class ComObject<T> : ComObject
    {
        public ComObject(T comObject)
            :base(comObject)
        {
            if (comObject == null)
                throw new ArgumentNullException(nameof(comObject));
        }

        public new T Object => (T)base.Object;

        public ComObject<Ti> As<Ti>() => new ComObject<Ti>((Ti)(object)Object);
        //public static implicit operator ComObject<T>(T value) => new ComObject<T>(value);
        //public static implicit operator T(ComObject<T> value) => value.Object;
    }
}
