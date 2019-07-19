// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1effectauthor.h(391,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Indicates support for features which are optional on D3D10 feature levels. This may be populated using CheckFeatureSupport.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS
    {
        public bool computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;
    }
}
