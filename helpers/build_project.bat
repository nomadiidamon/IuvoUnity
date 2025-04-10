
@echo off
echo Building the DLL with CMake...

if not exist build mkdir build

cmake -S . -B build -G "Visual Studio 17 2022" -A x64
if %errorlevel% neq 0 exit /b 1

cmake --build build --config Release
if %errorlevel% neq 0 exit /b 1

exit /b 0
