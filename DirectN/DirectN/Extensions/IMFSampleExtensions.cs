using System;

namespace DirectN
{
    public static class IMFSampleExtensions
    {
        public static long GetSampleDuration(this ComObject<IMFSample> input) => GetSampleDuration(input?.Object);
        public static long GetSampleDuration(this IMFSample input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetSampleDuration(out var value).ThrowOnError();
            return value;
        }

        public static long GetSampleTime(this ComObject<IMFSample> input) => GetSampleTime(input?.Object);
        public static long GetSampleTime(this IMFSample input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetSampleTime(out var value).ThrowOnError();
            return value;
        }
    }
}
