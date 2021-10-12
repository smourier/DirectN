// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(2675,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("7fd52380-4e07-101b-ae2d-08002b2ec713"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistStreamInit
    {
        [PreserveSig]
        HRESULT IsDirty();
        
        [PreserveSig]
        HRESULT Load(/* [in] __RPC__in_opt */ IStream pStm);
        
        [PreserveSig]
        HRESULT Save(/* [in] __RPC__in_opt */ IStream pStm, /* [in] */ bool fClearDirty);
        
        [PreserveSig]
        HRESULT GetSizeMax(/* [out] __RPC__out */ out ulong pCbSize);
        
        [PreserveSig]
        HRESULT InitNew();
    }
}
