cmake_minimum_required(VERSION 3.16)
project(UnitySubmoduleDLL LANGUAGES CSharp)

file(GLOB_RECURSE SRC_FILES "src/*.cs")
add_library(UnitySubmoduleDLL SHARED ${SRC_FILES})
set_target_properties(UnitySubmoduleDLL PROPERTIES
    OUTPUT_NAME "UnitySubmodule"
)

enable_testing()
file(GLOB_RECURSE TEST_FILES "tests/*.cs")
add_executable(UnityTests ${TEST_FILES})
add_test(NAME AllTests COMMAND UnityTests)
