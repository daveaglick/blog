#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Wyam.Recipe&prerelease&version=0.6.0-unstable0033

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "patriksvensson.se",
                            repositoryOwner: "patriksvensson",
                            repositoryName: "blog",
                            appVeyorAccountName: "patriksvensson",
                            webHost: "patriksvensson.se",
                            shouldPurgeCloudflareCache: true);

BuildParameters.PrintParameters(Context);

Build.Run();