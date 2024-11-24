namespace ConsoleSelectLinq.Entities;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Product (string name, double price) {
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;
}