# BookFair

## Description
**BookFair** is a simple **C# console application** that simulates a book fair management system.  
It allows basic management of books, authors, visitors, and addresses.

The application uses **text files** for data storage, so no database is required.

---

## What the Application Does
- Stores information about:
  - Books
  - Authors
  - Visitors
  - Addresses
- Loads data from text files when the application starts
- Saves changes back to the files
- Separates data, logic, and user interaction
- Runs entirely in the console

---

## Project Structure

```
BookFair/
│── BookFair.slnx
│── BookFair/
│ ├── Console/
│ │ └── Application.cs
│ ├── DAO/
│ │ ├── BookDAO.cs
│ │ ├── AuthorDAO.cs
│ │ ├── VisitorDAO.cs
│ │ └── IDAO.cs
│ ├── Data/
│ │ ├── books.txt
│ │ ├── authors.txt
│ │ ├── visitors.txt
│ │ └── addresses.txt
│ ├── Model/
│ │ ├── Book.cs
│ │ ├── Author.cs
│ │ ├── Visitor.cs
│ │ └── Address.cs
│ ├── Service/
│ │ ├── BookService.cs
│ │ ├── AuthorService.cs
│ │ └── VisitorService.cs
│ ├── Serialization/
│ │ └── Serializer.cs
│ ├── Storage/
│ │ └── Storage.cs
│ ├── Program.cs
│ └── BookFair.csproj
```


---

## How to Run
1. Install **.NET 9 SDK**
2. Open the project folder
3. Run:
```bash
dotnet run
```
Or open the project in Visual Studio and press F5.

## Data Storage
The application uses **text files** to store data. All files are located in the `Data` folder.

Each type of data is saved in a separate file:
- `books.txt`
- `authors.txt`
- `visitors.txt`
- `addresses.txt`

When the application starts, data is loaded from these files into memory.  
Whenever changes are made (add, update, delete), the data is written back to the files.

This approach removes the need for a database and keeps the project simple and easy to understand.

---

## Architecture
The project is organized using a **layered structure**, where each layer has a clear responsibility.

- **Model**  
  Contains the classes that represent the data used in the application  
  (e.g. `Book`, `Author`, `Visitor`, `Address`).

- **DAO (Data Access Object)**  
  Responsible for reading from and writing to the text files.  
  Each DAO handles one type of entity.

- **Service**  
  Contains the main application logic and rules.  
  It connects the console layer with the DAO layer.

- **Console Layer**  
  Handles user input and output and controls the program flow.

This structure improves code readability and makes the application easier to maintain and extend.