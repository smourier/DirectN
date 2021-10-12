// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(1445,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7dc9d5f9-9ed9-44ec-9bbf-0600bb589fbb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMF2DBuffer
    {
        [PreserveSig]
        HRESULT Lock2D(/* [annotation][out] _Outptr_result_bytebuffer_(_Inexpressible_(ComputePlaneSize(*plPitch))) */ out byte[] ppbScanline0, /* [annotation][out] _Out_ */ out int plPitch);
        
        [PreserveSig]
        HRESULT Unlock2D();
        
        [PreserveSig]
        HRESULT GetScanline0AndPitch(/* [annotation][out] _Out_ */ out IntPtr pbScanline0, /* [annotation][out] _Out_ */ out int plPitch);
        
        [PreserveSig]
        HRESULT IsContiguousFormat(/* [annotation][out] _Out_ */ out bool pfIsContiguous);
        
        [PreserveSig]
        HRESULT GetContiguousLength(/* [annotation][out] _Out_ */ out uint pcbLength);
        
        [PreserveSig]
        HRESULT ContiguousCopyTo(/* [annotation][size_is][out] _Out_writes_bytes_(cbDestBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbDestBuffer, /* [in] */ int cbDestBuffer);
        
        [PreserveSig]
        HRESULT ContiguousCopyFrom(/* [annotation][size_is][in] _In_reads_bytes_(cbSrcBuffer) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbSrcBuffer, /* [in] */ int cbSrcBuffer);
    }
}
