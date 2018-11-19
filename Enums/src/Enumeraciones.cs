using System;

namespace Enums
{
    enum Dia { Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };
    enum Mes : byte
    {
        Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto,
        Septiembre, Octubre, Noviembre, Diciembre
    };

    [Flags]
    enum Color
    {
        Ninguno = 0x0,
        Blanco = 0x1,
        Rojo = 0x2,
        Azul = 0x4,
        Verde = 0x8,
        Negro = 0x10,
        Amarillo = 0x20,
        Marron = 0x40
    }
}