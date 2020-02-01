# APITestAutomation
Base Project to test API using C# HTTPClient

## Pre-requisite ##
Visual Studio 2015 or higher
Windows 10 OS

## Key Libraries used in Project ##
### Core Libraries Used ###
--------------
Microsoft.AspNet.WebApi.Client V5.2.7
NewtonSoft.JSON v12.0.3

Programming Language: C#
Testing Framework: MS Test


## Structure of the Solution ##

The Solution is divided into four major sections as below:
### AcceptanceCriteria ###
### Helpers ###
### Validators ###
### Tests ###


## Coverage ##

## Executing Tests and analysing results ##
* Clone or copy the solution from the above repo on your machine.
* Open the solution in Visual Studio (version as specified in Pre-requisites)
* Right click the solution and build it. It will download all the dependencies.
* Open the Test menu in Visual studio and select Windows=> Test Explorer
* It will show the configured 3 tests in the system
* In test explorer window click on Run all it will run the tests.
* For viewing the test results click on the test and look for output link to see the details of results/validations.

## Key Features ##
* Easy to manage acceptance test criteria
* Short and crisp test cases
* Test cases are easy to understand 
* Can be easily extended further
* Reusable Components

## Known Issues ##
Some times MS test soutions doesnot shows up tests or not run, easy workaround is to clean and rebuild the solution. Even if this doesnot work then just update the MSTest.TestFramework and MSTest.TestAdapter package in nuget manager.
