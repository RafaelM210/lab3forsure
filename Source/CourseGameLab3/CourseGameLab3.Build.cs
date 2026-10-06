using UnrealBuildTool;
public class CourseGameLab3 : ModuleRules
{
    public CourseGameLab3(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicIncludePaths.Add(ModuleDirectory);
        PublicDependencyModuleNames.AddRange(new[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D", "EnhancedInput" });
    }
}
