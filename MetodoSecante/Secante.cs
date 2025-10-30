using System;
using System.Collections.Generic;
using System.Data;

namespace MetodoSecante
{
    internal class Secante
    {
        private float _x0;
        private float _x1;
        private float _error;
        private int _iteraciones;
        private float _raiz;
        private float _errorFinal;
        private List<IteracionSecante> _tablaIteraciones;

        public void LeerX0(float x0) => _x0 = x0;
        public void LeerX1(float x1) => _x1 = x1;
        public void LeerError(float error) => _error = error;

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

            _tablaIteraciones.Add(new IteracionSecante
            {
                Iteracion = 1,
                X0 = x0,
                XI = x1,
                Fx0 = fx0,
                FxI = fx1,
                X2 = x2,
                Error = 1.0f
            });

            iteracion++;
            errorActual = Math.Abs((x2 - x1) / x2);
            x0 = x1;
            x1 = x2;

            while (errorActual > _error && iteracion < 100)
            {
                fx0 = EvaluarFuncion(x0);
                fx1 = EvaluarFuncion(x1);
                x2 = CalcularX2(x0, x1, fx0, fx1);

                if (float.IsNaN(x2) || float.IsInfinity(x2))
                    throw new Exception("El método divergió o se produjo una división por cero.");

                errorActual = Math.Abs((x2 - x1) / x2);

                _tablaIteraciones.Add(new IteracionSecante
                {
                    Iteracion = iteracion + 1,
                    X0 = x0,
                    XI = x1,
                    Fx0 = fx0,
                    FxI = fx1,
                    X2 = x2,
                    Error = errorActual
                });

                x0 = x1;
                x1 = x2;
                iteracion++;
            }

            _iteraciones = iteracion;
            _raiz = x2;
            _errorFinal = errorActual;
        }

        private float EvaluarFuncion(float x)
        {
            return x * x * x - 2 * x - 5;
        }

        private float CalcularX2(float x0, float x1, float fx0, float fx1)
        {
            if (Math.Abs(fx1 - fx0) < 1e-6)
                throw new Exception("División por cero: f(x1) ≈ f(x0).");

            return x1 - (fx1 * (x1 - x0)) / (fx1 - fx0);
        }

        public int retIteraciones() => _iteraciones;
        public float retRaiz() => _raiz;
        public float retErrorFinal() => _errorFinal;

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

