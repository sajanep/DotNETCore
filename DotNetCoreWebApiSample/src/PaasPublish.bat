@echo off
dotnet restore ".\DotNetCoreWebApiSample\project.json"

rmdir /S /Q D:\Sajan\SampleApplications\ADNext\DotNETCore\DotNetCoreWebApiSample\src\Output

dotnet publish ".\DotNetCoreWebApiSample" --framework netcoreapp1.0 --output "D:\Sajan\SampleApplications\ADNext\DotNETCore\DotNetCoreWebApiSample\src\Output" --configuration Release

"C:\Program Files\IIS\Microsoft Web Deploy V3\msdeploy.exe" -verb:sync -source:contentPath="D:\Sajan\SampleApplications\ADNext\DotNETCore\DotNetCoreWebApiSample\src\Output" -dest:contentPath='DotnetCoreWebApiSample',ComputerName="https://dotnetcorewebapisample.scm.azurewebsites.net/msdeploy.axd",UserName="$DotnetCoreWebApiSample",Password="<YourPassword>",IncludeAcls="False",AuthType="Basic" -enablerule:AppOffline -enableRule:DoNotDeleteRule -retryAttempts:20 -verbose
