// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(219,9)
namespace DirectN
{
    /// <summary>
    /// Represents filtering modes transforms may select to use on their input textures.
    /// </summary>
    public enum D2D1_FILTER
    {
        D2D1_FILTER_MIN_MAG_MIP_POINT = 0,
        D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR = 1,
        D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 4,
        D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR = 5,
        D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT = 16,
        D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 17,
        D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT = 20,
        D2D1_FILTER_MIN_MAG_MIP_LINEAR = 21,
        D2D1_FILTER_ANISOTROPIC = 85,
        D2D1_FILTER_FORCE_DWORD = -1,
    }
}
