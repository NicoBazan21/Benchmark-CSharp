using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Strings
{
    public class TestString
    {
        #region Generadores
        private List<String> GenerarLista()
        {
            List<String> lista = new List<String>();
            for (int i = 0; i < 500; i++)
                lista.Add("t e s t");

            return lista;
        }
        #endregion

        #region Concatenaciones
        public String ConcatStrIgualacion(String value)
        {
            for (int i = 0; i < 50; i++)
                value += " " + "test";

            return value;
        }

        public String ConcatStrConStrBdlrAppend(String value)
        {
            StringBuilder sb = new StringBuilder(value);

            for (int i = 0; i < 50; i++)
            {
                sb.Append(" ");
                sb.Append("test");
            }

            return sb.ToString();
        }

        public String ConcatStrConcat(String value)
        {
            for (int i = 0; i < 50; i++)
                value = String.Concat(value);

            return value;
        }
        #endregion

        #region Iteradores
        public List<String> ReplaceFor()
        {
            List<String> lista = GenerarLista();

            List<String> retorno = new List<String>();

            for (int i = 0; i < lista.Count; i++)
                retorno.Add(lista[i].Replace(' ', '+'));

            return lista;
        }

        public List<String> ReplaceForeach()
        {
            List<String> lista = GenerarLista();

            List<String> retorno = new List<String>();

            foreach (String item in lista)
                retorno.Add(item.Replace(' ', '+'));

            return lista;
        }

        public List<String> CompareToFor(String comparar)
        {
            List<String> lista = GenerarLista();
            List<String> retorno = new List<String>();

            for (Int32 i = 0; i < lista.Count; i++)
                if (lista[i].CompareTo(comparar) != 0)
                    retorno.Add(lista[i]);

            return retorno;
        }
        public List<String> CompareToForeach(String comparar)
        {
            List<String> lista = GenerarLista();
            List<String> retorno = new List<String>();

            foreach (String item in lista)
                if (item.CompareTo(comparar) != 0)
                    retorno.Add(item);

            return retorno;
        }
        #endregion

        #region Comparadores
        public void CompareToSTR(String comparar)
        {
            Int32 rta;
            foreach (String item in GenerarLista())
                rta = item.CompareTo(comparar);
        }

        public void EqualsSTR(String comparar)
        {
            Boolean rta;
            foreach (String item in GenerarLista())
                rta = item.Equals(comparar);
        }

        public void IgualdadSTR(String comparar)
        {
            Boolean rta;
            foreach (String item in GenerarLista())
                rta = item == comparar;
        }
        #endregion
    }
}
