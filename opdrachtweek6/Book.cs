using System;
using System.Collections.Generic;

public class Book: Author{
    private string title;
    private Author author;
    private double price;
    private int qtyInStock = 0;
    
    public Book (string title, Author author, double price, int qtyInStock)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getTitle { get => title; set => title = value; }
    public Author getAuthor { get => author; set => author = value; }
    public double getPrice { get => price; set => price = value;}
    public int getQtyInStock { get => qtyInStock; set => qtyInStock = value; }
    public string getName { get => name; }
}