﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun6Odev4
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Remove(Gamer gamer);
        void Update(Gamer gamer);
    }
}
