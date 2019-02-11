namespace DynamicMapChatReceiver.Models
{
    public class UpdateModel
    {
        public int currentcount { get; set; }
        public bool hasStorm { get; set; }
        public Player[] players { get; set; }
        public bool isThundering { get; set; }
        public int confighash { get; set; }
        public int servertime { get; set; }
        public Update[] updates { get; set; }
        public long timestamp { get; set; }
    }

    public class Player
    {
        public string world { get; set; }
        public int armor { get; set; }
        public string name { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public float health { get; set; }
        public float z { get; set; }
        public int sort { get; set; }
        public string type { get; set; }
        public string account { get; set; }
    }

    public class Update
    {
        public string type { get; set; }
        public string playerName { get; set; }
        public string account { get; set; }
        public long timestamp { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public string message { get; set; }
        public string channel { get; set; }
    }
}
