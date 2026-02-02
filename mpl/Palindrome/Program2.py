list1 = [1, 5, 4, 9, 0]

# for i in meetings[::-1]:
#     print(i)

list2 = []
reverse_list = []

for i in range(len(list1)):
    # print(meetings[i], end = " ")
    list2.append(list1[i])


for i in range(len(list1) - 1, -1, -1):
    # print(meetings[i], end = " ")
    reverse_list.append(list1[i])

print(list2)
print(reverse_list)


if list2 == reverse_list:
    print("\nit is a polidron")
else:
    print("\nit is not a polidron")
