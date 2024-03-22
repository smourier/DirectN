// generated from <Windows SDK Path>\um\d3dcommon.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DInclude
    {
        [PreserveSig]
        HRESULT Open(_D3D_INCLUDE_TYPE IncludeType, [MarshalAs(UnmanagedType.LPStr)] string pFileName, IntPtr pParentData, IntPtr ppData, ref uint pBytes);

        [PreserveSig]
        HRESULT Close(IntPtr pData);
    }
}
