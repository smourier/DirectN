// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(307,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b7d14566-0509-4cce-a71f-0a554233bd9b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IInitializeWithFile
    {
        [PreserveSig]
        HRESULT Initialize(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszFilePath, /* [in] */ uint grfMode);
    }
}
