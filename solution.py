Sure, here is a Python console application that converts a number to an Excel-style column name and vice versa.

```python
def num_to_excel_col(num):
    result = ""
    while num > 0:
        num, remainder = divmod(num - 1, 26)
        result = chr(65 + remainder) + result
    return result

def excel_col_to_num(col):
    result = 0
    for i in range(len(col)):
        result *= 26
        result += ord(col[i]) - 64
    return result

def main():
    while True:
        print("\n1. Convert number to Excel-style column name")
        print("2. Convert Excel-style column name to number")
        print("3. Exit")
        choice = input("Enter your choice: ")
        if choice == '1':
            num = int(input("Enter a number: "))
            print("Excel-style column name: ", num_to_excel_col(num))
        elif choice == '2':
            col = input("Enter Excel-style column name: ")
            print("Number: ", excel_col_to_num(col))
        elif choice == '3':
            break
        else:
            print("Invalid choice. Please enter 1, 2 or 3.")

if __name__ == "__main__":
    main()
```

This console application provides a menu to the user to choose between converting a number to an Excel-style column name, converting an Excel-style column name to a number, or exiting the application. The conversion functions use the ASCII values of the uppercase English letters to perform the conversions.