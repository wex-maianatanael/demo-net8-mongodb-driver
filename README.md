# demo-net8-mongodb-driver

### Overview

Demo related to the mongodb driver usage.

### How to run it

In order to run this demo locally, go trough the following steps:

1. Run the `docker-compose up -d` command to setup the mongodb environment (mongodb + mongodb-express);

4. Run the Web API project and send HTTP requests to create and return user(s) from mongodb.

5. If you want to check the data you created in the database, open the mongo-express by using this url `http://localhost:8081`, passing the following credentials: user - `admin` and password - `pass`.

### External Refs.

- [MongoDB Driver doc](https://www.mongodb.com/docs/drivers/csharp/current/)
