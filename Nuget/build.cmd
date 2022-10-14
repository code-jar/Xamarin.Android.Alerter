set Version=7.2.4

msbuild ../Alerter.Bind/Alerter.Bind.csproj /t:Rebuild /p:Configuration=Release

nuget pack Alerter.Bind.nuspec -Version %Version%