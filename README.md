# Unity DLL Submodule Automation Template

This project bootstraps your Unity-compatible DLL project with:

- 🏗️ Auto DLL building via CMake
- 🚀 Auto-commits to `Experimental` after successful builds
- ✅ Auto merges to `Concrete` after passing tests
- 🔒 Manual promotion to `Release`

## Setup

1. Put your `.cs` files into `src/`, and tests into `tests/`
2. Make sure Git is initialized with remote set
3. Run:

```bash
./setup
```

## Notes

- `setup` handles all build, test, and commit logic.
- `scripts/utilities.sh` contains reusable Git+CMake helpers.
- Adjust `CMakeLists.txt` and `helpers` as needed for other submodules.
