﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.GeneratorStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.ComponentModel;

namespace KSP.Modules
{
  [Serializable]
  public enum GeneratorStatus : byte
  {
    [Description("PartModules/Generator/Nominal")] NOMINAL,
    [Description("PartModules/Generator/Off")] OFF,
    [Description("PartModules/Generator/Overheat")] OVERHEATED,
  }
}
