﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class UIChatMessage : MonoBehaviour
  {
    public TextMeshProUGUI messageText;
    public ChatMessageType type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContent(ChatMessageType type, string msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Display(bool display) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIChatMessage() => throw null;
  }
}
