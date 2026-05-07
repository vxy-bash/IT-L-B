from turtle import *
import colorsys

bgcolor("black")
hideturtle()
speed(0)

def draw(g, e, w, farbe):
    if w == 0:
        return
    
    if e < 1:
        c = colorsys.hsv_to_rgb(farbe, 0.8, 1)
        pencolor(c)
        fd(g)
        lt(90)
        fd(g)
        lt(90)
        fd(g/2)
        lt(90)
    else:
        v = g / 4
        h = g / 2
        
        fd(g); lt(90)
        fd(v); lt(90)
        fd(v); lt(90)
        fd(h); lt(90)
        
        draw(h, e - 1, w, farbe + 0.05)
        
        fd(v)
        lt(180)
        
        if e < 4:
            fd(g); lt(90)
            fd(h); lt(90)
        else:
            draw(g, e, w - 1, farbe + 0.01)

pensize(1)
penup()
goto(0, -200)
lt(90)
pendown()

draw(250, 4, 6, 0.0)
done()