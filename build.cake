#load "./cake/SharpBuild.cake"

var build = new SharpBuild(Context, "BlasterDv", "SampSharp-SKY-Wrapper",
    "SampSharp.SKY",
    "SampSharp.SKY.Entities");

Task("Clean")
    .Does(() => build.Clean());
   
Task("Restore")
    .Does(() => build.Restore());
 
Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() => build.Build());
    
Task("Pack")
    .IsDependentOn("Build")
    .Does(() => build.Pack());

Task("Publish")
    .WithCriteria(() => build.IsAppVeyorTag)
    .IsDependentOn("Pack")
    .Does(() => build.Publish());

Task("Default")
    .IsDependentOn("Build");

Task("AppVeyor")
    .IsDependentOn("Publish");

RunTarget(Argument("target", "Default"));
