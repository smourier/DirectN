using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0657AF73-53FD-47CF-84FF-C8492D2A80A3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGeometrySource2DInterop
    {
        [PreserveSig]
        HRESULT GetGeometry(out ID2D1Geometry value);

        [PreserveSig]
        HRESULT TryGetGeometryUsingFactory(ID2D1Factory factory, out ID2D1Geometry value);
    }
}
