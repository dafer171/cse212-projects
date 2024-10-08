using System.ComponentModel;

public class FeatureCollection
{
    //public string Type { get; set; }
    //public Metadata Metadata { get; set; }
    public Feature[] Features { get; set; }
}
public class Metadata
{
    public long Generated { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public int? Status { get; set; }
    public string Api { get; set; }
    public int? Count { get; set; }
}

public class Feature
{
    //public string Type { get; set; }
    public Properties Properties { get; set; }
    //public Geometry Geometry { get; set; }
    //public string Id { get; set; }
}

public class Properties
{
    public float Mag { get; set; }
    public string Place { get; set; }
    //public long Time { get; set; }
    //public long Updated { get; set; }
    //public string Tz { get; set; }
    //public string Url { set; get; }
    //public string Detail { get; set; }
    //public string Felt { get; set; }
    //public string Cdi { get; set; }
    //public string Mmi { get; set; }
    //public string Alert { get; set; }
    //public string Status { get; set; }
    //public long? Tsunami { get; set; }
    //public long? Sig { get; set; }
    //public string Net { get; set; }
    //public string Code { get; set; }
    //public string Ids { get; set; }
    //public string Sources { get; set; }
    //public string Types { get; set; }
    //public long? Nst { get; set; }
    //public float? Dmin { get; set; }
    //public float? Rms { get; set; }
    //public long? Gap { get; set; }
    //public string magType { get; set; }
    //public string type { get; set; }
    //public string title { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public double[] Coordinates { get; set; }
}
