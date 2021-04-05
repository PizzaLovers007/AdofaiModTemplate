SETLOCAL ENABLEDELAYEDEXPANSION
set /p version=<VERSION.txt
mkdir tmp
cd tmp
mkdir MyAdofaiMod
cp ../Info.json MyAdofaiMod
cp ../MyAdofaiMod/bin/Release/MyAdofaiMod.dll MyAdofaiMod

cd MyAdofaiMod
for /f "delims=" %%a in (Info.json) do (
    SET s=%%a
    SET s=!s:$VERSION=%version%!
    echo !s!
)>>"InfoChanged.json"
rm Info.json
mv InfoChanged.json Info.json
cd ..

tar -a -c -f MyAdofaiMod-%version%.zip MyAdofaiMod
mv MyAdofaiMod-%version%.zip ..
cd ..
rm -rf tmp
pause