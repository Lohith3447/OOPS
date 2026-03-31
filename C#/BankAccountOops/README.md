# Bank Account Management System (WinForms)

A practical Windows Forms application designed to demonstrate the core principles of **Object-Oriented Programming (OOP)** in C#.

## 🚀 Overview
This project simulates a basic banking system where users can create accounts, deposit funds, and withdraw money. The primary focus is showcasing OOPS Concepts.

## 🧠 OOP Concepts Implemented

### 1. Fundamentals
*   **Object Creation**: Dynamic instantiation of account objects based on user input.
*   **Constructors**: Used for initializing account details (Account Number, Holder Name, Initial Balance) at the moment of creation.

### 2. The Four Pillars
*   **Encapsulation**: Used `private` fields with `public` properties and methods to protect the account balance from unauthorized direct modification.
*   **Abstraction**: Hidden complex validation logic (like checking for sufficient funds) behind simple method calls like `Withdraw()`.
*   **Inheritance**: Created a base `Account` class with specialized derived classes (e.g., `SavingsAccount`, `CheckingAccount`) to reuse common logic.
*   **Polymorphism**: Implemented method overriding for different withdrawal rules or interest calculations across different account types.

## 🛠️ Tech Stack
*   **Language**: C#
*   **Framework**: .NET Windows Forms
*   **IDE**: Visual Studio

## 📸 How to Run
1. Open the `.sln` file in Visual Studio.
2. Press `F5` to build and run the application.
3. Use the form interface to interact with the OOP-driven logic.
