﻿// Copyright (c) Stephen Tetley 2019
// License: BSD 3 Clause

#r "netstandard"
#r "System.Xml.Linq"
#r "System.Xml.ReaderWriter"
#r "System.Xml.XDocument"
#r "System.IO.FileSystem.Primitives"
open System.IO


#I @"C:\Users\stephen\.nuget\packages\system.io.packaging\4.5.0\lib\netstandard1.3"
#r "System.IO.Packaging"
#I @"C:\Users\stephen\.nuget\packages\DocumentFormat.OpenXml\2.9.1\lib\netstandard1.3"
#r "DocumentFormat.OpenXml"

#load "..\src\SheetDoc\Internal\Syntax.fs"
#load "..\src\SheetDoc\Internal\Render.fs"
open SheetDoc.Internal.Syntax
open SheetDoc.Internal.Render

let outputFile (name : string) : string = 
    Path.Combine(__SOURCE_DIRECTORY__, @"..\output", name)

let test01 () : unit = 
    let doc1 = 
        { Sheets = [ { SheetName = "Sheet_1" }; { SheetName = "Sheet_2" } ]
        }
    renderSpreadSheetDoc doc1 (outputFile "test01.xlsx")


    