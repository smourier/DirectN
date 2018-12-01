// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(864,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56c294d0-753e-4260-8d61-a3d8820b1d54"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDesiredSample
    {
        [PreserveSig]
        HRESULT GetDesiredSampleTimeAndDuration(/* [annotation][out] _Out_ */ out long phnsSampleTime, /* [annotation][out] _Out_ */ out long phnsSampleDuration);
        
        [PreserveSig]
        void SetDesiredSampleTimeAndDuration(/* [in] */ long hnsSampleTime, /* [in] */ long hnsSampleDuration);
        
        [PreserveSig]
        void Clear();
    }
}
