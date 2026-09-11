<p align="center">
    <img src="https://github.com/user-attachments/assets/47207406-db16-4703-82a1-f3cab59da1f9" width="200" height="200" />
</p>

[![Build and Publish](https://github.com/kris701/CargoWiseReportTemplateCreator/actions/workflows/dotnet.yml/badge.svg)](https://github.com/kris701/CargoWiseReportTemplateCreator/actions/workflows/dotnet.yml)
![Nuget](https://img.shields.io/nuget/v/CargoWiseReportTemplateCreator)
![Nuget](https://img.shields.io/nuget/dt/CargoWiseReportTemplateCreator)
![GitHub last commit (branch)](https://img.shields.io/github/last-commit/kris701/CargoWiseReportTemplateCreator/main)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/kris701/CargoWiseReportTemplateCreator)
![Static Badge](https://img.shields.io/badge/Platform-Windows-blue)
![Static Badge](https://img.shields.io/badge/Platform-Linux-blue)
![Static Badge](https://img.shields.io/badge/Framework-dotnet--10.0-green)

# CargoWise Replication API Table Generator

This is a little tool to generate different data models from the CargoWise replication API responses.
Its really so that you dont have to manually write the definition each time.
This can also be used with my [Replication API Toolset](https://github.com/kris701/CargoWiseReplicationAPIInterface) for making data models.


It is packaged on the [NuGet Package Manager](https://www.nuget.org/packages/CargoWiseReplicationAPITableGenerator/) as a dotnet tool, so you can install it by writing `dotnet tool install CargoWiseReplicationAPITableGenerator` into a terminal.
You can then use the tool by writing `cwreplicationapitablegen` in a terminal.

There are two generators right now, one for C# and one for TSQL.
You use them as follows:

```powershell
cwreplicationapitablegen csharp -i input.json -n some_namespace -o ./
cwreplicationapitablegen tsql -i input.json -s dbo -o ./
```

The `input.json` file must be the direct result from querying a replication APIs `https://.../Services/api/replication/change-detail` endpoint!

The output file will be called whatever the input files table name is.
