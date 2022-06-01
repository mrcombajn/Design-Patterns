namespace DesignPatterns.Patterns.Builder
{
    public class ComputerBuilder
    {
        #region Fields
        private string? _processor;
        private string? _graphicCard;
        private string? _motherboard;
        private int _diskCapacity;
        private string? _psu;
        private string? _keyboard;
        private string? _mouse;
        private int _numberOfFans;
        private int _ramSize;
        private bool _cdRom;
        #endregion


        #region Constructors and Deconstructors
        public ComputerBuilder()
        {
        }
        #endregion


        public ComputerBuilder SetProcessor(string _processor)
        {
            this._processor = _processor;
            return this;
        }


        public ComputerBuilder SetGraphicCard(string _graphicCard)
        {
            this._graphicCard = _graphicCard;
            return this;
        }


        public ComputerBuilder SetDiskCapacity(int _diskCapacity)
        {
            this._diskCapacity = _diskCapacity;
            return this;
        }


        public ComputerBuilder SetPsu(string _psu)
        {
            this._psu = _psu;
            return this;
        }


        public ComputerBuilder SetKeyboard(string _keyboard)
        {
            this._keyboard = _keyboard;
            return this;
        }


        public ComputerBuilder SetMouse(string _mouse)
        {
            this._mouse = _mouse;
            return this;
        }


        public ComputerBuilder SetNumberOfFans(int _numberOfFans)
        {
            this._numberOfFans = _numberOfFans;
            return this;
        }


        public ComputerBuilder SetRamSize(int _ramSize)
        {
            this._ramSize = _ramSize;
            return this;
        }


        public ComputerBuilder SetCdRom(bool _cdRom)
        {
            this._cdRom = _cdRom;
            return this;
        }


        public Computer build()
        {
            Computer build = new Computer();
            build.Processor = _processor;
            build.GraphicCard = _graphicCard;
            build.Motherboard = _motherboard;
            build.DiskCapacity = _diskCapacity;
            build.Psu = _psu;
            build.Keyboard = _keyboard;
            build.Mouse = _mouse;
            build.NumberOfFans = _numberOfFans;
            build.Ram_size = _ramSize;
            build.Cd_rom = _cdRom;


            return build;
        }
    }
}

