namespace DirectN
{
    public partial struct D2D_SIZE_U
    {
        public D2D_SIZE_U(uint width, uint height)
        {
            this.width = width;
            this.height = height;
        }

        public D2D_SIZE_U(int width, int height)
        {
            this.width = (uint)width;
            this.height = (uint)height;
        }

        public override string ToString() => "W=" + width + ",H=" + height;
    }
}
