using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("94bc8415-04ea-4b2e-af13-4de95aa898eb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISoftwareBitmapNative : IInspectable
    {
        // IInspectable
        [PreserveSig]
        new HRESULT GetIids(out int iidCount, out IntPtr iids);

        [PreserveSig]
        new HRESULT GetRuntimeClassName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(HStringMarshaler))] out string className);

        [PreserveSig]
        new HRESULT GetTrustLevel(out TrustLevel trustLevel);

        // ISoftwareBitmapNative
        [PreserveSig]
        HRESULT GetData([MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);
    }
}
