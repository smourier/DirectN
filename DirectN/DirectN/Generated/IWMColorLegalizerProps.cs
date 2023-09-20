// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("776c93b3-b72d-4508-b6d0-208785f553e7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMColorLegalizerProps
    {
        [PreserveSig]
        HRESULT SetColorLegalizerQuality(/* [in] */ int lquality);
    }
}
