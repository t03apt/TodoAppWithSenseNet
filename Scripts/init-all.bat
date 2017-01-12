@echo OFF 
set OLDDIR=%CD%
call init-VsDevCmd.bat
call build-SenseNet.bat
call install-SenseNet.bat
call copy-SenseNetReferences.bat
call build-TodoApp.bat
call update-TodoApp.bat
chdir /d %OLDDIR% &rem restore current directory