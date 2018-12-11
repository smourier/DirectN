namespace DirectN
{
    public partial struct D2D_SIZE_F
    {
        public D2D_SIZE_F(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString() => "W=" + width + ",H=" + height;
    }
}
