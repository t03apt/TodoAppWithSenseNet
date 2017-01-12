@echo OFF 
set OLDDIR=%CD%
cd "..\SenseNetSource\Deployment"
call "InstallSenseNet.bat"
chdir /d %OLDDIR% &rem restore current directory