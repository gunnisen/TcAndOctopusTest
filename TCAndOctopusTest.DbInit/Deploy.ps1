& ".\TCAndOctopusTest.DbInit.exe"


#Write-Host "Connection String: <"$ConnectionString">"

#$contentPath = (Join-Path $OctopusOriginalPackageDirectoryPath "content")
#$fullPath = (Join-Path $contentPath "migrate.exe")
#Write-Host "Migrate Path: " $fullPath

#cd $contentPath
#Write-Host "Working Dir: " $(Get-Location)

#& ".\TCAndOctopusTest.DbInit.exe" | Write-Host
#& ".\migrate.exe" TCAndOctopusTest.Db.dll /startUpConfigrationFile=TCAndOctopusTest.Db.dll.config /connectionString=$ConnectionString /connectionProviderName="System.Data.SqlClient" /verbose | Write-Host
