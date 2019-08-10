var name = "MyWeb";
var publishDir = ".publish/W";
var version = DateTime.Now.ToString("yy.MM.dd.HHmm");

Task("Publish").Does(() => {
    var settings = new DotNetCoreMSBuildSettings();
    settings.Properties["Version"] = new string[] { version };

    CleanDirectory(publishDir);
    DotNetCorePublish($"src/{name}", new DotNetCorePublishSettings {
        OutputDirectory = publishDir,
        MSBuildSettings = settings,
        Runtime = "linux-x64"
    });
});

var target = Argument("target", "Publish");
RunTarget(target);
