namespace DirectN
{
    public sealed class ImmersiveColor
    {
        internal ImmersiveColor(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public string Name { get; }
        public int Code { get; }
        public _D3DCOLORVALUE Color { get; internal set; }
    }
}
