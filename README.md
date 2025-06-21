# MVC-Calculator-using-DotNet
# 🧮 MVCCalculator

A simple calculator web application built with **ASP.NET Core MVC (.NET 6)**. It performs basic arithmetic operations like addition, subtraction, multiplication, and division using MVC architecture.

---

## 🚀 Features

- 📥 Input two numbers
- ➕ Perform arithmetic operations: `+`, `-`, `*`, `/`
- 🖥️ Built using ASP.NET Core MVC
- 🔧 Typed ViewModel with computation logic
- 💡 Validation and null-checks for division

---

## 🏗️ Project Structure

MVCCalculator/
├── Controllers/
│ └── CalculatorController.cs
├── Models/
│ └── CalculatorModel.cs
├── Views/
│ └── Calculator/
│ └── Index.cshtml
├── Program.cs
├── Startup.cs
├── MVCCalculator.csproj


---

## 🛠️ How to Run

Make sure you have [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) installed.

```bash
# 1. Clone the repo
git clone https://github.com/yourusername/MVCCalculator.git
cd MVCCalculator

# 2. Restore dependencies
dotnet restore

# 3. Build the project
dotnet build

# 4. Run the app
dotnet run


navigate to https://localhost:5001/Calculator
