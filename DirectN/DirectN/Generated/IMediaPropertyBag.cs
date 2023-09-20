// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6025a880-c0d5-11d0-bd4e-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaPropertyBag
    {
        [PreserveSig]
        HRESULT EnumProperty(/* [in] */ uint iProperty, /* [out][in] */ out IntPtr pvarPropertyName, /* [out][in] */ out IntPtr pvarPropertyValue);
    }
}
