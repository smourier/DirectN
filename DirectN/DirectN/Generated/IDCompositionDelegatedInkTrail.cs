// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c2448e9b-547d-4057-8cf5-8144ede1c2da"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionDelegatedInkTrail
    {
        [PreserveSig]
        HRESULT AddTrailPoints(/* THIS_ _In_reads_(inkPointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DCompositionInkTrailPoint[] inkPoints, int inkPointsCount, /* _Out_ */ out uint generationId);
        
        [PreserveSig]
        HRESULT AddTrailPointsWithPrediction(/* THIS_ _In_reads_(inkPointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DCompositionInkTrailPoint[] inkPoints, int inkPointsCount, /* _In_reads_(predictedInkPointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DCompositionInkTrailPoint[] predictedInkPoints, int predictedInkPointsCount, /* _Out_ */ out uint generationId);
        
        [PreserveSig]
        HRESULT RemoveTrailPoints(uint generationId);
        
        [PreserveSig]
        HRESULT StartNewTrail(ref _D3DCOLORVALUE color);
    }
}
