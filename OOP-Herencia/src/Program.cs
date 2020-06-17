using System;

namespace OOP
{
class Program
{
    static void Main()
    {
        Bicicleta bicicleta =new Bicicleta{
            marca ="Aurorita",
            rodado=20
        };
        bicicleta.Pedalear();

        BicicletaMotorizada biciMotor =new BicicletaMotorizada{
            marca ="Super bike",
            rodado=26
        };
        biciMotor.EncenderMotor();
        biciMotor.Pedalear(); //Tiene sentido que pedalee una bici a motor ? Que solucion proponen ?
        biciMotor.ApagarMotor();
        biciMotor.ApagarMotor();

	}
}

}
