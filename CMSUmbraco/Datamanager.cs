namespace CMSUmbraco
{
    public class Root
    {
        public List<Station> Stations { get; set; }
    }
    public class Station
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public Coordinates coordinates { get; set; }
        public double rating { get; set; }  
        public bool paid { get; set; }  


    }

    public class Coordinates
    {
        public double latitute { get; set; }
        public double lonitute { get; set; }
    }
    public class Datamanager
    {
        public static async Task<Root> GetStationsAsync()
        {
            HttpClient client = new HttpClient();

            Root? data = await client.GetFromJsonAsync<Root>("http://gaddr.co/ios/stations");
            return data;
        }
    }
}
