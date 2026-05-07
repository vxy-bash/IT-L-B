import os
import time
import random
import keyboard
from colorama import Fore, Back, Style, init

init(autoreset=True)

# --- EINSTELLUNGEN ---
CHANCE = 0.0000005  
BTC_PREIS = 62450.0
# ---------------------

balance_btc = 0.0
running = False

def draw_ui():
    os.system('cls' if os.name == 'nt' else 'clear')
    eur_val = balance_btc * BTC_PREIS
    print(f"{Fore.CYAN}CRYPTO MINER v1.2")
    print(f"{Fore.WHITE}BTC: {Fore.YELLOW}{balance_btc:.8f} {Fore.WHITE}| EUR: {Fore.GREEN}{eur_val:,.2f}€")
    print(f"Status: {Fore.GREEN if running else Fore.RED}{'RUNNING' if running else 'STOPPED'}")
    print(f"{Fore.WHITE}[S] Start | [C] Stop | [Q] Exit")
    print("-" * 45)

draw_ui()

while True:
    if keyboard.is_pressed('s') and not running:
        running = True
        draw_ui()
    
    if keyboard.is_pressed('c') and running:
        running = False
        draw_ui()
    
    if keyboard.is_pressed('q'):
        break

    if running:
        if random.random() < CHANCE:
            # Zufällige Block-Menge generieren
            reward = random.uniform(0.5, 6.25)
            balance_btc += reward
            running = False 
            
            draw_ui()
            
            print(f"\n{Back.GREEN}{Fore.BLACK} !!! BLOCK SOLVED !!! {Style.RESET_ALL}")
            print(f"{Fore.WHITE}Reward: {Fore.YELLOW}{reward:.4f} BTC")
            print(f"{Fore.WHITE}Value:  {Fore.GREEN}{reward * BTC_PREIS:,.2f}€")
            print(f"{Fore.CYAN}Bot gestoppt. Neustart mit 'S'.")
        else:
            print(f"{Fore.RED}NOTHING FOUND {Fore.BLACK}(Hash: {random.getrandbits(32):x}...)")
            # time.sleep(0.01)
    else:
        time.sleep(0.1)