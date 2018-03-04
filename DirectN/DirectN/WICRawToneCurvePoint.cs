using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICRawToneCurvePoint
    {
        public double Input;
        public double Output;
    }

    // note: WICRawToneCurve is not defined since is of variable size
}
