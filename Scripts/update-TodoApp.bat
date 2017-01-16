@echo OFF 
set OLDDIR=%CD%
cd ..\WebApi
echo Clearing App_Data/LuceneIndex...
del .\App_Data\LuceneIndex /Q /S
del .\App_Data\LuceneIndex_backup /Q /S
cd .\Tools
md ..\Root\System\Schema
Import.exe -SOURCE ..\Root -TARGET /Root -SCHEMA ..\Root\System\Schema -ASM ..\bin
IndexPopulator.exe -ASM ..\bin
chdir /d %OLDDIR% &rem restore current directory