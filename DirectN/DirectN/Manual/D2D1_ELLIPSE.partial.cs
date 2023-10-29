namespace DirectN
{
    public partial struct D2D1_ELLIPSE
    {
        public D2D1_ELLIPSE(float x, float y, float radius)
            : this(x, y, radius, radius)
        {
        }

        public D2D1_ELLIPSE(float x, float y, float radiusX, float radiusY)
        {
            this.point = new D2D_POINT_2F(x, y);
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }

        public D2D1_ELLIPSE(D2D_POINT_2F point, float radius)
            : this(point, radius, radius)
        {
        }

        public D2D1_ELLIPSE(D2D_POINT_2F point, float radiusX, float radiusY)
        {
            this.point = point;
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }
    }
}
