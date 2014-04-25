// チュートリアルを写経

// --------------------------------------------------
// 整数と基本的な関数
// --------------------------------------------------

module Integrs =
    let sampleInteger = 176

    // 最初の整数から演算
    let sampleInteger2 = (sampleInteger / 4 + 5 - 7) * 4

    /// 0 ～ 99 の数値のリストです。
    let sampleNumbers = [0 .. 99]

    /// 0 ～ 99 のすべての数値とその平方を含むｓべてのタプルのリストです。
    /// タプルとは
    let sampleTableOfSquares = [for i in 0 .. 99 -> (i, i*i)]

    // 次の行では、汎用向けに %A を使用して、タプルを含むリストを出力します
    printfn "The table of squares from 0 to 99 is:\n%A" sampleTableOfSquares

module BasicFunctions =

    // 'let' を使用して、整数引数を受け入れ、整数を返す関数を定義します。
    let func1 x = x * x + 3

    // かっこは、関数引数では省略可能です
    let func1a (x) = x * x + 3

    /// 関数を適用します。 'let' を使用し、関数の戻り値の結果に名前をつけます。
    /// 変数の型は、関数の戻り値の型から推論されます。
    let result1 = func1 4573
    printfn "The result of squaring the integer 4573 and adding 3 is %d" result1

    // 必要であれば、'(引数:型)' を使用してパラメータ名の型に注釈をつけます。
    let func2 (x:int) = 2 * x * x - x / 5 + 3

    let result2 = func2(7 + 4)
    printfn "The result of applying the 1st sample function to (7 + 4 ) is %d" result2

    // 型注釈をつけているからコンパイルエラー
    // let result2b = func2("b") 

    let func3 x = 
        if x < 100.0 then
            2.0 * x * x - x / 5.0 + 3.0
        else
            2.0 * x * x + x / 5.0 - 37.0

    let result3 = func3 (6.5 + 4.5)
    printfn "The result of applying the 2nd sample function to (6.5 + 4.5) is %f" result3

// ---------------------------------------------------------------
// ブール値
// ---------------------------------------------------------------

module SomeBooleanValues = 
    let boolean1 = true
    let boolean2 = false

    let boolean3 = not boolean1 && (boolean2 || false)

    printfn "The expression 'not boolean1 && (boolean2 || false)' is %A" boolean3

// ---------------------------------------------------------------
// 文字列
// ---------------------------------------------------------------

module StringManipulation = 
    
    let string1 = "Hello"
    let string2 = "world"

    /// @ を使用し、verbatim 文字列リテラルを作成します。
    let string3 = @"c:\Program Files\"

    /// 三重引用符で囲んだ文字列リテラルを作成します。
    let string4 = """ He said "hello world" after you did"""

    // 間にスペースを挿入して2つの文字列を連結します
    let helloWorld = string1 + " " + string2

    printfn "%s" helloWorld

    /// 結果の文字列の１つから最初の7文字を取得して作成された文字列です。
    let substring = helloWorld.[0..6]
    printfn "%s" substring

