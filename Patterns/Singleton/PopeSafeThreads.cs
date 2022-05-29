namespace DesignPatterns.Patterns.Singleton
{
    internal class PopeSafeThreads
    {
        #region Fields
        private static PopeSafeThreads? _pope;
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
            return $"{this._name}.";
        }

        public static PopeSafeThreads GetInstace(string name)
        {
            lock (_lock)
            {
                if (_pope == null)
                {
                    _pope = new PopeSafeThreads(name);
                }
                return _pope;
            }
        }
        #endregion
    }
}
