// Implementation file for parser generated by fsyacc
module TigerParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Text.Lexing
open Microsoft.FSharp.Text.Parsing.ParseHelpers
# 1 "TigerParser.fsp"


# 9 "TigerParser.fs"
// This type is the type of tokens accepted by the parser
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
// This type is used to give symbolic names to token indexes, useful for error messages
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
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | LPAREN  -> 0 
  | RPAREN  -> 1 
  | LBRACE  -> 2 
  | RBRACE  -> 3 
  | LSQUARE  -> 4 
  | RSQUARE  -> 5 
  | LANGULAR  -> 6 
  | RANGULAR  -> 7 
  | COLON  -> 8 
  | SEMICOLON  -> 9 
  | COMMA  -> 10 
  | DOT  -> 11 
  | EQ  -> 12 
  | ASSIGN  -> 13 
  | NE  -> 14 
  | LT  -> 15 
  | GT  -> 16 
  | EOF  -> 17 
  | VAR  -> 18 
  | FUNCTION  -> 19 
  | TYPE  -> 20 
  | ARRAY  -> 21 
  | OF  -> 22 
  | IF  -> 23 
  | THEN  -> 24 
  | ELSE  -> 25 
  | INT _ -> 26 
  | ID _ -> 27 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_LPAREN 
  | 1 -> TOKEN_RPAREN 
  | 2 -> TOKEN_LBRACE 
  | 3 -> TOKEN_RBRACE 
  | 4 -> TOKEN_LSQUARE 
  | 5 -> TOKEN_RSQUARE 
  | 6 -> TOKEN_LANGULAR 
  | 7 -> TOKEN_RANGULAR 
  | 8 -> TOKEN_COLON 
  | 9 -> TOKEN_SEMICOLON 
  | 10 -> TOKEN_COMMA 
  | 11 -> TOKEN_DOT 
  | 12 -> TOKEN_EQ 
  | 13 -> TOKEN_ASSIGN 
  | 14 -> TOKEN_NE 
  | 15 -> TOKEN_LT 
  | 16 -> TOKEN_GT 
  | 17 -> TOKEN_EOF 
  | 18 -> TOKEN_VAR 
  | 19 -> TOKEN_FUNCTION 
  | 20 -> TOKEN_TYPE 
  | 21 -> TOKEN_ARRAY 
  | 22 -> TOKEN_OF 
  | 23 -> TOKEN_IF 
  | 24 -> TOKEN_THEN 
  | 25 -> TOKEN_ELSE 
  | 26 -> TOKEN_INT 
  | 27 -> TOKEN_ID 
  | 30 -> TOKEN_end_of_input
  | 28 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 30 
let _fsyacc_tagOfErrorTerminal = 28

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | LPAREN  -> "LPAREN" 
  | RPAREN  -> "RPAREN" 
  | LBRACE  -> "LBRACE" 
  | RBRACE  -> "RBRACE" 
  | LSQUARE  -> "LSQUARE" 
  | RSQUARE  -> "RSQUARE" 
  | LANGULAR  -> "LANGULAR" 
  | RANGULAR  -> "RANGULAR" 
  | COLON  -> "COLON" 
  | SEMICOLON  -> "SEMICOLON" 
  | COMMA  -> "COMMA" 
  | DOT  -> "DOT" 
  | EQ  -> "EQ" 
  | ASSIGN  -> "ASSIGN" 
  | NE  -> "NE" 
  | LT  -> "LT" 
  | GT  -> "GT" 
  | EOF  -> "EOF" 
  | VAR  -> "VAR" 
  | FUNCTION  -> "FUNCTION" 
  | TYPE  -> "TYPE" 
  | ARRAY  -> "ARRAY" 
  | OF  -> "OF" 
  | IF  -> "IF" 
  | THEN  -> "THEN" 
  | ELSE  -> "ELSE" 
  | INT _ -> "INT" 
  | ID _ -> "ID" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | LPAREN  -> (null : System.Object) 
  | RPAREN  -> (null : System.Object) 
  | LBRACE  -> (null : System.Object) 
  | RBRACE  -> (null : System.Object) 
  | LSQUARE  -> (null : System.Object) 
  | RSQUARE  -> (null : System.Object) 
  | LANGULAR  -> (null : System.Object) 
  | RANGULAR  -> (null : System.Object) 
  | COLON  -> (null : System.Object) 
  | SEMICOLON  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | DOT  -> (null : System.Object) 
  | EQ  -> (null : System.Object) 
  | ASSIGN  -> (null : System.Object) 
  | NE  -> (null : System.Object) 
  | LT  -> (null : System.Object) 
  | GT  -> (null : System.Object) 
  | EOF  -> (null : System.Object) 
  | VAR  -> (null : System.Object) 
  | FUNCTION  -> (null : System.Object) 
  | TYPE  -> (null : System.Object) 
  | ARRAY  -> (null : System.Object) 
  | OF  -> (null : System.Object) 
  | IF  -> (null : System.Object) 
  | THEN  -> (null : System.Object) 
  | ELSE  -> (null : System.Object) 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | ID _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; |]
let _fsyacc_action_rows = 2
let _fsyacc_actionTableElements = [|0us; 16385us; 0us; 49152us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 1us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 0us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; |]
let _fsyacc_reductions ()  =    [| 
# 228 "TigerParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (Microsoft.FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startstart));
# 237 "TigerParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 22 "TigerParser.fsp"
                                       "To come later!" 
                   )
# 22 "TigerParser.fsp"
                 : string));
|]
# 248 "TigerParser.fs"
let tables () : Microsoft.FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:Microsoft.FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 31;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : string =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))
