// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(4691,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("daac296f-7aa5-4dbf-8d15-225c5976f891"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICProgressiveLevelControl
    {
        [PreserveSig]
        HRESULT GetLevelCount(/* [retval][out] __RPC__out */ out uint pcLevels);
        
        [PreserveSig]
        HRESULT GetCurrentLevel(/* [retval][out] __RPC__out */ out uint pnLevel);
        
        [PreserveSig]
        HRESULT SetCurrentLevel(/* [in] */ uint nLevel);
    }
}
