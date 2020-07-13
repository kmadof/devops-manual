param([String] $WebappName)

$resourceGroup = 'TheCodeManual'
$expected = 'SomeValue', 'ANCM_ADDITIONAL_ERROR_PAGE_LINK', 'AnotherValue'
$ignoreSettings = 'WEBSITE_RUN_FROM_PACKAGE', 'Testowo'

.\check-webapp-settings.ps1 -WebappName $WebappName -ResourceGroup $resourceGroup -Expected $expected -IgnoreSettings $ignoreSettings