package main

import (
  "fmt"
  "CloudCMD/cmd"
)
var command string
func parseCmd() {
  if command == "help" {
    doHelp(commandType)
  }
  if command == "pystall" {
    doPystall(commandType)
  }
}
