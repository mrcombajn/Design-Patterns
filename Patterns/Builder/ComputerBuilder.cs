namespace DesignPatterns.Patterns.Builder
{
    public class ComputerBuilder
    {
        #region Fields
        private string? _processor;
        private string? _graphic_card;
        private string? _motherboard;
        private string? _disks_capacity;
        private string? _psu;
        private string? _keyboard;
        private string? _mouse;
        private int _number_of_fans;
        private int _ram_size;
        private bool _cd_rom;
        #endregion

        #region Constructors and Deconstructors
        public ComputerBuilder ()
        {
        }
        #endregion

    }
}
