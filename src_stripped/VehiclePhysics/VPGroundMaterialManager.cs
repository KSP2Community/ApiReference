﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundMaterialManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Material Manager")]
  public class VPGroundMaterialManager : GroundMaterialManagerBase
  {
    public GroundMaterial[] groundMaterials;
    public GroundMaterial fallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override GroundMaterial GetGroundMaterial(
      VehicleBase vehicle,
      GroundMaterialHit groundHit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundMaterialManager() => throw null;
  }
}
