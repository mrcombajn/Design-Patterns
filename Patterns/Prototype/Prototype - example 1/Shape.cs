namespace DesignPatterns.Patterns.Prototype.Prototype___example_1
{
    #region Using Statements
    #endregion
    public abstract class Shape : Cloneable
    {
        #region Fields
        
        protected int x;
        protected int y;
        protected string? color;
        
        #endregion

        #region Constructors
        protected Shape(int x, int y, string color)
        {
            x = x;
            y = y;
            color = color;
        }

        protected Shape(Shape s)
        {
            this.x = s.x;
            this.y = s.y;
            this.color = s.color;
        }
        #endregion

        #region Public Methods
        
        public abstract Cloneable Clone();
        
        #endregion
    }
}
