#!/bin/bash

ensure_branch_exists() {
    local branch=$1
    if ! git show-ref --verify --quiet refs/heads/$branch; then
        echo "Creating branch $branch"
        git branch $branch
    fi
}

sync_branch() {
    local branch=$(git branch --show-current)
    git fetch origin
    LOCAL=$(git rev-parse $branch)
    REMOTE=$(git rev-parse origin/$branch)

    if [ "$LOCAL" != "$REMOTE" ]; then
        echo "Updating local $branch"
        git pull origin $branch
    else
        echo "$branch is up to date."
    fi
}

auto_commit_to_experimental() {
    echo "Committing build to Experimental branch..."
    git checkout Experimental
    git add .
    git commit -m "Auto-commit: Successful build"
    git push origin Experimental
}

test_and_commit_to_concrete() {
    echo "Running tests..."
    ctest --output-on-failure

    if [ $? -eq 0 ]; then
        echo "Tests passed! Merging into Concrete..."
        git checkout Concrete
        git merge Experimental --no-edit
        git push origin Concrete
    else
        echo "Tests failed. Skipping merge."
    fi
}
