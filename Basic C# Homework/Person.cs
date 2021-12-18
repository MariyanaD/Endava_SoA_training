

public class Person {
    public string Name;
    public int Age;
    public bool HasCar;
    public double Money;
    public Car MyCar;


   public void BuyCar(Car whichCarToBuy) {
        if(this.Money >= whichCarToBuy.Price) {
            this.MyCar = whichCarToBuy;
            this.Money = this.Money - whichCarToBuy.Price;
        } else {
            System.Console.WriteLine(Name + " don't have enough money to buy the car.");
        }
    }

    public Car Car { get; internal set; }

    public Person() {
    }

   public Person(string nameParam){
        Name = nameParam;
    }

   public Person(string nameParam, int ageParam) {
        Name = nameParam;
        Age = ageParam;
    }

   public Person(string nameParam, int ageParam, bool hasCarParam) {
        Name = nameParam;
        Age = ageParam;
        HasCar = hasCarParam;
    }
}
