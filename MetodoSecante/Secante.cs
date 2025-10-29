using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSecante
{
    internal class Secante
    {
        public string _funcion;
        public float _x0;
        public float _x1;
        public float _error;
        public int _iteraciones;
        public float _raiz;
        public float _errorFinal;
        public List<IteracionSecante> _tablaIteraciones;

        public void LeerFuncion(string funcion)
        {
            _funcion = funcion;
        }

        public void LeerX0(float x0)
        {
            _x0 = x0;
        }

        public void LeerX1(float x1)
        {
            _x1 = x1;
        }

        public void LeerError(float error)
        {
            _error = error;
        }

        public void CalcularSecante()
        {
            _tablaIteraciones = new List<IteracionSecante>();
            float x0 = _x0;
            float x1 = _x1;
            float errorActual = 1.0f;
            int iteracion = 0;

            float fx0 = EvaluarFuncion(x0);
            float fx1 = EvaluarFuncion(x1);
            float x2 = CalcularX2(x0, x1, fx0, fx1);

            IteracionSecante primeraIteracion = new IteracionSecante();
            primeraIteracion.Iteracion = iteracion + 1;
            primeraIteracion.X0 = x0;
            primeraIteracion.XI = x1;
            primeraIteracion.Fx0 = fx0;
            primeraIteracion.FxI = fx1;
            primeraIteracion.X2 = x2;
            primeraIteracion.Error = 1.0f;

            _tablaIteraciones.Add(primeraIteracion);

            iteracion++;
            errorActual = Math.Abs((x2 - x1) / x2);
            x0 = x1;
            x1 = x2;

            while (errorActual > _error && iteracion < 100)
            {
                fx0 = EvaluarFuncion(x0);
                fx1 = EvaluarFuncion(x1);
                x2 = CalcularX2(x0, x1, fx0, fx1);
                errorActual = Math.Abs((x2 - x1) / x2);

                IteracionSecante iteracionActual = new IteracionSecante();
                iteracionActual.Iteracion = iteracion + 1;
                iteracionActual.X0 = x0;
                iteracionActual.XI = x1;
                iteracionActual.Fx0 = fx0;
                iteracionActual.FxI = fx1;
                iteracionActual.X2 = x2;
                iteracionActual.Error = errorActual;

                _tablaIteraciones.Add(iteracionActual);

                x0 = x1;
                x1 = x2;
                iteracion++;
            }

            _iteraciones = iteracion + 1;
            _raiz = x2;
            _errorFinal = errorActual;
        }

        private float EvaluarFuncion(float x)
        {
            return 3 * x * x * x + 4 * x * x - 6 * x + 21;
        }

        private float CalcularX2(float x0, float x1, float fx0, float fx1)
        {
            if (Math.Abs(fx1 - fx0) < 0.0001f)
                return x1;

            return x1 - (fx1 * (x1 - x0)) / (fx1 - fx0);
        }

        public string retFuncion()
        {
            return _funcion;
        }

        public float retX0()
        {
            return _x0;
        }

        public float retX1()
        {
            return _x1;
        }

        public float retError()
        {
            return _error;
        }

        public int retIteraciones()
        {
            return _iteraciones;
        }

        public float retRaiz()
        {
            return _raiz;
        }

        public float retErrorFinal()
        {
            return _errorFinal;
        }

        public DataTable retTablaIteraciones()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Iteración");
            dt.Columns.Add("x0");
            dt.Columns.Add("x1");
            dt.Columns.Add("f(x0)");
            dt.Columns.Add("f(x1)");
            dt.Columns.Add("x2");
            dt.Columns.Add("ε");

            foreach (var iter in _tablaIteraciones)
            {
                dt.Rows.Add(
                    iter.Iteracion,
                    iter.X0.ToString("F3"),
                    iter.XI.ToString("F3"),
                    iter.Fx0.ToString("F3"),
                    iter.FxI.ToString("F3"),
                    iter.X2.ToString("F3"),
                    iter.Error.ToString("F3")
                );
            }

            return dt;
        }
    }
}