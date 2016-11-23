# XReader

> Code Assessment for Outsurance.

![](http://i.imgur.com/JYN76xl.png)

### Notes

  - Output/result files are available in the root folder (*out1.csv*, *out2.csv*).
  - Unit tests were created but are not complete.

### Setup
  - Before you can run the solution, be sure to set your input/output paths in *progam.cs*. Also please make sure you have sufficient privileges (Admin) for the directory you will be writing to.
  
### About testing
Tests were created using Intellitest available since Visual Studio 2015. Usually, I would create tests manually, but one can't write tests for scenarios and border cases you do not know exist -- therefore its more effective to rely on a tool such as PEX to help discover execution paths and determine various input data which may break your solution in production.

I have provided sample tests (as created by Intellitest) for the IO component. File read/write tasks are usually troublesome, so I thought this would add value.

For a production environment the tests would not be sufficient.

### Logging
Logging was not implemented. Exceptions can be thrown from within IO (the component that was tested), but in production one would probably want to handle those exceptions gracefully by logging them to a file in order to provide the user with a better experience.

### Folder structure
Within the solution, tests are placed inside a Solution Folder (`_`). This is to keep them separate and always easily visible. On disk however, the tests projects can be found in the `\qa` folder.

### Domain
In this domain I could identify only one domain entity (DDD) -- `Record`. `Record` may hold information related to a person, but in this context, system users (or Business) will only refer to it as 'a record'. Terms such as these should be recorded in a document (Ubiquitous language) and used to communicate with Business.

### Design
From a design perspective, I aimed for a loosely coupled design which would abide by the SOLID principles. I introduced interfaces for all components, which will help with testing (especially mocking) and Inversion of Control. 

The initial design had one more additional component (not in the final solution) for hosting the sorting algorithms. The reason for this was because such functionality could easily be hosted within micro-services where they would have the ability to scale independently. I eventually discarded the idea since from within this context it may seem like the solution was over-engineered. 

Right now, all the different components are instantiated via the Console app (Runner), but in a production environment one should use a IoC container such as Windsor to help manage dependencies.
<br /><br/><br/>
**For any question, please do not hesitate to contact me.**
