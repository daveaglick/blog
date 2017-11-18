#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Wyam.Recipe&prerelease

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "patriksvensson.se",
                            repositoryOwner: "patriksvensson",
                            repositoryName: "blog",
                            appVeyorAccountName: "patrik",
                            webHost: "patriksvensson.se",
                            shouldPurgeCloudflareCache: true);

BuildParameters.PrintParameters(Context);

Build.Run();