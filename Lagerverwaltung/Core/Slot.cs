﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung.Core.Interfaces;

namespace Lagerverwaltung.Core
{
    class Slot : ISlot
    {
        #region ctor

        #endregion
        #region public

        #endregion
        #region private

        #endregion
        public float Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(ISlot other)
        {
            throw new NotImplementedException();
        }
    }
}
