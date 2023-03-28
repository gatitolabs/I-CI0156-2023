using Model; 

Child child = new(1, "Juan");
Console.WriteLine(child.ToString("Hi"));


Animal cat = new Cat();
Animal dog = new Dog();
Animal animal = new Animal(); 
cat.makeSound();
dog.makeSound();
animal.makeSound();