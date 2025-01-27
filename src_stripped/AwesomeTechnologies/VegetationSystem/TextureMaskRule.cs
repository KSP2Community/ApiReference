﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.TextureMaskRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation.Masks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class TextureMaskRule
  {
    public string TextureMaskGroupID;
    public float MinDensity;
    public float MaxDensity;
    public float ScaleMultiplier;
    public float DensityMultiplier;
    public List<SerializedControllerProperty> TextureMaskPropertiesList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMaskRule(TextureMaskRule sourceItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMaskRule(TextureMaskSettings textureMaskSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBooleanPropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIntPropertyValue(string propertyName) => throw null;
  }
}
