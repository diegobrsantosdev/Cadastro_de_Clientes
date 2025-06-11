# 🧾 Customer Management Application (.NET WinForms)

This is an application developed in C# using Windows Forms (.NET Framework), designed to manage customer records in a MySQL database. It provides an intuitive interface to perform full CRUD operations: **Create, Read, Update, and Delete** customer data.

## 🚀 Features

- **Customer Registration**  
  Collects and stores customer data, including:
  - Full Name
  - CPF (Brazilian Taxpayer ID)
  - Marital Status
  - Gender
  - Address (Street, Number, Neighborhood, City, State)

- **Search Functionality**  
  Easily locate customers by **name** or **CPF**.

- **Update and Delete**  
  Modify or remove customer data via interactive buttons.

- **Responsive UI**  
  Developed using Windows Forms for a desktop-friendly experience.

## 🛠️ Technologies

- C# (.NET Framework, Windows Forms)
- MySQL
- MySql.Data.MySqlClient (NuGet package)
- Visual Studio

## 🗃️ Database Schema

Ensure a MySQL database is running and includes the following table:

sql'''
CREATE TABLE clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100),
  cpf VARCHAR(14),
  estado_civil VARCHAR(20),
  genero VARCHAR(10),
  rua VARCHAR(100),
  numero VARCHAR(10),
  bairro VARCHAR(50),
  cidade VARCHAR(50),
  estado VARCHAR(2)
);

⚙️ How to Run
Clone or download this repository.

Open the .sln solution file in Visual Studio.

Ensure MySQL is installed and a database is created.

Update the connection string in Form1.cs with your MySQL credentials.

Install the MySql.Data package (via NuGet if needed).

Run the application.

📦 Project Structure

Cadastro_de_Clientes/
├── Form1.cs
├── Program.cs
├── Resources/
│   ├── Captura de tela 2024-07-26 .png
│   └── Usuário.png
├── Properties/
│   └── Resources.resx
├── obj/
└── ...

👨‍💻 Author
Diego Melo Bezerra dos Santos
🔗 github.com/diegobrsantosdev

This project was created for academic purposes and hands-on experience with Windows Forms and MySQL integration.
