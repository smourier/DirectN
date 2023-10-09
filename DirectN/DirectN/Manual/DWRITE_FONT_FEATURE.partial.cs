namespace DirectN
{
    public partial struct DWRITE_FONT_FEATURE
    {
        public DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG tag, uint parameter = 1)
        {
            nameTag = tag;
            this.parameter = parameter;
        }
    }
}
