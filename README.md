# 🛒 E-Commerce Admin Dashboard (ASP.NET Core MVC)

A lightweight ASP.NET Core MVC web application that simulates an admin dashboard for managing products in an e-commerce system. Designed for educational purposes, this project uses **in-memory data storage** — no database required.

---

## 📦 Features

### 🏠 Home Page (Dashboard)
- Displays a summary list of products:
  - Product Name
  - Price
  - Stock Quantity
- Includes a button to navigate to the **Manage Products** page.

### 🛠️ Manage Products Page
- View full product list:
  - ID, Name, Description, Price, Stock Quantity
- Add new products via a form.
- Form validation for required fields.
- Success message after product submission.

### 🧠 In-Memory Data
- Products are stored in a static list.
- Data resets on application restart.

### 🧱 MVC Architecture
- Clean separation of concerns:
  - Models
  - Views
  - Controllers

---

## 🗂️ Project Structure

```
E-Commerce Admin Dashboard/
│
├── Controllers/
│   ├── HomeController.cs
│   └── ProductController.cs
│
├── Models/
│   ├── Product.cs
│   └── ErrorViewModel.cs
│
├── ViewModels/
│   └── ProductViewModel.cs
│
├── Services/
│   ├── IServices/
│   └── ProductService.cs
│
├── Data/
│   └── ProductStore.cs
│
├── Views/
│   ├── Home/
│   ├── Product/
│   └── Shared/
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
│
├── Mapper/
│   └── ProductProfile.cs
│
├── wwwroot/
│
├── appsettings.json
└── Program.cs
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022 or later

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/ecommerce-admin-dashboard.git
   cd ecommerce-admin-dashboard
   ```

2. **Open the solution** in Visual Studio.

3. **Run the project** using IIS Express or:
   ```bash
   dotnet run
   ```

4. **Access the app** in your browser:
   ```
   https://localhost:xxxx
   ```

---

## ✅ Usage Guide

- Visit the **Home Page** to view product summaries.
- Click **Manage Products** to:
  - View full product details.
  - Add new products using the form.
- After submission:
  - A success message appears.
  - The product list updates automatically.

---

## 🧪 Validation Rules

- All form fields are required.
- Price and Stock Quantity must be valid numeric values.

---

## 🎯 Learning Objectives

This project helps reinforce:

- ASP.NET Core MVC fundamentals
- Razor views and form handling
- GET and POST actions
- Routing and navigation
- In-memory data management
- Basic validation techniques

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---
