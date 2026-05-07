import time
import requests
import os
import sys

def console_clear():
  os.system("cls")

def get_coordinates(city):
    url = f"https://geocoding-api.open-meteo.com/v1/search?name={city}&count=1"
    response = requests.get(url)
    data = response.json()
    if "results" not in data:
        return None, None
    lat = data["results"][0]["latitude"]
    lon = data["results"][0]["longitude"]
    return lat, lon
def get_weather(lat, lon):
    url = f"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,weather_code,wind_speed_10m"
    data = requests.get(url).json()
    return data["current"]

def decode_weather(code):
    if code == 0:
        return "Klarer Himmel"
    elif code <= 3:
        return "Bewölkt"
    elif code <= 48:
        return "Nebel"
    elif code <= 67:
        return "Regen"
    elif code <= 77:
        return "Schnee"
    elif code >= 95:
        return "Gewitter"
    else:
        return "Unbekannt"

def dashboard():
    print("Willkommen im Weather Dashboard")
    time.sleep(0.5)
    ort = input("Nach welchem Ort willst du suchen? ")
    print("Suche Koordinaten...")
    lat, lon = get_coordinates(ort)
    if lat is None:
        print("Ort nicht gefunden")
        return
    print(f"Ort {ort} gefunden")
    time.sleep(0.5)
    weather = get_weather(lat, lon)
    temp = weather["temperature_2m"]
    wind = weather["wind_speed_10m"]
    code = weather["weather_code"]
    weather_text = decode_weather(code)
    print("\nWEATHER REPORT")
    print(f"Ort: {ort}")
    print(f"Temperatur: {temp}°C")
    print(f"Wind: {wind} km/h")
    print(f"Wetter: {weather_text}")
    choice = input('Wollen Sie nach einem weiterem Ort suchen?\n')
    if choice.lower() == 'nein' or choice.lower() == 'n':
      os.system('cls')
      print('Programm wurde beendet.')
      sys.exit()

    print('Wird neu gestartet...')
    time.sleep(4)
    console_clear()
    

def main():
    while True:
      dashboard()

if __name__ == "__main__":
    main()

