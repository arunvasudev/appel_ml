// Signature file for parser generated by fsyacc
module TigerParser
type token = 
  | LPAREN
  | RPAREN
  | LBRACE
  | RBRACE
  | LSQUARE
  | RSQUARE
  | LANGULAR
  | RANGULAR
  | COLON
  | SEMICOLON
  | COMMA
  | DOT
  | EQ
  | ASSIGN
  | NE
  | LT
  | GT
  | EOF
  | VAR
  | FUNCTION
  | TYPE
  | ARRAY
  | OF
  | IF
  | THEN
  | ELSE
  | INT of (int)
  | ID of (string)
type tokenId = 
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LSQUARE
    | TOKEN_RSQUARE
    | TOKEN_LANGULAR
    | TOKEN_RANGULAR
    | TOKEN_COLON
    | TOKEN_SEMICOLON
    | TOKEN_COMMA
    | TOKEN_DOT
    | TOKEN_EQ
    | TOKEN_ASSIGN
    | TOKEN_NE
    | TOKEN_LT
    | TOKEN_GT
    | TOKEN_EOF
    | TOKEN_VAR
    | TOKEN_FUNCTION
    | TOKEN_TYPE
    | TOKEN_ARRAY
    | TOKEN_OF
    | TOKEN_IF
    | TOKEN_THEN
    | TOKEN_ELSE
    | TOKEN_INT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (string) 
