﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OutOfResourceMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Resources/OutOfResourceMessage", true, "A resource ran out", "")]
  public class OutOfResourceMessage : PartModuleMessageBase
  {
    public ResourceDefinitionID ResourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OutOfResourceMessage() => throw null;
  }
}
