using System;
using System.Collections.Generic;
class Shoppingcart{

    private  List<Tshirt> orderTshirt;
    
    public void addList(Tshirt tshirt){
        orderTshirt.Add(tshirt);
        tshirts = new List<Tshirt>();
    }
    public void getShopping(){
        foreach(Tshirt tshirt in tshirts){
            Console.WriteLine(tshirt.name);
        }

    }
}