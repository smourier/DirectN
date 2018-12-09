// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(5152,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a1faf330-ef97-11ce-9bc9-00aa00608e01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleParentUndoUnit : IOleUndoUnit
    {
        // IOleUndoUnit
        [PreserveSig]
        new HRESULT Do(/* [in] __RPC__in_opt */ IOleUndoManager pUndoManager);
        
        [PreserveSig]
        new HRESULT GetDescription(/* optional(BSTR) */ out IntPtr pBstr);
        
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
