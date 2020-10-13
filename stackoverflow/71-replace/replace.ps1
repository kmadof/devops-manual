$fileName = "Web.Release.config";
$xmlObject = [xml](Get-Content $fileName);

$names = $xmlObject.configuration.connectionStrings.add.name

$i = 1;
foreach ($name in $names)
{
    Write-Host "name is $name"
    $connectionstring = $xmlObject.configuration.connectionStrings.add | ?{$_.name -eq $name}
    Write-Host "Connection String name is" $connectionstring.connectionString
    $i = $i + 1
    $connectionstring.SetAttribute("connectionString","$($i)")
    
}
$xmlObject.Save("stackoverflow\71-replace\" + $fileName)

# $x = [xml] (Get-Content $fileName)
# # Select-Xml -xml $x  -XPath //configuration/connectionStrings |
# #     % { Write-Host $_
# #         $_.SetAttribute("connectionString","value")
# #       }
# # $x.Save($fileName)

# $nodes = $x.SelectNodes("/configuration/connectionStrings");
# foreach($node in $nodes) {
#     $node.SetAttribute("connectionString", "New York");
# }
# $x.Save($fileName+"s")