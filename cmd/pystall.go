package main

import (
  "fmt"
  "os/exec"
)

func pystall(commandType string) {
  cmd := exec.Command("pip", "install", commandType)
  output, err := cmd.CombinedOutput()
  if err != nil {
    fmt.Println("Error executing pip command:", err)
  } else {
    fmt.Println("Installed", commandType)
  }
}
