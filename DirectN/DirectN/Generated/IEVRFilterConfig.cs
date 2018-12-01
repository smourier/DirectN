// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1316,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("83e91e85-82c1-4ea7-801d-85dc50b75086"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEVRFilterConfig
    {
        [PreserveSig]
        HRESULT SetNumberOfStreams(/* [in] */ uint dwMaxStreams);
        
        [PreserveSig]
        HRESULT GetNumberOfStreams(/* [annotation][out] _Out_ */ out uint pdwMaxStreams);
    }
}
