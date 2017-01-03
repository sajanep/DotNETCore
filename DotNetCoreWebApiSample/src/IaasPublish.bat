@echo off
dotnet restore ".\DotNetCoreWebApiSample\project.json"

rmdir /S /Q C:\Sajan\DotNetCoreWebApiSample\src\Output

dotnet publish ".\DotNetCoreWebApiSample" --framework netcoreapp1.0 --output "C:\Sajan\DotNetCoreWebApiSample\src\Output" --configuration Release