using System;

namespace DirectN
{
    public static class IDXGIObjectExtensions
    {
        public static IComObject<T> GetParent<T>(this IDXGIObject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetParent(typeof(T).GUID, out var parent).ThrowOnError();
            return new ComObject<T>((T)parent);
        }
    }
}
