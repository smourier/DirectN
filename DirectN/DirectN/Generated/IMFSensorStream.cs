// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(18949,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e9a42171-c56e-498a-8b39-eda5a070b7fc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorStream
    {
        [PreserveSig]
        HRESULT GetMediaTypeCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetMediaType(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT CloneSensorStream(/* [annotation][out] _COM_Outptr_ */ out IMFSensorStream ppStream);
    }
}
