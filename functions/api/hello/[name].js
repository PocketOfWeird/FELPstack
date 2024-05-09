import { sayHello } from "../../../fsharp/hello/Program.fs.js";

export function onRequest(context) {
    let name = context.params.name;
    result = sayHello(name);
    return new Response(result);
}