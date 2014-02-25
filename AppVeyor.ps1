Param (
	$variables = @{},
	$outFolder
)

# list all artifacts
foreach($artifact in $artifacts.values)
{
	Write-Output "Artifact: $($artifact.name)"
	Write-Output "Type: $($artifact.type)"
	Write-Output "Path: $($artifact.path)"
	Write-Output "Url: $($artifact.url)"
}

$nuGetApiKeySecure = $variables["NuGetApiKeySecure"]
.\.nuget\NuGet.exe setApiKey $nuGetApiKeySecure

Write-Output $outFolder
Get-ChildItem $outFolder | `
Foreach-Object {
	Write-Output $_.FullName
}
