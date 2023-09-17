using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public partial struct D3D12_INPUT_ELEMENT_DESC : IDisposable
    {
        public void Dispose()
        {
            if (SemanticName != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(SemanticName);
                SemanticName = IntPtr.Zero;
            }
        }
    }
}
