# DH_Auto_Test
This contains an automation framework to drive a test-website for DH

# Preconditions

Install Visual Studio 2017.

Run Visual Studio 2017

Git-clone the project and make it visible on Visual Studio

SpecFlow package must be installed on Visual Studio project via NuGet manager (right click on project \ Manage Nuget packages, then look for the names and install).

.NET framework 4 must be installed on Visual Studio project via NuGet manager.

Selenium 3 framework must be installed on Visual Studio project via NuGet manager.

# Test Machine

Windows 7 Professional Service Pack 1.

Chrome 68.0.3440.106 (latest release version).

# Execution of the tests

Build the project by right clicking on DH_Auto_Test_Exercise \ Build.

Open the Test Explorer on Visual Studio by hitting 'Test' from the menu; then click on Windows / Test Explorer.
The Test Explorer window will open.

Then click on 'Run all' to run all the tests, or simply right click one of the test scenarios and click on 'Run selected tests'. There is also the possibility of clicking on the 'Run tests in parallel' icon to run the test cases in parallel.

Wait until tests are run. Chrome will be web-driven and shown on screen along the test actions.

When automation is done, the report with the results will show up on the Test Explorer window.

# Improvements for the project

Using MSTest to execute tests from command line and trigger them from a CI tool.

Using a Test Runner to organise the execution of the tests by tagging.

Using Page Factory to find elements with ease.
