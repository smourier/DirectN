﻿// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;
using LPD3DHAL_CLEARCB = System.IntPtr;
using LPD3DHAL_DRAWONEINDEXEDPRIMITIVECB = System.IntPtr;
using LPD3DHAL_DRAWONEPRIMITIVECB = System.IntPtr;
using LPD3DHAL_DRAWPRIMITIVESCB = System.IntPtr;
using LPD3DHAL_SETRENDERTARGETCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CALLBACKS2
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SetRenderTarget;
        public IntPtr Clear;
        public IntPtr DrawOnePrimitive;
        public IntPtr DrawOneIndexedPrimitive;
        public IntPtr DrawPrimitives;
    }
}
