// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1163,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bb8a4953-2c99-4f5a-96f5-4819027fa3ac"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionSurface
    {
        [PreserveSig]
        HRESULT BeginDraw(/* optional(tagRECT) */ IntPtr updateRect, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_ */ out IntPtr updateObject, /* _Out_ */ out tagPOINT updateOffset);
        
        [PreserveSig]
        HRESULT EndDraw();
        
        [PreserveSig]
        HRESULT SuspendDraw();
        
        [PreserveSig]
        HRESULT ResumeDraw();
        
        [PreserveSig]
        HRESULT Scroll(/* optional(tagRECT) */ IntPtr scrollRect, /* optional(tagRECT) */ IntPtr clipRect, /* _In_ */ int offsetX, /* _In_ */ int offsetY);
    }
}
