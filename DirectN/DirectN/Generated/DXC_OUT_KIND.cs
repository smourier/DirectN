// generated from <Windows SDK Path>\um\dxcapi.h
namespace DirectN
{
    /// <summary>
    /// Specifies the kind of output to retrieve from a IDxcResult.
    /// </summary>
    public enum DXC_OUT_KIND
    {
        /// <summary>
        /// No output.
        /// </summary>
        DXC_OUT_NONE = 0,
        
        /// <summary>
        /// IDxcBlob - Shader or library object.
        /// </summary>
        DXC_OUT_OBJECT = 1,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide.
        /// </summary>
        DXC_OUT_ERRORS = 2,
        
        /// <summary>
        /// IDxcBlob.
        /// </summary>
        DXC_OUT_PDB = 3,
        
        /// <summary>
        /// IDxcBlob - DxcShaderHash of shader or shader with source info (-Zsb/-Zss).
        /// </summary>
        DXC_OUT_SHADER_HASH = 4,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - from Disassemble.
        /// </summary>
        DXC_OUT_DISASSEMBLY = 5,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - from Preprocessor or Rewriter.
        /// </summary>
        DXC_OUT_HLSL = 6,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - other text, such as -ast-dump or -Odump.
        /// </summary>
        DXC_OUT_TEXT = 7,
        
        /// <summary>
        /// IDxcBlob - RDAT part with reflection data.
        /// </summary>
        DXC_OUT_REFLECTION = 8,
        
        /// <summary>
        /// IDxcBlob - Serialized root signature output.
        /// </summary>
        DXC_OUT_ROOT_SIGNATURE = 9,
        
        /// <summary>
        /// IDxcExtraOutputs - Extra outputs.
        /// </summary>
        DXC_OUT_EXTRA_OUTPUTS = 10,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - text directed at stdout.
        /// </summary>
        DXC_OUT_REMARKS = 11,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - text directed at stdout.
        /// </summary>
        DXC_OUT_TIME_REPORT = 12,
        
        /// <summary>
        /// IDxcBlobUtf8 or IDxcBlobWide - text directed at stdout.
        /// </summary>
        DXC_OUT_TIME_TRACE = 13,
        
        /// <summary>
        /// Last value for a counter.
        /// </summary>
        DXC_OUT_LAST = 13,
        DXC_OUT_NUM_ENUMS = 14,
        DXC_OUT_FORCE_DWORD = -1,
    }
}
