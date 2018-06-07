// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class SpinePlugin : ModuleRules
	{
		public SpinePlugin(ReadOnlyTargetRules Target) : base(Target)
		{
			PublicIncludePaths.AddRange(new string[] { "SpinePlugin/Public", "SpinePlugin/Public/spine-cpp/include" });
            PrivateIncludePaths.AddRange(new string[] { "SpinePlugin/Private", "SpinePlugin/Public/spine-cpp/include" });
            PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "RHI", "RenderCore", "ShaderCore", "ProceduralMeshComponent", "UMG", "Slate", "SlateCore" });
            OptimizeCode = CodeOptimization.Never;
			PublicDefinitions.Add("SPINE_UE4");
		}
	}
}
