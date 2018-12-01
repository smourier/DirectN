// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_2.h(98,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a resource domain whose objects and device contexts can be used together.
    /// </summary>
    [Guid("d21768e1-23a4-4823-a14b-7c3eba85d658"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device1
    {
        [PreserveSig]
        D2D1_RENDERING_PRIORITY GetRenderingPriority();
        
        [PreserveSig]
        void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority);
        
        [PreserveSig]
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext1 deviceContext1);
    }
}
