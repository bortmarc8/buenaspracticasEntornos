using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeApp
{
    ///<Descripción>
    ///    Esta clase se encarga de guardar un string.
    ///</Descripción>
    public class Clase1 {
        /// <Frase>
        ///     Variable que almacena el string, se le dará valor más tarde en los constructores.
        /// </Frase>
        private string frase;

        /// <Clase1()>
        ///     <descripción>
        ///         Constructor de la clase, este es el constructor que se utilizará cuando no se le pase ningún parámetro.
        ///         este constructor asignará a la variable 'frase' el string 'Frase por defecto'
        ///     </descripción>
        /// </Clase1()>
        public Clase1()
        {
            frase = "Frase por defecto";
        }

        /// <Clase1(string)>
        ///     <descripción>
        ///         Constructor sobrecargado de la clase, este es el constructor que se utilizará cuando se le pase un string como parámetro.
        ///         este constructor asignará a la variable 'frase' el string almacenado en la variable 'str' dado por parámetro al constructor
        ///     </descripción>
        /// </Clase1(string)>
        public Clase1(string str)
        {
            frase = str;
        }

        /// <setFrase(string)>
        ///     <descripción>Método que permite modificar la variable 'frase' por el string dado como parámatro</descripción>
        /// </setFrase(string)>
        public void setFrase(string str)
        {
            frase = str;
        }

        /// <getFrase()>
        ///     <descripción>Método que devuelve el valor de la variable 'frase'</descripción>
        ///     <devuelve>La propiedad frase</devuelve>
        /// </getFrase()>
        public string getFrase()
        {
            return frase;
        }
    }
}
