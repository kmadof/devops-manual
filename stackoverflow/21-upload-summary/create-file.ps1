$content = @"
Summary
======
- Created resources: 0
- Deleted resources: 0
- Updated resources: 0
- Unchanged resources: 117
- Skipped resources: 1

Details
======
* Skipped detail
    * MSGraph/DeviceAppManagement/MobileApps:
        * AnyDesk
"@

New-Item -Path . -Name "testsummary.md" -ItemType "file" -Value $content

Get-Location

Get-ChildItem
