using System;

namespace MetodoSecante
{
    internal class IteracionSecante
    {
        public int Iteracion { get; set; }
        public float X0 { get; set; }
        public float XI { get; set; }
        public float Fx0 { get; set; }
        public float FxI { get; set; }
        public float X2 { get; set; }
        public float Error { get; set; }
    }
}
