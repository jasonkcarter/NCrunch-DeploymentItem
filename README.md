NCrunch-DeploymentItem
======================

Demo of a test configuration utilizing MSTest a DeploymentItem that passes in VS and Resharper, but fails in NCrunch.

*Instructions*
- Pull the repository
- Open DeploymentItemProject.sln using Visual Studio 2010, 2012, or 2013
- Enable NCrunch and do not ignore any test projects (if it's not already enabled)
- Notice that the one test fails
- Open the Test->Test Explorer (VS 2012/13) or Test->Windows->Test List (VS 2010) windows.
- Run the one test and notice that it passes.
- If you have Resharper installed, run the test with its test runner as well, and notice that it passes.
