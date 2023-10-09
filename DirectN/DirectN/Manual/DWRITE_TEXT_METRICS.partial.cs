namespace DirectN
{
    public partial struct DWRITE_TEXT_METRICS
    {
        public override string ToString() => "L=" + left + ",T=" + top + ",W=" + widthIncludingTrailingWhitespace + ",H=" + height + ",LW=" + layoutWidth + ",LH=" + layoutHeight + ",C=" + lineCount;
    }
}
