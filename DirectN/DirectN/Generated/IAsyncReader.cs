// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(7859,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868aa-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAsyncReader
    {
        [PreserveSig]
        HRESULT RequestAllocator(/* [in] */ IMemAllocator pPreferred, /* [annotation][in] _In_ */ ref _AllocatorProperties pProps, /* [annotation][out] _Out_ */ out IMemAllocator ppActual);
        
        [PreserveSig]
        HRESULT Request(/* [in] */ IMediaSample pSample, /* [in] */ IntPtr dwUser);
        
        [PreserveSig]
        HRESULT WaitForNext(/* [in] */ uint dwTimeout, /* [annotation][out] _Out_opt_ */ out IMediaSample ppSample, /* [annotation][out] _Out_ */ out IntPtr pdwUser);
        
        [PreserveSig]
        HRESULT SyncReadAligned(/* [in] */ IMediaSample pSample);
        
        [PreserveSig]
        HRESULT SyncRead(/* [in] */ long llPosition, /* [in] */ int lLength, /* [annotation][size_is][out] _Out_writes_bytes_(lLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pBuffer);
        
        [PreserveSig]
        HRESULT Length(/* [annotation][out] _Out_ */ out long pTotal, /* [annotation][out] _Out_ */ out long pAvailable);
        
        [PreserveSig]
        HRESULT BeginFlush();
        
        [PreserveSig]
        HRESULT EndFlush();
    }
}
