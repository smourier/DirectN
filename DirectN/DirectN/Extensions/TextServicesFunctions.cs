using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class TextServicesFunctions
    {
        public static ITextServices CreateTextServices(this ITextHost2 host) => CreateTextServices<ITextServices>(host);
        public static T CreateTextServices<T>(this ITextHost2 host) where T : ITextServices
        {
            if (host == null)
                throw new ArgumentNullException(nameof(host));

            object unk;
            //if (IntPtr.Size == 8)
            //{
            //    CreateTextServices(null, host, out unk).ThrowOnError();
            //}
            //else
            {
                if (!(host is TextHost th))
                    throw new ArgumentException(null, nameof(host));

                CreateTextServices(null, th.HostThunk.Pointer, out unk).ThrowOnError();
            }
            return (T)unk;
        }

        [DllImport("msftedit", ExactSpelling = true)]
        public static extern HRESULT CreateTextServices([MarshalAs(UnmanagedType.IUnknown)] object punkOuter, ITextHost pITextHost, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [DllImport("msftedit", ExactSpelling = true)]
        public static extern HRESULT CreateTextServices([MarshalAs(UnmanagedType.IUnknown)] object punkOuter, IntPtr pITextHost, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [DllImport("msftedit", ExactSpelling = true)]
        public static extern HRESULT ShutdownTextServices([MarshalAs(UnmanagedType.IUnknown)] object pTextServices);
    }
}
