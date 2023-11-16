a, y, e, u = int(input()), int(input()), int(input()), int(input())
 if abs(a - e) == 2 and abs(y- u) == 1 or abs(a - e) == 1 and \
         abs(y - u) == 2:
  print("YES")
 else:
  print("NO")

