// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Indicates whether shader support for doubles is present on the underlying hardware. This may be populated using CheckFeatureSupport.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_FEATURE_DATA_DOUBLES
    {
        public bool doublePrecisionFloatShaderOps;
    }
}
