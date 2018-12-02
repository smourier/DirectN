// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(696,5)
using System;
using System.Runtime.InteropServices;
using D3D11_RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DeviceContext1
    {
        [PreserveSig]
        void CopySubresourceRegion1(/* [annotation] _In_ */ ref ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ref ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        void UpdateSubresource1(/* [annotation] _In_ */ ref ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        void DiscardResource(/* [annotation] _In_ */ ref ID3D11Resource pResource);
        
        [PreserveSig]
        void DiscardView(/* [annotation] _In_ */ ref ID3D11View pResourceView);
        
        [PreserveSig]
        void VSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void HSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void DSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void GSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void PSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void CSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void VSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void HSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void DSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void GSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void PSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void CSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        void SwapDeviceContextState(/* [annotation] _In_ */ ref ID3DDeviceContextState pState, /* optional(ID3DDeviceContextState) */ out IntPtr ppPreviousState);
        
        [PreserveSig]
        void ClearView(/* [annotation] _In_ */ ref ID3D11View pView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Color, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_RECT[] pRect, uint NumRects);
        
        [PreserveSig]
        void DiscardView1(/* [annotation] _In_ */ ref ID3D11View pResourceView, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D11_RECT[] pRects, uint NumRects);
    }
}
