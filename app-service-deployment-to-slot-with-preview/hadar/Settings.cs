namespace hadar
{
    public class Settings
    {
        public const string Key = "Settings";

        public string ValueFromConfig { get; set; }

        public string ValueFromConfigProduction { get; set; }

        public string ValueFromConfigSlot { get; set; }

        public string ValueOnlyOnProd { get; set; }

        public string ValueOnlyOnSlot { get; set; }
    }
}