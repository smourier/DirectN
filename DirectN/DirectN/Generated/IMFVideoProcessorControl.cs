﻿// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a3f675d5-6119-4f7f-a100-1d8b280f0efb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoProcessorControl
    {
        [PreserveSig]
        HRESULT SetBorderColor(/* optional(_MFARGB) */ IntPtr pBorderColor);
        
        [PreserveSig]
        HRESULT SetSourceRectangle(/* optional(tagRECT) */ IntPtr pSrcRect);
        
        [PreserveSig]
        HRESULT SetDestinationRectangle(/* optional(tagRECT) */ IntPtr pDstRect);
        
        [PreserveSig]
        HRESULT SetMirror(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_MIRROR eMirror);
        
        [PreserveSig]
        HRESULT SetRotation(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_ROTATION eRotation);
        
        [PreserveSig]
        HRESULT SetConstrictionSize(/* optional(tagSIZE) */ IntPtr pConstrictionSize);
    }
}
