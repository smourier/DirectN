// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(2364,1)
namespace DirectN
{
    /// <summary>
    /// Condition at the edges of inline object or text used to determine line-breaking behavior.
    /// </summary>
    public enum DWRITE_BREAK_CONDITION
    {
        /// <summary>
        /// Whether a break is allowed is determined by the condition of the neighboring text span or inline object.
        /// </summary>
        DWRITE_BREAK_CONDITION_NEUTRAL = 0,
        
        /// <summary>
        /// A break is allowed, unless overruled by the condition of the neighboring text span or inline object, either prohibited by a May Not or forced by a Must.
        /// </summary>
        DWRITE_BREAK_CONDITION_CAN_BREAK = 1,
        
        /// <summary>
        /// There should be no break, unless overruled by a Must condition from the neighboring text span or inline object.
        /// </summary>
        DWRITE_BREAK_CONDITION_MAY_NOT_BREAK = 2,
        
        /// <summary>
        /// The break must happen, regardless of the condition of the adjacent text span or inline object.
        /// </summary>
        DWRITE_BREAK_CONDITION_MUST_BREAK = 3,
    }
}
