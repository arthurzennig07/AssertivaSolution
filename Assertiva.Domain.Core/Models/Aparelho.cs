namespace Assertiva.Domain.Core;

public record Aparelho
{
    public Guid Id { get; set; }
    
    
    
}

public record AndroidDeviceInfo : Aparelho
{
    public string uuid { get; set; }
    public string model { get; set; }
    public string deviceOSVersion { get; set; }
    public string manufacturer { get; set; }
    public bool isAndroid { get; set; }
    
}

/*
    String id;
    String uuid;
    String model;
    String deviceOSVersion;
    String manufacturer;
    bool isAndroid = false;
    bool isIos = false;
    AndroidDeviceInfo androidInfo;
    IosDeviceInfo iosInfo;
 * 
 */