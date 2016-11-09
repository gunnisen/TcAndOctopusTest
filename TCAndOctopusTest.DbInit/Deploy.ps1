$contentPath = (Join-Path $OctopusOriginalPackageDirectoryPath "content")
$fullPath = (Join-Path $contentPath "TCAndOctopusTest.DbInit.exe")
Write-Host "Exe Path: " $fullPath

cd $contentPath
Write-Host "Working Dir: " $(Get-Location)

& ".\TCAndOctopusTest.DbInit.exe" | Write-Host
