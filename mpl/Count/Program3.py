# import random
# import math

# n = 10000000
# counter = 0

# for i in range(n):
#     x = random.random()
#     y = random.random()

    

#     if (0 <= x <= 1 and 0 <= y and y <= math.sqrt(1 - x**2) ):
    
#         counter += 1    
            
# print(counter)

# pi = 4*counter/n

# print(pi)

s = "araba, anahtar, Antalya, Ankara, Ardahan"

counter = 0

# count = s.count("a")


# print("number of a is: " + str(count))


for letter in s:
    if letter == "a":
        counter += 1
        
print(counter)
print(counter/len(s))
