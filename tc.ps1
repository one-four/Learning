$id = 9032
$f = 'c:\temp\xxx.exe'
$l='c:\\temp\\log';
'Hello' | ac $l;
while ($true) {
if ((gps -Id $id -ea SilentlyContinue).Id -eq $id) { sleep -m 200 }
else { del $f -ea SilentlyContinue; exit }}
