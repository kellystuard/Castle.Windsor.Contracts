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
Get-ChildItem $scriptPath | Format-Table -Property Name, LastWriteTime
Write-Output $buildFolder
Get-ChildItem $buildFolder | Format-Table -Property Name, LastWriteTime
Write-Output $srcFolder
Get-ChildItem $srcFolder | Format-Table -Property Name, LastWriteTime
Write-Output $outFolder
Get-ChildItem $outFolder | Format-Table -Property Name, LastWriteTime
Write-Output $tempFolder
Get-ChildItem $tempFolder | Format-Table -Property Name, LastWriteTime
Write-Output $projectName
Write-Output $projectVersion
Write-Output $projectBuildNumber


$tempSubFolder = $tempFolder + "Castle.Windsor.Contracts"
Write-Output $tempSubFolder
Get-ChildItem $tempSubFolder | Format-Table -Property Name, LastWriteTime

$nuGetApiKeySecure = $variables["NuGetApiKeySecure"]
.\.nuget\NuGet.exe setApiKey $nuGetApiKeySecure
