// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShooterClientTarget : TargetRules
{
	public ShooterClientTarget(TargetInfo Target) : base(Target)
	{
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;
		Type = TargetType.Client;
		bUsesSteam = true;		

        ExtraModuleNames.Add("ShooterGame");
    }
}
