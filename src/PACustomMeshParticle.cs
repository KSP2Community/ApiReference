﻿// Decompiled with JetBrains decompiler
// Type: PACustomMeshParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PACustomMeshParticle : PACustomParticle
{
  public Vector3 spinAxis;
  public Mesh mesh;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomMeshParticle() => throw null;
}
