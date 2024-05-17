MyWebApp

MyWebApp is a simple .NET Core 6.0 web application that serves as a basic web server. It listens on port 8080 and responds to incoming HTTP requests.

Installation

To install and run MyWebApp locally, follow these steps:

1. Clone the repository to your local machine:
git clone https://github.com/your-username/MyWebApp.git

2. Navigate to the project directory:
cd MyWebApp

3. Build the application:
dotnet build

4. Run the application:
dotnet run

The application will start listening on port 8080.

Usage

Once the application is running, you can access it through your web browser or make HTTP requests to http://localhost:8080.

API Endpoints

- GET /: Returns a simple "Hello, World!" message.
- GET /api/health: Returns a JSON response indicating the health status of the application.

Contributing

Contributions to MyWebApp are welcome! To contribute, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix: git checkout -b feature-name.
3. Make your changes and commit them: git commit -am 'Add new feature'.
4. Push to the branch: git push origin feature-name.
5. Submit a pull request.

License

This project is licensed under the MIT License. See the LICENSE file for details.
