cmake_minimum_required(VERSION 3.16)

set(PROJECT_NAME IuvoUnity)
project(${PROJECT_NAME} NONE) # Set NONE since we're not using a native language

# Custom target to build the .csproj using dotnet CLI
add_custom_target(${PROJECT_NAME}_build ALL
    COMMAND dotnet build ${CMAKE_CURRENT_SOURCE_DIR}/src/IuvoUnity.csproj
    WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}/src
)

# Optional: set the Visual Studio startup project and organize folders
if(WIN32)
    set_property(DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR} 
        PROPERTY VS_STARTUP_PROJECT ${PROJECT_NAME}_build)
    set_property(GLOBAL PROPERTY USE_FOLDERS ON)
endif()

# Set output name (though this won't affect dotnet output)
set_target_properties(${PROJECT_NAME}_build PROPERTIES
    OUTPUT_NAME "IuvoUnitySubmodule"
)

# Unit testing setup (manually run tests with dotnet CLI)
enable_testing()
file(GLOB_RECURSE TEST_FILES "tests/*.cs")
# You can create another dotnet test project instead of using add_executable
# Example (manual): dotnet test tests/IuvoUnity.Tests.csproj

# Post-build Git auto-commit
add_custom_command(TARGET ${PROJECT_NAME}_build POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E echo "Running Git commands..."
    COMMAND ${CMAKE_COMMAND} -E env bash -c "
        git add --all && 
        git commit -a -m 'auto commit' && 
        git push || { 
            echo '**********************************************************************'; 
            echo '*************** AUTO COMMIT FAILED! LOGIN TO GITHUB!******************';
            echo '**********************************************************************'; 
        }"
    WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}
    VERBATIM USES_TERMINAL
)
