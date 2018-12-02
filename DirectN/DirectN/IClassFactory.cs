using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000001-0000-0000-C000-000000000046")]
    public interface IClassFactory
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        object CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [MarshalAs(UnmanagedType.LPStruct)] Guid riid);
        void LockServer(bool fLock);
    }
}
