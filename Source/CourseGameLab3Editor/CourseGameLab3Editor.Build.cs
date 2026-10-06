using UnrealBuildTool;
public class CourseGameLab3Editor : ModuleRules
{
    public CourseGameLab3Editor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivateDependencyModuleNames.AddRange(new[] {
            "EnhancedInput", "InputCore", "Core", "CoreUObject", "Engine", "CourseGameLab3", "Paper2D", "UnrealEd",
            "BlueprintGraph", "Kismet", "KismetCompiler", "AssetRegistry"
        });
    }
}
