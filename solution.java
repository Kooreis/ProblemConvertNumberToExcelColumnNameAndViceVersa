Here is a Java console application that converts a number to an Excel-style column name and vice versa.

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number to convert to Excel-style column name:");
        int number = scanner.nextInt();
        System.out.println("Excel-style column name: " + convertToTitle(number));

        System.out.println("Enter an Excel-style column name to convert to number:");
        scanner.nextLine();
        String columnName = scanner.nextLine();
        System.out.println("Number: " + titleToNumber(columnName));
    }

    public static String convertToTitle(int n) {
        StringBuilder result = new StringBuilder();

        while (n > 0) {
            n--;
            result.insert(0, (char)('A' + n % 26));
            n /= 26;
        }

        return result.toString();
    }

    public static int titleToNumber(String s) {
        int result = 0;
        for (int i = 0; i < s.length(); i++) {
            result = result * 26 + (s.charAt(i) - 'A' + 1);
        }
        return result;
    }
}
```

This application first asks the user to enter a number, which it then converts to an Excel-style column name using the `convertToTitle` method. It then asks the user to enter an Excel-style column name, which it converts to a number using the `titleToNumber` method.