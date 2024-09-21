//  variación de la actividad dos de la clase 7 aplicando struct

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomAux = new Random();
        Coordenadas3D[] coord = new Coordenadas3D[5];

        for (int i = 0; i < coord.Length; i++)
        {
            coord[i] = new Coordenadas3D(randomAux.Next(1000), randomAux.Next(1000), randomAux.Next(1000));
            Console.WriteLine($"\nPosición del enemigo {i + 1}: (X, Y, Z) = ({coord[i].ejeX}, {coord[i].ejeY}, {coord[i].ejeZ})");
        }

        for (int i = 0; i < coord.Length; i++)
        {
            coord[i].MoverAleatoriamente(randomAux);
            Console.WriteLine($"\nPosición final del enemigo {i + 1}: (X, Y, Z) = ({coord[i].ejeX}, {coord[i].ejeY}, {coord[i].ejeZ})");
        }
    }
}

struct Coordenadas3D
{
    public double ejeX;
    public double ejeY;
    public double ejeZ;

    public Coordenadas3D(double x, double y, double z)
    {
        ejeX = x;
        ejeY = y;
        ejeZ = z;
    }

    public void MoverAleatoriamente(Random random)
    {
        int eje = random.Next(3);

        switch (eje)
        {
            case 0:
                ejeX += 5;
                break;
            
            case 1:
                ejeY += 5;
                break;
            
            case 2:
                ejeZ += 5;
                break;
        }
    }
}
