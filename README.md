# mysql-visual-studio-example
An example of how to connect to a MySQL Database using Visual Studio.

The code in this repository that involves interacting with a database is found at [mysql-visual-studio-example/MainWindow.xaml.cs](https://github.com/UWO-WebDev-SE/mysql-visual-studio-example/blob/master/mysql-visual-studio-example/MainWindow.xaml.cs).

## Some Notes on Connection Strings
Connection strings tell MySQL how to reach your database. The sample format used in this repository is:
```
server=127.0.0.1; user=YourUsername; password=YourPassword; database=YourDatabase; port=3306
```
Let's go through each of the components.
* **server:** The IP address or domain name of the server you are connecting to. If you are employing a tunnel to connect to your database, this should always be *localhost* or 127.0.0.1. If you are not using a tunnel, the domain name must be given in the following format: `softeng.cs.uwosh.edu:3306`, where `3306` is the receiving port on the server to be accessed.
* **user and password:** The username and password of the user who will be used to log into the MySQL server to access the database.
* **database:** The database to be interacted with. The user whose credentials are provided must have access to this database, otherwise you will be unable to connect.
* **port:** The port through which to establish the connection. This is the port on your local machine that will be used to send data to the MySQL server. It is through this local port that data is sent to the receiving port on the server. *Note: if you run a MySQL server on your local machine, port `3306` is probably in use, in which case you can resort to others such as `3307`. This is also important to remember when configuring your tunnel.*
