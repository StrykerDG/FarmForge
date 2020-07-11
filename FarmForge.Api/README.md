# FarmForge.Api
The FarmForge.Api folder contains all of the components that combine to create the FarmForge "system," including the api, datamodel, and migrations.

# FarmForge.Api Setup
The steps below outline how you can get the central FarmForge system up and running.

## appsettings.json structure
You must have an appsettings.json that defines the settings used by FarmForge. The appsettings.json file should be formatted as such:

```
{
    "ApiSettings": {
        "MajorVersion": X,
        "MinorVersion": Y,
        "SwaggerSettings": {
            "Title": "<API Title>",
            "Description": "<API Description>",
            "TermsOfService": "<API Terms of Service>",
            "ContactName": "<API Contact Name>",
            "ContactEmail": "<API Contact Email>",
            "ContactURL": "<API Contact Website>",
            "LicenseName": "<API License Name>",
            "LicenseURL": "<API License URL>"
        },
        "ConnectionStrings": {
            "Database": "Data Source=<DatabaseName.db>;"
        }
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
        }
    },
    "AllowedHosts": "*"
}
```

## Common
Regardless of where you are deploying FarmForge, the following steps must be completed first.

1. Clone [FarmForge](https://github.com/StrykerDG/FarmForge) to your local system.
2. Create an appsettings.json file that mimics the structure above.

## Local (IIS) Deployment
Follow these steps when deploying FarmForge to a machine using IIS

## Local (Raspberry Pi) Deployment
Follow these steps when deploying to a Raspberry Pi

### Requirements
1. Visual Studio
2. Windows 10 IoT Core Dashboard
3. Raspberry Pi 3 or newer
4. PostMan

### Install Windows10 IoT Core
Coming Soon

### Install FarmForge
1. In FarmForge.Api/FarmForge.Api/FarmForge.Api.csproj, uncomment the following line
```
<RuntimeIdentifier>win8-arm</RuntimeIdentifier>
```
3. Build the Release solution via Visual Studio
4. Publish the FarmForge.Api project to a folder profile
5. Open Windows explorer and navigate to the Raspberry Pi's C:\ drive
6. Create a FarmForge directory
7. Copy the contents of the publish folder on your local machine to the Raspberry Pi's C:\FarmForge Directory
8. Open the IoT Dashboard and find your device
9. From "Actions," choose "Launch Powershell"
10. From the Powershell window, enter the following to open port 5000
```
netsh advfirewall firewall add rule name="ASP.NET Core Web Server port" dir=in action=allow protocol=TCP localport=5000
```

### Run FarmForge
1. Open the IoT Dashboard and find your device
2. From "Actions," choose "Launch Powershell"
3. Navigate to C:\FarmForge
3. Enter the following to start the API
```
.\FarmForge.api.exe --urls http://*:5000
```
5. Verify the api is running and accessible by sending the following request via postman
```
http://{deviceIp}:5000/Api/v1.0/Device
```
The response should be
```
{
    "devices": []
}
```