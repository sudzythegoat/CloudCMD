package main

import (
  "fmt"
  "CloudCMD/cmd"
)

func parseCmd(command) {
  if command == "help" {
    doHelp(commandType)
  }
  if command == "pystall" {
    doPystall(commandType)
  }
  todo = "do{command}(commandtype)"
}
