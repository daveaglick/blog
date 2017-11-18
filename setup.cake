#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Wyam.Recipe&prerelease

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "patriksvensson.se",
                            repositoryOwner: "patriksvensson",
                            repositoryName: "blog",
                            appVeyorAccountName: "patriksvensson",
                            webHost: "patriksvensson.se/blog",
                            shouldPurgeCloudflareCache: true);

BuildParameters.PrintParameters(Context);

Build.Run();