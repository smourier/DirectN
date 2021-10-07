using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("407fb1de-f85a-4150-97cf-b7fb274fb4f8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkD2DRenderer
    {
        [PreserveSig]
        HRESULT Draw([MarshalAs(UnmanagedType.IUnknown)] object pD2D1DeviceContext, [MarshalAs(UnmanagedType.IUnknown)] object pInkStrokeIterable, bool fHighContrast);
    }
}
