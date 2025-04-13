 # 🧮 C# Basics: Variable Declaration and Output

This simple C# console application demonstrates how to declare and display different types of numeric variables: `int`, `float`, and `double`. It serves as a foundational example for beginners learning C# programming and .NET fundamentals.

---

## 📌 Overview

The program performs the following tasks:

- Declares variables of different numeric data types
- Initializes them with sample values
- Displays the values using string interpolation
- Waits for a key press before closing

---

## 🧠 Concepts Covered

✅ Variable Declaration  
✅ Data Types (`int`, `float`, `double`)  
✅ String Interpolation (`$""`)  
✅ Console Output (`Console.WriteLine`)  
✅ User Input Pause (`Console.ReadKey()`)

---

## 🧾 Code Example

```csharp
using System;

namespace Helloworld {
    class Check {
        static void Main(string[] args) {
            int a = 50;
            float pi = 3.14f;
            double salary = 4500.76d;

            Console.WriteLine($"The value of a is {a}");
            Console.WriteLine($"The value of pi is {pi}");
            Console.WriteLine($"The value of salary is {salary}");

            Console.ReadKey();
        }
    }
}
💻 Sample Output
The value of a is 50
The value of pi is 3.14
The value of salary is 4500.76


🚀 How to Run
 1.Make sure .NET SDK is installed
2.👉 Download .NET SDK

Navigate to the project folder in your terminal:

 cd Helloworld
 dotnet run


📘 Notes

1.float literals must include the f suffix (e.g., 3.14f).

2.double literals can include the d suffix (optional but good practice)

3.Console.ReadKey() is used to keep the console window open after output




