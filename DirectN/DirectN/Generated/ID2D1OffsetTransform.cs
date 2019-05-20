// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1effectauthor.h(830,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3fe6adea-7643-4f53-bd14-a0ce63f24042"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1OffsetTransform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1OffsetTransform
        [PreserveSig]
        void SetOffset(tagPOINT offset);
        
        [PreserveSig]
        tagPOINT GetOffset();
    }
}
