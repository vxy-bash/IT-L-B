from re import A


name = input("Bitte geben Sie Ihren Namen ein: ")
gender = input("Bitte geben Sie Ihr Geschlecht ein: ")
Uhrzeit = input("Bitte geben Sie die Uhrzeit ein:")


if gender == "m":
   gender = "Mann"
else:
    gender = "Frau"

if Uhrzeit < "12:00":
    print("Guten Morgen, " + gender + " " + name + "!")
elif Uhrzeit < "18:00":
    print("Guten Tag, " + gender + " " + name + "!")
else:
    print("Guten Abend, " + gender + " " + name + "!")