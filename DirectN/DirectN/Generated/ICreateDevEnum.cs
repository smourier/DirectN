// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(1090,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("29840822-5b84-11d0-bd3b-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICreateDevEnum
    {
        [PreserveSig]
        HRESULT CreateClassEnumerator(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidDeviceClass, /* [annotation][out] _Out_ */ out IEnumMoniker ppEnumMoniker, /* [in] */ uint dwFlags);
    }
}
