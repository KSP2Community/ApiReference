﻿// Decompiled with JetBrains decompiler
// Type: IPartSizeModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using UnityEngine;

public interface IPartSizeModifier
{
  Vector3 GetModuleSize(Vector3 defaultSize, ModifierStagingSituation sit);

  ModifierChangeWhen GetModuleSizeChangeWhen();
}
