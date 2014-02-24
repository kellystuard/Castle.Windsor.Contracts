Param (
	$variables = @{},
	$outFolder
)

$nuGetApiKeySecure = $variables["NuGetApiKeySecure"]
.\.nuget\NuGet.exe setApiKey $nuGetApiKeySecure

Get-ChildItem $outFolder -Filter *.nupkg | `
Foreach-Object {
	$content = Get-Content $_.FullName
	.\.nuget\NuGet.exe push $content
}