// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(231,9)
namespace DirectN
{
    /// <summary>
    /// Specifies the algorithm that is used when images are scaled or rotated. Note Starting in Windows 8, more interpolations modes are available. See D2D1_INTERPOLATION_MODE for more info.
    /// </summary>
    public enum D2D1_BITMAP_INTERPOLATION_MODE
    {
        /// <summary>
        /// Nearest Neighbor filtering. Also known as nearest pixel or nearest point sampling.
        /// </summary>
        D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
        
        /// <summary>
        /// Linear filtering.
        /// </summary>
        D2D1_BITMAP_INTERPOLATION_MODE_LINEAR = 1,
        
        /// <summary>
        /// Linear filtering.
        /// </summary>
        D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD = -1,
    }
}
