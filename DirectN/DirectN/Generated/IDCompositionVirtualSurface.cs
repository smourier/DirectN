// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1202,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae471c51-5f53-4a24-8d3e-d0c39c30b3f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionVirtualSurface : IDCompositionSurface
    {
        // IDCompositionSurface
        [PreserveSig]
        new HRESULT BeginDraw(/* optional(tagRECT) */ IntPtr updateRect, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_ */ out IntPtr updateObject, /* _Out_ */ out tagPOINT updateOffset);
        
        [PreserveSig]
        new HRESULT EndDraw();
        
        [PreserveSig]
        new HRESULT SuspendDraw();
        
        [PreserveSig]
        new HRESULT ResumeDraw();
        
        [PreserveSig]
        new HRESULT Scroll(/* optional(tagRECT) */ IntPtr scrollRect, /* optional(tagRECT) */ IntPtr clipRect, /* _In_ */ int offsetX, /* _In_ */ int offsetY);
        
        // IDCompositionVirtualSurface
        [PreserveSig]
        HRESULT Resize(/* THIS_ _In_ */ uint width, /* _In_ */ uint height);
        
        [PreserveSig]
        HRESULT Trim(/* THIS_ _In_reads_opt_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagRECT[] rectangles, /* _In_ */ int count);
    }
}
