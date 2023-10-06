// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00000002-0000-0000-c000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMalloc
    {
        [PreserveSig]
        void Alloc(/* [annotation][in] _In_ */ IntPtr cb);
        
        [PreserveSig]
        void Realloc(/* optional(void) */ IntPtr pv, /* [annotation][in] _In_ */ IntPtr cb);
        
        [PreserveSig]
        void Free(/* optional(void) */ IntPtr pv);
        
        [PreserveSig]
        IntPtr GetSize(/* optional(void) */ IntPtr pv);
        
        [PreserveSig]
        void DidAlloc(/* optional(void) */ IntPtr pv);
        
        [PreserveSig]
        void HeapMinimize();
    }
}
