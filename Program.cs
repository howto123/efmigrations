
using Contexts;
using Models;

Console.WriteLine("Welcome to this example using entity framework");

using var db = new ExampleContext();
Console.WriteLine($"The connection-string including password is: {db.ConnectionString}.");

// Clear all existing entries:
db.Examples.RemoveRange(db.Examples);

// Create
db.Examples.Add(new Example(){
    Name = "Name1",
});
db.Examples.Add(new Example(){
    Name = "Name2",
});
db.Examples.Add(new Example(){
    Name = "Name3",
});
db.SaveChanges();

// Read
Console.WriteLine("We have these inside the table now:");
var all = db.Examples;
foreach (var item in all )
{
    Console.WriteLine($"   Name: {item.Name}, Created: {item.Created}");
}

// Update
var one = db.Examples.SingleOrDefault(i => i.Name=="Name3");
if(one != null)
{
    one.Name = "New changed name!";
    db.SaveChanges();
}

// Delete
var toBeDeleted = db.Examples.SingleOrDefault(i => i.Name=="Name2");
if(toBeDeleted != null)
{
    db.Examples.Remove(toBeDeleted);
}
db.SaveChanges();

// Show changes again
Console.WriteLine($"\n And here we have the entries again: ");
var db2 = new ExampleContext();
var updated = db.Examples;
foreach (var item in updated )
{
    Console.WriteLine($"   Name: {item.Name}, Created: {item.Created}");
}


