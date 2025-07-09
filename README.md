# Learn-Csharp-Programming
👉👿️C# PROGRAMMING

👉👿️C# PROGRAMMING

👉Basic syntax

using System;

using System.Collection.Generic;

using System.Linq;

using System.Text;

using System.Threading.Task;

namespace ConsoleApplication

{

class Program

{

static void main(String [] args)

{

Input output statements and variable declaration

Console.Readkey();

}

}

}

👉👿️INPUT AND OUTPUT IN C#

👉Output

Console.WriteLine("", varname);---To provide output on screen

👉Input

Datatype varname=Console.ReadLine();---Taking input from user as string

To convert string to int

Convert.ToInt32(Console.ReadLine());

To convert string to float

Convert.ToFloat(ReadLine());

👉👿️VARIABLE DECLARATION

The name of memory location where store some data is called as variable

There are various datatype in c#

Int,char,float double etc

👉Syntax

Dataype varname=value;----Variable declaration and initialisation

Const keyword is used to declare constant variable

👉ARRAY

The collection of similar datatype value in contiguous memory allocation is called as Array

Syntax
Datatype [] Arrayname=new datatype[size];---Declaration

datatype [] Arrayname={values}---Initialization

👉STRING

The collection of char is called as string

Syntax

Stringname="value";

👉👿️CONDITIONAL STATEMENTS

👉IF STATEMENTS

if(condition)

{

Statement or code

}

👉IF ELSE STATEMENT

if(condition)

{

Statement or code

}

else

{

Line of code

}

👉IF ELSE STATEMENT

if(condition)

{

Line of code

}

else if(condition)

{

Line of code

}

else

{

Line of code

}

👉👿️LOOPING STATEMENT

👉WHILE LOOP

while(condition)

{

Line of code

}
👉FOR LOOP

for(initialisation,condition,incre/decre)

{

Line of code

}

👉DO WHILE LOOP

do

{

Line of code

}

while(condition);

👉👿️DECISION MAKING STATEMENTS

👉Syntax

switch(operation)

{

Case 1 :

Statements

Break;

Case 2:

Statements

Break;

Default:

Statement

Break;

}

👉👿️ FUNCTION

The code of block which perform particular task is called as Function

👉Syntax

static returntype functionname()

{

Line of code

}

👉👿️OBJECT ORIENTED PROGRAMMING

👉 👿️CLASS AND OBJECT

👉CLASS

The element which bind the datamembers and member function with each other is called as

class

Class keyword is used for class declaration

Syntax of class
Class classname

{

Datamembers and member function

}

👉 OBJECT

The element which used for access the datamember and member function is called as Object

Syntax of object

Classname objectname=new classname();

👉👿️ ENCAPSULATION

class classname

{

Datamembers

And

Member function

}

👉👿️INHERITANCE

The process of creating one class from another class is called as Inheritance

There are mainly 5 types of inheritance

1. Single

2. Multiple

3. Multilevel

4. Hierarchical

5. Hybrid

👉Syntax of inheritance

Public child class : parent class

👉👿️ POLYMORPHISM

The process of showing different behaviour according to their situation is called as

Polymorphism

1. Compile time

👉Function overloading

The single class content multiple same name function with different no of arguments is called as

Function overloading

2. Run time

👉 Function overriding

The multiple class contain same name function and inheritance is must between them is called

as Function overriding

👉👿️FILE OPERATION

using System.IO; ---This class used for File input output operation

👉FILE CREATION

String Filepath="File Name";
String content="File content or statement";

👉FILE WRITING

File.WriteAllText(Filepath,Filecontent);

👉FILE READING

String FileContent=File.ReadAllText(Filepath);

Console.WriteLine(FileContent);

👉️ OPERATORS

1... Arithmetic operators

(+). Addition

(-). Subtraction

(*). Multiplication

(/). Division

(%). Modulus

2... Relational operators

(>). Greater than

(<). Less than

(>=). Greater than equal to

(<=). Less than equal to

(==). Equal to equal to

(!=). Not equal to

3...Logical operators

(&&). Logical and

(||). Logical or

(!). Logical not

4...Increment/Decrement operators

(++). Increment

(--). Decrement

5...Ternary operators

(?). Question mark

(:). Colon

6...Assignment operators

(=). Equal to

Created by

S rahire
