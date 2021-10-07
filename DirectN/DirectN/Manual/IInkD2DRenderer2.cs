using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0a95dcd9-4578-4b71-b20b-bf664d4bfeee"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkD2DRenderer2
    {
        [PreserveSig]
        HRESULT Draw([MarshalAs(UnmanagedType.IUnknown)] object pD2D1DeviceContext, [MarshalAs(UnmanagedType.IUnknown)] object pInkStrokeIterable, INK_HIGH_CONTRAST_ADJUSTMENT fHighContrast);
    }
}
