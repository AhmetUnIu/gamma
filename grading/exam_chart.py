import matplotlib.pyplot as plt
import random

x = list(range(1, 13))

y_values = []

counter = 0

while counter < 12:
    y_values.append(random.randint(0, 100))
    counter += 1

plt.bar(x, y_values)
plt.xlabel("X Axis")
plt.ylabel("Y Axis")

plt.show()
