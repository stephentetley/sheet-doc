﻿// Copyright (c) Stephen Tetley 2019
// License: BSD 3 Clause

namespace SheetDoc.Internal


module Syntax = 

    type Value = 
        | Int of int
        | Str of string

    type CellDoc = 
        { CellValue : Value }

    type RowDoc = 
        { RowCells : CellDoc list }
        

    type SheetDoc = 
        { SheetName : string
          SheetRows : RowDoc list
        }

    type SpreadSheetDoc = 
        { Sheets : SheetDoc list 
        }