def ggT(a, b):
    """
    Berechnet den größten gemeinsamen Teiler (ggT) zweier Zahlen
    mithilfe des Euklidischen Algorithmus (iterativ).
    """
    dividend = max(a, b)
    divisor = min(a, b)
    
    while divisor != 0:
        rest = dividend % divisor

        quotient = dividend // divisor
        print(f"{dividend} : {divisor} = {quotient} Rest {rest}")
        
        dividend = divisor
        divisor = rest
        
    return dividend

if __name__ == "__main__":
    zahl1 = 75
    zahl2 = 54
    
    print(f"Berechne ggT von {zahl1} und {zahl2}:")
    ergebnis = ggT(zahl1, zahl2)
    print(f"Der größte gemeinsame Teiler ist: {ergebnis}")