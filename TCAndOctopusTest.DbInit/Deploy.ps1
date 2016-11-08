Write-Host "Will run TCAndOctopusTest.DbInit.exe..."
& ".\TCAndOctopusTest.DbInit.exe"
Write-Host "TCAndOctopusTest.DbInit.exe completed."


#Write-Host "Connection String: <"$ConnectionString">"

#$contentPath = (Join-Path $OctopusOriginalPackageDirectoryPath "content")
#$fullPath = (Join-Path $contentPath "migrate.exe")
#Write-Host "Migrate Path: " $fullPath

#cd $contentPath
#Write-Host "Working Dir: " $(Get-Location)

#& ".\TCAndOctopusTest.DbInit.exe" | Write-Host
#& ".\migrate.exe" TCAndOctopusTest.Db.dll /startUpConfigrationFile=TCAndOctopusTest.Db.dll.config /connectionString=$ConnectionString /connectionProviderName="System.Data.SqlClient" /verbose | Write-Host
