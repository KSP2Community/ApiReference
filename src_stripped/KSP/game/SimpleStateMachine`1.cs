﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.SimpleStateMachine`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class SimpleStateMachine<TEnum> where TEnum : Enum
  {
    private TEnum _lastState;
    private TEnum _currentState;
    private Dictionary<TEnum, Action> _onEnterDelegate;
    private Dictionary<TEnum, Action> _onLeaveDelegate;
    private readonly MessageCenter _messageCenter;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleStateMachine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleStateMachine(TEnum state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleStateMachine(TEnum state, MessageCenter messageCenter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TEnum GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TEnum GetLastState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetStateAndHistory(TEnum state, TEnum historyState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetState(TEnum state, bool announce = true, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PublishStateEnteredMessage(
      MessageCenter messageCenter,
      TEnum StateBeingEntered)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PublishStateChangedMessage(
      MessageCenter messageCenter,
      TEnum StateBeingLeft,
      TEnum StateBeingEntered)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PublishStateLeftMessage(
      MessageCenter messageCenter,
      TEnum StateBeingLeft)
    {
      throw null;
    }
  }
}
