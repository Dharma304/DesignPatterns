using  System;
namespace DesignPattern
{
    public class Duck
    {
         IFly fly;
         IQuack quack;
         ISwim swim;
        public Duck()
        {

        }
        public Duck(FlyBehaviour fly, QuackBehaviour quack, SwimBehaviour swim)
        {
            this.fly=fly;
            this.quack=quack;
            this.swim=swim;
        }

    }
}