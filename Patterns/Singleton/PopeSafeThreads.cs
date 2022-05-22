namespace DesignPatterns.Patterns.Singleton
{
    internal class PopeSafeThreads
    {
        #region Fields

        private static PopeSafeThreads _pope;
        private static int _popeId = 0;

        private static readonly object _lock = new object();

        private string _name;

        #endregion

        #region Constructors and Deconstructors

        private PopeSafeThreads(string _name)
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

        public static PopeSafeThreads GetInstace()
        {
            lock (_lock)
            {
                if (_pope == null)
                {
                    _pope = new PopeSafeThreads("John Paul II");
                    _popeId++;
                }
                return _pope;
            }
        }

        #endregion
    }
}
