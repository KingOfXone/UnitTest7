using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest7

public class UnitTest1

    [TestMethod]

    public void EsSegura_return_False()

    {

        var registerViewModel = new RegisterViewModel();

        bool result = registerViewModel.IsPasswordSecure("123456789");

        Assert.IsFalse(result);

    }




    [TestMethod]

    public void EsSegura_return_True()

    {

        var registerViewModel = new RegisterViewModel();

        bool result = registerViewModel.IsPasswordSecure("123456789@A");

        Assert.IsTrue(result);

    }




    [TestMethod]

    public void EsSegura_return_False_sinMayuscula()

    {

        var registerViewModel = new RegisterViewModel();


        bool result = registerViewModel.IsPasswordSecure("12345678aeiou");


        Assert.IsFalse(result);

    }


    [TestMethod]

    public void EsSegura_return_Truetiene_Mayuscula()

    {

        var registerViewModel = new RegisterViewModel();

        bool result = registerViewModel.IsPasswordSecure("12345678AeIoU");

        Assert.IsTrue(result);

    }


    [TestMethod]

    public void EsSegura_return_False_si_no_tiene_simbolo()

    {
        var registerViewModel = new RegisterViewModel();

        bool result = registerViewModel.IsPasswordSecure("12345678aeio");

        Assert.IsFalse(result);

    }




    [TestMethod]

    public void EsSegura_return_Truesimbolo()

    {

        var registerViewModel = new RegisterViewModel();


        bool result = registerViewModel.IsPasswordSecure("12345678AeIoU@");

        Assert.IsTrue(result);

    }



    internal class RegisterViewModel

    {

        internal bool IsPasswordSecure(string contraseña)

        {

            if (contraseña.Length < 10)

            {

                return false;

            }




            if (!ContieneMayuscula(contraseña))

            {

                return false;

            }




            if (!ContieneSimbolo(contraseña))

            {

                return false;

            }




            return true;

        }




        private bool ContieneMayuscula(string contraseña)

        {

            return contraseña.Any(c => Char.IsLetter(c) && Char.IsUpper(c));

        }




        private bool ContieneSimbolo(string contraseña)

        {

            return contraseña.Any(c => !Char.IsSymbol(c));

        }

    }

}

}