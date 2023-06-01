﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.IfStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class IfStatement : Statement
  {
    private List<IfStatement.IfBlock> m_Ifs;
    private IfStatement.IfBlock m_Else;
    private SourceRef m_End;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IfStatement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IfStatement.IfBlock CreateIfBlock(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IfStatement.IfBlock CreateElseBlock(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    private class IfBlock
    {
      public Expression Exp;
      public Statement Block;
      public RuntimeScopeBlock StackFrame;
      public SourceRef Source;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IfBlock() => throw null;
    }
  }
}
