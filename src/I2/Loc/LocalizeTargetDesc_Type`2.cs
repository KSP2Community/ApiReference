﻿// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizeTargetDesc_Type`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G>
    where T : Object
    where G : LocalizeTarget<T>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanLocalize(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ILocalizeTarget CreateTarget(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizeTargetDesc_Type() => throw null;
  }
}
