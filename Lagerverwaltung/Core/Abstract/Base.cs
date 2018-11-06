using System;
using System.Collections;
using System.Collections.Generic;
using Lagerverwaltung.Core.Interfaces;

namespace Lagerverwaltung.Core.Abstract
{
    abstract public class Base : IBase, IEquatable<Base>,IEnumerable<Base> //-> IEnumerator<T>, IComparable<IBasic>
    {
        public abstract float Hoehe { get; set; }
        public abstract float Breite { get; set; }
        public abstract float Laenge { get; set; }

        public virtual float BerechneFlaeche()
        {
            return Hoehe * Laenge;
        }

        public virtual float BerechneVolumen()
        {
            return Hoehe * Laenge * Breite;
        }

        public bool Equals(Base other)
        {
            return Breite == other.Breite && Laenge == other.Laenge && Hoehe == other.Hoehe;
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
        //private int _index;

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