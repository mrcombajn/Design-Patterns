using System;

namespace DesignPatterns.Patterns.Singleton.Singleton_Lazy_Initialization_example
{
    public class Singleton_Lazy
    {
        #region Fields

        private static Singleton_Lazy? instance;

        #endregion

        #region Constructors and Deconstructors

        private Singleton_Lazy()
        {
        }

        #endregion
        
        #region Public Methods

        
        public static Singleton_Lazy GetInstace()
        {
            if (instance == null)
            {
                instance = new Singleton_Lazy();
            }

            return instance;
        }

        #endregion
    }
}
