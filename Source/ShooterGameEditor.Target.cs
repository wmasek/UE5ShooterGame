// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShooterGameEditorTarget : TargetRules
{
	public ShooterGameEditorTarget(TargetInfo Target) : base(Target)
	{
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;
		Type = TargetType.Editor;

		ExtraModuleNames.Add("ShooterGame");
	}
}
