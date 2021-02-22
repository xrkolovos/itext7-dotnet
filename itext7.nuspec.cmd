Powershell.exe -File .\delete_obj_bin.ps1

dotnet build .\iTextCore.netstandard.sln --configuration Release

.\nuget.exe pack .\itext7.nuspec