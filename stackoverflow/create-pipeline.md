az pipelines create --name 'kmadof.dm-dotnet-core-on-windows' --description 'Cross stage variables' --repository https://github.com/kmadof/devops-manual --branch master --yml-path dotnet-core-on-windows/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' 

az pipelines create --name 'kmadof.dm-so-39' --description 'Create nuget package' --repository https://github.com/kmadof/devops-manual --branch master --yml-path stackoverflow/39-tasks/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' --folder-path stackoverflow


