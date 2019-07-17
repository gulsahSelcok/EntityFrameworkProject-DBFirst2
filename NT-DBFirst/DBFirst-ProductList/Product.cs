//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirst_ProductList
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    
        public virtual Category Category { get; set; } //one to one il�iki bknz: category.cs
                                                       //bu yap�y� joinlemeden Category i�inden t�m o class�n i�indeki alanlara ula�mak i�in yaz�l�r.
        //virtual tan�mlamad���m�zda bu s�n�f� tan�mlad���m�zda haf�za da bo�yere en ba��ndan buras�yla alakal� b�t�n bilgileri al�r.Bu daha haf�zay� yorar.Buna lazy Loading denir. yazarsak ise eager loading denir.
        //virtual yazmazsak hatalar alabiliriz o y�zden virtual yazmam�z gerekir.

        
    }
}
