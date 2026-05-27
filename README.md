# 📚 BookShopApp - Complete Online Book Store Management System

> A comprehensive desktop application for managing a complete online bookstore with user authentication, inventory management, shopping cart functionality, and order processing capabilities.

---

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Key Features](#key-features)
- [Technical Architecture](#technical-architecture)
- [System Requirements](#system-requirements)
- [Installation & Setup](#installation--setup)
- [Getting Started](#getting-started)
- [User Workflows](#user-workflows)
- [Database Schema](#database-schema)
- [Admin Credentials](#admin-credentials)
- [Project Structure](#project-structure)
- [Key Components](#key-components)
- [Technologies Used](#technologies-used)
- [Code Quality & Standards](#code-quality--standards)
- [Development Notes](#development-notes)
- [License & Credits](#license--credits)
- [Support & Documentation](#support--documentation)

---

## 🎯 Project Overview

**BookShopApp** is a full-featured Windows Forms application developed in C# using .NET Framework. The application provides a complete solution for online book store management, combining user-friendly interfaces with robust backend database operations.

### Purpose
The application is designed for:
- **Customers**: Browse books, manage shopping carts, place orders, and view order history
- **Administrators**: Manage inventory, process orders, handle user accounts, and generate reports



---

## ✨ Key Features

### 👤 User Authentication & Account Management

#### Customer Features
- **User Registration System**
  - Create new customer accounts with email validation
  - Secure password storage
  - Account profile management
  - User information update functionality
  
- **Login & Authentication**
  - Secure login for registered users
  - Session management
  - Password-based authentication
  - Login failure handling with error messages

#### Admin Features
- **Dedicated Admin Login Portal**
  - Separate admin authentication system
  - Hardcoded admin credentials for security
  - Admin dashboard access control
  - Session verification

### 📖 Book Management & Catalog

- **Browse Book Catalog**
  - View all available books in the store
  - Display book details including:
    - Title and Author
    - ISBN number
    - Price information
    - Stock availability
    - Book descriptions
    - Category information

- **Book Categories**
  - Fantasy books browsing
  - Horror books section
  - Romance novels collection
  - Mystery & Thriller section
  - Adventure stories category

- **Search & Filter**
  - Search books by title
  - Filter by category
  - Sort by price
  - Availability status

### 🛒 Shopping Cart Management

- **Add to Cart**
  - Add books to shopping cart with quantity selection
  - Real-time stock verification
  - Duplicate item handling
  - Price calculation on addition

- **View Cart**
  - Display all items in cart
  - View subtotal for each item
  - Modify quantities
  - Remove items from cart
  - Calculate total cart value

- **Cart Persistence**
  - Cart data stored in database
  - Cart recovery on re-login
  - Clear cart functionality

### 🛍️ Order Processing & Management

- **Order Placement**
  - Convert cart to order
  - Automatic order ID generation
  - Timestamp recording
  - Customer information association
  - Order confirmation

- **View Orders**
  - Display customer's order history
  - View order details
  - Track order status
  - See order dates and totals

- **Order Reports**
  - Generate order receipts
  - Crystal Reports integration
  - Bill generation in printable format
  - Order summaries

### 💾 Inventory Management (Admin Only)

- **Stock Management**
  - Update book quantities
  - Track stock levels
  - Low stock warnings
  - Stock status monitoring

- **Product Administration**
  - Add new books to catalog
  - Update book information
  - Manage pricing
  - Delete outdated entries

### 👥 User Management (Admin Only)

- **User Administration**
  - View all registered users
  - Update user information
  - Delete user accounts
  - Manage customer data

- **User Records**
  - Search users by ID
  - View user details
  - Modify user profiles
  - Account status management

### 📊 Reporting & Analytics

- **Crystal Reports Integration**
  - Order reports generation
  - Member/Customer reports
  - Inventory reports
  - Bill previews
  - Printable documents

- **Report Types**
  - Order History Reports
  - Customer Information Reports
  - Bill Receipts
  - Stock Status Reports

---

## 🏗️ Technical Architecture

### Application Layers

```
┌─────────────────────────────────────────┐
│     Presentation Layer (UI/Forms)       │
│   - Windows Forms Components            │
│   - User Interface Design               │
│   - Event Handling                      │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│     Business Logic Layer                │
│   - Data Processing                     │
│   - Validation Rules                    │
│   - Business Operations                 │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│     Data Access Layer (DAL)             │
│   - SQL Operations                      │
│   - Database Connectivity               │
│   - Query Execution                     │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│   Persistence Layer (SQL Server)        │
│   - Database Tables                     │
│   - Data Storage                        │
│   - Query Results                       │
└─────────────────────────────────────────┘
```

### Database Architecture

The application uses **SQL Server** with multiple interconnected databases:

#### Database 1: `oreader_db`
- **Purpose**: User authentication and account management
- **Key Tables**:
  - User credentials
  - Customer profiles
  - User account information

#### Database 2: `products_db`
- **Purpose**: Book catalog and inventory
- **Key Tables**:
  - Product information (Books)
  - Stock levels
  - Pricing data
  - Category information

#### Database 3: `cart_db`
- **Purpose**: Shopping cart management
- **Key Tables**:
  - Cart items
  - Customer cart associations
  - Temporary shopping data

#### Integration
- Databases are connected via SQL queries
- Foreign key relationships maintain data integrity
- Transaction support for order placement

---

## 💻 System Requirements

### Hardware Requirements
- **Processor**: Intel Core i3 or equivalent (minimum)
- **RAM**: 2 GB minimum, 4 GB recommended
- **Disk Space**: 500 MB for application and databases
- **Display**: 1024x768 resolution minimum

### Software Requirements
- **Operating System**: Windows 7, 8, 10, 11 (32-bit or 64-bit)
- **.NET Framework**: 4.7.2 or higher
- **SQL Server**: SQL Server 2012 or later
  - SQL Server Express Edition (free option)
  - SQL Server Developer Edition
  - Full SQL Server versions
- **IDE** (for development): Visual Studio 2019 or later

### Development Environment
- **Language**: C# (.NET Framework)
- **Framework**: Windows Forms
- **Reporting**: Crystal Reports
- **Version Control**: Git

---

## 🚀 Installation & Setup

### Step 1: Prerequisites Installation

1. **Install .NET Framework 4.7.2+**
   - Download from Microsoft official website
   - Follow standard installation wizard

2. **Install SQL Server**
   - Download SQL Server Express (free) or your preferred edition
   - Run setup wizard
   - Configure with default settings
   - Note your server name (typically `COMPUTERNAME` or `localhost\SQLEXPRESS`)

3. **Install Visual Studio** (for development)
   - Download Visual Studio Community 2022 (free)
   - Select ".NET desktop development" workload during installation
   - Install Crystal Reports extension if needed

### Step 2: Clone Repository

```bash
# Clone the repository
git clone https://github.com/NimnaOfficial/BookShopApp.git

# Navigate to project directory
cd BookShopApp
```

### Step 3: Database Configuration

1. **Open SQL Server Management Studio**

2. **Create Three Databases**:

   ```sql
   -- Create authentication database
   CREATE DATABASE oreader_db;
   
   -- Create products database
   CREATE DATABASE products_db;
   
   -- Create shopping cart database
   CREATE DATABASE cart_db;
   ```

3. **Configure Connection Strings**
   - Open project in Visual Studio
   - Locate the connection strings in source code files:
     - `Login.cs` - for oreader_db
     - `Addcart.cs` - for products_db
     - `Order.cs` - for cart_db
   - Update server name if different:
     ```csharp
     string cs = @"Data Source=YOUR_SERVER_NAME;
                   Initial Catalog=DATABASE_NAME;
                   Integrated Security=True";
     ```

### Step 4: Build & Run

1. **Open Solution in Visual Studio**
   ```
   File → Open → Project/Solution → Assign_04.sln
   ```

2. **Restore & Build**
   - Right-click solution in Solution Explorer
   - Select "Build Solution" (Ctrl+Shift+B)
   - Wait for compilation to complete

3. **Run Application**
   - Press F5 or click "Start Debugging"
   - Application window will open with login screen

---

## 🎮 Getting Started

### First Launch

1. **Application Starts with Opening Form**
   - Initial window displays entry options
   - Choose between Customer or Admin access

2. **Customer Path**
   - Click "Customer Login" or "Register New Customer"
   - Either login with existing credentials or register new account
   - Browse book catalog after authentication

3. **Admin Path**
   - Click "Admin Login"
   - Enter admin credentials
   - Access admin dashboard for management functions

### Initial Setup Considerations

- **Create Sample Data**: Manually insert book records in `products_db` using SQL Server Management Studio
- **Test Accounts**: Create test customer accounts for testing shopping workflow
- **Database Tables**: Ensure all required tables are created with proper schema

---

## 👥 User Workflows

### Customer Workflow

```
┌─────────┐
│  Start  │
└────┬────┘
     │
     ▼
┌──────────────┐      ┌────────────┐
│  Open Form   │─────▶│   Login    │
└──────────────┘      └────┬───────┘
                           │
                    ┌──────┴──────┐
                    │             │
                    ▼             ▼
              ┌─────────┐   ┌──────────┐
              │ Register│   │ Dashboard│
              └─────────┘   └────┬─────┘
                                 │
                    ┌────────────┼─────────────┐
                    ▼            ▼             ▼
              ┌─────────┐  ┌─────────┐  ┌──────────┐
              │Browse   │  │Category │  │My Orders │
              │Books    │  │Browse   │  │History   │
              └────┬────┘  └────┬────┘  └──────────┘
                   │            │
                   └────┬───────┘
                        ▼
                   ┌─────────────┐
                   │Add to Cart  │
                   └────┬────────┘
                        ▼
                   ┌─────────────┐
                   │View Cart    │
                   └────┬────────┘
                        │
                ┌───────┴────────┐
                │                │
               ▼                 ▼
        ┌──────────┐      ┌──────────┐
        │Modify    │      │Checkout  │
        │Cart      │      │Place Order
        └──────────┘      └────┬─────┘
                               │
                               ▼
                        ┌──────────────┐
                        │Order Created │
                        │Thank You Page│
                        └──────────────┘
```

### Admin Workflow

```
┌─────────┐
│  Start  │
└────┬────┘
     │
     ▼
┌──────────────┐      ┌──────────────┐
│  Open Form   │─────▶│  Admin Login │
└──────────────┘      └────┬─────────┘
                           │
                           ▼
                    ┌──────────────┐
                    │ Admin Menu   │
                    └────┬─────────┘
                         │
        ┌────────┬────────┼────────┬──────────┐
        ▼        ▼        ▼        ▼          ▼
    ┌─────┐ ┌──────┐ ┌────────┐ ┌─────┐ ┌──────────┐
    │Edit │ │Delete│ │Manage  │ │View │ │Generate  │
    │Stock│ │Users │ │Orders  │ │Users│ │Reports   │
    └─────┘ └──────┘ └────────┘ └─────┘ └──────────┘
```

---

## 🗄️ Database Schema

### oreader_db (User Authentication)

#### Users Table
```sql
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100),
    FullName NVARCHAR(100),
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
```

### products_db (Book Catalog)

#### Products Table
```sql
CREATE TABLE product_tbl (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    ISBN NVARCHAR(20),
    Category NVARCHAR(50),
    Price DECIMAL(10, 2) NOT NULL,
    Stock INT DEFAULT 0,
    Description NVARCHAR(MAX),
    PublishedDate DATETIME,
    IsAvailable BIT DEFAULT 1
);
```

### cart_db (Shopping Cart & Orders)

#### Cart Items Table
```sql
CREATE TABLE CartItems (
    CartItemID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    Quantity INT NOT NULL,
    AddedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES oreader_db.Users(UserID),
    FOREIGN KEY (BookID) REFERENCES products_db.product_tbl(BookID)
);
```

#### Orders Table
```sql
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10, 2) NOT NULL,
    OrderStatus NVARCHAR(50),
    ShippingAddress NVARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES oreader_db.Users(UserID)
);
```

#### Order Details Table
```sql
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    BookID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (BookID) REFERENCES products_db.product_tbl(BookID)
);
```

---

## 🔐 Admin Credentials

### Default Admin Account

**For accessing the Admin Dashboard:**

- **Username**: `KGLS17`
- **Password**: `20070612`

### Security Notes

⚠️ **Important**: 
- Admin credentials are **hardcoded** in `Admin_log.cs` for this project
- **NOT stored in the database** for security purposes
- Change these credentials in the source code before deployment in production
- Do NOT share admin credentials

### Accessing Admin Panel

1. Run the application
2. Click "Admin Login" button on opening form
3. Enter Username: `KGLS17`
4. Enter Password: `20070612`
5. Click Login to access admin dashboard

---

## 📁 Project Structure

```
BookShopApp/
│
├── README.md                          # This file
├── LICENSE.txt                        # MIT License
├── Admin (RM).txt                     # Admin notes and credentials
├── Assign_04.sln                      # Visual Studio Solution file
│
└── Assign_001/                        # Main Project Folder
    ├── Assign_001.csproj             # Project file
    │
    ├── Program.cs                     # Application entry point
    │
    ├── 📄 User Interface Forms/       # Windows Forms (.cs and .Designer.cs pairs)
    │   ├── Open.cs / Open.Designer.cs                # Opening/Welcome form
    │   ├── Login.cs / Login.Designer.cs              # Customer login form
    │   ├── Regist.cs / Regist.Designer.cs            # Customer registration form
    │   ├── Admin_log.cs / Admin_log.Designer.cs      # Admin login form
    │   ├── Admin_menu.cs / Admin_menu.Designer.cs    # Admin dashboard
    │   └── Bok_menu.cs / Bok_menu.Designer.cs        # Book menu/catalog
    │
    ├── 📚 Book Management/
    │   ├── Mys.cs / Mys.Designer.cs                  # Mystery books browsing
    │   ├── Fan.cs / Fan.Designer.cs                  # Fantasy books browsing
    │   ├── Hor.cs / Hor.Designer.cs                  # Horror books browsing
    │   ├── Rom.cs / Rom.Designer.cs                  # Romance books browsing
    │   ├── Nov.cs / Nov.Designer.cs                  # Novel books browsing
    │   ├── Adv.cs / Adv.Designer.cs                  # Adventure books browsing
    │   └── Cont.cs / Cont.Designer.cs                # Contact/Additional info
    │
    ├── 🛒 Shopping Cart & Orders/
    │   ├── Addcart.cs / Addcart.Designer.cs          # Add book to cart
    │   ├── ViwCart.cs / ViwCart.Designer.cs          # View shopping cart
    │   ├── Cont_open.cs / Cont_open.Designer.cs      # Continue shopping
    │   ├── Order.cs / Order.Designer.cs              # Order management
    │   ├── Viw_ords.cs / Viw_ords.Designer.cs        # View orders
    │   └── Thnx.cs / Thnx.Designer.cs                # Thank you page
    │
    ├── 👥 User Management/
    │   ├── frmDeleteUser.cs / frmDeleteUser.Designer.cs            # Delete user
    │   ├── frmUpdateUser.cs / frmUpdateUser.Designer.cs            # Update user info
    │   ├── frmDeleteAndUpdateAdmin.cs / frmDeleteAndUpdateAdmin.Designer.cs
    │   └── frmStockEdit.cs / frmStockEdit.Designer.cs              # Manage inventory
    │
    ├── 📋 Reporting/
    │   ├── CrystalReport1.cs                         # Report template 1
    │   ├── CrystalReport2.cs                         # Report template 2
    │   ├── BillReport1.cs                            # Bill report
    │   ├── MemsReport1.cs                            # Members/Users report
    │   ├── OrdReport1.cs                             # Orders report
    │   ├── Bill.cs / Bill.Designer.cs                # Bill display form
    │   ├── BillPreviewForm.cs / BillPreviewForm.Designer.cs  # Bill preview
    │   └── repoMemcs.cs / repoMemcs.Designer.cs      # Member report form
    │
    ├── 🗄️ Database & Data/
    │   ├── oreader_dbDataSet.Designer.cs             # Dataset for user database
    │   ├── repoOrds.cs / repoOrds.Designer.cs        # Orders dataset
    │   └── WEB.cs / WEB.Designer.cs                  # Web database utility
    │
    └── 📦 Project Resources/
        ├── Properties/
        │   ├── AssemblyInfo.cs                       # Assembly metadata
        │   ├── Settings.Designer.cs                  # Application settings
        │   └── Resources.Designer.cs                 # Resource files
        └── Resources/                                # Images, icons, assets
            └── (App images and media files)
```

---

## 🔧 Key Components

### Core Forms & Their Functions

#### 1. **Open.cs** - Application Entry Point
- **Purpose**: Initial welcome/menu screen
- **Features**: 
  - Navigation to Customer area
  - Navigation to Admin area
  - Application introduction
- **User Actions**: Select login type or registration

#### 2. **Login.cs** - Customer Authentication
- **Purpose**: Customer account login
- **Database**: `oreader_db`
- **Features**:
  - Username/Password validation
  - Error handling
  - SQL injection prevention
  - Session management
- **Flow**: Validates credentials → Opens Dashboard

#### 3. **Regist.cs** - Customer Registration
- **Purpose**: New customer account creation
- **Features**:
  - Input validation
  - Duplicate username checking
  - Database record insertion
  - Password confirmation
- **Flow**: Accepts new user info → Creates account → Auto-login or return to login

#### 4. **Bok_menu.cs** - Main Dashboard
- **Purpose**: Customer main menu after login
- **Features**:
  - Navigation to all book categories
  - Access to shopping cart
  - View order history
  - Logout functionality
- **Options**: Browse books by category, view cart, orders, logout

#### 5. **Addcart.cs** - Add to Cart
- **Purpose**: Add selected book to shopping cart
- **Database**: `products_db` → `cart_db`
- **Features**:
  - Quantity selection
  - Stock verification
  - Price calculation
  - Cart item insertion
- **Validation**: Checks stock availability before adding

#### 6. **ViwCart.cs** - View Shopping Cart
- **Purpose**: Display and manage cart contents
- **Features**:
  - List all items in cart
  - Calculate subtotals
  - Modify quantities
  - Remove items
  - Calculate total
  - Proceed to checkout

#### 7. **Order.cs** - Order Management
- **Purpose**: Process orders and manage order history
- **Features**:
  - Convert cart to order
  - Generate order ID
  - Record order timestamp
  - Store order in database
  - Display confirmation

#### 8. **Admin_menu.cs** - Admin Dashboard
- **Purpose**: Administrative operations center
- **Access**: Admin login required
- **Features**:
  - Manage book inventory
  - Manage users
  - View orders
  - Generate reports
  - Update stock levels

#### 9. **frmDeleteUser.cs** - User Deletion
- **Purpose**: Admin tool to delete customer accounts
- **Features**:
  - Search users by ID
  - Display user details
  - Confirm deletion
  - Database record removal

#### 10. **frmStockEdit.cs** - Inventory Management
- **Purpose**: Update product stock levels
- **Features**:
  - Search products by ID
  - Update stock quantity
  - Save changes to database

### Reporting Components

- **Crystal Reports**: Professional report generation
  - Bill receipts (BillReport1.cs)
  - Order reports (OrdReport1.cs)
  - Member/customer reports (MemsReport1.cs)
- **Report Forms**: Display and preview reports before printing

---

## 🛠️ Technologies Used

### Frontend
- **Framework**: Windows Forms (.NET Framework)
- **Language**: C# (Latest supported version)
- **UI Components**: Button, TextBox, DataGridView, ComboBox, ListBox
- **Event Handling**: Click, TextChanged, Load events

### Backend
- **Language**: C# with SQL Server integration
- **Data Access**: ADO.NET with SqlClient
- **Connection Management**: SqlConnection, SqlCommand, SqlDataReader
- **Transaction Support**: Available for multi-step operations

### Database
- **DBMS**: Microsoft SQL Server (2012 or later)
- **Edition**: Express / Developer / Enterprise
- **Connectivity**: Integrated Security / SQL Authentication

### Reporting
- **Tool**: Crystal Reports
- **Format**: Printable PDF-like documents
- **Reports Supported**:
  - Order summaries
  - Customer information
  - Bill receipts
  - Inventory status

### Development Tools
- **IDE**: Visual Studio 2022
- **Version Control**: Git/GitHub
- **Build System**: .NET Framework (MSBuild)
- **Compiler**: Roslyn C# Compiler

---

## 📊 Code Quality & Standards

### Architecture Pattern
- **Layered Architecture**:
  - Presentation Layer (Windows Forms)
  - Business Logic Layer
  - Data Access Layer (SQL queries)
  - Persistence Layer (SQL Server databases)

### Coding Conventions
- **Naming**:
  - Classes: PascalCase (e.g., `Login`, `Bok_menu`)
  - Methods: PascalCase (e.g., `Form_Load()`, `Button_Click()`)
  - Variables: camelCase (e.g., `userName`, `bookPrice`)
  - Constants: UPPER_CASE (e.g., `MAX_QUANTITY`)

- **Code Organization**:
  - Separate `.cs` and `.Designer.cs` files for UI and logic
  - Event handlers grouped logically
  - Database operations in dedicated methods
  - Validation logic before data operations

### Best Practices Implemented
- ✅ Input validation on all user entries
- ✅ Database connection management
- ✅ Proper error handling with try-catch blocks
- ✅ User feedback messages (MessageBox)
- ✅ Form state management
- ✅ Separation of UI and business logic
- ✅ SQL parameterized queries (when applicable)

### Error Handling
- **Exception Handling**: Try-catch blocks for risky operations
- **User Feedback**: MessageBox alerts for errors
- **Connection Errors**: Handled gracefully with user notifications
- **Validation**: Pre-operation checks before database writes

---

## 📝 Development Notes

### Database Connection Strings

The application uses hardcoded connection strings. Update these in the respective files:

**File Locations**:
- `Login.cs` - User authentication connection
- `Addcart.cs` - Product database connection
- `Order.cs` - Cart and order database connection
- `Admin_log.cs` - Admin authentication connection

**Connection String Format**:
```csharp
string cs = @"Data Source=SERVER_NAME;
              Initial Catalog=DATABASE_NAME;
              Integrated Security=True";
```

**Replace `SERVER_NAME` with**:
- Your machine name
- `localhost`
- `.` (dot) for local default instance
- `.\SQLEXPRESS` for SQL Server Express

### Testing Recommendations

1. **Unit Testing**:
   - Test login validation logic
   - Test cart calculations
   - Test order processing

2. **Integration Testing**:
   - Test database connections
   - Test multi-form workflows
   - Test data persistence

3. **User Testing**:
   - Test complete shopping workflow
   - Test admin operations
   - Test report generation

4. **Security Testing**:
   - SQL injection attempts
   - Authentication bypass attempts
   - Invalid input handling

### Known Limitations

- Connection strings are hardcoded (not production-ready)
- Admin credentials are hardcoded (not for production use)
- No password encryption for users
- Single-user session (no concurrent logins per account)
- No transaction support for order atomicity
- Crystal Reports must be installed separately

### Future Enhancement Opportunities

1. **Security Enhancements**:
   - Implement password hashing (bcrypt, PBKDF2)
   - Use encrypted connection strings
   - Add role-based access control

2. **Feature Additions**:
   - Payment gateway integration
   - Email notifications
   - Book reviews and ratings
   - Wishlist functionality
   - Discount coupons system

3. **Technical Improvements**:
   - Migrate to Entity Framework Core
   - Implement Repository pattern
   - Add comprehensive logging
   - Use dependency injection
   - Implement async/await patterns

4. **UI/UX Improvements**:
   - Modern UI framework (WPF)
   - Responsive design
   - Dark mode support
   - Accessibility features

---

## 📜 License & Credits

### License
This project is licensed under the **MIT License** - see [LICENSE.txt](LICENSE.txt) for details.

### Course Information
- **Course Code**: COCSE244F-021
- **Project Type**: Final GUI Project Assignment
- **Educational Purpose**: Learning C#, Windows Forms, and Database Management

### Developer & Credits
Developed as a comprehensive educational project for learning:
- C# Programming
- Windows Forms Development
- SQL Server Database Design
- Software Architecture
- Full-Stack Desktop Application Development

### Repository
- **Repository**: [NimnaOfficial/BookShopApp](https://github.com/NimnaOfficial/BookShopApp)
- **Owner**: NimnaOfficial
- **License**: MIT

---

## 🤝 Support & Documentation

### Getting Help

1. **Documentation**:
   - Read this comprehensive README
   - Review code comments in source files
   - Check inline documentation

2. **Troubleshooting**:
   - Verify SQL Server is running
   - Check database connection strings
   - Ensure .NET Framework 4.7.2+ is installed
   - Verify databases are created with correct names

3. **Common Issues**:

   **Issue**: "Cannot connect to database"
   - **Solution**: Check connection string server name, ensure SQL Server is running

   **Issue**: "Table not found"
   - **Solution**: Create required databases and tables using SQL scripts

   **Issue**: "Login fails"
   - **Solution**: Verify user exists in database, check credentials

   **Issue**: "Cannot open Crystal Reports"
   - **Solution**: Install Crystal Reports for Visual Studio

### Questions & Support

For questions or issues:
1. Check the troubleshooting section above
2. Review the Admin notes in `Admin (RM).txt`
3. Open an issue on GitHub repository
4. Review the source code documentation

---

## 📈 Version History

### Version 1.0 (Current)
- Initial release
- Core functionality implemented
- User authentication system
- Shopping cart and order management
- Admin dashboard
- Reporting capabilities

---

## 🎓 Educational Value

This project demonstrates:
- ✅ Multi-tier application architecture
- ✅ Windows Forms development best practices
- ✅ Relational database design
- ✅ ADO.NET data access
- ✅ Event-driven programming
- ✅ SQL query execution
- ✅ Business logic implementation
- ✅ User interface design
- ✅ Error handling and validation
- ✅ Report generation

---

**Last Updated**: May 2026

**Thank you for using BookShopApp! Happy reading and coding! 📚✨**
