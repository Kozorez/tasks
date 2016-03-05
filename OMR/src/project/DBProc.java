package project;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;

public class DBProc 
{
	private static String url = "jdbc:postgresql://127.0.0.1:5432/omr";
	private static String user = "postgres";
	
    private static String password;
    
    /*
    public static void createDatabase() 
    {
    	returnUserPassword();
    	
        try
        {
            Class.forName("org.postgresql.Driver");
        }
        catch (ClassNotFoundException ex)
        {
            System.out.println("Unable to load database driver");
            System.out.println("Details: " + ex);
        }
        
        changeDatebaseURL("postgres");
        
        try
        {
        	try(Connection connection = DriverManager.getConnection(url, user, password))
        	{
        		executeQuery(connection, "CREATE DATABASE omr;");
        	}
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
        
        changeDatebaseURL("omr");
        
        try
        {
            try(Connection connection = DriverManager.getConnection(url, user, password))
            {
                executeQuery(connection, "CREATE TABLE students(student_id VARCHAR(11) NOT NULL PRIMARY KEY, student_last_name VARCHAR(50) NOT NULL, student_first_name VARCHAR(50) NOT NULL);"
                		               + " CREATE TABLE test_works(test_work_id SERIAL NOT NULL PRIMARY KEY, test_work_name VARCHAR(50) NOT NULL, test_work_max_mark INTEGER NOT NULL);"
                		               + " CREATE TABLE student_test_works(student_id VARCHAR(11) NOT NULL REFERENCES students(student_id), test_work_id INTEGER NOT NULL REFERENCES test_works(test_work_id), student_mark INTEGER NOT NULL, test_work_date TIMESTAMP NOT NULL, PRIMARY KEY(student_id, test_work_id));");
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
    }
    */
    
    public static ArrayList<Student> selectQuery() 
    {  
    	ArrayList<Student> students = new ArrayList<Student>();
    	
        try
        {
            try(Connection connection = DriverManager.getConnection(url, user, password);
            	Statement statement = connection.createStatement())
            {
            	ResultSet resultSet = statement.executeQuery("SELECT * FROM student_test_works"
            			                                   + " JOIN students on student_test_works.student_id = students.student_id"
            			                                   + " JOIN test_works on student_test_works.test_work_id = test_works.test_work_id");
            	        	
            	while(resultSet.next())
                {
            		String student_id = resultSet.getString("student_id");
                    String last_name = resultSet.getString("student_last_name");
                    String first_name = resultSet.getString("student_first_name");
                    String test_work_name = resultSet.getString("test_work_name");
                    String student_mark = resultSet.getString("student_mark");
                    String test_work_max_mark = resultSet.getString("test_work_max_mark");
                    String test_work_date = resultSet.getString("test_work_date");
                    
                    students.add(new Student(student_id, last_name, first_name, test_work_name, student_mark, test_work_max_mark, test_work_date));
                }
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
        
		return students;
    }
    
    /*
    private static void insertStudent(String id, String lastName, String firstName) 
    {  
        try
        {
            try(Connection connection = DriverManager.getConnection(url, user, password))
            {
            	executeUpdate(connection, "INSERT INTO students(student_id, student_last_name, student_first_name)"
	                                    + " VALUES(" + "'" + id + "'" + ", " + "'" + lastName + "'" + ", " + "'" + firstName + "'" + ");");
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
    }
    */
    
    /*
    private static void insertTestWork(String testWorkName, String testWorkMaxMark) 
    {  
        try
        {
            try(Connection connection = DriverManager.getConnection(url, user, password))
            {
            	executeUpdate(connection, "INSERT INTO test_works(test_work_name, test_work_max_mark)"
            			                + " VALUES(" + "'" + testWorkName + "'" + ", " + testWorkMaxMark + ");");
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
    }
    */
    
    public static void insertStudentTestWork(TestWorkData databaseEntry) 
    {  
    	returnUserPassword();
    	
        try
        {
            try(Connection connection = DriverManager.getConnection(url, user, password))
            {
            	DateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            	
            	executeUpdate(connection, "INSERT INTO student_test_works(student_id, test_work_id, student_mark, test_work_date)"
            			                + " VALUES(" + "'" + databaseEntry.studentID + "'" + ", " + databaseEntry.testWorkID + ", " + databaseEntry.studentMark.value + ", " + "'" + df.format(new Date()) + "'" + ");");
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
        }
    }
    
    private static boolean executeQuery(Connection connection, String query)
    {
        try
        {
            try(Statement statement = connection.createStatement())
            {
            	statement.executeQuery(query);
            	
                return true;
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
            
            return false;
        }
    }
    
    private static boolean executeUpdate(Connection connection, String query)
    {
        try
        {
            try(Statement statement = connection.createStatement())
            {
            	statement.executeUpdate(query);
            	
                return true;
            }
        }
        catch(SQLException ex)
        {
        	System.out.println(ex);
            
            return false;
        }
    }

    private static void changeDatebaseURL(String databaseURL)
    {
    	url = "jdbc:postgresql://127.0.0.1:5432/" + databaseURL;
    }
    
    private static void returnUserPassword()
    {
    	Scanner input = new Scanner(System.in);
    	
    	System.out.println("Input the password of the database user:");
    
    	password = input.nextLine();
    }
    
    /*
    public static void insertStudentTestWork(Student student)
    {
    	insertStudent(student.studentId, student.lastName, student.firstName);
    	
    	insertTestWork(student.testWorkName, student.testWorkMaxMark);
    	
    	insertStudentTestWork("i.21", "1", "45", new Date().toString());
    }
    */
}