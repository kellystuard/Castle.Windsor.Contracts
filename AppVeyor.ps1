Param (
	$variables = @{},
	$artifacts = @{},
	$scriptPath,
	$buildFolder,
	$srcFolder,
	$outFolder,
	$tempFolder,
	$projectName,
	$projectVersion,
	$projectBuildNumber
)

# list all artifacts
foreach($artifact in $artifacts.values)
{
	Write-Output "Artifact: $($artifact.name)"
	Write-Output "Type: $($artifact.type)"
	Write-Output "Path: $($artifact.path)"
	Write-Output "Url: $($artifact.url)"
}

# script custom variables
foreach($name in $variables.keys)
{
	$value = $variables[$name]
	Write-Output "$name=$value"
}

Write-Output $scriptPath
Write-Output $buildFolder
Write-Output $srcFolder
Write-Output $outFolder
Write-Output $tempFolder
Write-Output $projectName
Write-Output $projectVersion
Write-Output $projectBuildNumber

$nuGetApiKeySecure = $variables["NuGetApiKeySecure"]
.\.nuget\NuGet.exe setApiKey $nuGetApiKeySecure

Write-Output $outFolder
Get-ChildItem $scriptPath | Format-Table -Property Name, LastWriteTime
Get-ChildItem $buildFolder | Format-Table -Property Name, LastWriteTime
Get-ChildItem $srcFolder | Format-Table -Property Name, LastWriteTime
Get-ChildItem $outFolder | Format-Table -Property Name, LastWriteTime
Get-ChildItem $tempFolder | Format-Table -Property Name, LastWriteTime
