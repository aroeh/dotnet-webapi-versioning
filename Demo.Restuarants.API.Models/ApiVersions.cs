namespace Demo.Restuarants.API.Models;

public static class ApiVersions
{
    public const string Latest = V3;
    public const string QueryParamVersion = $"?api-version={Latest}";

    public const string V1 = "1.0";
    public const string V2 = "2.0";
    public const string V3 = "3.0";

    public static string[] AllVersions => [
        V1,
        V2,
        V3
    ];
}
