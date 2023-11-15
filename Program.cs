// See https://aka.ms/new-console-template for more information
using PatronAdapter;

Motor motor;
int value = 2;
switch (value)
{
    case 1:
        motor = new MotorDiesel();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarCombustible();
        break;
    case 2:
        motor = new MotorNaftero();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarCombustible();
        break;
    case 3:
        motor = new MotorElectricoAdapter();
        motor.Arrancar();
        motor.Acelerar();
        motor.Detener();
        motor.CargarCombustible();
        break;
    default:
        motor = null;
        break;
}
