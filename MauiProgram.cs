// Q1 - Demonstrate a console application for XYZ company storing employee details such as empno, empname, designation and total salary. Get user inputs and display all details.

using Microsoft.Maui.ApplicationModel.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection.PortableExecutable;

class Employee
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public string Designation { get; set; }
    public double TotalSalary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int numEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numEmployees; i++)
        {
            Console.Write("Enter employee number: ");
            int empNo = int.Parse(Console.ReadLine());

            Console.Write("Enter employee name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter employee designation: ");
            string designation = Console.ReadLine();

            Console.Write("Enter total salary: ");
            double totalSalary = double.Parse(Console.ReadLine());

            Employee employee = new Employee
            {
                EmpNo = empNo,
                EmpName = empName,
                Designation = designation,
                TotalSalary = totalSalary
            };

            employees.Add(employee);
        }

        Console.WriteLine("Employee Details:");
        Console.WriteLine("-----------------");

        foreach (Employee employee in employees)
        {
            Console.WriteLine("EmpNo: {0}", employee.EmpNo);
            Console.WriteLine("EmpName: {0}", employee.EmpName);
            Console.WriteLine("Designation: {0}", employee.Designation);
            Console.WriteLine("TotalSalary: {0}", employee.TotalSalary);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

// Q2- Demonstrate a console application to calculate the Simple Interest (SI) by providing Principal (p), Rate(r) and Time (t).
using System;

class Program
{
    static void Main()
    {
        double principal, rate, time, simpleInterest;

        Console.Write("Enter Principal (P): ");
        principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate (R) as a percentage: ");
        rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (T) in years: ");
        time = double.Parse(Console.ReadLine());

        // Convert the rate from percentage to a decimal fraction
        rate = rate / 100;

        // Calculate Simple Interest (SI)
        simpleInterest = (principal * rate * time);

        Console.WriteLine($"Simple Interest (SI) is: {simpleInterest:C2}"); // Displaying SI as currency
    }
}
// Q3- Demonstrate a Console application to check the eligibility for voting. Take the birth year as the input from the user
using System;  
public class Exercise5
{
    public static void Main()
    {
        int vote_age;

        Console.Write("Input the age of the candidate : ");
        vote_age = Convert.ToInt32(Console.ReadLine());
        if (vote_age < 18)
        {
            Console.Write("Sorry, You are not eligible to caste your vote.\n");
            Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
        }
        else
            Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
    }
}

//Q4- Demonstrate a code to award grade to a student. Get name of a student and three subjects marks. Calculate the total marks and award Excellent, Good and Average.

 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class GFG
{

    static void Main(string[] args)
    {

         
        int r, marks1, marks2, marks3, total;

        float percentage;
        string n;

        Console.WriteLine("Enter Student Roll Number :");
        r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Student Name :");
        n = Console.ReadLine();

        Console.WriteLine("Enter Subject-1 Marks : ");
        marks1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Subject-2 Marks : ");
        marks2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Subject-3 Marks :");
        marks3 = Convert.ToInt32(Console.ReadLine());

        total = marks1 + marks2 + marks3;

        percentage = total / 3.0f;

        Console.WriteLine("Final result of {0} is:", n);
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Percentage : " + percentage);

        if (percentage <= 35)
        {
            Console.WriteLine("Grade is F");
        }
        else if (percentage >= 34 && percentage <= 39)
        {
            Console.WriteLine("Grade is D");
        }
        else if (percentage >= 40 && percentage <= 59)
        {
            Console.WriteLine("Grade is C");
        }
        else if (percentage >= 60 && percentage <= 69)
        {
            Console.WriteLine("Grade is B");
        }
        else if (percentage >= 70 && percentage <= 79)
        {
            Console.WriteLine("Grade is B+");
        }
        else if (percentage >= 80 && percentage <= 90)
        {
            Console.WriteLine("Grade is A");
        }
        else if (percentage >= 91)
        {
            Console.WriteLine("Grade is A+");
        }
    }
}

//Q5- Demonstrate a program in C# to display the multiplication table of a given integer using for loop.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer to display its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication Table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}

//Q6-Demonstrate a C# code to check the given number is palindrome or not using while loop.

using System;  
  public class PalindromeExample
{
    public static void Main(string[] args)
    {
        int n, r, sum = 0, temp;
        Console.Write("Enter the Number: ");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}


// Q7-Demonstrate a C# code  to search the number in a given array and its number of occurrence also.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the number to search: ");
        int numberToSearch = int.Parse(Console.ReadLine());

        int count = 0;

        foreach (int num in arr)
        {
            if (num == numberToSearch)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"{numberToSearch} is found in the array {count} times.");
        }
        else
        {
            Console.WriteLine($"{numberToSearch} is not found in the array.");
        }
    }
}


