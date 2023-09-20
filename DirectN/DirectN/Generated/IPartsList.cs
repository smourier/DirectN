// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6daa848c-5eb0-45cc-aea5-998a2cda1ffb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPartsList
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetPart(/* [annotation][in] _In_ */ uint nIndex, /* [annotation][out] _Out_ */ out IPart ppPart);
    }
}
