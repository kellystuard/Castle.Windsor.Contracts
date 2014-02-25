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

$nuGetApiKeySecure = $variables["NuGetApiKeySecure"]
.\.nuget\NuGet.exe setApiKey $nuGetApiKeySecure

$tempFolder + "\Castle.Windsor.Contracts" | Get-ChildItem -Filter "*.nupkg" | % {
	.\.nuget\NuGet.exe push $_.FullName
}
