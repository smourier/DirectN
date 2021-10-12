// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(830,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// An effect uses this interface to offset an image without inserting a rendering pass.
    /// </summary>
    [ComImport, Guid("3fe6adea-7643-4f53-bd14-a0ce63f24042"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1OffsetTransform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1OffsetTransform
        [PreserveSig]
        void SetOffset(tagPOINT offset);
        
        [PreserveSig]
        void GetOffset(out tagPOINT size);
    }
}
