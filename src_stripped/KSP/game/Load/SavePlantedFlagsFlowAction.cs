﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SavePlantedFlagsFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class SavePlantedFlagsFlowAction : SaveLoadGameFlowActionBase
  {
    private LoadGameData _gameData;
    private byte _playerID;
    private List<SerializedFlag> _serializedPlantedFlags;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SavePlantedFlagsFlowAction(LoadGameData data, byte playerID = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectFlagComponents(byte playerID) => throw null;
  }
}
