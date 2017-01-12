## Quickstart:
1) Download SenseNet Community Edition Source package from CodePlex
<br />link: [sensenet654-community-source](http://sensenet.codeplex.com/downloads/get/1586700)
2) Extract it to .\SenseNetSource folder (without creating a sub directory)
3) Open command prompt in .\Scripts and run init-all.bat
<br /> NOTE: working directory needs to be .\Scripts
4) Create an IIS site and app pool for WebApi project
<br /> name: TodoAppWebApi
<br />binding: todoAppWebApi
<br />.NET CLR Version: v4.0
<br />Identity: *local admin account*
<br />Disable Overlapped Recycle: true
5) Add host entry (C:\Windows\System32\drivers\etc\hosts)
<br />127.0.0.1 todoAppWebApi
6) Open [http://todoappwebapi/api/hello](http://todoappwebapi/api/hello)