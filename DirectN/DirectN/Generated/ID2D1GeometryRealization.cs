// generated from <Windows SDK Path>\um\d2d1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a16907d7-bc02-4801-99e8-8cf7f485f774"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GeometryRealization : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GeometryRealization
    }
}
