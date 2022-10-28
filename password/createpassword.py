users=open("users.png","w",encoding="utf8")
users.write(f"{input('enter app')}\n{input('enter password')}")
users.close()