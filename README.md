# 🖩 Calculator

A console-based Calculator application built with C#. This project
builds on the Math Game by introducing file persistence — calculation
history is saved to a text file and survives after the app closes.

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Requirements](#requirements)
- [Getting Started](#getting-started)
- [How to Use](#how-to-use)
- [Project Structure](#project-structure)
- [New Concepts Learned](#new-concepts-learned)
- [Technologies Used](#technologies-used)
- [License](#license)

---

## 📖 About the Project

This is a C# console application that functions as a basic calculator.
The user inputs two numbers, selects an arithmetic operation, and sees
the result. Every calculation is automatically saved to a local text
file so history is never lost between sessions.

This project is part of the **C# Foundation** series from the C# Academy
and introduces file I/O (input/output) as its core new concept.

---

## ✨ Features

- Addition, Subtraction, Multiplication and Division
- User-supplied numbers (not randomly generated)
- Calculation history saved to a local `.txt` file
- View full history from the menu
- Clear history from the menu
- Graceful handling of invalid input and division by zero

---

## ✅ Requirements

| # | Requirement |
|---|-------------|
| 1 | User inputs two numbers and selects an operation |
| 2 | App calculates and displays the result |
| 3 | All calculations are saved to a text file |
| 4 | User can view calculation history |
| 5 | User can clear the history file |
| 6 | Invalid input is handled without crashing |
| 7 | Division by zero is handled gracefully |

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio Code](https://code.visualstudio.com/) with the
  [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

### Installation

1. Clone the repository:
```bash
   git clone git@github.com:Timothynyezi/Calculator.git
```

2. Navigate into the project directory:
```bash
   cd Calculator
```

3. Run the application:
```bash
   dotnet run
```

---

## 🖩 How to Use

1. Launch the app with `dotnet run`
2. Enter your first number when prompted
3. Select an arithmetic operation from the menu
4. Enter your second number
5. View the result
6. Choose to calculate again, view history, clear history, or exit

---

## 📁 Project Structure
```
Calculator/
├── Program.cs            # Entry point and main application logic
├── FileHelper.cs         # Handles all file reading and writing
├── Calculator.csproj     # Project configuration
├── history.txt           # Auto-generated — stores calculation history
└── README.md             # Project documentation
```

---

## 🧠 New Concepts Learned

| Concept | Description |
|---|---|
| `File.WriteAllText()` | Write text content to a file |
| `File.AppendAllText()` | Add text to an existing file without overwriting |
| `File.ReadAllText()` | Read the full contents of a file |
| `File.Exists()` | Check if a file exists before reading |
| Multiple class files | Splitting code across more than one `.cs` file |

---

## 🛠 Technologies Used

- **Language:** C#
- **Framework:** .NET (Console Application)
- **IDE:** Visual Studio Code + C# Dev Kit
- **Version Control:** Git & GitHub

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---


