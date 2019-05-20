// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(8909,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("bee3d220-157b-11d0-bd23-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConfigInterleaving
    {
        [PreserveSig]
        HRESULT put_Mode(/* [in] */ InterleavingMode mode);
        
        [PreserveSig]
        HRESULT get_Mode(/* [annotation][out] _Out_ */ out InterleavingMode pMode);
        
        [PreserveSig]
        HRESULT put_Interleaving(/* [in] */ ref REFERENCE_TIME prtInterleave, /* [in] */ ref REFERENCE_TIME prtPreroll);
        
        [PreserveSig]
        HRESULT get_Interleaving(/* [annotation][out] _Out_ */ out REFERENCE_TIME prtInterleave, /* [annotation][out] _Out_ */ out REFERENCE_TIME prtPreroll);
    }
}
