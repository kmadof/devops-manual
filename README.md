# devops-manual
Playground for various Azure DevOps options


 - [Cross stage variables](http://thecodemanual.pl/2020/05/05/cross-stage-variables.html) - describes how to use variables across the stages. This is useful to evaluate go/no go decision for next stages/jobs in your YAML builds.
 - [Caching npm modules](http://thecodemanual.pl/2020/03/11/caching-not-only-nuget-packages-on-azure-devops.html#caching-npm-modules) - describes hot to cache npm modules and show difference between `npm install` and `npm ci`


 ## Stackoverflow questions:

 - pipeline 08 - creating nuget package with nuspec file
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(8)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=101&branchName=master)
 - pipeline 37 - issue with passing connection to kubernetes via variable - shows limitation of Azure DevOps
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-37?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=64&branchName=master)
 - [pipeline 55](https://stackoverflow.com/questions/63941345/set-variable-group-dynamically-using-system-pullrequest-targetbranch/63946930#63946930) - explains that System.PullRequest.* (apart for IsFork) can't be used in template expressions
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-55?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=115&branchName=master)
 - pipeline 59 - breaking pipeline through `exit 1`
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-59?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=105&branchName=master)