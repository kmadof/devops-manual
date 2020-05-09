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
# Ordered list
1. Step 1
2. Step 2
3. Step 3
    1. Step 3.1
    2. Step 3.2
    3. Step 3.3

Details
======

* Skipped detail
    * MSGraph/DeviceAppManagement/MobileApps:
        * AnyDesk

1. Skipped detail
    2. MSGraph/DeviceAppManagement/MobileApps:
        3. AnyDesk

# Unordered list

* Item 1
* Item 2
* Item 3
    * Item 3a
    * Item 3b
    * Item 3c

# Ordered list

1. Step 1
2. Step 2
3. Step 3
    1. Step 3.1
    2. Step 3.2
    3. Step 3.3

# List in list

1. Step 1
2. Step 2
3. Step 3
    * Item 3a
    * Item 3b
    * Item 3c
"@

New-Item -Path . -Name "testsummary.md" -ItemType "file" -Value $content

Get-Location

Get-ChildItem
