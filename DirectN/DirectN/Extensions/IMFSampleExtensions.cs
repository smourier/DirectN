using System;

namespace DirectN
{
    public static class IMFSampleExtensions
    {
        public static long GetSampleDuration(this IComObject<IMFSample> sample) => GetSampleDuration(sample?.Object);
        public static long GetSampleDuration(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetSampleDuration(out var value).ThrowOnError();
            return value;
        }

        public static long GetSampleTime(this IComObject<IMFSample> sample) => GetSampleTime(sample?.Object);
        public static long GetSampleTime(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetSampleTime(out var value).ThrowOnError();
            return value;
        }

        public static uint GetBufferCount(this IComObject<IMFSample> sample) => GetBufferCount(sample?.Object);
        public static uint GetBufferCount(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetBufferCount(out var value).ThrowOnError();
            return value;
        }

        public static uint GetTotalLength(this IComObject<IMFSample> sample) => GetTotalLength(sample?.Object);
        public static uint GetTotalLength(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetTotalLength(out var value).ThrowOnError();
            return value;
        }

        public static uint GetSampleFlags(this IComObject<IMFSample> sample) => GetSampleFlags(sample?.Object);
        public static uint GetSampleFlags(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetSampleFlags(out var value).ThrowOnError();
            return value;
        }

        public static void SetSampleFlags(this IComObject<IMFSample> sample, uint value) => SetSampleFlags(sample?.Object, value);
        public static void SetSampleFlags(this IMFSample sample, uint value)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.SetSampleFlags(value).ThrowOnError();
        }

        public static IComObject<IMFMediaBuffer> GetBufferByIndex(this IComObject<IMFSample> sample, uint index) => GetBufferByIndex(sample?.Object, index);
        public static IComObject<IMFMediaBuffer> GetBufferByIndex(this IMFSample sample, uint index)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.GetBufferByIndex(index, out var buffer).ThrowOnError();
            return new ComObject<IMFMediaBuffer>(buffer);
        }

        public static IComObject<IMFMediaBuffer> ConvertToContiguousBuffer(this IComObject<IMFSample> sample) => ConvertToContiguousBuffer(sample?.Object);
        public static IComObject<IMFMediaBuffer> ConvertToContiguousBuffer(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.ConvertToContiguousBuffer(out var buffer).ThrowOnError();
            return new ComObject<IMFMediaBuffer>(buffer);
        }

        public static void AddBuffer(this IComObject<IMFSample> sample, IComObject<IMFMediaBuffer> buffer) => AddBuffer(sample?.Object, buffer?.Object);
        public static void AddBuffer(this IMFSample sample, IMFMediaBuffer buffer)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            sample.AddBuffer(buffer).ThrowOnError();
        }

        public static void CopyToBuffer(this IComObject<IMFSample> sample, IComObject<IMFMediaBuffer> buffer) => CopyToBuffer(sample?.Object, buffer?.Object);
        public static void CopyToBuffer(this IMFSample sample, IMFMediaBuffer buffer)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            sample.CopyToBuffer(buffer).ThrowOnError();
        }

        public static void RemoveBufferByIndex(this IComObject<IMFSample> sample, uint index) => RemoveBufferByIndex(sample?.Object, index);
        public static void RemoveBufferByIndex(this IMFSample sample, uint index)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.RemoveBufferByIndex(index).ThrowOnError();
        }

        public static void RemoveAllBuffers(this IComObject<IMFSample> sample) => RemoveAllBuffers(sample?.Object);
        public static void RemoveAllBuffers(this IMFSample sample)
        {
            if (sample == null)
                throw new ArgumentNullException(nameof(sample));

            sample.RemoveAllBuffers().ThrowOnError();
        }

    }
}
