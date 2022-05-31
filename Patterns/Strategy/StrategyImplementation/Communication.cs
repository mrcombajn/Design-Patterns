namespace DesignPatterns.Patterns.Strategy
{
    #region Using Statements
    #endregion
    public class Communication
    {
        #region Fields
        private CommunicationStrategy _strategy;
        #endregion

        #region Public Methods
        public void SetStrategy(CommunicationStrategy _strategy)
        {
            this._strategy = _strategy;
        }

        public void InvokeStrategy()
        {
            _strategy.Communicate();
        }
        #endregion
    }
}
