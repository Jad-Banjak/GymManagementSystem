# Database Setup

SQL scripts for the **Gym Management System** desktop application.  
Main project documentation: [../README.md](../README.md)

---

## What to commit on GitHub

| Include | Do not include |
|---------|----------------|
| `01_CreateDatabase.sql` | `.mdf` / `.ldf` database files |
| `02_SeedData.sql` | Production backups (`.bak`) |
| `03_ValidateDemoData.sql` | Real passwords or personal connection strings |

---

## Warning

`01_CreateDatabase.sql` **drops and recreates** all application tables. All existing data in `Users`, `Members`, `Payments`, `Machines`, and `MembershipPlans` will be **deleted**. Use only for initial setup or an intentional reset.

---

## Quick setup (SSMS)

1. Install [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express is fine).
2. Open **SQL Server Management Studio (SSMS)** and connect to your instance.
3. Run scripts **in this order**:

| Order | Script | Purpose |
|-------|--------|---------|
| 1 | `01_CreateDatabase.sql` | Creates database, tables, keys, and check constraints |
| 2 | `02_SeedData.sql` | Inserts extended demo / portfolio data |
| 3 | `03_ValidateDemoData.sql` | *(Optional)* Prints row counts and dashboard checks |

4. Configure the app connection string in `../GymManagementSystem/App.config` (see [App.config.example](../GymManagementSystem/App.config.example)).

### Command line (optional)

```powershell
sqlcmd -S ".\YOUR_INSTANCE" -E -i "01_CreateDatabase.sql"
sqlcmd -S ".\YOUR_INSTANCE" -E -i "02_SeedData.sql"
sqlcmd -S ".\YOUR_INSTANCE" -E -i "03_ValidateDemoData.sql"
```

Replace `.\YOUR_INSTANCE` with your server (e.g. `localhost`, `.\SQLEXPRESS`, `.\DUGINSIGHT`).

---

## Connection string

In `GymManagementSystem/App.config`:

```xml
<add name="GymDb"
     connectionString="Server=localhost;Database=GymManagementSystem;Integrated Security=True;"
     providerName="System.Data.SqlClient" />
```

Use `App.config.example` as a template. Do not commit machine-specific server names if you prefer—each developer sets their own locally.

---

## Demo credentials

All seeded users share password **`Admin123!`** (SHA-256 hash in `PasswordHelper.cs`).

| Role | Email | Password |
|------|-------|----------|
| Admin | admin@gym.local | Admin123! |
| Staff | staff@gym.local | Admin123! |
| Staff | morgan@gym.local | Admin123! |
| Staff | jordan@gym.local | Admin123! *(inactive)* |

Public **Sign up** in the app creates **Staff** accounts only. **Admin** accounts come from this seed script or the admin user panel.

---

## Demo data summary

After `02_SeedData.sql`:

| Table | Records | Notes |
|-------|---------|-------|
| MembershipPlans | 5 | Includes 1 inactive plan |
| Users | 4 | 1 admin, 3 staff |
| Members | 12 | Active, expired, expiring soon |
| Payments | 19 | Paid, Pending, Cancelled |
| Machines | 12 | Active, Maintenance, Inactive |

---

## Schema overview

| Table | Purpose |
|-------|---------|
| `MembershipPlans` | Plan name, duration, price, status |
| `Members` | Member profiles linked to plans |
| `Payments` | Payments linked to members (cascade delete on member) |
| `Machines` | Gym equipment inventory |
| `Users` | Admin/staff login accounts |

Key constraints include role checks (`Admin` / `Staff`), payment status values, and machine status values aligned with the WinForms UI dropdowns.

---

## Author

**Jad Banjak**

- GitHub: [https://github.com/Jad-Banjak](https://github.com/Jad-Banjak)
- LinkedIn: [https://www.linkedin.com/in/jadbanjak/](https://www.linkedin.com/in/jadbanjak/)
