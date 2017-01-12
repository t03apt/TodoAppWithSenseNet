@echo OFF 
REM call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat" x86
echo "Starting NuGet restore..."
call "..\.nuget\NuGet.exe" restore "..\TodoApp.sln"
echo .  
echo "Starting build..."
devenv "..\TodoApp.sln" /build Debug 
echo . 
echo "All builds completed." 