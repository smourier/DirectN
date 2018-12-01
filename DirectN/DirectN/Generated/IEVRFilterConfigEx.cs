// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1423,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aea36028-796d-454f-beee-b48071e24304"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEVRFilterConfigEx : IEVRFilterConfig
    {
        // IEVRFilterConfig
        [PreserveSig]
        new HRESULT SetNumberOfStreams(/* [in] */ uint dwMaxStreams);
        
        [PreserveSig]
        new HRESULT GetNumberOfStreams(/* [annotation][out] _Out_ */ out uint pdwMaxStreams);
        
        // IEVRFilterConfigEx
        [PreserveSig]
        HRESULT SetConfigPrefs(/* [in] */ uint dwConfigFlags);
        
        [PreserveSig]
        HRESULT GetConfigPrefs(/* [out] __RPC__out */ out uint pdwConfigFlags);
    }
}
