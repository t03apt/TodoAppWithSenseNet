# This repository is used for experimental purposes.

## 1. Set up todoAppWebApi project:
1. Read: <http://wiki.sensenet.com/How_to_install_Sense/Net_from_source_package_(IIS_7.5_and_IIS_7.0)>
2. Install [MSBuild Extension Pack](http://www.msbuildextensionpack.com)
3. Download SenseNet Community Edition Source package from CodePlex
<br />Link: [sensenet654-community-source](http://sensenet.codeplex.com/downloads/get/1586700)
4. Extract it to .\SenseNetSource folder (without creating a sub directory)
5. Create alias: MySenseNetContentRepositoryDatasource
<br />See: [How to set up database connection](http://wiki.sensenet.com/How_to_install_Sense/Net_from_source_package_(IIS_7.5_and_IIS_7.0)#5._Set_up_database_connection)
6. Open command prompt in .\Scripts and run init-all.bat
<br /> NOTE: working directory needs to be .\Scripts
7. Create an IIS site and app pool for WebApi project
    * name: TodoAppWebApi
    * binding: todoAppWebApi
    * .NET CLR Version: v4.0
    * Identity: *local admin account*
    * Disable Overlapped Recycle: true
8. Add host entry (C:\Windows\System32\drivers\etc\hosts)
<br />127.0.0.1 todoAppWebApi
9. Browse <http://todoappwebapi/api/hello>

## 2. Set up WebUI site with reverse proxy
1. Install prerequisites
    * <https://www.iis.net/downloads/microsoft/url-rewrite>
    * <https://www.iis.net/downloads/microsoft/application-request-routing>
2. Create an IIS site and app pool for WebUI project
    * name: TodoAppWeb
    * binding: todoAppWeb
    * .NET CLR Version: v4.0
    * Identity: *local admin account*
3. Add host entry (C:\Windows\System32\drivers\etc\hosts)
<br />127.0.0.1 todoAppWeb
4. Browse:
    * <http://todoappweb/>
    * <http://todoappweb/api/hello>
    * <http://todoappweb/OData.svc/('Root')>
