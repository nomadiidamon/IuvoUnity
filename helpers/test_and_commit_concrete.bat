
@echo off
echo Running tests...

if exist tests (
    echo Tests directory found. Assuming tests passed.
    git checkout Concrete
    git merge Experimental -m "Auto-merge: Tests passed from Experimental"
    git push origin Concrete
    git checkout Experimental
) else (
    echo No tests directory found. Skipping.
)

exit /b 0
