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
This namespace contains classes related to acceptance criteria(CategoryDetailsAcceptance) and the locator class for the same( CategoryDetailsLocators).
The AcceptanceCriteria class takes all the requested criterias and the locator class locates the requested acceptance criteria using JsonPath.
It defines testdata and locates the elements using JsonPath 

### Helpers ###
* APIHelper class
This is a Core Library and Reusable class.
This is responsible for creatting the request and extracting and processing the response

* ConfiguratorManagerHelper class
This class reads the keys from appconfig 

### Validators ###
It validates the Acceptance Criteria given in the acceptance criteria class(es) using locator class(es) in the given API response.

### Tests ###
This namespace contains actual API tests based on acceptance criteria. It contains a class VerifyCategoryDetailsAPI with following Tests:
* VerifyCategoryName() - Validating categoryName Property having value Carbon credits.
* VerifyCategorysCanReListPropertyValue() -Validating CanReList Property is true.
* VerifyDescriptionForPromotionElementWithNameGallery() - Validating if description associated with Promotion element contains 2x larger image.

## Key Features ##
* Easy to manage acceptance test criteria
* Short and crisp test cases
* Test cases are easy to understand 
* Can be easily extended further
* Reusable Components
* Using JsonPath for validating the Response data, which reduces significant time and complexity in writing the code.

## Coverage ##
* Currently supporting simple HTTPClient GET Request and Response
* Only supporting application/JSON Content-Type
* Validation of string based elements in the Response.

## Executing Tests and analysing results ##
* Clone or copy the solution from the above repo on your machine.
* Open the solution in Visual Studio (version as specified in Pre-requisites)
* Right click the solution and build it. It will download all the dependencies.
* Open the Test menu in Visual studio and select Windows=> Test Explorer
* It will show the configured 3 tests in the system
* In test explorer window click on Run all it will run the tests.
* For viewing the test results click on the test and look for output link to see the details of results/validations.

## Known Issues ##
Some times MS test solutions does not shows up tests or not run, easy workaround is to clean and rebuild the solution. Even if this does not work then just update the MSTest.TestFramework and MSTest.TestAdapter package in nuget manager.
