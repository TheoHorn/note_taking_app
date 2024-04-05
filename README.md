# Note Management Application

## Overview

This application provides a platform for users to create and manage notes composed of files and tasks. Users can edit files within the application's text editor and keep track of tasks associated with each note.

## Technologies Used

- **C#**: The primary programming language used in this project.
- **.NET Framework**: Utilized for developing the MVC (Model-View-Controller) architecture.
- **ASP.NET MVC**: Used for creating web applications following the MVC pattern.
- **HTML/CSS**: Used for designing and styling the user interface.
- **JavaScript**: Used for enhancing user interactivity on the client-side.
- **Entity Framework**: Utilized for database operations and ORM (Object-Relational Mapping).
- **SQL Server**: Used as the database management system to store user data.

## Features

1. **Create Notes**: Users can create new notes by providing a title and description.
2. **Edit Files**: Users can edit files associated with each note using the built-in text editor.
3. **Manage Tasks**: Users can create, update, and delete tasks associated with each note.
4. **Responsive Design**: The application is designed to be responsive and accessible on various devices.

## Setup Instructions

1. **Clone the Repository**: 
```
git clone https://github.com/TheoHorn/note_taking_app.git
```

2. **Install Dependencies**: 
```
cd your-repository/Note_taking_app
dotnet restore
```

3. **Database Setup**: 
- Ensure you have SQL Server installed and running.
- Update the connection string in `appsettings.json` to point to your SQL Server instance.
- Run database migrations:
  ```
  dotnet ef database update
  ```

4. **Run the Application**:
   ```
   dotnet run
   ```

5. **Access the Application**: 
Open your web browser and navigate to `http://localhost:5006`.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [Apache 2.0 License](http://www.apache.org/licenses/) file for details.

## Contact

For any inquiries or suggestions, feel free to contact [Hornberger Théo](mailto:theo.hornberger@gmail.com).


