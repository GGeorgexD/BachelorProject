using UnrealBuildTool;

public class LicentaTarget : TargetRules
{
	public LicentaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Licenta");
	}
}
