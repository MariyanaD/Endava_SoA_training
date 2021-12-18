
public class Car : Vehicles
{
	public string Model;
	public double MaxSpeed;
	public double CurrentSpeed;
	public string Color;
	public int Gear;
	public Person Owner;
	public double Price;
	public bool IsSportCar;
	
	public Car() {
		
	}

	public Car(string Model, bool IsSportCar, string Color) {
		this.Model = Model;
		this.IsSportCar = IsSportCar;
		this.Color = Color;
		Gear = 1;
		CurrentSpeed = 0;
	}

	public Car(string Model, bool IsSportCar, string Color, double Price, double MaxSpeed) {
		this.Price = Price;
		if(!IsSportCar && MaxSpeed > 200) {
			this.MaxSpeed = 200;
		} else {
			this.MaxSpeed = MaxSpeed;
		}
	}

	public Car(string Model, bool IsSportCar, string Color, double Price, double MaxSpeed, double CurrentSpeed) {
		this.CurrentSpeed = CurrentSpeed;
	}

	public Car(string Model) {
		this.Model = Model;
	}
	
	public bool IsMoreExpensive(Car carToCompare) {
		if( this.Price > carToCompare.Price ){
			return true;
		} else {
			return false;
		}
	}
	
	public void ChangeOwner(Person NewOwner) {
		Owner = NewOwner;
		NewOwner.Car = this;
	}
		
	public void Accelerate() {
		CurrentSpeed = CurrentSpeed + 10;
		System.Console.WriteLine(CurrentSpeed);
	}
	
	public void ChangeGearUp() {
		if(Gear == 5) {
			System.Console.WriteLine("Tha max gear is 5.");
		} else {
			Gear++;
			System.Console.WriteLine("Current gear is " + Gear);
		}
	}
	
	public void ChangeGearDown() {
		if(Gear == 1) {
			System.Console.WriteLine("Tha min gear is 1.");
		} else {
			Gear--;
			System.Console.WriteLine("Current gear is " + Gear);
		}
	}
	
	public void ChangeGear(int NextGear) {
		if(NextGear < 1 || NextGear > 5) {
			System.Console.WriteLine("Sorry, choose gear between 1 and 5");
		} else {
			Gear = NextGear;
		}
	}
	
	public void ChangeColor(string NewColor) {
		Color = NewColor;
		System.Console.WriteLine("The new color is " + NewColor);
	}

    public void ChangeGear()
    {
        throw new System.NotImplementedException();
    }

    public void SpeedUp()
    {
        throw new System.NotImplementedException();
    }
}
