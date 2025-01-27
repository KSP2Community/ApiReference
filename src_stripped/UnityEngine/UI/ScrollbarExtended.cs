﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ScrollbarExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class ScrollbarExtended : 
    Scrollbar,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler
  {
    public SelectedDiscoverableMessage SliderReleasedMessageType;
    public readonly ScrollbarExtended.IsPointerDownChangedEvent onIsPointerDownChanged;
    public readonly ScrollbarExtended.DragPositionChangedEvent onDragPositionChanged;
    public readonly ScrollbarExtended.OnValueChangeWithoutPointer onValueDiffWithoutPointer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScrollbarExtended() => throw null;

    public class IsPointerDownChangedEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public IsPointerDownChangedEvent() => throw null;
    }

    public class DragPositionChangedEvent : UnityEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragPositionChangedEvent() => throw null;
    }

    public class OnValueChangeWithoutPointer : UnityEvent<float>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OnValueChangeWithoutPointer() => throw null;
    }
  }
}
