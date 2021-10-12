// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(1370,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("a7aba9c1-8983-11cf-8f20-00805f2cd064"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideMultipleClassInfo : IProvideClassInfo2
    {
        // IProvideClassInfo
        [PreserveSig]
        new HRESULT GetClassInfoW(/* [out] __RPC__deref_out_opt */ out ITypeInfo ppTI);
        
        // IProvideClassInfo2
        [PreserveSig]
        new HRESULT GetGUID(/* [in] */ uint dwGuidKind, /* [out] __RPC__out */ out Guid pGUID);
        
        // IProvideMultipleClassInfo
        [PreserveSig]
        HRESULT GetMultiTypeInfoCount(/* [out] __RPC__out */ out uint pcti);
        
        [PreserveSig]
        HRESULT GetInfoOfIndex(/* [in] */ uint iti, /* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out ITypeInfo pptiCoClass, /* [out] __RPC__out */ out uint pdwTIFlags, /* [out] __RPC__out */ out uint pcdispidReserved, /* [out] __RPC__out */ out Guid piidPrimary, /* [out] __RPC__out */ out Guid piidSource);
    }
}
