// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a86892-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumPins
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cPins, /* [annotation][size_is][out] _Out_writes_to_(cPins, *pcFetched) */ IntPtr ppPins, /* optional(ULONG) */ IntPtr pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cPins);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumPins ppEnum);
    }
}
