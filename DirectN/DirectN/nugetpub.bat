rmdir nupkg /Q /S
nuget pack -Build -OutputDirectory nupkg -properties Configuration=Release
nuget push nupkg\*.nupkg -Source https://api.nuget.org/v3/index.json