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
    }
}
