using System;

namespace DirectN
{
    public static class IMFSampleExtensions
    {
        public static long GetSampleDuration(this IComObject<IMFSample> obj) => GetSampleDuration(obj?.Object);
        public static long GetSampleDuration(this IMFSample obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetSampleDuration(out var value).ThrowOnError();
            return value;
        }

        public static long GetSampleTime(this IComObject<IMFSample> obj) => GetSampleTime(obj?.Object);
        public static long GetSampleTime(this IMFSample obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetSampleTime(out var value).ThrowOnError();
            return value;
        }
    }
}
