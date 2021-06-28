// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(394,9)
namespace DirectN
{
    /// <summary>
    /// This determines what gamma is used for interpolation/blending.
    /// </summary>
    public enum D2D1_GAMMA1
    {
        /// <summary>
        /// Colors are manipulated in 2.2 gamma color space.
        /// </summary>
        D2D1_GAMMA1_G22 = 0,
        
        /// <summary>
        /// Colors are manipulated in 1.0 gamma color space.
        /// </summary>
        D2D1_GAMMA1_G10 = 1,
        
        /// <summary>
        /// Colors are manipulated in ST.2084 PQ gamma color space.
        /// </summary>
        D2D1_GAMMA1_G2084 = 2,
        
        /// <summary>
        /// Colors are manipulated in ST.2084 PQ gamma color space.
        /// </summary>
        D2D1_GAMMA1_FORCE_DWORD = -1,
    }
}
