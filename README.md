# devops-manual
Playground for various Azure DevOps options


 - [Cross stage variables](http://thecodemanual.pl/2020/05/05/cross-stage-variables.html) - describes how to use variables across the stages. This is useful to evaluate go/no go decision for next stages/jobs in your YAML builds.
 - [Caching npm modules](http://thecodemanual.pl/2020/03/11/caching-not-only-nuget-packages-on-azure-devops.html#caching-npm-modules) - describes hot to cache npm modules and show difference between `npm install` and `npm ci`
 - Caching ruby gems - simple ruby gems cache base son built in task
 - [Gated checkin for .net core](http://thecodemanual.pl/2020/03/26/gated-check-in-build-on-azure-devops-for-dotnet-core-app.html) - shows how to create pipeline which serves as gated checkin policy</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=5&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=6&branchName=master)
 - [Gated checkin for .net core using templates](http://thecodemanual.pl/2020/04/02/build-templates-on-azure-devops.html) - shows how to create pipeline which serves as gated checkin policy using pipeline template</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-with-template-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=7&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-with-template-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=8&branchName=master)


 ## Stackoverflow questions:

 - pipeline 08 - creating nuget package with nuspec file</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(8)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=101&branchName=master)
 - pipeline 13 - simple multistage pipeline with condition and failing one stage </br>
[![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-13?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=34&branchName=master)
 - pipeline 37 - issue with passing connection to kubernetes via variable - shows limitation of Azure DevOps</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-37?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=64&branchName=master)
 - [pipeline 40](https://stackoverflow.com/questions/62044055/is-it-possible-to-cancel-a-azure-devops-pipeline-job-programmatically) - example of using condition to control pipeline flow</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-40-conditional?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=67&branchName=master)
 - pipeline 45 - few examples how to run python scripts</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-45?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=90&branchName=master)
 - pipeline 46 - getting access to Agent.OS variable in condition</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-46?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=92&branchName=master)
 - pipeline 47 - multi stage pipeline with deployment availabe only for Pull Requests</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=93&branchName=master)
 - pipeline 50 - example of `Default branch for manual and scheduled builds`</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-50?branchName=pipeline-in-branch)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=102&branchName=pipeline-in-branch)
 - [pipeline 51](https://stackoverflow.com/questions/63733965/blazor-webassembly-azure-devops-build-pipeline-publish-artifacts) - sample Blazor pipeline</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(9)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=103&branchName=master)
 - [pipeline 55](https://stackoverflow.com/questions/63941345/set-variable-group-dynamically-using-system-pullrequest-targetbranch/63946930#63946930) - explains that System.PullRequest.* (apart for IsFork) can't be used in template expressions</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-55?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=115&branchName=master)
 - pipeline 59 - breaking pipeline through `exit 1`</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-59?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=105&branchName=master)
 - [pipeline 60](https://stackoverflow.com/questions/63788704/azure-pipelines-file-trigger-for-files-on-root-level) - how to configure trigger to run pipeline in case of change in root level files</br>
  [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(13)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=107&branchName=master)
 - [pipeline 61](https://stackoverflow.com/questions/63678236/link-azure-devops-ci-and-cd-yaml-pipelines) - pipeline triggered by another pipeline with fetching original build number over REST API</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(7)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=100&branchName=master)
 - pipeline 62 - multistage pipeline siumulating failure of one stage over beeceptor</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(5)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=98&branchName=master)
 - pipeline 63 - tag filter</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(4)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=97&branchName=master)
 - pipeline 64 - tag filter</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(3)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=96&branchName=master)
 - pipeline 65 - getting secret from key vault using Azure CLI</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(1)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=94&branchName=master)
 - [pipeline 66](https://stackoverflow.com/questions/63996987/tagging-docker-containers-with-azure-pipelines) - keep build id for tag purpose re-running whole job/stage/piepline</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=120&branchName=master)