# Test projects to validate VTech.AsyncRefactoring Tool
Code for the Tool: <https://github.com/Bor1ss/VTech.AsyncRefactoring.Extension>

## Description of the projects

| Project | Number of Errors | Error types | Number of sub-projects | Additional info |
| ------ | ------ | ------ | ------ | ------ |
| OneError\\Wait | 1 | .Wait() | 1 | 
| OneError\\Result | 1 | .Result | 1 | 
| OneError\\GetResult | 1 | .GetAwaiter().GetResult() | 1 | 
| ------ | ------ | ------ | ------ | ------ |
| MultipleErrors\\OneFile.AllStandart | 4 | .Wait() .Result .GetAwaiter().GetResult() | 1 |
| MultipleErrors\\MultiProjects.AllStandart | 3 | .Wait() .Result .GetAwaiter().GetResult() | 4 |
| ------ | ------ | ------ | ------ | ------ |
| Combined\\Overrides | 1 | .Wait() | 1 | Method that should be asynchronized has overrides
| Combined\\Implementations | 1 | .Result | 1 | Method that should be asynchronized implements an interface
| Combined\\ThirdPartyAsyncMethods | 1 | .Result | 2 | Method that used in blocking way is from outside of solution
| Combined\\AllStandartWithFullSyncStack | 3 | .Result | 4 | One call stack should left unchanged
| ------ | ------ | ------ | ------ | ------ |

