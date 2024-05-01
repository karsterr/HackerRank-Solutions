# Enter your code here. Read input from STDIN. Print output to STDOUT
t = int(input())

for _ in range(t):
    s = input()
    
    even = ""
    odd = ""
    
    for i in range(len(s)):
        if i % 2 == 0:
            even += s[i]
        else:
            odd += s[i]
    
    print(even, odd)