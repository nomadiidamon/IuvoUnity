
@echo off
where git >nul 2>&1
if %errorlevel% neq 0 (
    echo Git is not installed or not in PATH.
    exit /b 1
)
exit /b 0
