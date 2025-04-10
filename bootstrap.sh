#!/bin/bash
set -e

source ./scripts/utilities.sh

echo "🔧 Unity DLL Git/CMake Automation Template"
echo "------------------------------------------"

# Ensure branches
echo "📁 Setting up branches..."
git checkout main 2>/dev/null || git checkout Release
git branch -m Release 2>/dev/null || true
ensure_branch_exists Experimental
ensure_branch_exists Concrete

# Sync branch
echo "🔄 Syncing current branch..."
sync_branch

# Configure + build project
echo "🏗️  Building project with CMake..."
mkdir -p build && cd build
cmake ..
cmake --build .

# Auto-commit to Experimental
cd ..
auto_commit_to_experimental

# Run tests and commit to Concrete if successful
test_and_commit_to_concrete

echo "✅ Done. Manual promotion to Release when ready."
