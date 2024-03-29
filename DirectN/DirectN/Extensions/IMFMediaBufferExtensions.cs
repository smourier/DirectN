﻿using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class IMFMediaBufferExtensions
    {
        public static void WithLock(this IComObject<IMFMediaBuffer> buffer, Action<IntPtr, uint, uint> action) => WithLock(buffer?.Object, action);
        public static void WithLock(this IMFMediaBuffer buffer, Action<IntPtr, uint, uint> action)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var ptr = Lock(buffer, out var max, out var current);
            try
            {
                action(ptr, max, current);
            }
            finally
            {
                Unlock(buffer);
            }
        }

        public static T WithLock<T>(this IComObject<IMFMediaBuffer> buffer, Func<IntPtr, uint, uint, T> action) => WithLock<T>(buffer?.Object, action);
        public static T WithLock<T>(this IMFMediaBuffer buffer, Func<IntPtr, uint, uint, T> func)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var ptr = Lock(buffer, out var max, out var current);
            try
            {
                return func(ptr, max, current);
            }
            finally
            {
                Unlock(buffer);
            }
        }

        public static IntPtr Lock(this IComObject<IMFMediaBuffer> buffer) => Lock(buffer?.Object, out var max, out var current);
        public static IntPtr Lock(this IComObject<IMFMediaBuffer> buffer, out uint maxLength, out uint currentLength) => Lock(buffer?.Object, out maxLength, out currentLength);
        public static IntPtr Lock(this IMFMediaBuffer buffer) => Lock(buffer, out _, out _);
        public static IntPtr Lock(this IMFMediaBuffer buffer, out uint maxLength, out uint currentLength)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            var p = Marshal.AllocHGlobal(2 * 4);
            try
            {
                buffer.Lock(out var ptr, p, p + 4).ThrowOnError();
                maxLength = (uint)Marshal.ReadInt32(p);
                currentLength = (uint)Marshal.ReadInt32(p + 4);
                return ptr;
            }
            finally
            {
                Marshal.FreeHGlobal(p);
            }
        }

        public static void Unlock(this IComObject<IMFMediaBuffer> buffer) => Unlock(buffer?.Object);
        public static void Unlock(this IMFMediaBuffer buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            buffer.Unlock().ThrowOnError();
        }

        public static uint GetCurrentLength(this IComObject<IMFMediaBuffer> buffer) => GetCurrentLength(buffer?.Object);
        public static uint GetCurrentLength(this IMFMediaBuffer buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            buffer.GetCurrentLength(out var value).ThrowOnError();
            return value;
        }

        public static uint GetMaxLength(this IComObject<IMFMediaBuffer> buffer) => GetMaxLength(buffer?.Object);
        public static uint GetMaxLength(this IMFMediaBuffer buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            buffer.GetMaxLength(out var value).ThrowOnError();
            return value;
        }

        public static void SetCurrentLength(this IComObject<IMFMediaBuffer> buffer, uint length) => SetCurrentLength(buffer?.Object, length);
        public static void SetCurrentLength(this IMFMediaBuffer buffer, uint length)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            buffer.SetCurrentLength(length).ThrowOnError();
        }
    }
}
