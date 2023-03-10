namespace DAL;
using BOL;

public class DBManager
{
    public static List<Product>GetAllProducts(){
        List<Product>allProducts=new List<Product>();
        allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", Price = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", Price = 15, Category = "Flower", Balance = 7000 });
            allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", Price = 26, Category = "Flower", Balance = 3400 });
            allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck",Price = 16, Category = "Flower", Balance = 27000 });
            allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.",Price = 6, Category = "Flower", Balance = 1000 });
            allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", Price = 26, Category = "Flower", Balance = 2000 });
            allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", Price = 36, Category = "Flower", Balance = 159 });
            allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", Price = 16, Category = "Flower", Balance = 67 });
            allProducts.Add(new Product { ProductId = 9, Title = "Daffodil", Description = "Wedding Flower", Price = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { ProductId = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", Price = 7, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { ProductId = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", Price = 12, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { ProductId = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", Price = 10, Category = "Flower", Balance = 700 });
            allProducts.Add(new Product { ProductId = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", Price = 16, Category = "Flower", Balance = 1500 });
            allProducts.Add(new Product { ProductId = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", Price = 8, Category = "Flower", Balance = 2300 });
            allProducts.Add(new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", Price = 17, Category = "Flower", Balance = 10000 });
            return allProducts;
    }

}
