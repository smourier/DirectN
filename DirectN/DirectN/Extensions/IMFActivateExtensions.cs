using System;

namespace DirectN
{
    public static class IMFActivateExtensions
    {
        public static ComObject<T> ActivateObject<T>(this ComObject<IMFActivate> input) => ActivateObject<T>(input?.Object, typeof(T).GUID);
        public static ComObject<T> ActivateObject<T>(this ComObject<IMFActivate> input, Guid riid) => ActivateObject<T>(input?.Object, riid);
        public static ComObject<T> ActivateObject<T>(this IMFActivate input) => ActivateObject<T>(input, typeof(T).GUID);
        public static ComObject<T> ActivateObject<T>(this IMFActivate input, Guid riid)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.ActivateObject(riid, out var pv).IsError)
                return null;

            return new ComObject<T>((T)pv);
        }
    }
}
