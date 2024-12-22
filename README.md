# .NET 9 SETUP PROJECT

Welcome to the **.NET 9 Setup Project**! This repository is designed to help you understand and revise the basics of setting up a .NET 9 project.

---

## **PROJECT FEATURES**

### 1. **Entity Framework Core (EF Core)**
We are utilizing **Entity Framework Core (ORM)** with the **Code-First Approach** for database management. Below are the key commands:

- **Adding Migrations**:
  ```bash
  add-migration "Migration_Message"
  ```
  Use this command to create migrations for any CRUD operations in the database.

- **Running Migrations**:
  ```bash
  update-database
  ```
  This command runs all pending migrations to update the database.

### 2. **Package Restoration**
Before running the project, **restoring all the NuGet packages** is mandatory. Use the following command:
```bash
dotnet restore
```

### 3. **Authentication**
Authentication is not implemented yet but will be added in the future.

### 4. **Manual Mapping**
We are using **manual mapping** for mapping objects and DTOs in this project. Automappers will **not** be used.

### 5. **Dependency Injection (DI)**
The project implements **Simple Injector** for Dependency Injection. Refer to the official [Simple Injector documentation](https://simpleinjector.org/) for more details.

---

## **PROJECT SETUP INSTRUCTIONS**

### **1. Clone the Repository**
```bash
git clone https://github.com/yourusername/your-repository.git
```

### **2. Restore Packages**
```bash
dotnet restore
```

### **3. Run the Project**
Use the following command to run the application:
```bash
dotnet run
```

### **4. Apply Database Migrations**
- Add your migration:
  ```bash
  dotnet ef migrations add "YourMigrationName"
  ```
- Update your database:
  ```bash
  dotnet ef database update
  ```

---

## **FUTURE PLANS**

- Add **Authentication and Authorization**.
- Expand the project to include more advanced EF Core features.
- Optimize the dependency injection setup.

---

## **CONTRIBUTION GUIDELINES**
We welcome contributions! Please fork the repository, make your changes, and submit a pull request.

---

### **LICENSE**
This project is licensed under the [MIT License](LICENSE).

---

**Happy Coding!** 🎉


