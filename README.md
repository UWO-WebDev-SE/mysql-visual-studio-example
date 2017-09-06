# mysql-visual-studio-example
An example of how to connect to a MySQL Database using Visual Studio.

The code in this repository that involves interacting with a database is found at [mysql-visual-studio-example/MainWindow.xaml.cs](https://github.com/UWO-WebDev-SE/mysql-visual-studio-example/blob/master/mysql-visual-studio-example/MainWindow.xaml.cs).

Please follow the [References Quick Guide](https://github.com/UWO-WebDev-SE/mysql-visual-studio-example/blob/master/References%20Quick%20Guide.pdf) to use the [MySQL libraries](https://github.com/UWO-WebDev-SE/mysql-visual-studio-example/tree/master/MySQL%20Libraries) in your project. If you do not do this step, you will not be able to import the necessary classes to interact with your MySQL database.

## Some Notes on Connection Strings
Connection strings tell MySQL how to reach your database. The sample format used in this repository is:
```
server=127.0.0.1; user=YourUsername; password=YourPassword; database=YourDatabase; port=3306
```
Let's go through each of the components.
* **server:** The IP address or domain name of the server you are connecting to. If you are employing a tunnel to connect to your database, this should always be `localhost` or `127.0.0.1`. If you are not using a tunnel, the domain name must be given (e.g. `softeng.cs.uwosh.edu`).
* **user and password:** The username and password of the user who will be used to log into the MySQL server to access the database.
* **database:** The database to be interacted with. The user whose credentials are provided must have access to this database, otherwise you will be unable to connect.
* **port:** The port used to establish the connection. This is the port on the given server through which data is received. *If you wish to use a different local port on your machine to route traffic to the server's remote port, please use [PuTTY](http://www.putty.org/) on Windows or [SSH](https://www.openssh.com/) on Linux and establish a tunnel instead, following the directions above for the server address.*
