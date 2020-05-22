// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(2682,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6daa848c-5eb0-45cc-aea5-998a2cda1ffb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPartsList
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetPart(/* [annotation][in] _In_ */ uint nIndex, /* [annotation][out] _Out_ */ out IPart ppPart);
    }
}
