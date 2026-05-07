eingeben = int(input("Bitte geben Sie eine Zahl ein: "))
numbers = (0, 10, 12, 4, 7, 20, 21, 13)

gefunden = False  
gefunden_index = -1 

for i in range(len(numbers)):
    if numbers[i] == eingeben:
        gefunden_index = i + 1
        gefunden = True
        break 

if gefunden:
    print(f"Zahl gefunden an Position: {gefunden_index}")
else:
    print("Zahl nicht gefunden")