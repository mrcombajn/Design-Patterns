namespace DesignPatterns.Patterns.Singleton
{
    public class Pope
    {
        #region Fields

        private static Pope? _pope;
        private string _name;

        #endregion

        #region Constructors and Deconstructors

        private Pope(string _name)
        {
            this._name = _name;
        }

        #endregion

        #region Public Methods

        public void DoPopeThings()
        {
            Console.WriteLine("Doing pope things.");
        }

        public override string ToString()
        {
            return $"{this._name}";
        }

        public static Pope GetInstace(string name)
        {
            if(_pope == null)
            {
                _pope = new Pope(name);
            }
            return _pope;
        }

        #endregion
    }
}
