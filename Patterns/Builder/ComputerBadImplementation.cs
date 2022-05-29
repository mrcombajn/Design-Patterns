﻿namespace DesignPatterns.Patterns.Builder
{
    public class ComputerBadImplementation : AbstractComputer
    {

        #region Constructors and Deconstructors
        public ComputerBadImplementation(string _processor, string _motherboard, string _psu)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
        }

        public ComputerBadImplementation(string _processor, string _motherboard, string _psu, string _graphic_card, string _keyboard, string _mouse, int _ram_size)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._graphic_card = _graphic_card;
            this._keyboard = _keyboard;
            this._mouse = _mouse;
            this._ram_size = _ram_size;
        }

        public ComputerBadImplementation(string _processor, string _motherboard, string _psu, string _graphic_card, int _ram_size, int _number_of_fans, bool _cd_rom)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._graphic_card = _graphic_card;
            this._ram_size = _ram_size;
            this._cd_rom = _cd_rom;
        }

        public ComputerBadImplementation(string _processor, string _motherboard, string _psu, int _ram_size, bool _cd_rom)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._ram_size = _ram_size;
            this._cd_rom = _cd_rom;
        }

        public ComputerBadImplementation(string _processor, string _motherboard, string _psu, int _ram_size)
        {
            this._processor = _processor;
            this._motherboard = _motherboard;
            this._psu = _psu;
            this._ram_size = _ram_size;
        }

        public ComputerBadImplementation(string _processor, string _psu, string _graphic_card, string _mouse)
        {
            this._processor = _processor;
            this._psu = _psu;
            this._graphic_card = _graphic_card;
            this._mouse = _mouse;
        }

        #endregion
    }
}
