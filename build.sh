cd UnityEngine
mkdir -p bin/Debug
mcs /langversion:4 /nowarn:1591 /t:library /out:bin/Debug/UnityEngine.dll /doc:bin/Debug/UnityEngine.xml /recurse:'*.cs'
