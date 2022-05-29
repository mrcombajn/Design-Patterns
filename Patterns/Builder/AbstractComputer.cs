namespace DesignPatterns.Patterns.Builder
{
    abstract public class AbstractComputer
    {
        #region Fields
        protected string? _processor;
        protected string? _graphic_card;
        protected string? _motherboard;
        protected string? _disks_capacity;
        protected string? _psu;
        protected string? _keyboard;
        protected string? _mouse;
        protected int _number_of_fans;
        protected int _ram_size;
        protected bool _cd_rom;
        #endregion

        #region Getters and Setters
        public string? Processor { get; set; }
        public string? Graphic_card { get; set; }
        public string? Motherboard { get; set; }
        public string? Keyboard { get; set; }
        public string? Mouse { get; set; }
        public int Number_of_fans { get; set; }
        public int Ram_size { get; set; }
        public bool Cd_rom { get; set; }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            return $"Processor: {_processor}, " +
                   $"Graphic card: {_graphic_card}, " +
                   $"Motherboard: {_motherboard}, " +
                   $"Disks capacity: {_disks_capacity}, " +
                   $"PSU: {_psu}, " +
                   $"Keyboard: {_keyboard}, " +
                   $"Mouse: {_mouse}, " +
                   $"Number of fans: {_number_of_fans}, " +
                   $"RAM size: {_ram_size}, " +
                   $"CD-ROM: {_cd_rom}";
        }
        #endregion
    }
}
