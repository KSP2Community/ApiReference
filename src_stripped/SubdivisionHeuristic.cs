﻿// Decompiled with JetBrains decompiler
// Type: SubdivisionHeuristic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

[Flags]
public enum SubdivisionHeuristic
{
  TriangleArea = 2,
  ScreenSizeRatio = 4,
  SquaredPerimeter = 8,
  Default = SquaredPerimeter | ScreenSizeRatio | TriangleArea, // 0x0000000E
}
