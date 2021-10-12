// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(5767,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d001f200-ef97-11ce-9bc9-00aa00608e01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleUndoManager
    {
        [PreserveSig]
        HRESULT Open(/* [in] __RPC__in_opt */ IOleParentUndoUnit pPUU);
        
        [PreserveSig]
        HRESULT Close(/* [in] __RPC__in_opt */ IOleParentUndoUnit pPUU, /* [in] */ bool fCommit);
        
        [PreserveSig]
        HRESULT Add(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT GetOpenParentState(/* [out] __RPC__out */ out uint pdwState);
        
        [PreserveSig]
        HRESULT DiscardFrom(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT UndoTo(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT RedoTo(/* [in] __RPC__in_opt */ IOleUndoUnit pUU);
        
        [PreserveSig]
        HRESULT EnumUndoable(/* [out] __RPC__deref_out_opt */ out IEnumOleUndoUnits ppEnum);
        
        [PreserveSig]
        HRESULT EnumRedoable(/* [out] __RPC__deref_out_opt */ out IEnumOleUndoUnits ppEnum);
        
        [PreserveSig]
        HRESULT GetLastUndoDescription(/* [out] __RPC__deref_out_opt */ out IntPtr pBstr);
        
        [PreserveSig]
        HRESULT GetLastRedoDescription(/* [out] __RPC__deref_out_opt */ out IntPtr pBstr);
        
        [PreserveSig]
        HRESULT Enable(/* [in] */ bool fEnable);
    }
}
