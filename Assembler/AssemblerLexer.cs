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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class AssemblerLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, REG=8, ADDR=9, 
		ID=10, FUNC=11, INT=12, HEX_DIGIT=13, DIGIT=14, CHAR=15, STRING=16, FLOAT=17, 
		WS=18, NEWLINE=19;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "REG", "ADDR", 
		"ID", "FUNC", "LETTER", "INT", "HEX_DIGIT", "DIGIT", "CHAR", "STRING", 
		"STR_CHARS", "FLOAT", "WS", "NEWLINE"
	};


	public AssemblerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public AssemblerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static AssemblerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x15', '\xB7', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\n', '\x3', '\n', '\x6', '\n', 'S', '\n', '\n', '\r', '\n', 
		'\xE', '\n', 'T', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\a', '\v', 'Z', 
		'\n', '\v', '\f', '\v', '\xE', '\v', ']', '\v', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x5', '\xE', '\x66', '\n', '\xE', '\x3', '\xE', '\x6', '\xE', 'i', '\n', 
		'\xE', '\r', '\xE', '\xE', '\xE', 'j', '\x3', '\xF', '\x3', '\xF', '\x5', 
		'\xF', 'o', '\n', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\a', '\x13', '|', '\n', 
		'\x13', '\f', '\x13', '\xE', '\x13', '\x7F', '\v', '\x13', '\x3', '\x14', 
		'\x5', '\x14', '\x82', '\n', '\x14', '\x3', '\x14', '\x6', '\x14', '\x85', 
		'\n', '\x14', '\r', '\x14', '\xE', '\x14', '\x86', '\x3', '\x14', '\x3', 
		'\x14', '\x6', '\x14', '\x8B', '\n', '\x14', '\r', '\x14', '\xE', '\x14', 
		'\x8C', '\a', '\x14', '\x8F', '\n', '\x14', '\f', '\x14', '\xE', '\x14', 
		'\x92', '\v', '\x14', '\x3', '\x14', '\x5', '\x14', '\x95', '\n', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x6', '\x14', '\x99', '\n', '\x14', '\r', 
		'\x14', '\xE', '\x14', '\x9A', '\x6', '\x14', '\x9D', '\n', '\x14', '\r', 
		'\x14', '\xE', '\x14', '\x9E', '\x5', '\x14', '\xA1', '\n', '\x14', '\x3', 
		'\x15', '\x6', '\x15', '\xA4', '\n', '\x15', '\r', '\x15', '\xE', '\x15', 
		'\xA5', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\a', 
		'\x16', '\xAC', '\n', '\x16', '\f', '\x16', '\xE', '\x16', '\xAF', '\v', 
		'\x16', '\x5', '\x16', '\xB1', '\n', '\x16', '\x3', '\x16', '\x5', '\x16', 
		'\xB4', '\n', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\xAD', '\x2', 
		'\x17', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\x2', '\x1B', '\xE', '\x1D', '\xF', '\x1F', '\x10', '!', 
		'\x11', '#', '\x12', '%', '\x2', '\'', '\x13', ')', '\x14', '+', '\x15', 
		'\x3', '\x2', '\x6', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', '\x2', 
		'\x43', 'H', '\x63', 'h', '\x3', '\x2', '$', '$', '\x4', '\x2', '\v', 
		'\v', '\"', '\"', '\x2', '\xC7', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '-', '\x3', '\x2', '\x2', '\x2', '\x5', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\a', ';', '\x3', '\x2', '\x2', '\x2', '\t', '=', 
		'\x3', '\x2', '\x2', '\x2', '\v', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\r', '\x44', '\x3', '\x2', '\x2', '\x2', '\xF', '\x46', '\x3', '\x2', 
		'\x2', '\x2', '\x11', 'M', '\x3', '\x2', '\x2', '\x2', '\x13', 'P', '\x3', 
		'\x2', '\x2', '\x2', '\x15', 'V', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'^', '\x3', '\x2', '\x2', '\x2', '\x19', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x65', '\x3', '\x2', '\x2', '\x2', '\x1D', 'n', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', 'p', '\x3', '\x2', '\x2', '\x2', '!', 'r', 
		'\x3', '\x2', '\x2', '\x2', '#', 'v', '\x3', '\x2', '\x2', '\x2', '%', 
		'}', '\x3', '\x2', '\x2', '\x2', '\'', '\xA0', '\x3', '\x2', '\x2', '\x2', 
		')', '\xA3', '\x3', '\x2', '\x2', '\x2', '+', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '-', '.', '\a', '\x30', '\x2', '\x2', '.', '/', '\a', 'i', '\x2', 
		'\x2', '/', '\x30', '\a', 'n', '\x2', '\x2', '\x30', '\x31', '\a', 'q', 
		'\x2', '\x2', '\x31', '\x32', '\a', '\x64', '\x2', '\x2', '\x32', '\x33', 
		'\a', '\x63', '\x2', '\x2', '\x33', '\x34', '\a', 'n', '\x2', '\x2', '\x34', 
		'\x35', '\a', 'u', '\x2', '\x2', '\x35', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x37', '\a', '\x30', '\x2', '\x2', '\x37', '\x38', '\a', '\x66', 
		'\x2', '\x2', '\x38', '\x39', '\a', 'g', '\x2', '\x2', '\x39', ':', '\a', 
		'h', '\x2', '\x2', ':', '\x6', '\x3', '\x2', '\x2', '\x2', ';', '<', '\a', 
		'<', '\x2', '\x2', '<', '\b', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', 
		'\x63', '\x2', '\x2', '>', '?', '\a', 't', '\x2', '\x2', '?', '@', '\a', 
		'i', '\x2', '\x2', '@', '\x41', '\a', 'u', '\x2', '\x2', '\x41', '\n', 
		'\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\a', '?', '\x2', '\x2', '\x43', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', '.', '\x2', '\x2', 
		'\x45', '\xE', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\a', 'n', '\x2', 
		'\x2', 'G', 'H', '\a', 'q', '\x2', '\x2', 'H', 'I', '\a', '\x65', '\x2', 
		'\x2', 'I', 'J', '\a', '\x63', '\x2', '\x2', 'J', 'K', '\a', 'n', '\x2', 
		'\x2', 'K', 'L', '\a', 'u', '\x2', '\x2', 'L', '\x10', '\x3', '\x2', '\x2', 
		'\x2', 'M', 'N', '\a', 't', '\x2', '\x2', 'N', 'O', '\x5', '\x1B', '\xE', 
		'\x2', 'O', '\x12', '\x3', '\x2', '\x2', '\x2', 'P', 'R', '\a', '%', '\x2', 
		'\x2', 'Q', 'S', '\x5', '\x1D', '\xF', '\x2', 'R', 'Q', '\x3', '\x2', 
		'\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', '\x2', 'T', 'R', '\x3', '\x2', 
		'\x2', '\x2', 'T', 'U', '\x3', '\x2', '\x2', '\x2', 'U', '\x14', '\x3', 
		'\x2', '\x2', '\x2', 'V', '[', '\x5', '\x19', '\r', '\x2', 'W', 'Z', '\x5', 
		'\x19', '\r', '\x2', 'X', 'Z', '\x4', '\x32', ';', '\x2', 'Y', 'W', '\x3', 
		'\x2', '\x2', '\x2', 'Y', 'X', '\x3', '\x2', '\x2', '\x2', 'Z', ']', '\x3', 
		'\x2', '\x2', '\x2', '[', 'Y', '\x3', '\x2', '\x2', '\x2', '[', '\\', 
		'\x3', '\x2', '\x2', '\x2', '\\', '\x16', '\x3', '\x2', '\x2', '\x2', 
		']', '[', '\x3', '\x2', '\x2', '\x2', '^', '_', '\x5', '\x15', '\v', '\x2', 
		'_', '`', '\a', '*', '\x2', '\x2', '`', '\x61', '\a', '+', '\x2', '\x2', 
		'\x61', '\x18', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\t', '\x2', 
		'\x2', '\x2', '\x63', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x64', '\x66', 
		'\a', '/', '\x2', '\x2', '\x65', '\x64', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\x3', '\x2', '\x2', '\x2', '\x66', 'h', '\x3', '\x2', '\x2', 
		'\x2', 'g', 'i', '\x5', '\x1F', '\x10', '\x2', 'h', 'g', '\x3', '\x2', 
		'\x2', '\x2', 'i', 'j', '\x3', '\x2', '\x2', '\x2', 'j', 'h', '\x3', '\x2', 
		'\x2', '\x2', 'j', 'k', '\x3', '\x2', '\x2', '\x2', 'k', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', 'l', 'o', '\x5', '\x1F', '\x10', '\x2', 'm', 'o', 
		'\t', '\x3', '\x2', '\x2', 'n', 'l', '\x3', '\x2', '\x2', '\x2', 'n', 
		'm', '\x3', '\x2', '\x2', '\x2', 'o', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'p', 'q', '\x4', '\x32', ';', '\x2', 'q', ' ', '\x3', '\x2', '\x2', '\x2', 
		'r', 's', '\a', ')', '\x2', '\x2', 's', 't', '\v', '\x2', '\x2', '\x2', 
		't', 'u', '\a', ')', '\x2', '\x2', 'u', '\"', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\a', '$', '\x2', '\x2', 'w', 'x', '\x5', '%', '\x13', '\x2', 
		'x', 'y', '\a', '$', '\x2', '\x2', 'y', '$', '\x3', '\x2', '\x2', '\x2', 
		'z', '|', '\n', '\x4', '\x2', '\x2', '{', 'z', '\x3', '\x2', '\x2', '\x2', 
		'|', '\x7F', '\x3', '\x2', '\x2', '\x2', '}', '{', '\x3', '\x2', '\x2', 
		'\x2', '}', '~', '\x3', '\x2', '\x2', '\x2', '~', '&', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '}', '\x3', '\x2', '\x2', '\x2', '\x80', '\x82', '\a', 
		'/', '\x2', '\x2', '\x81', '\x80', '\x3', '\x2', '\x2', '\x2', '\x81', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '\x82', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x83', '\x85', '\x5', '\x1F', '\x10', '\x2', '\x84', '\x83', '\x3', 
		'\x2', '\x2', '\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', 
		'\x84', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x88', '\x3', '\x2', '\x2', '\x2', '\x88', '\x90', '\a', 
		'\x30', '\x2', '\x2', '\x89', '\x8B', '\x5', '\x1F', '\x10', '\x2', '\x8A', 
		'\x89', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\x3', '\x2', '\x2', 
		'\x2', '\x8C', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\x3', 
		'\x2', '\x2', '\x2', '\x8D', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x8E', 
		'\x8A', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x92', '\x3', '\x2', '\x2', 
		'\x2', '\x90', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\xA1', '\x3', '\x2', '\x2', '\x2', '\x92', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '\x93', '\x95', '\a', '/', '\x2', 
		'\x2', '\x94', '\x93', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\x3', 
		'\x2', '\x2', '\x2', '\x95', '\x96', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x9C', '\a', '\x30', '\x2', '\x2', '\x97', '\x99', '\x5', '\x1F', '\x10', 
		'\x2', '\x98', '\x97', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\x3', 
		'\x2', '\x2', '\x2', '\x9A', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		'\x9B', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '\x9C', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\x9E', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9E', 
		'\x9F', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\x81', '\x3', '\x2', '\x2', '\x2', '\xA0', '\x94', '\x3', 
		'\x2', '\x2', '\x2', '\xA1', '(', '\x3', '\x2', '\x2', '\x2', '\xA2', 
		'\xA4', '\t', '\x5', '\x2', '\x2', '\xA3', '\xA2', '\x3', '\x2', '\x2', 
		'\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA3', '\x3', 
		'\x2', '\x2', '\x2', '\xA5', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA6', 
		'\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\b', '\x15', '\x2', 
		'\x2', '\xA8', '*', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAD', '\a', 
		'=', '\x2', '\x2', '\xAA', '\xAC', '\v', '\x2', '\x2', '\x2', '\xAB', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAF', '\x3', '\x2', '\x2', 
		'\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xAE', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xAF', 
		'\xAD', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xA9', '\x3', '\x2', '\x2', 
		'\x2', '\xB0', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB3', '\x3', 
		'\x2', '\x2', '\x2', '\xB2', '\xB4', '\a', '\xF', '\x2', '\x2', '\xB3', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\x3', '\x2', '\x2', 
		'\x2', '\xB4', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\a', 
		'\f', '\x2', '\x2', '\xB6', ',', '\x3', '\x2', '\x2', '\x2', '\x16', '\x2', 
		'T', 'Y', '[', '\x65', 'j', 'n', '}', '\x81', '\x86', '\x8C', '\x90', 
		'\x94', '\x9A', '\x9E', '\xA0', '\xA5', '\xAD', '\xB0', '\xB3', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace J77E524P.Assembler