// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_GET_POINTER_SHAPE_DATA
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public uint BufferSizeSupplied;
        public IntPtr pShapeBuffer;
        public uint BufferSizeRequired;
        public _D3DKMT_OUTDUPL_POINTER_SHAPE_INFO ShapeInfo;
    }
}
