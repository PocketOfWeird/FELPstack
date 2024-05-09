open Fetch

(*
type Name = Name of string
type ValidateName = string -> Name option
let validateName: ValidateName =
    fun (s) -> 
        if s.Length > 0 && s.Length <= 50
            then Some (Name s)
            else None

type SayHello = Name -> string
let sayHello:SayHello =
    fun (name) ->
        let (Name s) = name
        "Hello " + s
*)
let onRequest context =
    Response.create("Hello, world!")


(*

    export function onRequest(context) {
        return new Response("Hello, world!")
    }
*)