@echo OFF 
REM call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat" x86
echo "Starting NuGet restore..."
call "..\.nuget\NuGet.exe" restore "..\SenseNetSource\Source\SenseNet\SenseNetCommunity.sln"
echo .  
echo "Starting build..."
devenv "..\SenseNetSource\Source\SenseNet\SenseNetCommunity.sln" /build Debug 
echo . 
echo "All builds completed." 