<h1 align="center">
  <a href="https://git.io/typing-svg">
    <img src="https://readme-typing-svg.herokuapp.com?font=Kaushan+Script&weight=500&size=50&duration=1000&pause=1000&color=98FFD0&center=true&vCenter=true&multiline=true&repeat=false&width=800&height=75&lines=CentSible+🪙" alt="Typing SVG" />
  </a>
</h1>

<p align="center">
  <img src="centsible.gif" width="600">
</p>

<p align="center">
  <a href="https://git.io/typing-svg">
    <img src="https://readme-typing-svg.herokuapp.com?font=Jersey+10&weight=500&size=16&duration=1000&pause=1000&color=98FFD0&center=true&vCenter=true&multiline=true&repeat=false&width=700&height=120&lines=Your+finances,+finally+under+control.;Log+every+expense,+set+your+goals,;and+watch+your+savings+grow+—+make+every+cent+count.;Because+managing+money+should+be+sensible." alt="Typing SVG" />
  </a>
</p>

<p align="center">
  <a>
    <img alt="Platform" src="https://img.shields.io/badge/Platform-Windows_Desktop-98FFD0?logoColor=black&style=for-the-badge">
  </a>
  <a>
    <img alt="Language" src="https://img.shields.io/badge/Language-C%23-98FFD0?logoColor=black&style=for-the-badge">
  </a>
  <a>
    <img alt="Framework" src="https://img.shields.io/badge/Framework-Windows_Forms_.NET-98FFD0?logoColor=black&style=for-the-badge">
  </a>
  <a>
    <img alt="Database" src="https://img.shields.io/badge/Database-MySQL_XAMPP-FEC148?logoColor=black&style=for-the-badge">
  </a>
  <a>
    <img alt="IDE" src="https://img.shields.io/badge/IDE-Visual_Studio-FEC148?logoColor=black&style=for-the-badge">
  </a>
  <a>
    <img alt="NuGet" src="https://img.shields.io/badge/NuGet-MySql.Data-02A4DE?logoColor=black&style=for-the-badge">
  </a>
</p>

<hr style="border: 2px solid #8cf2c4;">

## 📌 Description and Purpose

<p align="justify">
<b>CentSible</b> is a personal finance management desktop application built to help individuals to responsibly control their money without the complexity of traditional budgeting tools. The name itself is a play on words: every <i>cent</i> is made <i>sensible</i>.
</p>

<p align="justify">
Many people struggle to track where their money goes on a day-to-day basis. CentSible addresses this by offering a centralized, easy-to-use interface where users can record transactions, set savings goals, monitor their monthly budget, and visualize spending patterns — all in one place.
</p>

<p align="justify">
The application supports multiple user accounts, each with their own private financial data. By automating calculations and surfacing actionable insights through charts and progress indicators, CentSible transforms raw numbers into meaningful financial awareness.
</p>

**Core objectives of the system:**

- 🪙 Enable users to log and categorize daily expenses.
- 📊 Provide feedback on budget standing — how much has been spent, how much remains, and how close the user is to their savings target.
- 🔥 Motivate consistent engagement through login streak tracking and visual goal progress.
- 💡 Help users develop long-term money habits by making financial data clear, visual, and actionable.

<hr style="border: 2px solid #98FFD0;">

## 📌 UML Diagram

<hr style="border: 2px solid #98FFD0;">

## 📌 Features and Functionalities

<p align="justify">
Below is a comprehensive overview of every feature built into CentSible, organized by functional area.
</p>

| | Feature | Description |
|---|---|---|
| 🔐 | **Secure User Authentication** | Multi-user login system with automated password masking. Each account is isolated so every user only sees their own financial data. Users can register a new account from the login screen. |
| 📊 | **Real-Time Financial Dashboard** | The home screen provides an overview of the user's financial status, including goal progress and spending records, a login streak counter to reward consistency, and a summary of the recent transactions. |
| 🎯 | **Automated Goal Tracking** | Progress bars display real-time status for three financial targets: total amount Spent, amount being Saved, and the current Spending pace. These update automatically as transactions are recorded. |
| ⚠️ | **Intelligent Goal Management** | Goals include smart alerts. A warning message appears when 50% of the monthly budget has been consumed, giving users an early signal to review their spending. Remaining days and target balance are calculated and displayed dynamically. |
| 📝 | **Transaction Management** | Full CRUD capabilities for financial records: users can Create new expense or income entries, Read and review existing transactions, Update records if details change, and Delete entries logged in error. |
| 💰 | **Budget Monitoring** | A dedicated view compares the user's set Monthly Budget against their Total Spent figure. A live Remaining Budget counter updates with every new transaction. |
| 🥧 | **Categorized Data Visualization** | An automated pie chart breaks down spending by category such as Food, Leisure, Transportation, Utilities, Health, and Ohters. This lets users immediately see which areas consume the largest share of their budget. |
| 📈 | **Predictive Spending Forecast** | A line graphs analyze historical transaction records to project future savings and spending trends, helping users plan ahead and adjust habits before problems arise. |

<hr style="border: 2px solid #98FFD0;">

## 📌 How the Program Works

<p align="justify">
CentSible follows a client-database architecture. The desktop application is written in C# using Windows Forms, while the data layer is powered by a local MySQL database hosted through XAMPP. Communication between the two is handled via the MySql.Data NuGet package, which provides the MySQL Connector for .NET.
</p>

