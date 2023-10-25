namespace DesignPatterns.Patterns.Builder.BuilderImplementationViaSetters
{
    public class ComputerImpl : AbstractComputer
    {

        #region Constructors and Deconstructors
        public ComputerImpl(string _processor, string _motherboard, string _psu)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
        }

        public ComputerImpl(string _processor, string _motherboard, string _psu, string _graphicCard, string _keyboard, string _mouse, int _ram_size)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._graphicCard = _graphicCard;
            this._keyboard = _keyboard;
            this._mouse = _mouse;
            this._ram_size = _ram_size;
        }

        public ComputerImpl(string _processor, string _motherboard, string _psu, string _graphicCard, int _ram_size, int _number_of_fans, bool _cd_rom)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._graphicCard = _graphicCard;
            this._ram_size = _ram_size;
            this._cd_rom = _cd_rom;
        }

        public ComputerImpl(string _processor, string _motherboard, string _psu, int _ram_size, bool _cd_rom)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._ram_size = _ram_size;
            this._cd_rom = _cd_rom;
        }

        public ComputerImpl(string _processor, string _motherboard, string _psu, int _ram_size)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._ram_size = _ram_size;
        }

        public ComputerImpl(string _processor, string _psu, string _graphicCard, string _mouse)
        {
            this._processor = _processor;
            this._psu = _psu;
            this._graphicCard = _graphicCard;
            this._mouse = _mouse;
        }

        #endregion

        #region Public Methods 
        /// <summary>
        /// To String Method.
        /// </summary>
        /// <returns> Description of Computer class. </returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
