
@echo off
for /f "delims=" %%i in ('git symbolic-ref --short HEAD 2^>nul') do set branch=%%i

if "%branch%"=="Experimental" (
    git add .
    git commit -m "Auto-commit: Build successful on Experimental"
    git push origin Experimental
) else (
    echo Not on Experimental branch. Skipping auto-commit.
)

exit /b 0
