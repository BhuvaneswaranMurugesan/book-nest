# 📚 BookNest — Online Book Store

> A full-featured online bookstore built with ASP.NET Core MVC, Entity Framework Core, and MS SQL Server. Browse books, manage a cart, place orders, and administrate the store — all in one platform.

---

## 🚀 Tech Stack

| Layer      | Technology                        |
|------------|-----------------------------------|
| Backend    | ASP.NET Core 8 MVC                |
| Database   | Microsoft SQL Server              |
| ORM        | Entity Framework Core 8           |
| Frontend   | Razor Views + Bootstrap 5         |
| Auth       | ASP.NET Core Identity             |
| Version Control | Git + GitHub                 |

---

## ✨ Features

- 🔍 Browse and search books by title, author, or genre
- 🔐 User registration, login, and role-based access (User / Admin)
- 🛒 Shopping cart — add, remove, and update quantities
- 📦 Checkout and order placement with order history
- 🛠️ Admin panel — manage books (CRUD) and view all orders

---

## 🗂️ Project Structure

```
BookNest/
├── Controllers/         # Route handlers (Books, Cart, Orders, Admin, Auth)
├── Models/              # EF Core entity classes
├── ViewModels/          # Data transfer objects for Razor Views
├── Views/               # Razor .cshtml UI pages
│   ├── Books/
│   ├── Cart/
│   ├── Orders/
│   ├── Admin/
│   └── Shared/          # Layout, navbar, partials
├── Data/                # AppDbContext + migrations
├── Services/            # Business logic layer
├── wwwroot/             # Static files (CSS, JS, images)
└── appsettings.json     # Config (connection string, etc.)
```

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) (or SQL Server Express / LocalDB)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/booknest.git
cd booknest
```

### 2. Configure the Database

Open `appsettings.json` and update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=BookNestDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Apply Migrations

```bash
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run
```

Navigate to `https://localhost:5001` in your browser.

---

## 🌿 Git Branching Strategy

We follow a simple **feature-branch workflow**:

```
main          → stable, production-ready code only
dev           → active development branch (merge PRs here)
feature/xxx   → individual feature branches (branch off dev)
```

### Branch Naming Convention

| Type    | Format                    | Example                      |
|---------|---------------------------|------------------------------|
| Feature | `feature/short-desc`      | `feature/shopping-cart`      |
| Bug Fix | `fix/short-desc`          | `fix/login-redirect`         |
| Hotfix  | `hotfix/short-desc`       | `hotfix/order-null-ref`      |
| Chore   | `chore/short-desc`        | `chore/update-dependencies`  |

### Workflow

```bash
# Start a new feature
git checkout dev
git pull origin dev
git checkout -b feature/your-feature-name

# Work on your feature, then push
git add .
git commit -m "feat: add shopping cart functionality"
git push origin feature/your-feature-name

# Open a Pull Request → dev on GitHub
```

> **Rule:** Never push directly to `main` or `dev`. Always use Pull Requests.

---

## 💬 Commit Message Convention

Follow this format for clean commit history:

```
type: short description
```

| Type     | When to use                        |
|----------|------------------------------------|
| feat     | Adding a new feature               |
| fix      | Fixing a bug                       |
| chore    | Config, dependency, or setup tasks |
| refactor | Code restructure without new logic |
| style    | Formatting, naming cleanup         |
| docs     | README or documentation changes    |


---

## 👥 Team

| Name        | Role                        | GitHub                          |
|-------------|-----------------------------|---------------------------------|
| Bhuvanesh   | Developer                   | [@dev1](https://github.com)     |
| Danush      | Developer                   | [@dev2](https://github.com)     |

> Update this table with your real names and GitHub handles.

---

## 📋 Task Board

We track tasks using **GitHub Issues + Projects**.

- Use **Issues** to log bugs, features, and tasks
- Use **Labels** like `feature`, `bug`, `in-progress`, `done`
- Link PRs to issues using `Closes #issue-number` in your PR description

---

## 📄 License

This project is for educational/personal use.