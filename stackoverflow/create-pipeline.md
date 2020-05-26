az pipelines create --name 'kmadof.dm-dotnet-core-on-windows' --description 'Cross stage variables' --repository https://github.com/kmadof/devops-manual --branch master --yml-path dotnet-core-on-windows/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' 

az pipelines create --name 'kmadof.dm-so-37' --description 'Create nuget package' --repository https://github.com/kmadof/devops-manual --branch master --yml-path stackoverflow/37-kubernetes/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' --folder-path stackoverflow


