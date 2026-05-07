import turtle


screen = turtle.Screen()
screen.title("Zeichenprogramm mit Event-Handlern")
t = turtle.Turtle()
t.speed(0)
t.penup()
t.hideturtle()  

farbe = "black"
pinseldicke = 10




def draw_dot(x, y):
    t.goto(x, y)
    t.dot(pinseldicke, farbe)


def set_red():
    global farbe
    farbe = "red"

def set_green():
    global farbe
    farbe = "green"

def set_blue():
    global farbe
    farbe = "blue"

def set_yellow():
    global farbe
    farbe = "yellow"

# Pinseldicke ändern
def increase_size():
    global pinseldicke
    pinseldicke += 2  

def decrease_size():
    global pinseldicke
    if pinseldicke > 2:
        pinseldicke -= 2 


screen.onclick(draw_dot)        
screen.onkey(set_red, "r")      
screen.onkey(set_green, "g")    
screen.onkey(set_blue, "b")      
screen.onkey(set_yellow, "y")    
screen.onkey(increase_size, "Up")    
screen.onkey(decrease_size, "Down")  

screen.listen()  


turtle.done()
