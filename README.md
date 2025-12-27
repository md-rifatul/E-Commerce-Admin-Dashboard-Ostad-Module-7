# ---

# 

# ```markdown

# \# 🛒 E-Commerce Admin Dashboard (ASP.NET Core MVC)

# 

# This is a simple ASP.NET Core MVC web application that simulates an admin dashboard for managing products in an e-commerce system. It is designed for learning purposes and does \*\*not\*\* use a database — all data is stored in memory and resets on application restart.

# 

# \## 📌 Project Features

# 

# \- 🏠 \*\*Home Page (Dashboard)\*\*  

# &nbsp; Displays a summary list of products showing:

# &nbsp; - Product Name

# &nbsp; - Price

# &nbsp; - Stock Quantity

# 

# \- 🛠️ \*\*Manage Products Page\*\*

# &nbsp; - View full product list (ID, Name, Description, Price, Stock Quantity)

# &nbsp; - Add new products via a form

# &nbsp; - Basic form validation (required fields)

# &nbsp; - Success message after adding a product

# 

# \- 🧠 \*\*In-Memory Data Storage\*\*  

# &nbsp; Products are stored in a static list — no database required.

# 

# \- 🧱 \*\*MVC Architecture\*\*  

# &nbsp; Clean separation of concerns using:

# &nbsp; - Models

# &nbsp; - Views

# &nbsp; - Controllers

# 

# \## 🗂️ Project Structure

# 

# ```

# E-Commerce Admin Dashboard/

# │

# ├── Controllers/

# │   ├── HomeController.cs

# │   └── ProductController.cs

# │

# ├── Models/

# │   ├── Product.cs

# │   └── ErrorViewModel.cs

# │

# ├── ViewModels/

# │   └── ProductViewModel.cs

# │

# ├── Services/

# │   ├── IServices/

# │   └── ProductService.cs

# │

# ├── Data/

# │   └── ProductStore.cs

# │

# ├── Views/

# │   ├── Home/

# │   ├── Product/

# │   └── Shared/

# │       ├── \_ViewImports.cshtml

# │       └── \_ViewStart.cshtml

# │

# ├── Mapper/

# │   └── ProductProfile.cs

# │

# ├── wwwroot/

# │

# ├── appsettings.json

# └── Program.cs

# ```

# 

# \## 🚀 Getting Started

# 

# \### Prerequisites

# 

# \- \[.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)

# \- Visual Studio 2022 or later

# 

# \### Run the Application

# 

# 1\. Clone the repository:

# &nbsp;  ```bash

# &nbsp;  git clone https://github.com/your-username/ecommerce-admin-dashboard.git

# &nbsp;  cd ecommerce-admin-dashboard

# &nbsp;  ```

# 

# 2\. Open the solution in Visual Studio.

# 

# 3\. Run the project using IIS Express or `dotnet run`.

# 

# 4\. Navigate to `https://localhost:xxxx` in your browser.

# 

# \## ✅ Usage

# 

# \- Visit the \*\*Home Page\*\* to see a summary of products.

# \- Click \*\*Manage Products\*\* to view the full list and add new products.

# \- Fill out the form and submit to add a product.

# \- A success message will appear and the product list will update.

# 

# \## 🧪 Validation

# 

# \- All fields in the product form are required.

# \- Price and Stock Quantity must be valid numbers.

# 

# \## 📚 Learning Goals

# 

# This project helps you practice:

# 

# \- ASP.NET Core MVC fundamentals

# \- Razor views and form handling

# \- GET and POST actions

# \- Routing and navigation

# \- In-memory data management

# \- Basic validation

# 

# \## 📄 License

# 

# This project is open-source and available under the \[MIT License](LICENSE).

# 

# ---

# 

# Happy coding! 🎉

# ```

