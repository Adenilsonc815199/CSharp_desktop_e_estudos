using System;


namespace Exceptions
{
    class TestaFuncionario
    {
        static void Main()
        {
            Funcionario f = new Funcionario();

            try { 
            f.AumentaSalario(-1000);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Houve um ArgumentException ao aumentar o salário");
            }
        }
    }
}
