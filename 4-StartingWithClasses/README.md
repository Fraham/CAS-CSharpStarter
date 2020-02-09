# Starting With Classes

This is where we are learning about classes.

Class allow us to keep data and functionality within the same area making it easier to understand how things connect.

In our example we have a class called `Transaction`. This class has three properties: Amount, Date and Notes. For this call we have no functionality but it will store the data for us.

The `BankAccount` class is a bit more complex, it only pieces of data: Number, Owner and a list of Transactions. But it also contains some functionality to:  make a deposit, make a withdrawal  and to get the history of the account.

For these we don't have to pass any data about the account to the methods as they are already have access to the data inside the class because they are also inside the class. For example in `GetAccountHistory`, the method is able to get the list of transactions from the class and then list those out to the console.

## How to work with classes

A class in itself doesn't do anything, it is just a template of data and functionality. To make use of class we need to initialise a class to an object.

This is done using the `new` keyword and the class name following. We can see this with `new BankAccount` in our first line of the `main` method. The remainder of the line of the initialisation parameters, these provide the object with the initial state.

How does the initial state get set? We can use a special type of method called a constructor. The constructor in the `BankAccount` class takes in a `name` and `initialBalance` as parameters.

The constructor does the following:

* Sets the account number
* Increments the account number, ready for the next account
* Sets the `Owner` to the `name` passed in
* Makes the first deposit with the `initialBalance` passed in

## Things to extend

We are able to overload constructors in classes in the same way we can with methods. So we can extend the `BankAccount` class to have a new constructor. To make the calling call easier we have a constructor that just takes a name and set there `initialBalance` to ten. We are also able to call a constructor from another constructor

```c#
public BankAccount(string name) : this(name, 10)
{

}
```

Which can be called with:

```c#
var account = new BankAccount("Fey Ijaware");
```
