def multipliziere_iterativ(x, y):
    """
    Berechnet x * y iterativ durch Addition.
    """
    ergebnis = 0
    for _ in range(x):
        ergebnis += y
    return ergebnis

x = 3
y = 4
ergebnis = multipliziere_iterativ(x, y)
print(f"Iterativ: {x} * {y} = {ergebnis}")