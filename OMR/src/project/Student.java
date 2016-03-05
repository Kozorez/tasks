package project;

public class Student 
{
	public String studentId;
	public String lastName;
	public String firstName;
	public String testWorkName;
	public String studentMark;
	public String testWorkMaxMark;
	public String testWorkDate;
	
	public Student(String studentId, String lastName, String firstName, String testWorkName, String studentMark, String testWorkMaxMark, String testWorkDate)
	{
		this.studentId = studentId;
		this.lastName = lastName;
		this.firstName = firstName;
		this.testWorkName = testWorkName;
		this.studentMark = studentMark;
		this.testWorkMaxMark = testWorkMaxMark;
		this.testWorkDate = testWorkDate;
	}
}
