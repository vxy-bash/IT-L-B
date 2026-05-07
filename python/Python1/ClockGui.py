import tkinter as tk
import time

def update_time():
    """
    Holt die aktuelle Zeit, formatiert sie und aktualisiert das Label.
    Ruft sich selbst nach 1000ms (1 Sekunde) erneut auf.
    """
    current_time = time.strftime('%H:%M:%S')
    
    clock_label.config(text=current_time)
    
    clock_label.after(1000, update_time)

root = tk.Tk()
root.title("Meine Uhr")

clock_label = tk.Label(root, font=('Arial', 60, 'bold'), background='black', foreground='cyan')

clock_label.pack(anchor='center')

update_time()

root.mainloop()