#r "paket:
nuget Fake.Core.Target 
nuget Fake.DotNet.NuGet //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet.NuGet



// Default target
Target.create "Default" (fun _ ->

  let token = Environment.environVarOrDefault "token" ""
  
  NuGet.NuGetPublish 
    (fun p ->
      {
        p with
          Project = "Cool-package"
          Version = "1.1.3"
          PublishUrl = "https://pkgs.dev.azure.com/thecodemanual/4fa6b279-3db9-4cb0-aab8-e06c2ad550b2/_packaging/devops-manual/nuget/v3/index.json"
          WorkingDir = "."
          OutputPath = "."
          AccessKey = token
      })
)



// start build
Target.runOrDefault "Default"