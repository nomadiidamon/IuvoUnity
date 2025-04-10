
@echo off
for /f "delims=" %%i in ('git symbolic-ref --short HEAD 2^>nul') do set branch=%%i

git fetch origin

git rev-parse origin/%branch% >nul 2>&1
if %errorlevel% neq 0 (
    echo No remote branch found for %branch%. Skipping sync.
    exit /b 0
)

for /f "delims=" %%i in ('git rev-parse %branch%') do set LOCAL=%%i
for /f "delims=" %%i in ('git rev-parse origin/%branch%') do set REMOTE=%%i

if not "!LOCAL!" == "!REMOTE!" (
    echo Pulling latest changes from origin/%branch%...
    git pull origin %branch%
) else (
    echo Branch %branch% is already up to date.
)

exit /b 0
