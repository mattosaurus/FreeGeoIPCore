# FreeGeoIPCore
A .NET Core client for accessing IP location details at <a href="https://freegeoip.net" alt="freegeoip.net">freegeoip.net</a>.

# Installation
To use FreeGeoIPCore in your C# project, you can either download the FreeGeoIPCore C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package FreeGeoIPCore
```
Once you have the FreeGeoIPCore libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using FreeGeoIPCore.Models;
```
# Usage
This is intended for usage in .NET Core projects, there is a limit of 10,000 calls per hour on the API.

An IP address can be looked up and a location object returned by the following method.

```C#
        public static void Main(string[] args)
        {
            FreeGeoIPClient client = new FreeGeoIPClient();
            Location location = client.GetLocation({IPADDRESS}).Result;
        }
```
