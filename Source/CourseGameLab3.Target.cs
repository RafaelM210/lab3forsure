using UnrealBuildTool;
using System.Collections.Generic;
public class CourseGameLab3Target : TargetRules
{
    public CourseGameLab3Target(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        ExtraModuleNames.Add("CourseGameLab3");
    }
}
