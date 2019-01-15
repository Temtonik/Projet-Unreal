using UnrealBuildTool;

public class WukongpointpngTarget : TargetRules
{
	public WukongpointpngTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Wukongpointpng");
	}
}
