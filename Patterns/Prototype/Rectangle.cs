namespace DesignPatterns.Patterns.Prototype
{
    public class Rectangle : Shape
    {
        #region Fields
        private int _width;
        private int _height;
        #endregion

        #region Constructors
        public Rectangle(int _x, int _y, string _color, int _width, int _height) : base(_x, _y, _color)
        {
            this._width = _width;
            this._height = _height;
        }

        private Rectangle(Rectangle rectangle) : base(rectangle)
        {
            this._width = rectangle._width;
            this._height = rectangle._height;
        }
        #endregion

        #region Public Methods
        public override Cloneable Clone()
        {
            return new Rectangle(this);
        }
    }
}
