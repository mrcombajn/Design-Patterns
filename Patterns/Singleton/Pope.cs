namespace DesignPatterns.Patterns.Singleton
{
    public class Pope
    {
        #region Fields

        private static Pope _pope;
        private static int _popeId = 0;
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
            return string.Format($"{0} number {1}", _name, _popeId);
        }

        public static Pope GetInstace()
        {
            if(_pope == null)
            {
                _pope = new Pope("John Paul II");
                _popeId++;
            }
            return _pope;
        }

        #endregion
    }
}
