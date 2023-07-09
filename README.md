# Inventory Management System
The Inventory Management System is a simple application designed for individual sellers on sites like eBay and Depop, helping them to manage their inventory. It also allows backups to be generated for data security.

![screenshot](pics/ims.PNG)

## Installation
- Please note that you need .NET Framework 4.8 installed, and you will need MSBuild if you do not have Visual Studio installed.

1. Clone the repository to your local machine:
```command
git clone https://github.com/consolelogreece/InventoryManagementSystem.git
```
2. Either load and run the project in Visual Studio, or: 

3. Navigate to the project directory in the terminal, and then into the IMS_UI directory.

3. Build the project (note: you may need to [configure environment variables](https://softchief.com/2022/06/11/solved-msbuild-is-not-recognized-as-an-internal-or-external-command-operable-program-or-batch-file-while-working-with-pcf/)):
```command
MSBuild.exe
```

4. Navigate to /bin/debug and run IMS_UI.exe.


## Configuration
After cloning the repository and before running the application, you need to update the `filePath` key in the `App.config` file located in the `/IMS_UI` directory. This key specifies the path where the data and backups will be stored.

Open the `App.config` file in a text editor and update the following section with your file path:

```xml
<appSettings>
 <add key="filePath" value="YOUR_FILE_PATH_HERE" />
</appSettings>
```

## License
This project is licensed under the [MIT](https://www.mit.edu/~amini/LICENSE.md) license.