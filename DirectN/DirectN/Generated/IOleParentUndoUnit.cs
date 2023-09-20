// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a1faf330-ef97-11ce-9bc9-00aa00608e01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleParentUndoUnit : IOleUndoUnit
    {
        // IOleUndoUnit
        [PreserveSig]
        new HRESULT Do(/* [in] __RPC__in_opt */ IOleUndoManager pUndoManager);
        
        [PreserveSig]
        new HRESULT GetDescription(/* [out] __RPC__deref_out_opt */ out IntPtr pBstr);
        
        [PreserveSig]
        new HRESULT GetUnitType(/* [out] __RPC__out */ out Guid pClsid, /* [out] __RPC__out */ out int plID);
        
        [PreserveSig]
        new HRESULT OnNextAdd();
        
        // IOleParentUndoUnit
        [PreserveSig]
        HRESULT Open(/* [in] __RPC__in_opt */ IOleParentUndoUnit pPUU);
        
        [PreserveSig]
        HRESULT Close(/* [in] __RPC__in_opt */ IOleParentUndoUnit pPUU, /* [in] */ bool fCommit);
        
        [PreserveSig]
        HRESULT Add(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT FindUnit(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT GetParentState(/* [out] __RPC__out */ out uint pdwState);
    }
}
