// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(1529,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("33ae5ea6-4316-436f-8ddd-d73d22f829ec"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMF2DBuffer2 : IMF2DBuffer
    {
        // IMF2DBuffer
        [PreserveSig]
        new HRESULT Lock2D(/* [annotation][out] _Outptr_result_bytebuffer_(_Inexpressible_(ComputePlaneSize(*plPitch))) */ out byte[] ppbScanline0, /* [annotation][out] _Out_ */ out int plPitch);
        
        [PreserveSig]
        new HRESULT Unlock2D();
        
        [PreserveSig]
        new HRESULT GetScanline0AndPitch(/* [annotation][out] _Out_ */ out IntPtr pbScanline0, /* [annotation][out] _Out_ */ out int plPitch);
        
        [PreserveSig]
        new HRESULT IsContiguousFormat(/* [annotation][out] _Out_ */ out bool pfIsContiguous);
        
        [PreserveSig]
        new HRESULT GetContiguousLength(/* [annotation][out] _Out_ */ out uint pcbLength);
        
        [PreserveSig]
        new HRESULT ContiguousCopyTo(/* [annotation][size_is][out] _Out_writes_bytes_(cbDestBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbDestBuffer, /* [in] */ int cbDestBuffer);
        
        [PreserveSig]
        new HRESULT ContiguousCopyFrom(/* [annotation][size_is][in] _In_reads_bytes_(cbSrcBuffer) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbSrcBuffer, /* [in] */ int cbSrcBuffer);
        
        // IMF2DBuffer2
        [PreserveSig]
        HRESULT Lock2DSize(/* [annotation][in] _In_ */ _MF2DBuffer_LockFlags lockFlags, /* [annotation][out] _Outptr_result_bytebuffer_(_Inexpressible_(ComputePlaneSize(*plPitch))) */ out byte[] ppbScanline0, /* [annotation][out] _Out_ */ out int plPitch, /* [annotation][out] _Outptr_result_bytebuffer_(*pcbBufferLength) */ out IntPtr ppbBufferStart, /* [annotation][out] _Out_ */ out uint pcbBufferLength);
        
        [PreserveSig]
        HRESULT Copy2DTo(/* [annotation][in] _In_ */ IMF2DBuffer2 pDestBuffer);
    }
}
