/*Nuget Packages References*/

using SQLite;
using System;


//Client Table
public class Client
{
    [PrimaryKey]
    public string Client_ID {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Phone {get; set;}
    public string email {get; set;}

}

//Contact Table
public class Contact
{
    [PrimaryKey]
    public string Contact_ID {get; set;}
    public string Name{get; set;}
    public string Species_Type { get; set; }
    public string Cond_Type{get; set;}
    public string Vacc_ID {get; set;}
    public string Vacc_Injection_Date{get; set;}
    public string Vacc_Expiry_Date{get; set;}
}
//Host Table
public class Host
{
    [PrimaryKey]
    public string Host_ID {get; set;}
    public string Species { get; set;}
    public string Host_Name {get; set;}

}
//Species Table
public class Species
{
    [PrimaryKey]
    public string Species_Type_ID {get; set;}
    public string Species_Name {get; set;}
    public string Host_ID {get; set;}

}
//Condition Table
public class Condition
{
    [PrimaryKey]
    public string Condition_ID {get; set;}
    public string  Condition_Name {get; set;}
    public string Host { get; set; }
    
}

//Condition Questions Table
public class ConditionQuestions
{
    [PrimaryKey]
    public string Question_ID {get; set;}
    public string Condition_Question {get; set;}
    public string Species_Type {get; set;}
    public string Host_Type {get; set;}
    public string Cond_Type{get; set;}
    public string Vacc_ID{get; set;}
    public string Vacc_Name{get; set;}
    public string Vacc_Injection_Date{get; set;}
    public string Vacc_Expiry_Date{get; set;}
}

//Tutorial Table
public class Tutorial 
{
	[PrimaryKey]
	public string Tutorial_ID{get; set;}
	public string Tutorial_Content{get; set;}
		
}

//Test Table
public class Test
{
	[PrimaryKey]
	public string Test_ID {get; set;}
	public string Reference_Number {get; set;}
	public string Test_Directions {get; set;}
	public string Image_Res {get; set;}
	public string Image {get; set; }
	public string Test_Address {get; set;}
	public double Test_Lat {get; set;}
	public double Test_Long {get; set;}
	public DateTime Test_Date {get; set;}
	
}

//Condition_Test Table
public class Condition_Test 
{
	
    [PrimaryKey]
    public string ConditionID {get; set;}
    public string ConditionName { get; set; }
    public string Test_ID {get; set;}

}

//Condition_Host Table
public class Condition_Host
{
	[PrimaryKey]
	public string ConditionID {get; set;}
	public string Test_ID {get; set;}
	public string Test_Directions{get; set;}
	public int Image_Res {get; set;}
	public string Image {get; set; }
	public string Host_Type {get; set;}

}

//Report Table 
public class Report 
{
	[PrimaryKey]
	public string Report_ID {get; set;}
	public string Condition_ID {get; set;}
	public string Question_ID {get; set;}
	public string Sub_Status {get; set;}
	public string Report_Completion_Status {get; set;}
	public DateTime Report_Date {get; set;}
	
}

//Report_Questions Table
public class Report_Questions
{
	[PrimaryKey]
	public string Report_ID {get; set;}
	public string Question_ID {get; set;}
}

//Questions Table
public class Questions
{
	[PrimaryKey]
	public string Question_ID {get; set;}
	public string Tutorial_Content { get; set; }
}