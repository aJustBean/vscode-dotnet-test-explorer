module FSharpTests

open Xunit
open Shouldly

[<Fact>]
let ``This is a test that has spaces in it's name`` () =
   (true).ShouldBe(true)