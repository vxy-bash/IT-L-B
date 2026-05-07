import turtle

def draw_correct_squares(size, count):
    t = turtle.Turtle()
    t.speed(0)
    
    current_size = size
    for _ in range(100):
        # Zeichne Quadrat
        for _ in range(4):
            t.forward(current_size)
            t.left(90)
        
        t.forward(current_size)
        t.left(90)
        t.forward(current_size)
        t.right(90)
        
        t.backward(current_size / 2)
        
        current_size /= 2


    turtle.done()

    

draw_correct_squares(100, 7)