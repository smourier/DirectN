using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A6BA4205-E59E-4E71-B25B-4E436D21EE3D")]
    public interface IDisplayPathInterop
    {
        [PreserveSig]
        HRESULT CreateSourcePresentationHandle(out IntPtr value);

        [PreserveSig]
        HRESULT GetSourceId(out uint sourceId);
    }
}
