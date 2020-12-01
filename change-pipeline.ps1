git add .

$date = Get-Date -Format "dddd dd/MM/yyyy HH:mm K"
$message = "Changed SO pipeline $($date) [skip ci]"

git commit -m $message

git push