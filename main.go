package main

import "fmt"

func main() {
    var command, commandType string
    for {
        fmt.Print("[>] ")
        fmt.Scanln(&command, &commandType)
        parseCmds()
    }
}
