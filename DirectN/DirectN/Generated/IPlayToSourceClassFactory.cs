// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfsharingengine.h(1228,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("842b32a3-9b9b-4d1c-b3f3-49193248a554"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPlayToSourceClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IPlayToControl pControl, /* [annotation][out] _Outptr_ */ out IntPtr ppSource);
    }
}
