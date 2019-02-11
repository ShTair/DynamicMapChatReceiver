namespace DynamicMapChatReceiver.Models
{
    public class ConfigurationModel
    {
        public float updaterate { get; set; }
        public int chatlengthlimit { get; set; }
        public Component[] components { get; set; }
        public World[] worlds { get; set; }
        public int confighash { get; set; }
        public string spammessage { get; set; }
        public string defaultmap { get; set; }
        public string msgchatrequireslogin { get; set; }
        public string msghiddennamejoin { get; set; }
        public string title { get; set; }
        public bool grayplayerswhenhidden { get; set; }
        public string quitmessage { get; set; }
        public int defaultzoom { get; set; }
        public bool allowwebchat { get; set; }
        public bool allowchat { get; set; }
        public string sidebaropened { get; set; }
        public float webchatinterval { get; set; }
        public string msgchatnotallowed { get; set; }
        public bool loggedin { get; set; }
        public string coreversion { get; set; }
        public string joinmessage { get; set; }
        public bool webchatrequireslogin { get; set; }
        public string showlayercontrol { get; set; }
        public bool loginenabled { get; set; }
        public int maxcount { get; set; }
        public string dynmapversion { get; set; }
        public string msgmaptypes { get; set; }
        public bool cyrillic { get; set; }
        public string msghiddennamequit { get; set; }
        public string msgplayers { get; set; }
        public string webprefix { get; set; }
        public bool showplayerfacesinmenu { get; set; }
        public string defaultworld { get; set; }
    }

    public class Component
    {
        public string spawnlabel { get; set; }
        public bool spawnbedhidebydefault { get; set; }
        public string spawnbedformat { get; set; }
        public bool showworldborder { get; set; }
        public string type { get; set; }
        public bool showlabel { get; set; }
        public string offlineicon { get; set; }
        public bool showspawnbeds { get; set; }
        public bool showofflineplayers { get; set; }
        public string spawnbedicon { get; set; }
        public bool offlinehidebydefault { get; set; }
        public string offlinelabel { get; set; }
        public bool enablesigns { get; set; }
        public string defaultsignset { get; set; }
        public string spawnicon { get; set; }
        public int offlineminzoom { get; set; }
        public int spawnbedminzoom { get; set; }
        public bool showspawn { get; set; }
        public string spawnbedlabel { get; set; }
        public int maxofflinetime { get; set; }
        public bool allowurlname { get; set; }
        public bool focuschatballoons { get; set; }
        public bool showplayerfaces { get; set; }
        public bool sendbutton { get; set; }
        public int messagettl { get; set; }
        public bool hidebydefault { get; set; }
        public bool showplayerhealth { get; set; }
        public bool showplayerbody { get; set; }
        public string label { get; set; }
        public bool smallplayerfaces { get; set; }
        public int layerprio { get; set; }
        public bool showdigitalclock { get; set; }
        public bool showmcr { get; set; }
        public bool hidey { get; set; }
    }

    public class World
    {
        public int sealevel { get; set; }
        public bool _protected { get; set; }
        public Map[] maps { get; set; }
        public int extrazoomout { get; set; }
        public Center center { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public int worldheight { get; set; }
    }

    public class Center
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Map
    {
        public float inclination { get; set; }
        public bool nightandday { get; set; }
        public string imageformat { get; set; }
        public string shader { get; set; }
        public string compassview { get; set; }
        public string prefix { get; set; }
        public object icon { get; set; }
        public int scale { get; set; }
        public float azimuth { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string lighting { get; set; }
        public object backgroundday { get; set; }
        public bool bigmap { get; set; }
        public float[] maptoworld { get; set; }
        public bool _protected { get; set; }
        public string background { get; set; }
        public int mapzoomout { get; set; }
        public int boostzoom { get; set; }
        public string name { get; set; }
        public object backgroundnight { get; set; }
        public string perspective { get; set; }
        public int mapzoomin { get; set; }
        public float[] worldtomap { get; set; }
    }

}
