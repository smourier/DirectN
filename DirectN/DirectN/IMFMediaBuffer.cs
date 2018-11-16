using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("045FA593-8799-42b8-BC8D-8968C6453507"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaBuffer
    {
        [PreserveSig]
        HRESULT Lock(out IntPtr ppbBuffer, out int pcbMaxLength, out int pcbCurrentLength);

        [PreserveSig]
        HRESULT Unlock();

        [PreserveSig]
        HRESULT GetCurrentLength(out int pcbCurrentLength);

        [PreserveSig]
        HRESULT SetCurrentLength(int cbCurrentLength);

        [PreserveSig]
        HRESULT GetMaxLength(out int pcbMaxLength);
    }
}
