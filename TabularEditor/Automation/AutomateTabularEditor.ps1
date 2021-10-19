Write-Output("Start of Code")
$p = Start-Process -filePath "C:\Program Files (x86)\Tabular Editor\TabularEditor.exe" -Wait -NoNewWindow -PassThru `
       -ArgumentList "`"Provider=MSOLAP;Data Source=powerbi://api.powerbi.com/v1.0/myorg/workspace;User ID=userid;Password=password;Persist Security Info=True;Impersonation Level=Impersonate`" `"dataset`" -S `"script-path`" -D `"powerbi://api.powerbi.com/v1.0/myorg/workspace`" `"dataset`" -O"
Write-Output("End of Code")