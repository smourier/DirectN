namespace DirectN
{
    public enum D2D1_LINE_JOIN
    {
        D2D1_LINE_JOIN_MITER = 0,

        /// <summary>
        /// Bevel join.
        /// </summary>
        D2D1_LINE_JOIN_BEVEL = 1,

        /// <summary>
        /// Round join.
        /// </summary>
        D2D1_LINE_JOIN_ROUND = 2,

        /// <summary>
        /// Miter/Bevel join.
        /// </summary>
        D2D1_LINE_JOIN_MITER_OR_BEVEL = 3,
    }
}
