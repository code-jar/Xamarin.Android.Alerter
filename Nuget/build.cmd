set Version=6.1.0

msbuild ../Alerter.Bind/Alerter.Bind.csproj /t:Rebuild /p:Configuration=Release

nuget pack Alerter.Bind.nuspec -Version %Version%