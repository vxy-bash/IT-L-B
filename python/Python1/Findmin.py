def find_min(a, b, c):
    """
    Bestimmt das Minimum dreier verschiedener Werte.
    """
    if a < b and a < c:
        return a
    elif b < a and b < c:
        return b
    else:
        return c

if __name__ == "__main__":
    zahl1 = 10
    zahl2 = 5
    zahl3 = 8
    
    minimum = find_min(zahl1, zahl2, zahl3)
    print(f"Das Minimum von {zahl1}, {zahl2} und {zahl3} ist: {minimum}")