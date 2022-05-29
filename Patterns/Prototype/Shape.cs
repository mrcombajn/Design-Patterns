namespace DesignPatterns.Patterns.Prototype
{
    #region Using Statements
    #endregion
    public abstract class Shape : Cloneable
    {
        #region Fields
        protected int _x;
        protected int _y;
        protected string? _color;
        #endregion

        #region Constructors
        public Shape(int _x, int _y, string _color)
        {
            _x = _x;
            _y = _y;
            _color = _color;
        }

        public Shape(Shape s)
        {
            this._x = s._x;
            this._y = s._y;
            this._color = s._color;
        }
        #endregion

        #region Public Methods
        public abstract Cloneable Clone();
        #endregion
    }
}
