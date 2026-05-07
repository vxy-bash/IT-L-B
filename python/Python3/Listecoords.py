import turtle


screen = turtle.Screen()
screen.title("Koordinatensystem mit Punkten")

t = turtle.Turtle()
t.speed(0)
t.hideturtle()


def draw_axes(length=300, step=50):
    t.penup()
    t.goto(-length, 0)  
    t.pendown()
    t.forward(length * 2)

    t.penup()
    t.goto(0, -length) 
    t.setheading(90)
    t.pendown()
    t.forward(length * 2)

    t.penup()
    for x in range(-length, length + 1, step):
        t.goto(x, 0)
        t.pendown()
        t.goto(x, -5)
        t.penup()
        t.goto(x, -20)
        t.write(str(x), align="center", font=("Arial", 8, "normal"))

    for y in range(-length, length + 1, step):
        if y == 0:
            continue  #
        t.goto(0, y)
        t.pendown()
        t.goto(5, y)
        t.penup()
        t.goto(20, y - 5)
        t.write(str(y), align="left", font=("Arial", 8, "normal"))

    t.setheading(0)


coords = [[50, 50], [10, 120], [170, -50]]


draw_axes()

t.penup()
for (x, y) in coords:
    t.goto(x, y)
    t.dot(15, "red")

turtle.done()
