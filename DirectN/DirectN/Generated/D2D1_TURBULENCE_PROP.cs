// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effects.h(700,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Turbulence effect's top level properties. Effect description: Generates a bitmap based on the Perlin noise turbulence function.
    /// </summary>
    public enum D2D1_TURBULENCE_PROP
    {
        /// <summary>
        /// Property Name: "Offset" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_TURBULENCE_PROP_OFFSET = 0,
        
        /// <summary>
        /// Property Name: "Size" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_TURBULENCE_PROP_SIZE = 1,
        
        /// <summary>
        /// Property Name: "BaseFrequency" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_TURBULENCE_PROP_BASE_FREQUENCY = 2,
        
        /// <summary>
        /// Property Name: "NumOctaves" Property Type: UINT32
        /// </summary>
        D2D1_TURBULENCE_PROP_NUM_OCTAVES = 3,
        
        /// <summary>
        /// Property Name: "Seed" Property Type: INT32
        /// </summary>
        D2D1_TURBULENCE_PROP_SEED = 4,
        
        /// <summary>
        /// Property Name: "Noise" Property Type: D2D1_TURBULENCE_NOISE
        /// </summary>
        D2D1_TURBULENCE_PROP_NOISE = 5,
        
        /// <summary>
        /// Property Name: "Stitchable" Property Type: BOOL
        /// </summary>
        D2D1_TURBULENCE_PROP_STITCHABLE = 6,
        
        /// <summary>
        /// Property Name: "Stitchable" Property Type: BOOL
        /// </summary>
        D2D1_TURBULENCE_PROP_FORCE_DWORD = -1,
    }
}
