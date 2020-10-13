# devops-manual
Playground for various Azure DevOps options

 - [Cross stage variables](http://thecodemanual.pl/2020/05/05/cross-stage-variables.html) - describes how to use variables across the stages. This is useful to evaluate go/no go decision for next stages/jobs in your YAML builds.</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-cross-stage-variables?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=40&branchName=master)
 - [Caching npm modules](http://thecodemanual.pl/2020/03/11/caching-not-only-nuget-packages-on-azure-devops.html#caching-npm-modules) - describes hot to cache npm modules and show difference between `npm install` and `npm ci`</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-cache-npm?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=52&branchName=master)
 - Caching ruby gems - simple ruby gems cache base son built in task
 - [Gated checkin for .net core](http://thecodemanual.pl/2020/03/26/gated-check-in-build-on-azure-devops-for-dotnet-core-app.html) - shows how to create pipeline which serves as gated checkin policy</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=5&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=6&branchName=master)
 - [Gated checkin for .net core using templates](http://thecodemanual.pl/2020/04/02/build-templates-on-azure-devops.html) - shows how to create pipeline which serves as gated checkin policy using pipeline template</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-with-template-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=7&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual-gated-checkin-with-template-gc?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=8&branchName=master)
 - [How to build docker image on Azure DevOps?](http://thecodemanual.pl/2020/04/20/how-to-build-docker-image-on-azure-devops.html) - shopwing various option of building Docker images on Azure DevOps</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-build-docker-image-with-build-kit?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=19&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-build-docker-image-on-acr?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=18&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-build-docker-image-on-agent?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=17&branchName=master)


 ## Stackoverflow questions:
 - docker multiple apps with container registry</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-docker-multiple-apps?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=28&branchName=master)
 - dm-variable-groups-01 - selecting variable group using runtime parameters</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-variable-groups-01?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=9&branchName=master)
 - dm-variable-groups-02 - selecting variable group based on the variable </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-variable-groups-02?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=10&branchName=master)
 - dm-variable-groups-03 - using different syntaxed with variables and variable group</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-variable-groups-03?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=24&branchName=master)
 - dotnet core on widnows with getting number of passed and failed test over REST API </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.dm-dotnet-core-on-windows?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=41&branchName=master)
 - pipeline 01 - publishing dotnet core project</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-01?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=11&branchName=master)
 - pipeline 02 - getting IP address of the host</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-02?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=12&branchName=master)
 - pipeline 03 - publishing artifacts</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-03-a?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=13&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-03-b?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=14&branchName=master)
 - pipeline 04 - empty value in runtime paramaters</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-04?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=15&branchName=master)
 - pipeline 05 - different host machines for jobs</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-05?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=16&branchName=master)
 - [pipeline 06](https://stackoverflow.com/questions/61306564/azure-devops-build-pipeline-doesnt-build-executables) - publishing dotnet core project</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-06?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=23&branchName=master)
 - pipeline 07 - calling Azure DevOps REST API </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-07?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=25&branchName=master)
 - pipeline 08 - creating nuget package with nuspec file and overriding package version</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-08?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=26&branchName=master)
 - pipeline 09 - array parameter for templates</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-09?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=29&branchName=master)
 - pipeline 10 - multistage pipeline </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-10?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=30&branchName=master)
 - pipeline 11 - multistage pipeline </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-11-b?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=32&branchName=master)
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-11-b?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=32&branchName=master)
 - [pipeline 12](https://stackoverflow.com/questions/61497425/azure-devops-azurecli-task-with-scriptpath-option-failed-to-authenticate-to-crea) - running container instance, using replace token, running C# code written in build file</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-12?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=33&branchName=master)
 - pipeline 13 - simple multistage pipeline with condition and failing one stage </br>
[![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-13?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=34&branchName=master)
 - pipeline 14 - adding tag and using output variables</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-14?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=35&branchName=master)
 - pipeline 16 - conditional run of steps based on the runtime parameters</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-16?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=38&branchName=master)
 - [pipeline 17](stackoverflow.com/questions/61651777/how-can-we-pass-variable-as-a-parametersas-a-list) - shows not possible - dunamic list in yaml</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-17?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=42&branchName=master)
 - [pipeline 18](https://stackoverflow.com/questions/61676408/is-it-possible-to-import-a-script-in-a-yaml-template/61677662#61677662) - importing script in template fro other repo</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-18?repoName=kmadof%2Fdevops-manual&branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=43&repoName=kmadof%2Fdevops-manual&branchName=master)
 - pipeline 20 - scheduled pipeline</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-20-scheduled?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=46&branchName=master)
 - pipeline 21 - upload summary</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-21-upload-summary?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=47&branchName=master)
 - [pipeline 23](https://stackoverflow.com/questions/61734755/variable-substitution-in-config-json-files-in-azure-devops-pipeline/61736613#61736613) - token replace in config and json files</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-23-token-replace?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=49&branchName=master)
 - [pipeline 24](https://stackoverflow.com/questions/61676408/is-it-possible-to-import-a-script-in-a-yaml-template/61677662#61677662) extending pipeline using template from different repository </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-24?repoName=kmadof%2Fdevops-manual&branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=50&repoName=kmadof%2Fdevops-manual&branchName=master)
 - pipeline 25 - archive multiple artifacts </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-25?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=51&branchName=master)
 - [pipeline 26](https://stackoverflow.com/questions/61799711/impossible-to-update-variable-from-variable-group-library/61800119#61800119) - update variables in variable group over REST API</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-26?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=53&branchName=master)
 - [pipeline 28](https://stackoverflow.com/questions/61783014/using-lerna-js-and-azure-devops-pipeline/61786014?noredirect=1#comment109330301_61786014) - and [here](https://stackoverflow.com/questions/61953776/how-to-combine-git-branch-and-tag-triggers-in-azure-pipelines) using tag filters </br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-28-tag-filters?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=55&branchName=master)
 - pipeline 37 - issue with passing connection to kubernetes via variable - shows limitation of Azure DevOps</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-37?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=64&branchName=master)
 - [pipeline 38](https://stackoverflow.com/questions/62043374/azure-replace-token-for-service-model-endpoint-for-asp-net-mvc-in-pipeline-relea/62044492#62044492)- WCF endpoint replace using token replace task</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-38-token-replace?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=65&branchName=master)
 - [pipeline 39](https://stackoverflow.com/questions/62044055/is-it-possible-to-cancel-a-azure-devops-pipeline-job-programmatically) - cancelling pipeline programatically over REST API</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-39?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=66&branchName=master)
 - [pipeline 40](https://stackoverflow.com/questions/62044055/is-it-possible-to-cancel-a-azure-devops-pipeline-job-programmatically) - example of using condition to control pipeline flow</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-40-conditional?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=67&branchName=master)
 - pipeline 41 - using secret mappings, and playing with lists which are not supported by YAML here</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-41?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=73&branchName=master)
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
 - [pipeline 56](https://stackoverflow.com/questions/63950046/printing-parameter-variables-in-azure-devops-template/63951973#63951973) printing variables</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-56?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=116&branchName=master)
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
 - pipeline 67 - composing package version by getting last package version from REST API</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/kmadof.devops-manual%20(8)?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=101&branchName=master)
 - [pipeline 68](https://stackoverflow.com/questions/58823004/how-can-i-use-if-else-in-variables-of-azure-devops-yaml-pipeline-with-variable-g) - conditional variables</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-68-a-conditional-variables?branchName=dev)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=121&branchName=dev) [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-68-b-conditional-variables?branchName=dev)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=122&branchName=dev)
 - [pipeline 70](https://stackoverflow.com/questions/64020523/how-to-add-env-vars-into-azure-devops-pipeline) - showing mapping variables to envs</br>
 [![Build Status](https://dev.azure.com/thecodemanual/DevOps%20Manual/_apis/build/status/stackoverflow/kmadof.dm-so-70-env-vars?branchName=master)](https://dev.azure.com/thecodemanual/DevOps%20Manual/_build/latest?definitionId=124&branchName=master)
