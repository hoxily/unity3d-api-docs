@set csccmd=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
@cd UnityEngine
%csccmd% /nologo /nowarn:1591 /t:library /out:bin\Debug\UnityEngine.dll /doc:bin\Debug\UnityEngine.xml *.cs Internal\*.cs
@pause