def prime(a):
    
    if a < 2:
        return False
        
    for i in range(2, int(a**0.5) + 1):
        
        if a % i == 0:
            return False
            
    return True

fibonacci_numbers  = [0, 1]

while True:
    
    numbers = fibonacci_numbers[-1] + fibonacci_numbers[-2]
    
    if numbers >= 1000:
        
        break
    
    fibonacci_numbers.append(numbers)
    

primes_fibonaccis = [num for num in fibonacci_numbers if num > 0 and prime(num)]


print(f"Numbers between 0-1000 that are both Fibonacci and prime: {primes_fibonaccis}")
print(f"Total both prime and Fibonacci numbers: {len(primes_fibonaccis)}")
