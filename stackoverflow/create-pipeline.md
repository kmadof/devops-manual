az pipelines create --name 'kmadof.dm-dotnet-core-on-windows' --description 'Cross stage variables' --repository https://github.com/kmadof/devops-manual --branch master --yml-path dotnet-core-on-windows/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' 

az pipelines create --name 'kmadof.dm-so-68-a-conditional-variables' --description 'Conditional variables' --repository https://github.com/kmadof/devops-manual --branch master --yml-path stackoverflow/68-conditional-variables/build-a.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' --folder-path stackoverflow


