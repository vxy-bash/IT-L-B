name = input("Bitte geben Sie Ihren Namen ein: ")
Passwort = input("Bitte geben Sie Ihr Passwort ein: ")

if name == "Gast" and Passwort == "geheim":
    print("Zugang verweigert!")
else:
    print("Zugang gewährt!")
