namespace BOL;
public class Product
{
private int id;
private string title;
private string  imageURL;
private string category;
private string description;
private float price;
private int balance;

public Product(){

}

public Product(int productId, string title){
this.id=productId;
this.title=title;
}


public Product(int productId, string title,string brand, string category){
    this.id=productId;
    this.title=title;
    this.category=category;
}

public Product(int productId,string title, string brand, string category, float price, int balance ){
    this.id=productId;
    this.title=title;
    this.category=category;
    this.price=price;
    this.balance=balance;
}

public Product(int productId,string title, string brand, string category, float price, int balance ,string description, string imageURL){
    this.id=productId;
    this.title=title;
    this.category=category;
    this.price=price;
    this.balance=balance;
    this.description=description;
    this.imageURL=imageURL;
}

public int ProductId{
    get{return id;}
    set{id=value;}
}

public string Title{
    get {return title;}
    set {title=value;}
}

public string Category{
    get{return category;}
    set{category=value;}
}

public string Description{
    get{return description;}
    set{description=value;}
}

public string ImageURL{
    get{return imageURL;}
    set{imageURL=value;}
}


public float Price{
    get {return price;}
    set {price=value;}
}

public float Balance{
    get {return Balance;}
    set {Balance=value;}
}

}
