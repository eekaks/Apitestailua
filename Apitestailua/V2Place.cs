using System;
using System.Collections.Generic;
using System.Threading.Tasks;


public class V2Places
{
    public Meta meta { get; set; }
    public List<V2Place> data { get; set; }
    public Tag[] tagsarray { get; set; }
}

public class Meta
{
    public string count { get; set; }
}
public class V2Place
{
    public string id { get; set; }
    public Name name { get; set; }
    public Sourcetype? sourceType { get; set; }
    public string infoUrl { get; set; }
    public DateTime modifiedAt { get; set; }
    public Location location { get; set; }
    public Description description { get; set; }
    public Tag[] tags { get; set; }
    public string[] extra_searchwords { get; set; }
    public string openingHoursUrl { get; set; }
}

public class Name
{
    public string fi { get; set; }
    public string en { get; set; }
    public string sv { get; set; }
    public string zh { get; set; }
}

public class Sourcetype
{
}

public class Location
{
    public double? lat { get; set; }
    public double? lon { get; set; }
    public Address address { get; set; }
}


public class Address
{
    public string streetAddress { get; set; }
    public string postalCode { get; set; }
    public string locality { get; set; }
    public string neighbourhood { get; set; }
}

public class Description
{
    public string intro { get; set; }
    public string body { get; set; }
    public Image[] images { get; set; }
}

public class Image
{
    public string url { get; set; }
    public string copyrightHolder { get; set; }
    public Licensetype? licenseType { get; set; }
    public string media_id { get; set; }
}

public class Licensetype
{
    public int? id { get; set; }
    public string? name { get; set; }
}

public class Tag
{
    public string id { get; set; }
    public string name { get; set; }
}

