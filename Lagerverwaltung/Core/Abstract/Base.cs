using System;
using System.Collections;
using System.Collections.Generic;
using Lagerverwaltung.Core.Interfaces;

namespace Lagerverwaltung.Core.Abstract
{
    abstract public class Base : IBase, IEquatable<Base>,IEnumerable<Base> //-> IEnumerator<T>, IComparable<IBasic>
    {
        public abstract float Höhe { get; set; }
        public abstract float Breite { get; set; }
        public abstract float Länge { get; set; }

        public virtual float BerechneFlaeche()
        {
            return Höhe * Länge;
        }

        public virtual float BerechneVolumen()
        {
            return Höhe * Länge * Breite;
        }

        public bool Equals(Base other)
        {
            return Breite == other.Breite && Länge == other.Länge && Höhe == other.Höhe;
        }

        public IEnumerator<Base> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal sealed class BaseEnumerator : IEnumerator<Base>
    {
        private int _index;

        internal BaseEnumerator(Base b)
        {
        }

        public Base Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}