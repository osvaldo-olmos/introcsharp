using System;

namespace OOP
{

    public class BicicletaMotorizada : Bicicleta
    {
        bool motorOn =false;

        public void EncenderMotor() {
            if(motorOn)
            {
                Console.WriteLine("No se puede encender un motor encendido");
            }else
            {
                motorOn =true; 
            }
        }
        public void ApagarMotor() {
            if(!motorOn)
            {
                Console.WriteLine("No se puede apagar un motor apagado");
            }else
            {
                motorOn =false; 
            } 
        }
    }
}