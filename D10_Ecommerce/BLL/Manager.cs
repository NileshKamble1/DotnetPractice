namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
public List<Product>GetAllProduct(){
    List<Product>allProduct=new List<Product>();
    allProduct=DBManager.GetAllProducts();
    return allProduct;
}

public Product GetProduct(int  id){
    List<Product> allProducts=GetAllProduct();
Product foundProduct=allProducts.Find((product)=>product.ProductId ==id);
      return foundProduct ;
     }
}
