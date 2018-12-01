// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1318,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a7aba9c1-8983-11cf-8f20-00805f2cd064"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideMultipleClassInfo : IProvideClassInfo2
    {
        // IProvideClassInfo
        [PreserveSig]
        new HRESULT GetClassInfoA(/* optional(ITypeInfo) */ out IntPtr ppTI);
        
        // IProvideClassInfo2
        [PreserveSig]
        new HRESULT GetGUID(/* [in] */ uint dwGuidKind, /* [out] __RPC__out */ out Guid pGUID);
        
        // IProvideMultipleClassInfo
        [PreserveSig]
        HRESULT GetMultiTypeInfoCount(/* [out] __RPC__out */ out uint pcti);
        
        [PreserveSig]
        HRESULT GetInfoOfIndex(/* [in] */ uint iti, /* [in] */ uint dwFlags, /* optional(ITypeInfo) */ out IntPtr pptiCoClass, /* [out] __RPC__out */ out uint pdwTIFlags, /* [out] __RPC__out */ out uint pcdispidReserved, /* [out] __RPC__out */ out Guid piidPrimary, /* [out] __RPC__out */ out Guid piidSource);
    }
}