### 🔐 Application Launch and Login
<p align="justify">
When the application starts, the user is greeted by a Login screen. Existing users enter their credentials; passwords are masked automatically for privacy. New users click <b>Create Account</b> to register, providing a username and password that are then stored securely in the database. Upon successful login, the system loads that user's profile and financial records and navigates to the Dashboard.
</p>

### 📊 Dashboard — The Control Center
<p align="justify">
The Dashboard is the first screen a logged-in user sees. It aggregates and displays:
</p>

- A monthly summary showing income logged versus total amount spent so far.
- The current login streak — a counter that increments each consecutive day the user opens the app, designed to build a daily check-in habit.
- A snapshot of recent recorded transactions.
- The three goal progress bars (Spent / Saving / Spending) so the user can instantly view their financial details without navigating elsewhere.

### 📝 Logging Transactions
<p align="justify">
Users navigate to the Transaction section to record a new income or expense entry. Each record captures:
</p>

- 💵 **Amount** — the monetary value of the transaction.
- 🏷️ **Category** — chosen from a predefined list (e.g., Food, Leisure, Transportation, Utilities, Others).
- 📋 **Description** — a short optional note about the transaction.
- 📅 **Date** — defaults to the current day.

<p align="justify">
Once saved, the system immediately recalculates all budget totals, progress bars, and chart data, so every screen reflects the latest state of the user's finances.
</p>

### 🎯 Goal Management
<p align="justify">
The Goal Management section lets users define financial targets. For each goal, the user sets a target amount to save or a maximum amount to spend, and a deadline date by which the goal should be met. The system continuously calculates the remaining amount needed and the number of days left. If spending crosses the <b>50% threshold</b> of a budget goal, a warning alert is displayed automatically — no manual checking required.
</p>

### 🥧 Reports and Visualizations
<p align="justify">
The Reports section contains two key visual tools:
</p>

- **Spending Breakdown Pie Chart** — presents all categorized transactions and renders a color-coded pie chart. Slice sizes reflect the real proportion of spending per category, updated each time new data is saved.
- **Savings & Spending Forecast Line Graph** — reads the historical transaction database to detect trends and projects them forward, giving the user a data-driven view of where their finances are heading if current habits continue.

### 💾 Data Persistence
<p align="justify">
All data — user credentials, transactions, goals, and settings — is stored in a MySQL database running locally via XAMPP. Because data lives in the database rather than in application memory, records persist between sessions. Closing and reopening the application does not reset any information; everything is exactly as the user left it.
</p>

<hr style="border: 2px solid #98FFD0;">

## 📌 System Requirements

<p align="justify">
Before running CentSible, ensure your machine meets the following requirements:
</p>

| Requirement | Details |
|---|---|
| 🖥️ **Operating System** | Windows 10 or Windows 11 (64-bit recommended) |
| 💻 **IDE** | Visual Studio 2019 or later (Community edition is free) |
| 🗄️ **Database Server** | XAMPP (includes MySQL and phpMyAdmin) |
| ⚙️ **.NET Runtime** | .NET Framework 4.7.2 or later (included with Visual Studio) |
| 📦 **NuGet Package** | MySql.Data — installable via the NuGet Package Manager in Visual Studio |
| 🧠 **RAM** | 4 GB minimum (8 GB recommended) |
| 💾 **Disk Space** | At least 500 MB free (for Visual Studio build artifacts and database) |

<hr style="border: 2px solid #98FFD0;">

## 📌 How to Run the Application

<p align="justify">
Follow these steps in order. Each step must be completed successfully before moving to the next.
</p>

| Step | Title | Instructions |
|---|---|---|
| **1** | 📥 **Download the Project Files** | Go to the project's GitHub repository. Click the green **Code** button and select **Download ZIP**. Once the download completes, extract the folder to a location of your choice such as your Desktop or Documents folder. |
| **2** | 📂 **Open the Solution in Visual Studio** | Inside the extracted folder, locate the file with the `.slnx` extension (e.g., `CentSible.slnx`). Double-click it to open the entire solution in Visual Studio, which will load all project files, forms, and configurations automatically. |
| **3** | 🗄️ **Start the Database Server** | Open **XAMPP Control Panel**. Click **Start** next to the MySQL module. The status indicator should turn green, confirming the database server is running. Always start XAMPP before launching the app. |
| **4** | 🗃️ **Import the Database Schema** | Open phpMyAdmin at `http://localhost/phpmyadmin`. Create a new database named `centsible_db`. Import the provided `.sql` file from the project folder using the **Import** tab. Without this step, the application will crash on login. |
| **5** | 📦 **Install the MySQL NuGet Package** | In Visual Studio, right-click the project name in **Solution Explorer** and select **Manage NuGet Packages**. Search for `MySql.Data` and click **Install**. If it already shows a checkmark, skip this step. |
| **6** | 🔨 **Build the Solution** | Navigate to **Build > Rebuild Solution**. Check the Output panel — it should display `Rebuild All: 1 succeeded` with zero errors. If errors appear, review the Error List panel for missing packages or connection string issues. |
| **7** | 🚀 **Launch the Application** | Press **F5** on your keyboard or click the green **Play** button in the toolbar. The application will build and launch the Login screen. You are now ready to use CentSible. |
| **8** | 🪙 **Register Your Account and Start Tracking** | On the Login screen, click **Create Account**. Fill in your desired username and password, then confirm. After registration, log in with your new credentials and begin tracking your finances. |

<hr style="border: 2px solid #98FFD0;">
