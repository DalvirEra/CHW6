// y = k1x + b1
// y = k2x+b2
// 0 = (k1-k2)x + (b1-b2)
// - (k1-k2) x = b1-b2
// x = b1-b2 / - (k1-k2)
// y = k2x+b2


TheLine First = new TheLine();
TheLine Second = new TheLine();
double[] Coords = First.CrossPoint(Second);
Console.WriteLine("Координаты пересечения:");
Console.WriteLine("X: " + Coords[0]);
Console.WriteLine("Y: " + Coords[1]);

// Не судите строго, просто задание было сделано немного в шутку =)

class TheLine {
    
    public double Kx;
    public double bplus;

    public TheLine(){
        Console.WriteLine("Введите k: ");
        Kx = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b: ");
        bplus = Convert.ToDouble(Console.ReadLine());
    }
    public double[] CrossPoint(TheLine O){
        double Xcoord = (bplus - O.bplus)/-(Kx-O.Kx);
        double Ycoord = (O.Kx* Xcoord + O.bplus);
        double[] Coords = new double[] {Xcoord,Ycoord};
        return  Coords;
    }
}

