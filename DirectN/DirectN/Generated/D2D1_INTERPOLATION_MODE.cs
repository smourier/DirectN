// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(242,9)
namespace DirectN
{
    /// <summary>
    /// This is used to specify the quality of image scaling with ID2D1DeviceContext::DrawImage and with the 2D Affine Transform Effect.
    /// </summary>
    public enum D2D1_INTERPOLATION_MODE
    {
        D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
        D2D1_INTERPOLATION_MODE_LINEAR = 1,
        D2D1_INTERPOLATION_MODE_CUBIC = 2,
        D2D1_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR = 3,
        D2D1_INTERPOLATION_MODE_ANISOTROPIC = 4,
        D2D1_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC = 5,
        D2D1_INTERPOLATION_MODE_FORCE_DWORD = -1,
    }
}
