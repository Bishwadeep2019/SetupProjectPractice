This is a .net 9 setup project to understand revise the basics of setup.

1. We are using Entity Framework Core(ORM) in this project, and for creating databases we are using the code first approach. 
  a. For adding the migrations(Any CRUD operation in DB) we use command add-migration "migration message"
  b. For running the migrations we use update-database. It will run all the migrations which are not run yet.
2. Restoring all the packages before running the project is mandatory
3. We are going to add authentication to this project in future.
4. We are going to use manual mapping in this project.
5. Need to implement simple injector for DI. 
