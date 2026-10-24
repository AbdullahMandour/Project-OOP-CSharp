# RestrantAPP

A restaurant ordering console application built with **C#** to practice **Object-Oriented Programming** (inheritance, abstraction, encapsulation, polymorphism) and the **Repository pattern**.

## Features

- Manage **Clients**, **Restaurants** and **Admins** (add, search, edit, delete)
- Manage the **Menu** (add meals, view all meals)
- Create and manage **Orders** (add, search, edit, delete, change status)
- Total price is calculated automatically from the meal price and quantity
- **Input validation**: if the user enters something invalid, the program shows an error and asks the same question again
- Data is stored in memory using generic repositories

## Tech Stack

- C# (.NET 6 or later)
- Console application (top-level statements)
- No external packages

## Project Structure

```
RestrantAPP/
├── Program.cs                  # Console UI and main menu
└── Classes/
    ├── CLSUsers.cs             # Abstract base class for all users
    ├── CLSClint.cs             # Client (inherits CLSUsers)
    ├── CLSRestrant.cs          # Restaurant (inherits CLSUsers)
    ├── CLSAdmin.cs             # Admin (inherits CLSUsers)
    ├── CLSMeal.cs              # Meal
    ├── CLSOrder.cs             # Order + OrderStatus enum
    ├── IRepositry.cs           # Generic repository interface
    ├── EmpClintRepositry.cs    # Client repository
    ├── EmpRestrantRepositry.cs # Restaurant repository
    ├── EmpAdminRepositry.cs    # Admin repository
    ├── EmpMealRepositry.cs     # Meal repository
    ├── EmpOrderRepositry.cs    # Order repository
    ├── ValidationHelper.cs     # Validation rules
    └── InputHelper.cs          # Reads input and re-asks until it is valid
```

## Class Diagram

```mermaid
classDiagram
    class CLSUsers {
        <<abstract>>
        +int UserId
        +string UserName
        +string Email
        +string Password
        +string Phone
        +string City
        +string Location
        +Login(email, password) bool
        +ShowOrder()* void
        +DisplayInfo() void
    }
    class CLSClint {
        +int FlatNumber
        +int FloorNumber
        +string SecondePhone
        +string DelivaryLocation
    }
    class CLSRestrant {
        +string Logo
        +string TaxCard
        +string Telephone
    }
    class CLSAdmin {
        +string JobName
    }
    class CLSMeal {
        +int MealId
        +string MealName
        +decimal MealPrice
        +int RestrantId
    }
    class CLSOrder {
        +int OrderId
        +int ClintId
        +int RestrantId
        +string OrderDetalis
        +OrderStatus Status
        +decimal TotalPrice
        +DateTime OrderDate
        +PrintOrder() void
    }
    class IRepositry~T~ {
        <<interface>>
        +GetAll() List~T~
        +GetById(id) T
        +Add(entity) bool
        +Edit(entity) bool
        +Delete(id) bool
    }

    CLSUsers <|-- CLSClint
    CLSUsers <|-- CLSRestrant
    CLSUsers <|-- CLSAdmin
    IRepositry <|.. EmpClintRepositry
    IRepositry <|.. EmpRestrantRepositry
    IRepositry <|.. EmpAdminRepositry
    IRepositry <|.. EmpMealRepositry
    IRepositry <|.. EmpOrderRepositry
```

## Program Flow

```mermaid
flowchart TD
    A([Start]) --> B[Seed default meals]
    B --> C[Show Main Menu]
    C --> D{User choice}

    D -->|1, 5, 6, 7| E[Client: Add / Search / Delete / Edit]
    D -->|2, 8, 9, 10| F[Restaurant: Add / Search / Delete / Edit]
    D -->|3, 11, 12, 13| G[Admin: Add / Search / Delete / Edit]
    D -->|14, 15, 16, 17| H[Order: Add / Search / Delete / Edit]
    D -->|18| I[Change Order Status]
    D -->|19, 20| J[Meal: Add / View Menu]
    D -->|4| K([Exit])
    D -->|Other| L[Invalid choice message]

    E --> M[Press any key]
    F --> M
    G --> M
    H --> M
    I --> M
    J --> M
    L --> M
    M --> C
```

## Input Validation Flow

Every text, number and price the user enters goes through the same loop. The program does not move to the next question until the answer is valid.

```mermaid
flowchart TD
    A[Ask the question] --> B[Read user input]
    B --> C{Valid? ValidationHelper}
    C -- No --> D[Show error message] --> A
    C -- Yes --> E[Go to next question]
```

### Validation rules

| Field | Rule |
|---|---|
| Name | Must not be empty |
| Email | Must be a valid email format |
| Phone | 11 digits and starts with `01` |
| Password | At least 8 characters |
| Price | A number greater than 0 |
| Numbers (IDs, flat, floor) | Must be a valid integer |
| Other text fields | Must not be empty |

## Add Order Flow

```mermaid
flowchart TD
    A[Enter Order ID] --> B{Order ID exists?}
    B -- Yes --> X[Show error]
    B -- No --> C[Enter Client ID and Restaurant ID]
    C --> D[Show menu, choose meal and quantity]
    D --> E{Meal exists?}
    E -- No --> X
    E -- Yes --> F[Total = meal price x quantity]
    F --> G[Save order with status Pending]
    G --> H([Back to menu])
    X --> H
```

## Order Status Flow

```mermaid
flowchart LR
    P[Pending] --> A[Approved]
    P --> R[Rejected]
    A --> D[Delivered]
    P --> C[Cancelled]
    A --> C
```

Available statuses: `Pending`, `Approved`, `Rejected`, `Delivered`, `Cancelled`.

## Main Menu

| Entity | Add | Search | Delete | Edit |
|---|---|---|---|---|
| Client | 1 | 5 | 6 | 7 |
| Restaurant | 2 | 8 | 9 | 10 |
| Admin | 3 | 11 | 12 | 13 |
| Order | 14 | 15 | 16 | 17 |

| Option | Action |
|---|---|
| 18 | Change order status |
| 19 | Add a new meal |
| 20 | View the menu |
| 4 | Exit |

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or later
- Visual Studio 2022 (optional)

### Run

```bash
git clone https://github.com/AbdullahMandour/Project-OOP-C-.git
cd Project-OOP-C-
dotnet run --project RestrantAPP
```

Or open `RestrantAPP.sln` in Visual Studio and press **F5**.

## How to Use

Data is stored in memory only, so it resets every time the program closes. To place an order:

1. Choose **1** and register a client.
2. Choose **2** and register a restaurant with ID **100** (the default meals belong to restaurant 100).
3. Choose **14** to create the order using the same client and restaurant IDs.
4. Choose **18** to approve or reject the order.

## Known Limitations and Future Work

- [ ] Store data in a database (SQL Server / SQLite) instead of in-memory lists
- [ ] Hash passwords instead of storing plain text
- [ ] Implement real login for each user type
- [ ] Support multiple meals in one order
- [ ] Fix spelling in class and member names (`Clint` → `Client`, `Restrant` → `Restaurant`, `Repositry` → `Repository`)

## Author

**Abdullah Mandour** ([@AbdullahMandour](https://github.com/AbdullahMandour))
