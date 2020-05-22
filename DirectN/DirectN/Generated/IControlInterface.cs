// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(3252,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("45d37c3f-5140-444a-ae24-400789f3cbf3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IControlInterface
    {
        [PreserveSig]
        HRESULT GetName(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrName);
        
        [PreserveSig]
        HRESULT GetIID(/* [annotation][out] _Out_ */ out Guid pIID);
    }
}
