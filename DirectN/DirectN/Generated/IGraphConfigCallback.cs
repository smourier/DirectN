// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(18275,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ade0fd60-d19d-11d2-abf6-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphConfigCallback
    {
        [PreserveSig]
        HRESULT Reconfigure(ref IntPtr pvContext, uint dwFlags);
    }
}
