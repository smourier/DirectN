using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c3c181ec-2914-4791-af02-02d224a10b43"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISoftwareBitmapNativeFactory : IInspectable
    {
        // IInspectable
        [PreserveSig]
        new HRESULT GetIids(out int iidCount, out IntPtr iids);

        [PreserveSig]
        new HRESULT GetRuntimeClassName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(HStringMarshaler))] out string className);

        [PreserveSig]
        new HRESULT GetTrustLevel(out TrustLevel trustLevel);

        // ISoftwareBitmapNativeFactory
        [PreserveSig]
        HRESULT CreateFromWICBitmap(IWICBitmap data, bool forceReadOnly, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

        [PreserveSig]
        HRESULT CreateFromMF2DBuffer2(
            IntPtr data,
            [MarshalAs(UnmanagedType.LPStruct)] Guid subtype,
            uint width,
            uint height,
            bool forceReadOnly,
            IntPtr minDisplayAperture,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            out IntPtr ppv);
    }
}
