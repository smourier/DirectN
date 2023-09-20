// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root interface for all resources in D2D.
    /// </summary>
    [ComImport, Guid("2cd90691-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Resource
    {
        [PreserveSig]
        void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
    }
}
