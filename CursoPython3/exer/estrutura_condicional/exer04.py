"""
4- Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
sabendo que o mesmo pode começar em um dia e terminar em outro, 
tendo uma duração mínima de 1 hora e máxima de 24 horas. 
"""

hour_start = int(input("Digite a hora inicial do jogo: "))
hour_end = int(input("Digite a hora final do jogo: "))

# Ensuring the hours are within the valid range
hour_start = max(1, min(24, hour_start))
hour_end = max(1, min(24, hour_end))

if hour_start < hour_end:
    duration = hour_end - hour_start
else:
    duration = 24 - hour_start + hour_end

print(f"A duração do jogo é de {duration} hora(s).")
