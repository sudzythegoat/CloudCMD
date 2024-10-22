import time
helpcmd = [
    {"cmd": "say", "help": "Repeats a phrase", "ex": "say help returns 'help'"}
    ]
while True:
    prompt = input("CMD ")
    if prompt.startswith("say"):
        message = prompt[4:]
        print(message)
    elif prompt.startswith("pyrun"):
        ctr = prompt[6:]
        try:
            eval(ctr)
        except Exception as e:
            print(f"Caught error: {e}")
            time.sleep(1)
    elif prompt.startswith("help "):
        command = prompt[5:]
        found = False
        for cmd_info in helpcmd:
            if cmd_info["cmd"] == command:
                print(f"{cmd_info['help']}")
                print(f"eg: {cmd_info['ex']}")
                found = True
                break
        if not found:
            print(f"No help available for command: {command}")
    
