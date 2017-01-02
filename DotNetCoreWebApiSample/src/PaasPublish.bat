@echo off
dotnet restore ".\DotNetCoreWebApiSample\project.json"

dotnet publish ".\DotNetCoreWebApiSample" --framework netcoreapp1.0 --output "D:\Sajan\SampleApplications\ADNext\DotNETCore\DotNetCoreWebApiSample\src\Output" --configuration Release

"C:\Program Files\IIS\Microsoft Web Deploy V3\msdeploy.exe" -verb:sync -source:contentPath="D:\Sajan\SampleApplications\ADNext\DotNETCore\DotNetCoreWebApiSample\src\Output" -dest:contentPath='DotnetCoreWebApiSample',ComputerName="https://dotnetcorewebapisample.scm.azurewebsites.net/msdeploy.axd",UserName="$DotnetCoreWebApiSample",Password="Qp4yMCgQP43SLpDY4QyfAG9o34tdBlePL0scduhzGMhu0n8SEZ5R5XMctguL",IncludeAcls="False",AuthType="Basic" -enablerule:AppOffline -enableRule:DoNotDeleteRule -retryAttempts:20 -verbose
