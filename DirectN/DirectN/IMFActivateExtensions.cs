using System;

namespace DirectN
{
    public static class IMFActivateExtensions
    {
        public static T ActivateObject<T>(this ComObject<IMFActivate> obj) => ActivateObject<T>(obj?.Object, typeof(T).GUID);
        public static T ActivateObject<T>(this ComObject<IMFActivate> obj, Guid riid) => ActivateObject<T>(obj?.Object, riid);
        public static T ActivateObject<T>(this IMFActivate obj) => ActivateObject<T>(obj, typeof(T).GUID);
        public static T ActivateObject<T>(this IMFActivate obj, Guid riid)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.ActivateObject(riid, out var pv).ThrowOnError();
            return (T)pv;
        }
    }
}
