set Version=7.0.1

msbuild ../Alerter.Bind/Alerter.Bind.csproj /t:Rebuild /p:Configuration=Release

nuget pack Alerter.Bind.nuspec -Version %Version%