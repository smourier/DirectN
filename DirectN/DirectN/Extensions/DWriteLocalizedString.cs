namespace DirectN
{
    public class DWriteLocalizedString
    {
        public string LocaleName { get; set; }
        public string String { get; set; }

        public override string ToString() => String + " (" + LocaleName + ")";
    }
}