// Q8-Demonstrate a code to display two dimensional array showing only even number like this :             


using System;

class Program
{
    static void Main()
    {
        int rows = 2;
        int columns = 5;
        int evenNumber = 2;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write(evenNumber + "\t");
                evenNumber += 2;
            }
            Console.WriteLine();
        }
    }
}


//Q9-Telecom company is storing consumer details. Demonstrate a class to represent a consumer account. Include the following data members: Name of the consumer, Consumer’s Mobile Number, Call usage in minutes. Calculate the bill amount to be paid. Bill amount = minutes * Rs. 2. Write a C# program to demonstrate the method to calculate & display the consumer number along with the total amount to be paid.


using System;

class ConsumerAccount
{
    public string Name { get; set; }
    public string MobileNumber { get; set; }
    public int CallUsageInMinutes { get; set; }

    public double CalculateBillAmount()
    {
        return CallUsageInMinutes * 2.0;
    }
}

class Program
{
    static void Main()
    {
        ConsumerAccount consumer = new ConsumerAccount();

        Console.Write("Enter consumer's name: ");
        consumer.Name = Console.ReadLine();

        Console.Write("Enter consumer's mobile number: ");
        consumer.MobileNumber = Console.ReadLine();

        Console.Write("Enter call usage in minutes: ");
        consumer.CallUsageInMinutes = int.Parse(Console.ReadLine());

        double billAmount = consumer.CalculateBillAmount();

        Console.WriteLine($"Consumer: {consumer.Name}");
        Console.WriteLine($"Mobile Number: {consumer.MobileNumber}");
        Console.WriteLine($"Total Amount to be Paid: Rs. {billAmount:C2}");
    }
}


//Q10- Demonstrate a class to represent a employee’s details. Include the following Data Members: Name of the employee, Employee Id, Salary, Leave balance and methods: To assign initial values, to increment the salary, to display name and the leave balance. Write a C# program to demonstrate the working of the various class members.

using System;

class EmployeeDetails
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public double Salary { get; set; }
    public int LeaveBalance { get; set; }

    public void AssignInitialValues(string name, int employeeId, double salary, int leaveBalance)
    {
        Name = name;
        EmployeeId = employeeId;
        Salary = salary;
        LeaveBalance = leaveBalance;
    }

    public void IncrementSalary(double incrementAmount)
    {
        Salary += incrementAmount;
    }

    public void DisplayNameAndLeaveBalance()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Leave Balance: {LeaveBalance} days");
    }
}

class Program
{
    static void Main()
    {
        EmployeeDetails employee = new EmployeeDetails();

        employee.AssignInitialValues("John Doe", 1001, 50000.0, 20);

        Console.WriteLine("Employee Information:");
        Console.WriteLine($"Employee ID: {employee.EmployeeId}");
        Console.WriteLine($"Salary: Rs. {employee.Salary:F2}");

        employee.IncrementSalary(5000.0);

        Console.WriteLine($"Updated Salary: Rs. {employee.Salary:F2}");

        Console.WriteLine("\nEmployee Name and Leave Balance:");
        employee.DisplayNameAndLeaveBalance();
    }
}


// Q11- Demonstrate a C# Program to find out the multiplication of two, three and four operands using method overloading.

using System;

class Multiplication
{
    public int Multiply(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public int Multiply(int operand1, int operand2, int operand3)
    {
        return operand1 * operand2 * operand3;
    }

    public int Multiply(int operand1, int operand2, int operand3, int operand4)
    {
        return operand1 * operand2 * operand3 * operand4;
    }
}

class Program
{
    static void Main()
    {
        Multiplication calculator = new Multiplication();

        int result1 = calculator.Multiply(3, 4);
        Console.WriteLine("Multiplication of two operands: " + result1);

        int result2 = calculator.Multiply(2, 5, 7);
        Console.WriteLine("Multiplication of three operands: " + result2);

        int result3 = calculator.Multiply(1, 2, 3, 4);
        Console.WriteLine("Multiplication of four operands: " + result3);
    }
}


// Q12- Demonstrate a class called Employee with id and salary. Employee class is inheriting from Human class. Name and age should be defined in Human class. Include display method in Employee class to display all details

using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Employee : Human
{
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, int id, double salary) : base(name, age)
    {
        Id = id;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age} years");
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Salary: Rs. {Salary:F2}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("John Doe", 30, 1001, 50000.0);
        employee.DisplayDetails();
    }
}



//Q13- A University has decided promotion criteria for students. According to criteria a student cannot be promoted to next academic year if he has less than 4.5 CGPA. A developer is trying to implement this situation using exception handling by reading the necessary details of all 6 subjects

using System;

