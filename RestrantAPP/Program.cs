



using RestrantAPP.Classes;


EmpClintRepositry empClint = new EmpClintRepositry();

EmpRestrantRepositry obempretrant = new EmpRestrantRepositry();

EmpAdminRepositry obempadmin = new EmpAdminRepositry();

EmpOrderRepositry orderRepo = new EmpOrderRepositry();

EmpMealRepositry mealRepo = new EmpMealRepositry();


// Data Seeding: إضافة وجبات أساسية للمنيو أول ما السيستم يفتح
mealRepo.Add(new CLSMeal(1, "Chicken Shawarma", 60.0m, 100));
mealRepo.Add(new CLSMeal(2, "Beef Burger", 90.0m, 100));
mealRepo.Add(new CLSMeal(3, "Margherita Pizza", 120.0m, 100));
mealRepo.Add(new CLSMeal(4, "Crispy Crepe", 75.0m, 100));
mealRepo.Add(new CLSMeal(5, "Fried Chicken", 150.0m, 100));
// -------------------------------------------------

while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("====== Welcome to Al Hakym Restrant ======");

        
       
        //**************************************************
        
        Console.WriteLine("Welcome to in AL Hakym Restrant\n");
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("====== Welcome to Al Hakym Restrant ======");
            Console.WriteLine("--- Client ---");
            Console.WriteLine("1. Add New Client");
            Console.WriteLine("5. Search for a Client");
            Console.WriteLine("6. Delete a Client");
            Console.WriteLine("7. Edit a Client\n");
            Console.WriteLine("--- Restaurant ---");
            Console.WriteLine("2. Add New Restaurant");
            Console.WriteLine("8. Search for a Restaurant");
            Console.WriteLine("9. Delete a Restaurant");
            Console.WriteLine("10.Edit a Restaurant\n");
            Console.WriteLine("--- Admin ---");
            Console.WriteLine("3. Add New Admin");
            Console.WriteLine("11" +
                "" +
                ". Search for an Admin");
            Console.WriteLine("12.Delete an Admin");
            Console.WriteLine("13.Edit an Admin\n");
            Console.WriteLine("--- Order ---");
            Console.WriteLine("14. Add New Order");
            Console.WriteLine("15. Search for an Order");
            Console.WriteLine("16. Delete an Order");
            Console.WriteLine("17. Edit an Order");
            Console.WriteLine("18. Change Order Status (Restrant Only)");
            Console.WriteLine("19. Add New Meal (Restrant Only)");
            Console.WriteLine("20. View Restaurant Menu"); // <--- السطر الجديد
            Console.WriteLine("4. Exit ");
            Console.WriteLine("===============================================");
            Console.Write("Enter your choice: ");



            Console.WriteLine("Enter your Choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Add Client ---");
                    Console.WriteLine("\n--- Enter Client Data ---");

                    Console.WriteLine("Please Enter Your Id Client");
                    int ID = InputHelper.ReadInt();

                    string UserName = InputHelper.ReadString("Please Enter Client Name", ValidationHelper.IsValidName, "Invalid name.");

                    string email = InputHelper.ReadString("Please enter Client Email", ValidationHelper.IsValidEmail, "Invalid email.");

                    string phone = InputHelper.ReadString("Please enter Client Phone number", ValidationHelper.IsValidPhone, "Phone must be 11 digits and start with 01.");

                    string password = InputHelper.ReadString("Please Enter Client Password", ValidationHelper.IsValidPassword, "Password must be at least 8 characters.");

                    string secondPhoneNumber = InputHelper.ReadString("Please enter Client second phone number", ValidationHelper.IsValidPhone, "Phone must be 11 digits and start with 01.");

                    string location = InputHelper.ReadString("Please enter Client Location", ValidationHelper.IsValidString, "Location cannot be empty.");

                    string city = InputHelper.ReadString("Please enter Client City", ValidationHelper.IsValidString, "City cannot be empty.");

                    string DelevaryLocation = InputHelper.ReadString("Please enter Delevary Location", ValidationHelper.IsValidString, "Delivery location cannot be empty.");

                    Console.WriteLine("Please enter Flat Number");
                    int flatNumber = InputHelper.ReadInt();

                    Console.WriteLine("Please enter Floor number");
                    int FloorNumber = InputHelper.ReadInt();

                    // create new client object
                    CLSClint obclint = new CLSClint(flatNumber, FloorNumber, secondPhoneNumber, DelevaryLocation, ID, UserName, email, password, phone, city, location);

                    empClint.Add(obclint);
                    Console.WriteLine("Your Data has been Successfuly Registered");

                    // print all clients
                    foreach (var item in empClint.GetAll())
                    {
                        item.DisplayInfo();
                    }

                    break;
                case "2":
                    Console.WriteLine("\n--- Add Restaurant ---");
                    Console.WriteLine("\n--- Enter Restrant Data ---");

                    string logo = InputHelper.ReadString("Please Enter Logo", ValidationHelper.IsValidString, "Logo cannot be empty.");

                    string taxcard = InputHelper.ReadString("Please Enter Tax Card", ValidationHelper.IsValidString, "Tax card cannot be empty.");

                    string telephone = InputHelper.ReadString("Please Enter Hot Telephone", ValidationHelper.IsValidString, "Telephone cannot be empty.");

                    Console.WriteLine("Please Enter Id");
                    int userid = InputHelper.ReadInt();

                    string username = InputHelper.ReadString("Please Enter User Name", ValidationHelper.IsValidName, "Invalid name.");

                    string email2 = InputHelper.ReadString("Please Enter Email", ValidationHelper.IsValidEmail, "Invalid email.");

                    string password2 = InputHelper.ReadString("Please Enter Password", ValidationHelper.IsValidPassword, "Password must be at least 8 characters.");

                    string phone2 = InputHelper.ReadString("Please Enter Phone", ValidationHelper.IsValidPhone, "Phone must be 11 digits and start with 01.");

                    string city2 = InputHelper.ReadString("Please Enter City", ValidationHelper.IsValidString, "City cannot be empty.");

                    string location2 = InputHelper.ReadString("Please Enter location", ValidationHelper.IsValidString, "Location cannot be empty.");

                    // create new restaurant object
                    CLSRestrant obrestrant = new CLSRestrant(logo, taxcard, telephone, userid, username, email2, password2, phone2, city2, location2);

                    obempretrant.Add(obrestrant);
                    Console.WriteLine("Your Data has been Successfuly Registered");

                    // print all restaurants
                    foreach (var item in obempretrant.GetAll())
                    {
                        item.DisplayInfo();
                    }
                    break;

                case "3":
                    Console.WriteLine("\n--- Add Admin ---");
                    Console.WriteLine("\n--- Enter Admin Data ---");

                    string jobName = InputHelper.ReadString("Please Enter Job Name:", ValidationHelper.IsValidString, "Job name cannot be empty.");

                    Console.WriteLine("Please Enter Admin ID:");
                    int userid3 = InputHelper.ReadInt();

                    string username3 = InputHelper.ReadString("Please Enter Admin Name:", ValidationHelper.IsValidName, "Invalid name.");

                    string email3 = InputHelper.ReadString("Please Enter Email:", ValidationHelper.IsValidEmail, "Invalid email.");

                    string password3 = InputHelper.ReadString("Please Enter Password:", ValidationHelper.IsValidPassword, "Password must be at least 8 characters.");

                    string phone3 = InputHelper.ReadString("Please Enter Phone:", ValidationHelper.IsValidPhone, "Phone must be 11 digits and start with 01.");

                    string city3 = InputHelper.ReadString("Please Enter City:", ValidationHelper.IsValidString, "City cannot be empty.");

                    string location3 = InputHelper.ReadString("Please Enter Location:", ValidationHelper.IsValidString, "Location cannot be empty.");

                    // create admin object
                    CLSAdmin obadmin = new CLSAdmin(jobName, userid3, username3, email3, password3, phone3, city3, location3);

                    // add to list
                    obempadmin.Add(obadmin);
                    Console.WriteLine("Admin Data has been Successfully Registered!\n");

                    // print all admins
                    Console.WriteLine("--- All Admins ---");
                    foreach (var item in obempadmin.GetAll())
                    {
                        item.DisplayInfo();
                    }

                    break;

                case "4":
                    Console.WriteLine("Good Bye!");
                    Environment.Exit(0);
                    break;

                case "5":
                    Console.WriteLine("\n---- Search for Clint ----");
                    Console.WriteLine("Enter Clint Id To Search");
                    int searchId = InputHelper.ReadInt();

                    //Make Emplotee start Search on Clint
                    var result = empClint.GetById(searchId);

                    //validation
                    if (result != null)
                    {
                        Console.WriteLine("\n Client Found Successfuly:");
                        result.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("\nError: Client not found!");

                    }
                    break;

                case "6":
                    Console.WriteLine("\n--- Delete Client ---");
                    Console.Write("Enter Client ID to delete: ");
                    int deleteId = InputHelper.ReadInt();
                    bool isdeleted = empClint.Delete(deleteId);
                    if (isdeleted == true)
                    {
                        Console.WriteLine("\nClient Deleted Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Client not found!");
                    }
                    break;

                case "7":
                    Console.WriteLine("\n--- Edit Client ---");
                    Console.Write("Enter Client ID to edit: ");
                    int editId = InputHelper.ReadInt();
                    var edit = empClint.GetById(editId);
                    if (edit != null)
                    {
                        Console.WriteLine($"Client Found! Current Name: {edit.UserName}");
                        Console.Write("Enter New Name: ");
                        string newName = InputHelper.ReadString("Enter New Name:", ValidationHelper.IsValidName, "Invalid name.");
                        // 4. نبعت الصندوق للموظف يعمل حفظ للتعديلات
                        bool isEdited = empClint.Edit(edit);

                        if (isEdited == true)
                        {
                            Console.WriteLine("\nClient Data Updated Successfully!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError: Client not found!");
                    }
                    break;

                case "8":
                    Console.WriteLine("\n--- Search for Restaurant ---");
                    Console.WriteLine("Please Enter Id Restrant to Search");
                    int searchid = InputHelper.ReadInt();
                    var restrant = obempretrant.GetById(searchid);
                    if (restrant != null)
                    {
                        Console.WriteLine("\nRestaurant Found Successfully:");
                        restrant.DisplayInfo();
                    }
                    else { Console.WriteLine("\nError: Restaurant not found!"); }
                    break;

                case "9":
                    Console.WriteLine("\n--- Delete Restaurant ---");
                    Console.Write("Enter Restaurant ID to delete: ");
                    int deleteid = InputHelper.ReadInt();
                    bool isdeletedRes = obempretrant.Delete(deleteid);
                    if (isdeletedRes == true)
                    {
                        Console.WriteLine("\nRestaurant Deleted Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Restaurant not found!");
                    }
                    break;


                case "10":
                    Console.WriteLine("\n--- Edit Restaurant ---");
                    Console.Write("Enter Restaurant ID to edit: ");
                    int editid = InputHelper.ReadInt();
                    //roooh dooar
                    var existrestrant = obempretrant.GetById(editid);
                    if (existrestrant != null)
                    {
                        Console.WriteLine($"Restaurant Found! Current Name: {existrestrant.UserName}");
                        existrestrant.UserName = InputHelper.ReadString("Enter New Restaurant Name:", ValidationHelper.IsValidName, "Invalid name.");
                        obempretrant.Edit(existrestrant);
                        Console.WriteLine("\nRestaurant Data Updated Successfully!");
                    }
                    else { Console.WriteLine("\nError: Restaurant not found!"); }
                    break;

                case "11":
                    Console.WriteLine("\n--- Search for Admin ---");
                    Console.Write("Enter Admin ID to search: ");
                    int searchidAdmin = InputHelper.ReadInt();
                    var searchadmin = obempadmin.GetById(searchidAdmin);
                    if (searchadmin != null)
                    {
                        Console.WriteLine("\nAdmin Found Successfully:");
                        searchadmin.DisplayInfo();
                    }
                    else { Console.WriteLine("\nError: Admin not found!"); }
                    break;

                case "12":
                    Console.WriteLine("\n--- Delete Admin ---");
                    Console.Write("Enter Admin ID to delete: ");
                    int deletetadmin = InputHelper.ReadInt();
                    bool isdeleteAcmin = obempadmin.Delete(deletetadmin);
                    if (isdeleteAcmin)
                    {
                        Console.WriteLine("\nAdmin Deleted Successfully!");
                    }
                    else { Console.WriteLine("\nError: Admin not found!"); }
                    break;

                case "13":
                    Console.WriteLine("\n--- Edit Admin ---");
                    Console.Write("Enter Admin ID to edit: ");
                    int editidAdmin = InputHelper.ReadInt();
                    var editadmin = obempadmin.GetById(editidAdmin);
                    if (editadmin != null)
                    {
                        Console.WriteLine($"Admin Founded! Current Name: {editadmin.UserName}");
                        Console.WriteLine("Enter New Admin Name:");
                        editadmin.UserName = InputHelper.ReadString("Enter New Admin Name:", ValidationHelper.IsValidName, "Invalid name.");
                        Console.WriteLine("\nAdmin Data Updated Successfully!");
                    }
                    else { Console.WriteLine("\nError: Admin not found!"); }
                    break;

                case "14":
                    Console.WriteLine("\n--- Add New Order ---");
                    Console.WriteLine("\n--- Enter Order Data ---\n");
                    Console.WriteLine("Please Enter Order ID:");
                    int ordId = InputHelper.ReadInt();
                    if (orderRepo.GetById(ordId) != null)
                    {
                        Console.WriteLine("Error: Order ID already exists! Please use a unique Order ID.");
                        break;
                    }
                    Console.WriteLine("Please Enter Client ID:");
                    int clintId = InputHelper.ReadInt();

                    Console.WriteLine("Please Enter Restaurant ID:");
                    int restrantId = InputHelper.ReadInt();


                    Console.WriteLine("---- Our Menu ----");
                    foreach (var item in mealRepo.GetAll())
                    {
                        Console.WriteLine($"{item.MealId}. {item.MealName} . {item.RestrantId} . {item.MealPrice} EGP");
                    }
                    Console.WriteLine("Please Enter Meal Id:");
                    int mealI2d = InputHelper.ReadInt();

                    Console.WriteLine("Please Enter Quantity");
                    int quantity = InputHelper.ReadInt();

                    //Search on meal End EmpMealRepositry to get meal price
                    var meal = mealRepo.GetById(mealI2d);
                    if (meal != null)
                    {
                        decimal totalPrice = meal.MealPrice * quantity;
                        Console.WriteLine($"Total Price: {totalPrice} EGP");
                        string orderDetails = $"{quantity} x {meal.MealName}";
                        // Create new order object
                        CLSOrder newOrder = new CLSOrder(ordId, clintId, restrantId, orderDetails, totalPrice);
                        // Add order to repository
                        orderRepo.Add(newOrder);
                        Console.WriteLine("\nOrder has been successfully added! [Status : Pending]");
                        Console.WriteLine($"[System Info]: You ordered {orderDetails}. Total Price = {totalPrice} EGP.");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Meal not found!");


                    }
                    break;


                case "15":
                    Console.WriteLine("\n--- Search for Order ---");
                    Console.WriteLine("Enter Order ID to search: ");
                    int searchOrderId = InputHelper.ReadInt();

                    var searchonOreder = orderRepo.GetById(searchOrderId);
                    if (searchonOreder != null)
                    {
                        Console.WriteLine("\nOrder Found Successfully:");
                        searchonOreder.PrintOrder();
                    }
                    else
                    {
                        Console.WriteLine("\nError: Order not found!");
                    }
                    break;

                case "16":
                    Console.WriteLine("\n--- Delete Order ---");
                    Console.Write("Enter Order ID to delete: ");
                    int deleteOrderId = InputHelper.ReadInt();
                    bool isDeletedOrder = orderRepo.Delete(deleteOrderId);
                    if (isDeletedOrder)
                    {
                        Console.WriteLine("\nOrder Deleted Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Order not found!");
                    }
                    break;

                case "17":
                    Console.WriteLine("\n--- Edit Order ---");
                    Console.Write("Enter Order ID to edit: ");
                    int editOrderId = InputHelper.ReadInt();
                    var editOrder = orderRepo.GetById(editOrderId);
                    if (editOrder != null)
                    {
                        Console.WriteLine($"Order Found! Current Details: {editOrder.OrderDetalis}");
                        Console.WriteLine("Enter New Order Details:");
                        editOrder.OrderDetalis = InputHelper.ReadString("Enter New Order Details:", ValidationHelper.IsValidString, "Order details cannot be empty.");
                        editOrder.TotalPrice = InputHelper.ReadPrice(); orderRepo.Edit(editOrder);
                        Console.WriteLine("\nOrder Data Updated Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Order not found!");
                    }
                    break;

                case "18":
                    Console.WriteLine("\n--- Change Order Status ---");
                    Console.Write("Enter Order ID: ");
                    int statusOrdId = InputHelper.ReadInt();

                    // Get the order from the repository
                    var orderToCgangeStatus = orderRepo.GetById(statusOrdId);
                    if (orderToCgangeStatus != null)
                    {
                        Console.WriteLine($"Current Status To Order{orderToCgangeStatus.Status}");
                        Console.WriteLine("Choose New Status:");
                        Console.WriteLine("1. Approved ");
                        Console.WriteLine("2. Rejected ");
                        Console.Write("Enter your choice (1 or 2): ");
                        string statusChoice = Console.ReadLine();


                        string newStatus = "";
                        if (statusChoice == "1")
                        {
                            newStatus = "Approved";
                        }
                        else if (statusChoice == "2")
                        {
                            newStatus = "Rejected";
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice! Status not changed.");
                            break;
                        }

                        //send to emp Change the order status


                        bool isStatusChanged = orderRepo.ChangeOrderStatus(statusOrdId, Enum.Parse<OrderStatus>(newStatus, true));
                        if (isStatusChanged)
                        {
                            Console.WriteLine("\nOrder Status Changed Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Order not found!");
                        }
                    }
                    break;


                case "19":
                    Console.WriteLine("\n--- Add New Meal ---");
                    Console.WriteLine("Please Enter Meal ID:");
                    int mealId = InputHelper.ReadInt();

                    string mealName = InputHelper.ReadString("Please Enter Meal Name:", ValidationHelper.IsValidString, "Meal name cannot be empty.");

                    Console.WriteLine("Please Enter Meal Price:");
                    decimal mealPrice = InputHelper.ReadPrice();

                    Console.WriteLine("Please Enter Restaurant ID:");
                    int restrantIdForMeal = InputHelper.ReadInt();

                    // create new meal object
                    CLSMeal newMeal = new CLSMeal(mealId, mealName, mealPrice, restrantIdForMeal);

                    // add meal to repository
                    mealRepo.Add(newMeal);
                    Console.WriteLine("\nMeal has been successfully added!");

                    // print all meals
                    Console.WriteLine("\n--- All Meals ---");
                    foreach (var item in mealRepo.GetAll())
                    {
                        Console.WriteLine($"{item.MealId}. {item.MealName} . {item.RestrantId} . {item.MealPrice} EGP");
                    }
                    break;

                case "20":

                    Console.WriteLine("\n========== OUR MENU ==========");

                    // السيستم بيروح يجيب كل الوجبات اللي في الدرج (الأساسية + أي حاجة ضفتها بـ 19)
                    var allMeals = mealRepo.GetAll();

                    if (allMeals.Count == 0)
                    {
                        Console.WriteLine("The menu is currently empty.");
                    }
                    else
                    {
                        foreach (var item in allMeals)
                        {
                            // بيطبعها بشكل سطر شيك
                            Console.WriteLine($"{item.MealId}. {item.MealName} . {item.RestrantId} . {item.MealPrice} EGP");
                        }
                    }
                    Console.WriteLine("==============================\n");
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Choice! Please select from 1 to 4.");
                        break;
                    }




            }

            Console.WriteLine("\nPress any key to return to Main Menu...");
            Console.ReadKey();
        }




        Console.WriteLine("\nPress any key to return to Main Menu...");
        Console.ReadKey();

    }
    catch (FormatException)
    {
        // الدرع الأول: بيمسك أخطاء إدخال الحروف بدل الأرقام (زي الـ ID والسعر)
        Console.WriteLine("\n[System Error]: Invalid Input! Please enter numbers only.");
        Console.WriteLine("Press any key to try again...");
        Console.ReadKey();
    }
    catch (ArgumentException ex)
    {
        // الدرع التاني: بيمسك الإيرور اللي جاي من كلاس Validation لو الداتا غلط
        Console.WriteLine($"\n[Validation Error]: {ex.Message}");
        Console.WriteLine("Press any key to try again...");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        // الدرع التالت: بيمسك أي خطأ تاني غير متوقع في السيستم
        Console.WriteLine($"\n[Unexpected Error]: An error occurred: {ex.Message}");
        Console.WriteLine("Press any key to try again...");
        Console.ReadKey();
    }
}