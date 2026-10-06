using UnrealBuildTool;
using System.Collections.Generic;
public class CourseGameLab3EditorTarget : TargetRules
{
    public CourseGameLab3EditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        ExtraModuleNames.AddRange(new[] { "CourseGameLab3", "CourseGameLab3Editor" });
    }
}
