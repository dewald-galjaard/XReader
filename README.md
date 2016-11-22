# XReader

![](http://i.imgur.com/JYN76xl.png)

#### Notes

  - Output/Result files are available in the root folder.
  - Unit tests were created but are not complete.

#### Setup
  - Before you can run the solution, be sure to set your input/output paths in *progam.cs*
  
#### About testing
Tests was created using Intellitest. Usually I would create tests manually, but one can't write tests for scenarios you do not know exist -- therefore its more effective to rely on a tool such as PEX to help discover execution paths and determine various input data.

I have provided sample tests (as created by Intellitest) for the IO component. File read/write tasks are usually troublesome, so I thought this would add value.

For a production environment the tests would not be sufficient.

#### Folder structure
Within the solution tests are placed inside a solution folder `_`. This is to keep them seperate and always at the top. On disk however, the projects can be found under `\qa`.

#### Domain
For this specific example I could identify only one domain entity from a DDD perspective `Record`. Record may hold information related to a persons, but in this context, users will only refer to it as a 'Record'.


