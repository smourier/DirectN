// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(19254,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ade0fd60-d19d-11d2-abf6-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphConfigCallback
    {
        [PreserveSig]
        HRESULT Reconfigure(IntPtr pvContext, uint dwFlags);
    }
}
