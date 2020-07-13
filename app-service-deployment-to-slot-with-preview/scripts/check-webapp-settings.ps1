param([String] $WebappName, [String] $ResourceGroup, [String[]] $Expected, [String[]] $IgnoreSettings)

$settings = az webapp config appsettings list --name $WebappName --resource-group $ResourceGroup --query '[].[name]' --out tsv

$filtereddata = $settings | Where{ $_ -notin $IgnoreSettings }

$result = Compare-Object -ReferenceObject  $filtereddata -DifferenceObject $Expected

Write-Host $result

if($result.Length -ne 0) {
   throw "They are missing settings in webapp $($WebappName)"
}