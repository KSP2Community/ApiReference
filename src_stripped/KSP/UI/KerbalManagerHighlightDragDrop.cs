﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManagerHighlightDragDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KerbalManagerHighlightDragDrop : HighlightedDragDropLogic
  {
    [SerializeField]
    private string _slotIsEmptyKey;
    [SerializeField]
    private string _dragDropDummyObjectKey;
    private GameObject _dummyPrefab;
    private GameObject _draggingObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleElementBeginDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleElementDrag(
      PointerEventData pointerData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleElementEndDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void MoveElementInto(
      UIList_ListElement element,
      UIList_ListView targetView,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyDummyObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApplicationFocus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalManagerHighlightDragDrop() => throw null;
  }
}
