using System;
namespace DesignPattern.Creational.Factory
{
    public  class Factory
    {
         IFactory ifactory;
       public IFactory CreateProductByID(int id)
        {
            if (id == 1)
            {
                ifactory = new Cushion();
            }
            else if (id == 2)
            {
                ifactory = new Softtoy();
            }
            else if(id==3)
            {
                ifactory=new Craft();
            }
            return ifactory;
        }
    }
}