class Program
{
    static void Main()
    {
        try
        {
            double totalCGPA = 0;
            int numSubjects = 6;

            for (int i = 1; i <= numSubjects; i++)
            {
                Console.Write($"Enter CGPA for Subject {i}: ");
                double cgpa = double.Parse(Console.ReadLine());

                if (cgpa < 0 || cgpa > 10)
                {
                    throw new Exception("Invalid CGPA. CGPA should be between 0 and 10.");
                }

                totalCGPA += cgpa;
            }

            double averageCGPA = totalCGPA / numSubjects;

            Console.WriteLine($"Average CGPA: {averageCGPA:F2}");

            if (averageCGPA >= 4.5)
            {
                Console.WriteLine("Promoted to the next academic year.");
            }
            else
            {
                Console.WriteLine("Not promoted to the next academic year.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid CGPA.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}



//Q14-Demonstrate a program to get and set the student’s roll number, Name and Specialization using C# property


using System;

class Student
{
    private int rollNumber;
    private string name;
    private string specialization;

    public int RollNumber
    {
        get { return rollNumber; }
        set { rollNumber = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Specialization
    {
        get { return specialization; }
        set { specialization = value; }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Enter Roll Number: ");
        student.RollNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Specialization: ");
        student.Specialization = Console.ReadLine();

        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Roll Number: " + student.RollNumber);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Specialization: " + student.Specialization);
    }
}


//Q15- Demonstrate a C# Program to find out the area of the triangle and rectangle using delegates.

using System;

delegate double CalculateAreaDelegate();

class Program
{
    static void Main()
    {
        CalculateAreaDelegate triangleAreaDelegate = CalculateTriangleArea;
        CalculateAreaDelegate rectangleAreaDelegate = CalculateRectangleArea;

        Console.WriteLine("Choose a shape to calculate area (1 for Triangle, 2 for Rectangle):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                double triangleArea = triangleAreaDelegate();
                Console.WriteLine("Area of the Triangle: " + triangleArea);
                break;

            case 2:
                double rectangleArea = rectangleAreaDelegate();
                Console.WriteLine("Area of the Rectangle: " + rectangleArea);
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static double CalculateTriangleArea()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseLength = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = double.Parse(Console.ReadLine());

        return 0.5 * baseLength * height;
    }

    static double CalculateRectangleArea()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        return length * width;
    }
}


//Q16-Demonstrate a C# Program to create 10 fruit list and later remove the last 3 names from the list.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>
        {
            "Apple", "Banana", "Cherry", "Date", "Fig",
            "Grapes", "Kiwi", "Lemon", "Mango", "Orange"
        };

        Console.WriteLine("Original Fruit List:");
        PrintFruitList(fruits);

        if (fruits.Count >= 3)
        {
            // Remove the last 3 names from the list
            fruits.RemoveRange(fruits.Count - 3, 3);
            Console.WriteLine("\nFruit List after Removing the Last 3 Names:");
            PrintFruitList(fruits);
        }
        else
        {
            Console.WriteLine("There are not enough items to remove.");
        }
    }

    static void PrintFruitList(List<string> fruits)
    {
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}


//Q17-Demonstrate a C# program to create the sorted array of 5 students details with roll number and name.

using System;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public Student(int rollNumber, string name)
    {
        RollNumber = rollNumber;
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[5];

        students[0] = new Student(101, "Alice");
        students[1] = new Student(102, "Bob");
        students[2] = new Student(103, "Charlie");
        students[3] = new Student(104, "David");
        students[4] = new Student(105, "Eve");

        // Sorting the array of students based on roll number
        Array.Sort(students, (s1, s2) => s1.RollNumber.CompareTo(s2.RollNumber));

        Console.WriteLine("Sorted Student Details:");

        foreach (Student student in students)
        {
            Console.WriteLine($"Roll Number: {student.RollNumber}, Name: {student.Name}");
        }
    }
}
//Q18- Demonstrate a Table Student with the following fields:StudId, Studname, Course_Name, Semester.Demonstrate a C# code to display students’ details.


using System;
using System.Collections.Generic;

class Student
{
    public int StudId { get; set; }
    public string StudName { get; set; }
    public string CourseName { get; set; }
    public string Semester { get; set; }

    public Student(int studId, string studName, string courseName, string semester)
    {
        StudId = studId;
        StudName = studName;
        CourseName = courseName;
        Semester = semester;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Add student details to the list
        students.Add(new Student(1, "Alice", "Computer Science", "Spring 2023"));
        students.Add(new Student(2, "Bob", "Mathematics", "Fall 2022"));
        students.Add(new Student(3, "Charlie", "Physics", "Spring 2023"));
        students.Add(new Student(4, "David", "History", "Fall 2022"));
        students.Add(new Student(5, "Eve", "Biology", "Spring 2023"));

        Console.WriteLine("Student Details:");
        Console.WriteLine("StudId\tStudName\tCourse_Name\tSemester");

        foreach (Student student in students)
        {
            Console.WriteLine($"{student.StudId}\t{student.StudName}\t\t{student.CourseName}\t\t{student.Semester}");
        }
    }
}


//Q19- Demonstrate a program to raise the exception not eligible for voting if the age is less than 18.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("Not eligible for voting");
            throw new Exception("Not eligible for voting");
        }
        else
        {
            Console.WriteLine("Eligible for voting");
        }
    }
}


/*Q20-Demonstrate a Table Employee as follows:
EmpId EmpName	Salary
1001	Mark	45,000
1002	Gates	25,000
1003	Steve	35,000
1004	Mask	50,000
1005	Ram	55,000

Demonstrate a console application code to display employee table using a Data reader
and 
Write the code to perform the following tasks:
a.Update the EmpName as “Mark Zukerberg” for EmpID = 1001
b.	Delete the row of EmpId = 1005
c.	Insert a new row to the table as follows: EmpID = 1006, EmpName = “Shyam”, Salary = 60,000 */

using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Simulated data (You should replace this with your database connection)
        DataTable employeeTable = new DataTable();
        employeeTable.Columns.Add("EmpId", typeof(int));
        employeeTable.Columns.Add("EmpName", typeof(string));
        employeeTable.Columns.Add("Salary", typeof(decimal));

