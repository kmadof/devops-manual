$file=$args[0]

try{
    $ProcessInfo = New-Object System.Diagnostics.ProcessStartInfo 
    $ProcessInfo.FileName = "powershell.exe"
    $ProcessInfo.RedirectStandardError = $true 
    $ProcessInfo.RedirectStandardOutput = $true 
    $ProcessInfo.UseShellExecute = $false 
    $ProcessInfo.Arguments = $file
    $Process = New-Object System.Diagnostics.Process 
    $Process.StartInfo = $ProcessInfo
    $Process.Start() | Out-Null
    $stdOutput = $Process.StandardOutput.ReadToEnd()
    $stdError = $Process.StandardError.ReadToEnd() 
    Write-Host $stdOutput
    Write-Host $stdError
    $Process.WaitForExit()
}
catch{
    Write-Host "Could not execute script."
    Write-Error $Error[0]
    Exit
}
