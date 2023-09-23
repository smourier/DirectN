// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e3f6778b-6660-4cc8-a291-ecc4192d9967"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackDescription3
    {
        [PreserveSig]
        HRESULT GetJackCount(/* [annotation][out] _Out_ */ out uint pcJacks);
        
        [PreserveSig]
        HRESULT GetJackDescription3(/* [in] */ uint nJack, /* [annotation][out] _Out_ */ out _tagKSJACK_DESCRIPTION3 pDescription3);
    }
}
