// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShooterGameTarget : TargetRules
{
    public ShooterGameTarget(TargetInfo Target) : base(Target)
    {
	    IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;
        Type = TargetType.Game;
        bUsesSteam = true;

		ExtraModuleNames.Add("ShooterGame");
    }
}
