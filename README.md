# Static- non static functions | Introduction to encapsulation
This is a simple example of static and non-static functions in C#.
It's based upon a codealong with Terje Kolboten 
[Undervisning - Objekter via static](https://www.youtube.com/watch?v=aoh-XvXdyCA) and 
[Introduksjon til innkapsling](https://www.youtube.com/watch?v=Zo_ul94-L9E&t=1s )

## Static Functions
Static functions are functions which are not tied up to an instance of a class. 
They can be called directly from the class itself, without  initializing an object of the class

```csharp
public class StaticExample
{
	public static void StaticFunction()
	{
		Console.WriteLine("This is a static function");
	}
}
```



## Non-Static Functions
Non-static function is (aka instance method) a function which is tied up to an instance of a class.
Which means that an object must be initialized first then called.

```csharp
public class NonStaticExample
{
	public void NonStaticFunction()
	{
		Console.WriteLine("This is a non-static function");
	}
}
```

## Encapsulation
Encapsulation is a Bundle of data and functions

```csharp
public class EncapsulationExample
{
	private string _name;

	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
}
```

## Requirements
- Visual Studio 2019 > / Rider 2020.3 >
- .NET Core 8.0

## Installation
1. Clone the repository
2. ```shell script
   git clone https://github.com/krigjo25/console-static-nonstactic-codealong
   ```
3. Open the project in Visual Studio
4. Run the project
5. Done!

## Notes from the developer
Created with love for programming, thanks for reading.
I hope you'll have a beautiful day as you are!,<br>
@krigjo25

