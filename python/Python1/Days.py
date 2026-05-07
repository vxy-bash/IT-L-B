last_day_prev_year = int(input("letzter tag vom letzten jahr(1-7): "))

leap_flag = int(input("Ist es ein schalt jahr (1=ja, 0=nein): "))

days_in_month = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]

if leap_flag == 1:
    days_in_month[1] = 29

current_day = (last_day_prev_year % 7) + 1

for month in range(1, 13):
    if current_day == 7:
        print(f"Month {month}: 1st is Sunday")
    current_day = (current_day + days_in_month[month - 1] - 1) % 7 + 1