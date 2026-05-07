def berechne_potenz(x, n):
    """
    Berechnet die n-te Potenz einer Zahl x (x^n).
    x und n sind natürliche Zahlen.
    """
    ergebnis = 1

    for _ in range(n):
        ergebnis = ergebnis * x
    return ergebnis

if __name__ == "__main__":
    print("Potenzberechnung y = x^n")
    try:
        basis = int(input("Bitte geben Sie die Basis (x) ein: "))
        exponent = int(input("Bitte geben Sie den Exponenten (n) ein: "))
        
        if basis < 0 or exponent < 0:
            print("Bitte nur natürliche Zahlen eingeben.")
        else:
            resultat = berechne_potenz(basis, exponent)
            print(f"{basis} hoch {exponent} ist: {resultat}")
            
    except ValueError:
        print("Ungültige Eingabe. Bitte geben Sie ganze Zahlen ein.")