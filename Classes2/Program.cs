using Classes2;

// CLASS KENDİSİ YANİ TYPE DEĞERİ  || DEĞİŞKEN ÜRETTİM = 
//productManager => ProductManager class'ının instance ı olmuş oldu yani bellekteki bir kopyası
var productManager = new ProductManager();
productManager.Add();


var product1 = new Product();
product1.ProductName = "Koltuk";
product1.Unitprice = 7890;
product1.UnitInStock = 4;

var product2 = new Product { ProductName = "Çikolata", Unitprice = 23, UnitInStock = 5 };


productManager.Add(product1); //overloading örneği