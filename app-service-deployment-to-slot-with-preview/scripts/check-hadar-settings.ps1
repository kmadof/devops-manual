$appName = 'Hadar'
$resourceGroup = 'TheCodeManual'
$expected = 'SomeValue', 'ANCM_ADDITIONAL_ERROR_PAGE_LINK', 'AnotherValue2'
$ignoreSettings = 'WEBSITE_RUN_FROM_PACKAGE', 'Testowo'

C:\dev\scripts\check-webapp-settings.ps1 -WebappName $appName -ResourceGroup $resourceGroup -Expected $expected -IgnoreSettings $ignoreSettings