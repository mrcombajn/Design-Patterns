using DesignPatterns.Patterns.Prototype.Prototype___example_1;

namespace DesignPatterns.Patterns.Prototype
{
    #region Using Statements
    #endregion
    public class Circle : Shape
    {
        #region Fields
        private int _radius;
        #endregion

        #region Constructors
        public Circle(int _x, int _y, string _color, int _radius) : base(_x, _y, _color)
        {
            this._radius = _radius;
        }
        
        private Circle(Circle circle) : base(circle)
        {
            this._radius = circle._radius;
        }
        #endregion

        #region Public Methods
        public override Cloneable Clone()
        {
            return new Circle(this);
        }
        #endregion
    }
}
