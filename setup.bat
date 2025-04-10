
@echo off
setlocal enabledelayedexpansion

echo Running Unity DLL Setup Script...

call helpers\check_git.bat || goto :error
call helpers\check_branch.bat || goto :error
call helpers\sync_branch.bat || goto :error
call helpers\build_project.bat || goto :error
call helpers\commit_experimental.bat || goto :error
call helpers\test_and_commit_concrete.bat || goto :error

echo Setup complete!
goto :eof

:error
echo An error occurred during setup. Exiting...
exit /b 1
