@echo OFF 
md "..\WebApi\Admin\bin"
xcopy /s/Y "..\SenseNetSource\Source\SenseNet\WebSite\Admin\bin" "..\WebApi\Admin\bin"