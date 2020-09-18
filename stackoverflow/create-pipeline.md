az pipelines create --name 'kmadof.dm-dotnet-core-on-windows' --description 'Cross stage variables' --repository https://github.com/kmadof/devops-manual --branch master --yml-path dotnet-core-on-windows/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' 

az pipelines create --name 'kmadof.dm-so-58' --description 'List runtime parameters' --repository https://github.com/kmadof/devops-manual --branch master --yml-path stackoverflow/58-runtime-parameters/build.yaml --org https://dev.azure.com/thecodemanual --project 'DevOps Manual' --folder-path stackoverflow


