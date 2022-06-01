namespace DesignPatterns.Patterns.Builder
{
    abstract public class AbstractComputer
    {
        #region Fields
        protected string? _processor;
        protected string? _graphicCard;
        protected string? _motherboard;
        protected int? _diskCapacity;
        protected string? _psu;
        protected string? _keyboard;
        protected string? _mouse;
        protected int _numberOfFans;
        protected int _ram_size;
        protected bool _cd_rom;
        #endregion

        #region Getters and Setters
        public string? Processor { get; set; }
        public string? GraphicCard { get; set; }
        public string? Motherboard { get; set; }
        public int DiskCapacity { get; set; }
        public string? Keyboard { get; set; }
        public string? Mouse { get; set; }
        public string? Psu { get; set; }
        public int NumberOfFans { get; set; }
        public int Ram_size { get; set; }
        public bool Cd_rom { get; set; }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            return $"Processor: {_processor}, " +
                   $"Graphic card: {_graphicCard}, " +
                   $"Motherboard: {_motherboard}, " +
                   $"Disks capacity: {_diskCapacity}, " +
                   $"PSU: {_psu}, " +
                   $"Keyboard: {_keyboard}, " +
                   $"Mouse: {_mouse}, " +
                   $"Number of fans: {_numberOfFans}, " +
                   $"RAM size: {_ram_size}, " +
                   $"CD-ROM: {_cd_rom}";
        }
        #endregion
    }
}
