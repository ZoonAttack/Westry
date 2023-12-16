# Westry
# VERY IMPORTANT DATABASE INFORMATION

Create a new Server and make sure that it's name is "localhost"

![image](https://github.com/ZoonAttack/Westry/assets/62998842/c58a428c-6fe9-43be-9dd2-90f8381909f4)

Create a new database and make sure it's name is "Dev_DB"

All the tables should have same name when creating it And I will explain every step

![image](https://github.com/ZoonAttack/Westry/assets/62998842/cacb56fb-4605-40d9-9fd3-3518e47a6454)

# Admins Table
Right click on the "admin_id" and Set Primary key

![image](https://github.com/ZoonAttack/Westry/assets/62998842/519e903b-7c17-403e-9a75-4d46844b0f41)



# Cashiers Table
Right click on the "cashier_id" and Set Primary key

![image](https://github.com/ZoonAttack/Westry/assets/62998842/532c776e-f950-4d84-92b5-1c473efaae5f)



# Meals Table
Right click on the "meal_id" and Set Primary key

MUST BE "nvarchar(50)" FOR ARABIC TO WORK IN DATABASE

![image](https://github.com/ZoonAttack/Westry/assets/62998842/53a043b0-abc1-4432-bcda-1d60af025e08)




# MealsLog Table
Right click on the "meal_id" and Set Primary key

![image](https://github.com/ZoonAttack/Westry/assets/62998842/fa2c3f8c-1b0b-4da6-a77a-57050a33a4b5)

Right click on the "meal_id" and Relationships

![image](https://github.com/ZoonAttack/Westry/assets/62998842/66fa1204-ab8d-4aa6-a926-c0a07da48f4f)

Click add and then Table And Columns

Click on the small square

![image](https://github.com/ZoonAttack/Westry/assets/62998842/9e69da97-8e62-48c1-87b9-8ed27fe22fac)


Adjust as the photo and then OK

![image](https://github.com/ZoonAttack/Westry/assets/62998842/5c31fd1e-3fa0-4768-b434-11fddbd3bbf6)



# Customers Table

Repeat the same steps for the primary key

![image](https://github.com/ZoonAttack/Westry/assets/62998842/74fb5c3e-4530-4861-960b-d37dabe82635)

and edit the meal_id relationship

and adjust to be like this

![image](https://github.com/ZoonAttack/Westry/assets/62998842/54ff319f-d063-4f0e-87fc-d0d3d29b687d)

# Finally
Then after all of this the connection string should be the same for all of us.

# More Information

Notice that you have to create a record in Meals table before creating a Customers record or MealsLog record

Example on every table

Admin Table

![image](https://github.com/ZoonAttack/Westry/assets/62998842/735d5828-934a-4a74-bd4f-ace6be0c49bf)

Cashier Table

![image](https://github.com/ZoonAttack/Westry/assets/62998842/d4b4c820-7a31-49f9-9275-49ceebf03201)

Customer Table

![image](https://github.com/ZoonAttack/Westry/assets/62998842/c736a4ce-df61-4b6f-9ae9-25532864d2b4)

Notice that the counters changed becasue IT IS WORKING

Meals Table

![image](https://github.com/ZoonAttack/Westry/assets/62998842/ee30f7c1-5f15-4cd7-92d8-b812d866db58)
