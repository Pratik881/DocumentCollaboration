# Collaborative Document Management System
A **Collaborative Document Management System** built with **ASP.NET Core MVC** using **Identity** for authentication and authorization. This project includes user registration, login, role-based access control, profile management, password reset via Gmail, and an advanced document collaboration feature.
## Features
✅ **User Authentication & Authorization** (ASP.NET Core Identity)  
✅ **Role-Based Access Control** (Admin, User, Collaborator)  
✅ **User Registration & Login**  
✅ **Profile Management**  
✅ **Password Reset via Gmail**  
✅ **Advanced Document Collaboration**  
   - Users can **create multiple documents**, each assigned a **unique ID**.  
   - Other users can **use the ID to collaborate** with the document owner.  
   - **Role-based access** ensures proper permission control.  
   
## Technologies Used
- **ASP.NET Core MVC**
- **ASP.NET Core Identity**
- **Entity Framework Core**
- **SQL Server**
- **Razor Views**
## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Pratik881/DocumentCollaboration.git
   ```
2. Navigate to the project directory:
   ```bash
   cd DocumentCollaboration
   ```
3. Update the appsettings.json file with the necessary details provided in appsettings.example.json
4. Apply database migrations:
   ```bash
   dotnet ef database update
   ```
5. Run the project:
   ```bash
   dotnet run
   ```
## Usage
- **Admin Role**: Manages users,documents, assigns roles, and oversees the system.
- **User Role**: Registers, logs in, and manages personal documents.
- **Collaborator Role**: Uses unique document IDs to collaborate with other users on shared documents.
