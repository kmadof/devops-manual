$content = @"
Summary
======
- Created resources: 0
- Deleted resources: 0
- Updated resources: 0
- Unchanged resources: 117
- Skipped resources: 1

Details
----
1. First item.
   - Item 1
   - Item 2
   - Item 3
1. Second item.
   - Nested item 1
   - Nested item 2
   - Nested item 3

Details
======

* Skipped detail
    * MSGraph/DeviceAppManagement/MobileApps:
        * AnyDesk

1. Skipped detail
    2. MSGraph/DeviceAppManagement/MobileApps:
        3. AnyDesk

# Unordered list
- Test
    - Test 2
        - Test3
"@

New-Item -Path . -Name "testsummary.md" -ItemType "file" -Value $content

Get-Location

Get-ChildItem
