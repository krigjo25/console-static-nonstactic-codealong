# Static- non static functions | Introduction to encapsulation

This is a simple example of static and non-static functions in C#.
It's based upon a codealong with Terje Kolboten 
[Undervisning - Objekter via static](https://www.youtube.com/watch?v=aoh-XvXdyCA) and 
[Introduksjon til innkapsling](https://www.youtube.com/watch?v=Zo_ul94-L9E&t=1s )

## Static Functions

Static functions are functions that are not tied to an instance of a class. 
They can be called directly from the class itself.

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

Non-static functions are functions that are tied to an instance of a class.
They can only be called from an instance of the class.

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

Encapsulation is the concept of bundling the data (fields) and methods (functions)
that operate on the data into a single unit (class).

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

## License
[No Licence](https://choosealicense.com/no-permission/)
Take a look at the accomponied LICENCE for details

