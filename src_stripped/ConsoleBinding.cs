﻿// Decompiled with JetBrains decompiler
// Type: ConsoleBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

public class ConsoleBinding : InputBinding_obsolete
{
  private ConsoleButtons mKey;
  private IPlatformController controller;
  private float holdStartTime;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding(ConsoleButtons key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding(ConsoleButtons key, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKey(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyUp(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDoubleTapDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetHold(float holdtime, bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateConsoleController() => throw null;
}
