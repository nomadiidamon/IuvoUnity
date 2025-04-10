
@echo off
for /f "delims=" %%i in ('git symbolic-ref --short HEAD 2^>nul') do set branch=%%i

if not defined branch (
    echo Not on a valid git branch.
    exit /b 1
)

echo Current branch: %branch%

REM Rename main to Release
git rev-parse --verify main >nul 2>&1
if %errorlevel%==0 git branch -m main Release

REM Create branches if they don't exist
git show-ref --verify --quiet refs/heads/Experimental || git branch Experimental
git show-ref --verify --quiet refs/heads/Concrete || git branch Concrete

exit /b 0
