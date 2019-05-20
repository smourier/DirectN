// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(81,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_STATE_BLOCK_MASK
    {
        public byte VS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] VSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] VSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] VSConstantBuffers;
        public byte GS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] GSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] GSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] GSConstantBuffers;
        public byte PS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] PSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] PSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] PSConstantBuffers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] IAVertexBuffers;
        public byte IAIndexBuffer;
        public byte IAInputLayout;
        public byte IAPrimitiveTopology;
        public byte OMRenderTargets;
        public byte OMDepthStencilState;
        public byte OMBlendState;
        public byte RSViewports;
        public byte RSScissorRects;
        public byte RSRasterizerState;
        public byte SOBuffers;
        public byte Predication;
    }
}
