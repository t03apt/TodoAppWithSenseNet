## Quickstart:
1) Read: [http://wiki.sensenet.com/How_to_install_Sense/Net_from_source_package_(IIS_7.5_and_IIS_7.0)]()
2) Install [MSBuild Extension Pack](http://www.msbuildextensionpack.com)
3) Download SenseNet Community Edition Source package from CodePlex
<br />Link: [sensenet654-community-source](http://sensenet.codeplex.com/downloads/get/1586700)
4) Extract it to .\SenseNetSource folder (without creating a sub directory)
5) Create alias: MySenseNetContentRepositoryDatasource
<br />See: [How to set up database connection](http://wiki.sensenet.com/How_to_install_Sense/Net_from_source_package_(IIS_7.5_and_IIS_7.0)#5._Set_up_database_connection)
6) Open command prompt in .\Scripts and run init-all.bat
<br /> NOTE: working directory needs to be .\Scripts
7) Create an IIS site and app pool for WebApi project
<br /> name: TodoAppWebApi
<br />binding: todoAppWebApi
<br />.NET CLR Version: v4.0
<br />Identity: *local admin account*
<br />Disable Overlapped Recycle: true
8) Add host entry (C:\Windows\System32\drivers\etc\hosts)
<br />127.0.0.1 todoAppWebApi
9) Open [http://todoappwebapi/api/hello]()