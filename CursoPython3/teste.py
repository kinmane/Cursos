def main():
    n = int(input())

    vect = []

    for i in range(n):
        vect.append(float(input()))

    sum = 0

    for i in range(n):
        sum += vect[i]

    avg = sum / n

    print(f"AVERAGE HEIGHT = {avg:.2f}")
