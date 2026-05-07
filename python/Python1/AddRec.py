def multiply_recursive(x, y):
    """
    Multipliziert x und y durch x-maliges Addieren von y (rekursiv).
    x * y = y + (x-1) * y
    """
    if x == 0:
        return 0
    else:
        return y + multiply_recursive(x - 1, y)

if __name__ == "__main__":
    x = 3
    y = 4
    print(f"Rekursiv: {x} * {y} = {multiply_recursive(x, y)}")