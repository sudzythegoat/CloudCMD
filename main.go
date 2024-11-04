package main

import "fmt"

func main() {
    var command, commandType string
    fmt.Scanln(&command, &commandType)
    parseCmds()
}
