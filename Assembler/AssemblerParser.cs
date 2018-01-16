//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Assembler.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace J77E524P.Assembler {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class AssemblerParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, REG=8, ADDR=9, 
		ID=10, FUNC=11, INT=12, HEX_DIGIT=13, DIGIT=14, CHAR=15, STRING=16, FLOAT=17, 
		WS=18, NEWLINE=19;
	public const int
		RULE_program = 0, RULE_globals = 1, RULE_functionDeclaration = 2, RULE_instr = 3, 
		RULE_operand = 4, RULE_label = 5;
	public static readonly string[] ruleNames = {
		"program", "globals", "functionDeclaration", "instr", "operand", "label"
	};

	private static readonly string[] _LiteralNames = {
		null, "'.globals'", "'.def'", "':'", "'args'", "'='", "','", "'locals'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "REG", "ADDR", "ID", "FUNC", 
		"INT", "HEX_DIGIT", "DIGIT", "CHAR", "STRING", "FLOAT", "WS", "NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Assembler.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static AssemblerParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AssemblerParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AssemblerParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ProgramContext : ParserRuleContext {
		public GlobalsContext globals() {
			return GetRuleContext<GlobalsContext>(0);
		}
		public FunctionDeclarationContext[] functionDeclaration() {
			return GetRuleContexts<FunctionDeclarationContext>();
		}
		public FunctionDeclarationContext functionDeclaration(int i) {
			return GetRuleContext<FunctionDeclarationContext>(i);
		}
		public InstrContext[] instr() {
			return GetRuleContexts<InstrContext>();
		}
		public InstrContext instr(int i) {
			return GetRuleContext<InstrContext>(i);
		}
		public LabelContext[] label() {
			return GetRuleContexts<LabelContext>();
		}
		public LabelContext label(int i) {
			return GetRuleContext<LabelContext>(i);
		}
		public ITerminalNode[] NEWLINE() { return GetTokens(AssemblerParser.NEWLINE); }
		public ITerminalNode NEWLINE(int i) {
			return GetToken(AssemblerParser.NEWLINE, i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				{
				State = 12; globals();
				}
				break;
			}
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 19;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
				case 1:
					{
					State = 15; functionDeclaration();
					}
					break;
				case 2:
					{
					State = 16; instr();
					}
					break;
				case 3:
					{
					State = 17; label();
					}
					break;
				case 4:
					{
					State = 18; Match(NEWLINE);
					}
					break;
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << ID) | (1L << NEWLINE))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GlobalsContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(AssemblerParser.INT, 0); }
		public ITerminalNode[] NEWLINE() { return GetTokens(AssemblerParser.NEWLINE); }
		public ITerminalNode NEWLINE(int i) {
			return GetToken(AssemblerParser.NEWLINE, i);
		}
		public GlobalsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_globals; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterGlobals(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitGlobals(this);
		}
	}

	[RuleVersion(0)]
	public GlobalsContext globals() {
		GlobalsContext _localctx = new GlobalsContext(Context, State);
		EnterRule(_localctx, 2, RULE_globals);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==NEWLINE) {
				{
				{
				State = 23; Match(NEWLINE);
				}
				}
				State = 28;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 29; Match(T__0);
			State = 30; Match(INT);
			State = 31; Match(NEWLINE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionDeclarationContext : ParserRuleContext {
		public IToken name;
		public IToken args;
		public IToken locs;
		public ITerminalNode NEWLINE() { return GetToken(AssemblerParser.NEWLINE, 0); }
		public ITerminalNode ID() { return GetToken(AssemblerParser.ID, 0); }
		public ITerminalNode[] INT() { return GetTokens(AssemblerParser.INT); }
		public ITerminalNode INT(int i) {
			return GetToken(AssemblerParser.INT, i);
		}
		public FunctionDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionDeclaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterFunctionDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitFunctionDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public FunctionDeclarationContext functionDeclaration() {
		FunctionDeclarationContext _localctx = new FunctionDeclarationContext(Context, State);
		EnterRule(_localctx, 4, RULE_functionDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33; Match(T__1);
			State = 34; _localctx.name = Match(ID);
			State = 35; Match(T__2);
			State = 36; Match(T__3);
			State = 37; Match(T__4);
			State = 38; _localctx.args = Match(INT);
			State = 39; Match(T__5);
			State = 40; Match(T__6);
			State = 41; Match(T__4);
			State = 42; _localctx.locs = Match(INT);
			State = 43; Match(NEWLINE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstrContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(AssemblerParser.ID, 0); }
		public ITerminalNode NEWLINE() { return GetToken(AssemblerParser.NEWLINE, 0); }
		public OperandContext[] operand() {
			return GetRuleContexts<OperandContext>();
		}
		public OperandContext operand(int i) {
			return GetRuleContext<OperandContext>(i);
		}
		public InstrContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterInstr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitInstr(this);
		}
	}

	[RuleVersion(0)]
	public InstrContext instr() {
		InstrContext _localctx = new InstrContext(Context, State);
		EnterRule(_localctx, 6, RULE_instr);
		try {
			State = 65;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 45; Match(ID);
				State = 46; Match(NEWLINE);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 47; Match(ID);
				State = 48; operand();
				State = 49; Match(NEWLINE);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 51; Match(ID);
				State = 52; operand();
				State = 53; Match(T__5);
				State = 54; operand();
				State = 55; Match(NEWLINE);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 57; Match(ID);
				State = 58; operand();
				State = 59; Match(T__5);
				State = 60; operand();
				State = 61; Match(T__5);
				State = 62; operand();
				State = 63; Match(NEWLINE);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperandContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(AssemblerParser.ID, 0); }
		public ITerminalNode REG() { return GetToken(AssemblerParser.REG, 0); }
		public ITerminalNode ADDR() { return GetToken(AssemblerParser.ADDR, 0); }
		public ITerminalNode FUNC() { return GetToken(AssemblerParser.FUNC, 0); }
		public ITerminalNode INT() { return GetToken(AssemblerParser.INT, 0); }
		public ITerminalNode CHAR() { return GetToken(AssemblerParser.CHAR, 0); }
		public ITerminalNode STRING() { return GetToken(AssemblerParser.STRING, 0); }
		public ITerminalNode FLOAT() { return GetToken(AssemblerParser.FLOAT, 0); }
		public OperandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operand; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterOperand(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitOperand(this);
		}
	}

	[RuleVersion(0)]
	public OperandContext operand() {
		OperandContext _localctx = new OperandContext(Context, State);
		EnterRule(_localctx, 8, RULE_operand);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 67;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << REG) | (1L << ADDR) | (1L << ID) | (1L << FUNC) | (1L << INT) | (1L << CHAR) | (1L << STRING) | (1L << FLOAT))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(AssemblerParser.ID, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAssemblerListener typedListener = listener as IAssemblerListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(Context, State);
		EnterRule(_localctx, 10, RULE_label);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 69; Match(ID);
			State = 70; Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x15', 'K', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x5', '\x2', 
		'\x10', '\n', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x6', '\x2', '\x16', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x17', 
		'\x3', '\x3', '\a', '\x3', '\x1B', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 
		'\x1E', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x44', '\n', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x2', '\x2', '\b', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\x2', 
		'\x3', '\x4', '\x2', '\n', '\xE', '\x11', '\x13', '\x2', 'M', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '#', '\x3', '\x2', '\x2', '\x2', '\b', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x45', '\x3', '\x2', '\x2', '\x2', '\f', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\x10', '\x5', '\x4', '\x3', '\x2', '\xF', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\x10', '\x15', '\x3', '\x2', '\x2', '\x2', '\x11', '\x16', '\x5', '\x6', 
		'\x4', '\x2', '\x12', '\x16', '\x5', '\b', '\x5', '\x2', '\x13', '\x16', 
		'\x5', '\f', '\a', '\x2', '\x14', '\x16', '\a', '\x15', '\x2', '\x2', 
		'\x15', '\x11', '\x3', '\x2', '\x2', '\x2', '\x15', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x13', '\x3', '\x2', '\x2', '\x2', '\x15', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x15', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\x3', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1B', 
		'\a', '\x15', '\x2', '\x2', '\x1A', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\x1C', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1F', 
		'\x3', '\x2', '\x2', '\x2', '\x1E', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', ' ', '\a', '\x3', '\x2', '\x2', ' ', '!', '\a', '\xE', '\x2', 
		'\x2', '!', '\"', '\a', '\x15', '\x2', '\x2', '\"', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '#', '$', '\a', '\x4', '\x2', '\x2', '$', '%', '\a', '\f', 
		'\x2', '\x2', '%', '&', '\a', '\x5', '\x2', '\x2', '&', '\'', '\a', '\x6', 
		'\x2', '\x2', '\'', '(', '\a', '\a', '\x2', '\x2', '(', ')', '\a', '\xE', 
		'\x2', '\x2', ')', '*', '\a', '\b', '\x2', '\x2', '*', '+', '\a', '\t', 
		'\x2', '\x2', '+', ',', '\a', '\a', '\x2', '\x2', ',', '-', '\a', '\xE', 
		'\x2', '\x2', '-', '.', '\a', '\x15', '\x2', '\x2', '.', '\a', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\a', '\f', '\x2', '\x2', '\x30', '\x44', 
		'\a', '\x15', '\x2', '\x2', '\x31', '\x32', '\a', '\f', '\x2', '\x2', 
		'\x32', '\x33', '\x5', '\n', '\x6', '\x2', '\x33', '\x34', '\a', '\x15', 
		'\x2', '\x2', '\x34', '\x44', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', 
		'\a', '\f', '\x2', '\x2', '\x36', '\x37', '\x5', '\n', '\x6', '\x2', '\x37', 
		'\x38', '\a', '\b', '\x2', '\x2', '\x38', '\x39', '\x5', '\n', '\x6', 
		'\x2', '\x39', ':', '\a', '\x15', '\x2', '\x2', ':', '\x44', '\x3', '\x2', 
		'\x2', '\x2', ';', '<', '\a', '\f', '\x2', '\x2', '<', '=', '\x5', '\n', 
		'\x6', '\x2', '=', '>', '\a', '\b', '\x2', '\x2', '>', '?', '\x5', '\n', 
		'\x6', '\x2', '?', '@', '\a', '\b', '\x2', '\x2', '@', '\x41', '\x5', 
		'\n', '\x6', '\x2', '\x41', '\x42', '\a', '\x15', '\x2', '\x2', '\x42', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\x43', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x31', '\x3', '\x2', '\x2', '\x2', '\x43', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x43', ';', '\x3', '\x2', '\x2', '\x2', '\x44', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\t', '\x2', '\x2', 
		'\x2', '\x46', '\v', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', '\f', 
		'\x2', '\x2', 'H', 'I', '\a', '\x5', '\x2', '\x2', 'I', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\xF', '\x15', '\x17', '\x1C', '\x43',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace J77E524P.Assembler