        // Populating the employee table with sample data
        employeeTable.Rows.Add(1001, "Mark", 45000);
        employeeTable.Rows.Add(1002, "Gates", 25000);
        employeeTable.Rows.Add(1003, "Steve", 35000);
        employeeTable.Rows.Add(1004, "Mask", 50000);
        employeeTable.Rows.Add(1005, "Ram", 55000);

        // Displaying the original employee table
        Console.WriteLine("Original Employee Table:");
        DisplayEmployeeTable(employeeTable);

        // a. Update EmpName as "Mark Zukerberg" for EmpID = 1001
        DataRow markRow = employeeTable.Select("EmpId = 1001")[0];
        markRow["EmpName"] = "Mark Zukerberg";

        // b. Delete the row of EmpId = 1005
        DataRow ramRow = employeeTable.Select("EmpId = 1005")[0];
        employeeTable.Rows.Remove(ramRow);

        // c. Insert a new row to the table
        DataRow newRow = employeeTable.NewRow();
        newRow["EmpId"] = 1006;
        newRow["EmpName"] = "Shyam";
        newRow["Salary"] = 60000;
        employeeTable.Rows.Add(newRow);

        // Displaying the modified employee table
        Console.WriteLine("\nModified Employee Table:");
        DisplayEmployeeTable(employeeTable);
    }

    static void DisplayEmployeeTable(DataTable table)
    {
        Console.WriteLine("EmpId\tEmpName\tSalary");

        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine($"{row["EmpId"]}\t{row["EmpName"]}\t{row["Salary"]}");
        }
    }
}


/*Q21- Demonstrate a Table Doctor with the following fields: 
Doctor_name, Doctor_ID, Department, Days_of_availability and Consultation fees.
Demonstrate a console application code to display doctors’ details using a Data reader. */


using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Simulated data (You should replace this with your database connection)
        DataTable doctorTable = new DataTable();
        doctorTable.Columns.Add("Doctor_name", typeof(string));
        doctorTable.Columns.Add("Doctor_ID", typeof(int));
        doctorTable.Columns.Add("Department", typeof(string));
        doctorTable.Columns.Add("Days_of_availability", typeof(string));
        doctorTable.Columns.Add("Consultation_fees", typeof(decimal));

        doctorTable.Rows.Add("Dr. Smith", 101, "Cardiology", "Monday, Wednesday, Friday", 100.00);
        doctorTable.Rows.Add("Dr. Johnson", 102, "Dermatology", "Tuesday, Thursday", 85.00);
        doctorTable.Rows.Add("Dr. Brown", 103, "Orthopedics", "Monday, Friday", 120.00);

        Console.WriteLine("Doctors' Details:");
        Console.WriteLine("Doctor_name\tDoctor_ID\tDepartment\tDays_of_availability\tConsultation fees");

        // Simulated DataReader
        using (var reader = doctorTable.CreateDataReader())
        {
            while (reader.Read())
            {
                string doctorName = reader["Doctor_name"].ToString();
                int doctorID = (int)reader["Doctor_ID"];
                string department = reader["Department"].ToString();
                string daysOfAvailability = reader["Days_of_availability"].ToString();
                decimal consultationFees = (decimal)reader["Consultation_fees"];

                Console.WriteLine($"{doctorName}\t{doctorID}\t{department}\t{daysOfAvailability}\t{consultationFees:C}");
            }
        }
    }
}
