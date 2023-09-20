// generated from <Windows SDK Path>\um\mfsharingengine.h
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
