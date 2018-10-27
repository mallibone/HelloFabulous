namespace HelloFabulous.macOS
open System
open AppKit

module main =
    [<EntryPoint>]
    let main args =
        NSApplication.Init ()
        NSApplication.SharedApplication.Delegate <- new AppDelegate(); // add this line
        NSApplication.Main (args)
        0
